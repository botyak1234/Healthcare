const API = "https://localhost:7140/api/patients";

export async function getAllPatients() {
  const res = await fetch(API);
  return await res.json();
}

export async function getPatient(id) {
  const res = await fetch(`${API}/${id}`);
  return await res.json();
}
