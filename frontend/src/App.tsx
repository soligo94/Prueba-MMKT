import { BrowserRouter } from 'react-router-dom';
import { Route, Routes } from 'react-router';
import './App.css';
import routes from './route-config';
import Menu from './utils/Menu';

function App() {
  return (
    <>
     <BrowserRouter>
      <Menu/>
       <div className="container">
         <Routes> 
           {routes.map( path => 
             <Route key={path.path} path={path.path}>
               <path.component/>
             </Route>)}
         </Routes>
       </div>
     </BrowserRouter>
    </>
   );
}

export default App;
