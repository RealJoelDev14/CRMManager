import React from "react";
import { useQuery } from "react-query";
import { getAllCustomers } from "../../common/services/api/customer/customer.api";
import { CustomerList } from "./components/customers.list";
import { Link } from "react-router-dom";

export const CustomerPage = () => {
  const { data, isLoading } = useQuery(["customers"], getAllCustomers);

  return (
    <>
      <div className="row mt-3">
        <div className="col">
          <h1>Customers</h1>
        </div>
      </div>
      <div className="row mt-3">
        <div className="col d-flex justify-content-end">
          <Link to={"create"} className="btn btn-primary">
            Create
          </Link>
        </div>
      </div>
      <div className="row mt-3">
        <div className="col">
          {isLoading && <p> loading...</p>}
          {!isLoading && (
            <>
              <div className="card rounded-4 shadow-sm">
                <div className="card-body">
                  <CustomerList customers={data} />
                </div>
              </div>
            </>
          )}
        </div>
      </div>
    </>
  );
};
