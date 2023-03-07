import NewProduct from "./product/NewProduct";
import ProductDetail from "./product/ProductDetail";
import ProductList from "./product/ProductList";

const routes = [
    {path: '/product/allProducts', component: ProductList},
    {path: '/product/newProduct', component: NewProduct}
];

export default routes;