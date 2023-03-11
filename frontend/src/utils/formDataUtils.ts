import { productDTO } from "../product/model/product.model";

export function convertProductToFormData(product: productDTO) : FormData
{
    const formData  = new FormData();

    formData.append('name', product.name);
    formData.append('description', product.description);
    
    formData.append('price', String(product.price));
    formData.append('family', String(product.family));

    return formData    
}
