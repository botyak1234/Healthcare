import PatientsList from "./components/PatientsList";
import DoctorsList from "./components/DoctorsList";
import DiseasesList from "./components/DiseasesList";

function App() {
  return (
    <div style={{ padding: 20 }}>
      <h1>Поликлиника</h1>

      <PatientsList />
      <DoctorsList />
      <DiseasesList />
    </div>
  );
}

export default App;
