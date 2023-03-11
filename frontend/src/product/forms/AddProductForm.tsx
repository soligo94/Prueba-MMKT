import { productDTO } from "../model/product.model";
import { Button } from 'primereact/button';
import { Dropdown } from 'primereact/dropdown';
import { InputText } from 'primereact/inputtext';
import { Link, useNavigate } from "react-router-dom";
import './AddProductForm.css'
import { Form, Formik, FormikHelpers } from "formik";
import { useEffect, useState } from "react";



export default function AddProductForm(props: addProductFormProps) {
    const [productName, setProductName] = useState('');
    const [productPrice, setProductPrice] = useState('');
    const [productDescription, setProductDescription] = useState('');
    const [productFamily, setProductFamily] = useState<any>(null);

    let navigate = useNavigate(); 
    
    const routeChange = () =>{ 
        let path = `/`; 
        navigate(path);
    }

    const productsArray = [
        {
            label: "Gaming", code: '1',
        },
        {
            label: "Accesorios Informática", code: '2',
        },
        {
            label: "Telefonía", code: '3',
        },
        {
            label:"SmartWatch", code: '4',
        },
        {
            label: "TV", code: '5',
        },
        {
            label: "Audio HiFi", code: '6',
        },
        {
            label: "Consolas y juegos", code: '7',
        },
        {
            label: "Electrodomésticos", code: '8',
        },
        {
            label: "Pequeños electrodomésticos", code: '9',
        },
        {
            label: "Belleza y salud", code: '10',
        },
        {
            label: "Climatización y calefacción", code: '11',
        },
        {
            label: "Smart home", code: '12',
        },
        {
            label: "Deporte nutrición", code: '13',
        },
        {
            label: "Movilidad Urbana", code: '14',
        },
        {
            label: "Otras categorias", code: '15',
        }
    ];

    console.log("product", productName);
    console.log("descripc", productDescription);
    console.log("price", productPrice);
    console.log("family", productFamily);

    return (
        <Formik initialValues={props.product} 
        onSubmit={(values, actions) =>
            {
                debugger
                values.name = productName;
                values.description = productDescription;
                values.family = productFamily.code;
                values.price = Number(productPrice);
                props.onSubmit(values, actions);
            }}>
            {(formikProps) => (
            <Form onChange={ev => ev.preventDefault()}>
                <div className="form-prod">
                    <div className="flex justify-content-center">
                    <div className="card">
                        <h3 className="text-center">Añadir producto</h3>
                         <div className="p-fluid">
                            <div className="field">
                                <span className="p-float-label">
                                    <InputText id="name" name="name" onChange={e => setProductName(e.target.value)} value={productName} />
                                    <label htmlFor="name">Nombre</label>
                                </span>
                            </div>
                            <div className="field">
                                <span className="p-float-label p-input-icon-right">
                                    <InputText id="description" name="description" onChange={e => setProductDescription(e.target.value)} value={productDescription}/>
                                    <label htmlFor="description">Descripción</label>
                                </span>
                            </div>
                            <div className="field">
                                <span className="p-float-label">
                                    <InputText id="price" name="price"onChange={e => setProductPrice(e.target.value)} value={productPrice} />
                                    <label htmlFor="price">Precio</label>
                                </span>
                            </div>
                                <div className="field">
                                <span className="p-float-label">
                                    <Dropdown id="family" name="family" onChange={(e) => setProductFamily(e.value)} value={productFamily} 
                                    options= {productsArray}/>
                                    <label htmlFor="family">Categoría</label>
                                </span>
                            </div>
                            <Button type="submit" disabled={formikProps.isSubmitting} label="Guardar" className="mt-2" />
                            <Button className="cancelBtn" onClick={routeChange} label="Cancelar"/>
                        </div>
                    </div>
                    </div>
                </div>
                </Form>)}
        </Formik>)
}

interface addProductFormProps{
    product: productDTO;
    onSubmit(values: productDTO, actions: FormikHelpers<productDTO>): void;
}