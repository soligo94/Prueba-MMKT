import { BrowserRouter } from 'react-router-dom';
import { Route, Routes} from 'react-router';
import './App.css';
import Menu from './utils/Menu';
import NewProduct from './product/NewProduct';
import ProductList from './product/forms/AllProductsForm';
import 'primereact/resources/themes/lara-light-indigo/theme.css';   // theme
import 'primereact/resources/primereact.css';                       // core css
import 'primeicons/primeicons.css';                                 // icons

function App() {
  return (
    <>
     <BrowserRouter>
      <Menu/>
       <div className="container">
         <Routes> 
            <Route path='/product/allProducts' element={<ProductList />} />
            <Route path='/product/newProduct' element={<NewProduct />} />
         </Routes>
       </div>
     </BrowserRouter>
    </>
   );
}

export default App;
