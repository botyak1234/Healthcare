const API = "https://localhost:7140/api/diseases";

export async function getAllDiseases() {
  const res = await fetch(API);
  return await res.json();
}

export async function updateDisease(id, data) {
  const res = await fetch(`${API}/${id}`, {
    method: "PUT",
    headers: { "Content-Type": "application/json" },
    body: JSON.stringify(data)
  });
  return await res.json();
}
