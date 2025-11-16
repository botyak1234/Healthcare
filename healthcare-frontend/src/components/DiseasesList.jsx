import { useEffect, useState } from "react";
import { getAllDiseases, updateDisease } from "../services/diseases";

export default function DiseasesList() {
  const [diseases, setDiseases] = useState([]);
  const [editing, setEditing] = useState(null);

  useEffect(() => {
    getAllDiseases().then(setDiseases);
  }, []);

  const startEdit = (d) => {
    setEditing({ ...d });
  };

  async function save() {
    await updateDisease(editing.id, editing);
    setDiseases(await getAllDiseases());
    setEditing(null);
  }

  return (
    <div>
      <h2>Болезни</h2>

      <ul>
        {diseases.map((d) => (
          <li key={d.id}>
            <strong>{d.name}</strong> — {d.description}
            <button onClick={() => startEdit(d)}>Edit</button>
          </li>
        ))}
      </ul>

      {editing && (
        <div>
          <h3>Редактировать</h3>

          <input
            value={editing.name}
            onChange={(e) => setEditing({ ...editing, name: e.target.value })}
          />

          <input
            value={editing.description}
            onChange={(e) =>
              setEditing({ ...editing, description: e.target.value })
            }
          />

          <button onClick={save}>Сохранить</button>
        </div>
      )}
    </div>
  );
}
