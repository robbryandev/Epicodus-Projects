import PropTypes from 'prop-types';
import React, { useEffect } from 'react';
import { v4 } from 'uuid';

function ItemForm(props) {
    const {name, description, quantity, onNewItemCreation} = props;
    const id = props.id != null ? props.id : v4();
    function handleNewTicketFromSubmission(event) {
        event.preventDefault();
        console.log(event.target.name)
        onNewItemCreation({
            name: event.target.name.value,
            description: event.target.description.value,
            quantity: event.target.quantity.value,
            id: id
        });
        event.target.name.value = "";
        event.target.description.value = "";
        event.target.quantity.value = "";
    }

    useEffect(() => {
        document.getElementById("name-input").value = name;
        document.getElementById("description-input").value = description;
        document.getElementById("quantity-input").value = quantity;
    }, [name, description, quantity])
    return (
        <form onSubmit={handleNewTicketFromSubmission}>
            <label htmlFor="name">Name</label>
            <input
                id='name-input'
                name="name"
                defaultValue={name}
            />
            <br />
            <label htmlFor="description">Description</label>
            <input
                id='description-input'
                name="description"
                defaultValue={description}
            />
            <br />
            <label htmlFor="quantity">Quantity</label>
            <input
                id='quantity-input'
                name="quantity"
                defaultValue={quantity}
            />
            <br />
            <button type="submit">Submit</button>
        </form>
    )
}

ItemForm.propTypes = {
    name: PropTypes.string,
    description: PropTypes.string,
    quantity: PropTypes.string,
    onNewItemCreation: PropTypes.func
};

export default ItemForm;