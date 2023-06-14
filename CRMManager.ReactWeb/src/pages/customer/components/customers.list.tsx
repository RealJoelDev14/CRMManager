import React from "react";
import { Customer } from "../../../common/models/customer";

export const CustomerList = ({ customers }: any) => {
  return (
    <>
      <table className="table table-striped">
        <thead>
          <tr>
            <th>Name</th>
            <th>Tax Number</th>
            <th>Street</th>
          </tr>
        </thead>
        <tbody>
          {customers.map((ele: Customer, index: number) => {
            return (
              <tr key={index}>
                <td>{ele.name}</td>
                <td>{ele.taxNumber}</td>
                <td>@{ele.street}</td>
              </tr>
            );
          })}
        </tbody>
      </table>
    </>
  );
};
