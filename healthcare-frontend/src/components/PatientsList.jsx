import { useEffect, useState } from "react";
import { getAllPatients } from "../services/patients";

export default function PatientsList() {
  const [patients, setPatients] = useState([]);

  useEffect(() => {
    getAllPatients().then(setPatients);
  }, []);

  return (
    <div>
      <h2>Пациенты</h2>

      <ul>
        {patients.map((p) => (
          <li key={p.id}>
            <strong>{p.fullName}</strong> —{" "}
            {new Date(p.birthDate).toLocaleDateString()}
            <br />
          </li>
        ))}
      </ul>
    </div>
  );
}
