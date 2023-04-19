import PropTypes from "prop-types"
import Item from "./Item";

export default function ItemList(props) {
    const { items, onEdit, setEdit, setDelete } = props;
    return (
        <>
            {
                items.map((item => {
                    return (
                        <div key={item.id}>
                            <Item id={item.id} name={item.name} description={item.description} quantity={item.quantity} onEdit={onEdit} setEdit={setEdit} setDelete={setDelete}/>
                        </div>
                    )
                }))
            }
        </>
    )
}

ItemList.propTypes = {
    items: PropTypes.arrayOf(PropTypes.object),
    onEdit: PropTypes.func,
    setEdit: PropTypes.func,
    setDelete: PropTypes.func
}