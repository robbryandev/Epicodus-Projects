import "../styles/App.css"
import { newItem } from "./Item";
import { useState } from "react";
import ItemForm from "./ItemForm";
import ItemList from "./ItemList";

function App() {
  // app states
  const [itemElements, setItems] = useState([]);
  const [formValues, setForm] = useState({
    id: null,
    name: "",
    description: "",
    quantity: ""
  })
  const [editing, setEditing] = useState(false);
  
  // form item creation callback
  function addItem(i) {
    let newItemList;
    if (editing) {
      newItemList = [...itemElements]
      console.log(`I: ${JSON.stringify(i)}`)
      const itemIndex = newItemList.findIndex(it => it.id === i.id)
      const editItem = newItemList[itemIndex];
      editItem.name = i["name"];
      editItem.description = i["description"];
      editItem.quantity = i["quantity"];
      newItemList[itemIndex] = editItem;
      setForm({id: null, name: "", description: "", quantity: ""})
      setEditing(false)
    } else {
      newItemList = [...itemElements,
          newItem(i.id, i.name, i.description, i.quantity)
      ]
    }
    setItems(newItemList);
  }

  function deleteItem(id) {
    const newItems = itemElements.filter((it => it.id !== id));
    setItems(newItems)
  }

  return (
    <div className="App">
      <ItemForm
          id={formValues.id}
          name={formValues.name}
          description={formValues.description}
          quantity={formValues.quantity}
          onNewItemCreation={addItem}
        />
      <ItemList items={itemElements} onEdit={setForm} setEdit={setEditing} setDelete={deleteItem}/>
    </div>
  );
}

export default App;
