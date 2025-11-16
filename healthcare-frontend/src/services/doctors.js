const API = "https://localhost:7140/api/doctors";

export async function getDoctorsBySpecialty(specialty = "1111") {
  const url = `${API}?specialty=${specialty}`;
  const res = await fetch(url);
  return await res.json();
}
