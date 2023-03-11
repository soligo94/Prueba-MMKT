import { Menubar } from 'primereact/menubar';
import { MenuItem } from 'primereact/menuitem';

export default function Menu() {
    const items: MenuItem[] = [
        {
            label: 'Productos',
            icon: 'pi pi-fw pi-list',
            items: [
                {
                    label: 'Todos los productos',
                    icon: 'pi pi-fw pi-bars',
                    url:'/product/allProducts'
                },
                {
                    label: 'Nuevo producto',
                    icon: 'pi pi-fw pi-plus',
                    url:'/product/newProduct'
                },
            ]
        }
    ];

    const start = <a href="/"><img alt="logo" src="https://cdn-1.webcatalog.io/catalog/mediamarkt-it/mediamarkt-it-icon-filled-256.png?v=1676693565130" height="40"className="mr-2" ></img></a>;
    //const end = <InputText placeholder="Search" type="text" className="w-full" />;

    return (
        <div className="card">
            <Menubar model={items} start={start}/>
        </div>
    )
}