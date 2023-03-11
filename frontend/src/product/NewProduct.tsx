import axios, { AxiosError, AxiosResponse } from "axios";
import { useNavigate } from "react-router-dom";
import { useState } from "react";
import { urlProducts } from "../utils/endpoint";
import AddProductForm from "./forms/AddProductForm";
import { productDTO } from "./model/product.model";
import ErrorDisplay from "../utils/ErrorDisplay";

export default function NewProduct()
{
    const [errors, setErrors] = useState<string[]>([]);
    const navigate = useNavigate();

    async function createProudct(product: productDTO)
    {
        try{

            debugger
            await axios({
                method: "post",
                url: urlProducts,
                withCredentials: false,
                data: product,
                headers: {'Content-Type': 'multipart/form-data'}
            });
            navigate('/');
        }
        catch(errors){
            console.log(errors);
        }
    }
    return(
        <>
            <ErrorDisplay errors={errors} />
            <AddProductForm product={{ name:'', description: '', price: 0, family: ''}} onSubmit={async values=> await createProudct(values) } />
        </>
    )
}