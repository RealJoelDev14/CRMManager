import React from "react";

export const CustomerForm = ({ submit, customer, onChange }: any) => {
  return (
    <>
      <form>
        <div className="mb-3">
          <label htmlFor="name" className="form-label">
            Name
          </label>
          <input
            type="text"
            className="form-control"
            id="name"
            name="name"
            onChange={onChange}
            value={customer.name}
          />
        </div>
        <div className="mb-3">
          <label htmlFor="taxNumber" className="form-label">
            Tax Number
          </label>
          <input
            type="text"
            className="form-control"
            id="taxNumber"
            name="taxNumber"
            onChange={onChange}
            value={customer.taxNumber}
          />
        </div>
        <div className="mb-3">
          <label htmlFor="street" className="form-label">
            Street
          </label>
          <input
            type="text"
            className="form-control"
            id="street"
            name="street"
            onChange={onChange}
            value={customer.street}
          />
        </div>
        <button onClick={submit} type="button" className="btn btn-primary">
          Submit
        </button>
      </form>
    </>
  );
};
