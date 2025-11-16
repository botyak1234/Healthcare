import { useEffect, useState } from "react";
import { getDoctorsBySpecialty } from "../services/doctors";

export default function DoctorsList() {
  const [specialty, setSpecialty] = useState("1111");
  const [doctors, setDoctors] = useState([]);

  useEffect(() => {
    getDoctorsBySpecialty(specialty).then((data) => {
      if (Array.isArray(data)) setDoctors(data);
      else setDoctors([]);
    });
  }, [specialty]);

  return (
    <div>
      <h2>Врачи</h2>

      <input
        placeholder="Специальность..."
        value={specialty}
        onChange={(e) => setSpecialty(e.target.value)}
      />

      <ul>
        {doctors.map((d) => (
          <li key={d.id}>
            <strong>{d.fullName}</strong> — {d.specialty}
          </li>
        ))}
      </ul>
    </div>
  );
}
