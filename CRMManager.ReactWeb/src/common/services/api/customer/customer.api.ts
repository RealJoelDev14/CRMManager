import axios from "axios";
import { CreateCustomer } from "../../../models/customer";



export async function getAllCustomers(){
    const response= await axios.get("https://localhost:7220/api/customer")
    return response.data
}

export async function createCustomer(customer:CreateCustomer){
    const response= await axios.post("https://localhost:7220/api/customer",customer)
    return response.data
}