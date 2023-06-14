import React, { useState } from "react";
import { CreateCustomer } from "../../common/models/customer";
import { CustomerForm } from "./components/customer.form";
import { useMutation } from "react-query";
import { createCustomer } from "../../common/services/api/customer/customer.api";
import { useNavigate } from "react-router-dom";

export const CustomerCreatePage = () => {
  const navigate = useNavigate();
  const [customer, setCustomer] = useState<CreateCustomer>({
    name: "",
    street: "",
    taxNumber: "",
  });

  const { mutate } = useMutation(createCustomer, {
    onSuccess: () => {
      navigate("/customers");
    },
  });

  function onChange({ target }: any) {
    const updateCustomer = { ...customer, [target.name]: target.value };
    setCustomer(updateCustomer);
  }
  function submit() {
    mutate(customer);
  }
  return (
    <>
      <div className="row mt-3">
        <div className="col">
          <h1>Create Customer</h1>
        </div>
      </div>
      <div className="row mt-3">
        <div className="col">
          <div className="card">
            <div className="card-body">
              <div className="row">
                <div className="col">
                  <CustomerForm
                    customer={customer}
                    onChange={onChange}
                    submit={submit}
                  />
                </div>
              </div>
            </div>
          </div>
        </div>
      </div>
    </>
  );
};
