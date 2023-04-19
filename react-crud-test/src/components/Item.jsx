import PropTypes from "prop-types"

export function newItem(id, name, description, quantity) {
    return {
        name: name,
        description: description,
        quantity: quantity,
        id: id
    }
}

export default function Item(props) {
    const {id, name, description, quantity, onEdit, setEdit, setDelete} = props;
    function sendEdit(event) {
        setEdit(true)
        onEdit({
            name: name,
            description: description,
            quantity: quantity,
            id: id
        });
    }
    function sendDelete(event) {
        setDelete(id);
    }
    const itemStyles = {

    }
    return (
        <div key={id} className="merch-item" id={id} style={itemStyles}>
            <h3>{name}</h3>
            <p>{description}</p>
            <p>{quantity}</p>
            <button onClick={sendEdit}>Edit</button>
            <button onClick={sendDelete}>Delete</button>
        </div>
    )
}

Item.propTypes = {
    id: PropTypes.string,
    name: PropTypes.string,
    description: PropTypes.string,
    quantity: PropTypes.string,
    onEdit: PropTypes.func,
    setEdit: PropTypes.func,
    setDelete: PropTypes.func
}