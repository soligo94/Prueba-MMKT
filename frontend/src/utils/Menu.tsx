import { NavLink } from "react-router-dom";

export default function Menu(){
    const activeClass = "active";
    return(
        <nav className="navbar navbar-expand-lg navbar-light bg-light">
            <div className="container-fluid">
                <NavLink  className={({ isActive }) =>
                                [
                                    "navbar-brand",
                                    isActive ? activeClass : null,
                                ]
                                    .filter(Boolean)
                                    .join(" ")
                            } to="/" >React Películas</NavLink>
                <div className="collapse navbar-collapse">
                    <ul className="navbar-nav me-auto mb-2 mb-lg-0">
                        <li className="nav-item">
                            <NavLink className={({ isActive }) =>
                                [
                                    "nav_link",
                                    isActive ? activeClass : null,
                                ]
                                    .filter(Boolean)
                                    .join(" ")
                            } to="/product/allProducts">
                                Listado de productos
                            </NavLink>
                        </li>
                        <li className="nav-item">
                            <NavLink className={({ isActive }) =>
                                [
                                    "nav_link",
                                    isActive ? activeClass : null,
                                ]
                                    .filter(Boolean)
                                    .join(" ")
                            } to="/product/newProduct">
                                Nuevo product
                            </NavLink>
                        </li>
                    </ul>
                </div>
            </div>
        </nav>
    )
}