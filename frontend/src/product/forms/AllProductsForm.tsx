import  axios, { AxiosResponse, AxiosError }  from "axios";
import { ChangeEvent, useEffect, useState } from "react";
import { urlProducts } from "../../utils/endpoint";
import { product, productDTO } from "../model/product.model";
import { DataTable } from 'primereact/datatable';
import { Column } from 'primereact/column';
import { FilterMatchMode, FilterOperator } from 'primereact/api';
import { InputText } from "primereact/inputtext";

export default function ProductsList(props: productsListProps)
{
    const [totalPages, setTotalPages] = useState(0);
    const [recordsPerPage, setRecordsPerPage] = useState(10);
    const [page, setPage] = useState(1);
    const [products, setProducts] = useState<productDTO[]>([]);
    const [filters, setFilters] = useState({
        global: { value: null, matchMode: FilterMatchMode.CONTAINS },
        name: {
            operator: FilterOperator.AND, 
            constraints: [{ value: null, matchMode: FilterMatchMode.CONTAINS }]
        },
        description: {
            operator: FilterOperator.AND, 
            constraints: [{ value: null, matchMode: FilterMatchMode.CONTAINS }]
        },
    });
    const [filterValue, setFilterValue] = useState("");

    useEffect(() => 
    {
        loadProducts();
    }, [page, recordsPerPage])

    const renderHeader = () => {
        return (
            <div className="flex justify-content-between align-items-center">
                <h5 className="m-0">Productos</h5>
                <span className="p-input-icon-left">
                    <i className="pi pi-search" />
                    <InputText value={filterValue} onChange={onFilterChange} placeholder="Buscar producto" />
                </span>
            </div>
        )
    }

    const onFilterChange = (e: ChangeEvent<any>) => {
        const value = e.target.value;
        let _filters = { ...filters };
        _filters["global"].value = value;
        console.log(value);
        console.log(_filters);
        setFilters(_filters);
        setFilterValue(value);
    }

    const header = renderHeader();

    function loadProducts()
    {
        axios.get(urlProducts, {
            params: {page, recordsPerPage}
        })
        .then((response: AxiosResponse<productDTO[]>) =>
        {
            const totalRecords = parseInt(response.headers['totalRecords'], 10);
            convertIdFamilyToString(response); 
            setProducts(response.data)
            setTotalPages(Math.ceil(totalRecords/recordsPerPage));
        })
    }
    function convertIdFamilyToString(response: AxiosResponse<productDTO[]>)
    {
        debugger
        response.data.forEach( product => {
            switch(product.family.toString()) { 
                case "1": { 
                   product.family = "Gaming"
                   break; 
                } 
                case "2": { 
                    product.family = "Accesorios Informática"
                   break; 
                }
                case "3": { 
                    product.family = "Telefonía"
                    break; 
                } 
                case "4": { 
                    product.family = "SmartWatch"
                    break; 
                } 
                case "5": { 
                    product.family = "TV"
                    break; 
                } 
                case "6": { 
                    product.family = "Consolas y juegos"
                    break; 
                } 
                case "7": { 
                    product.family = "Electrodomésticos"
                    break; 
                } 
                case "8": { 
                    product.family = "Pequeños electrodomésticos"
                    break; 
                } 
                case "9": { 
                    product.family = "Belleza y salud"
                    break; 
                } 
                case "10": { 
                    product.family = "Climatización y calefacción"
                    break; 
                } 
                case "11": { 
                    product.family = "Smart home"
                    break; 
                } 
                case "12": { 
                    product.family = "Deporte nutrición"
                    break; 
                } 
                case "13": { 
                    product.family = "Movilidad Urbana"
                    break; 
                } 
                case "14": { 
                    product.family = "Otras categorias"
                    break; 
                } 
        }});

    }
    return(
        <>
        <div className="datatable-doc-demo">
            <div className="card">
                <DataTable value={products} paginator className="p-datatable-customers" header={header} rows={10}
                    paginatorTemplate="FirstPageLink PrevPageLink PageLinks NextPageLink LastPageLink CurrentPageReport RowsPerPageDropdown" rowsPerPageOptions={[1,5,10,25,50]}
                    dataKey="id" rowHover responsiveLayout="scroll" filters={filters}
                    globalFilterFields={['name', 'description']} emptyMessage="No hay productos"
                    currentPageReportTemplate="Mostrando {first} a {last} de {totalRecords} registros">
                    <Column field="name" header="Nombre" filterField="name" style={{ minWidth: '14rem' }} />
                    <Column field="description" header="Descripción" filterField="description" style={{ minWidth: '14rem' }}/>
                    <Column field="price" header="Precio" filterMenuStyle={{ width: '14rem' }} style={{ minWidth: '14rem' }} />
                    <Column field="family" header="Categoria" style={{ minWidth: '8rem' }} />
                </DataTable>
            </div>
        </div>
        </>
    )
}

interface productsListProps{
    products?: product[]
}