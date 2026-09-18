import 'bootstrap/dist/css/bootstrap.css';
import './App.css';
import { useState, Fragment } from 'react';

export default function App() {
  const dane = [
    { id: 0, alt: "Mak", filename: "obraz1.jpg", category: 1, downloads: 35 },
    { id: 1, alt: "Bukiet", filename: "obraz2.jpg", category: 1, downloads: 43 },
    { id: 2, alt: "Dalmatyńczyk", filename: "obraz3.jpg", category: 2, downloads: 2 },
    { id: 3, alt: "Świnka morska", filename: "obraz4.jpg", category: 2, downloads: 53 },
    { id: 4, alt: "Rotwailer", filename: "obraz5.jpg", category: 2, downloads: 43 },
    { id: 5, alt: "Audi", filename: "obraz6.jpg", category: 3, downloads: 11 },
    { id: 6, alt: "kotki", filename: "obraz7.jpg", category: 2, downloads: 22 },
    { id: 7, alt: "Róża", filename: "obraz8.jpg", category: 1, downloads: 33 },
    { id: 8, alt: "Świnka morska", filename: "obraz9.jpg", category: 2, downloads: 123 },
    { id: 9, alt: "Foksterier", filename: "obraz10.jpg", category: 2, downloads: 22 },
    { id: 10, alt: "Szczeniak", filename: "obraz11.jpg", category: 2, downloads: 12 },
    { id: 11, alt: "Garbus", filename: "obraz12.jpg", category: 3, downloads: 321 }
  ];

  const [kwiaty, setKiwaty] = useState(true);
  const [zwierzeta, setZwierzeta] = useState(true);
  const [samochody, setSamochody] = useState(true);

  const [pobrania, setPobrania] = useState(
    dane.map(d => d.downloads)
  );

  return <>
    <h1>Kategorie zdjęć</h1>

    <div className="container">
      <div className="row">
        <div className="form-check form-switch col-2">
          <input className="form-check-input" type="checkbox" id="cbKwiaty" checked={kwiaty} onClick={() => setKiwaty(!kwiaty)} />
          <label className="form-check-label">Kwiaty</label>
        </div>
        <div className="form-check form-switch col-2">
          <input className="form-check-input" type="checkbox" id="cbZwierzeta" checked={zwierzeta} onClick={() => setZwierzeta(!zwierzeta)} />
          <label className="form-check-label">Zwierzęta</label>
        </div>
        <div className="form-check form-switch col-2">
          <input className="form-check-input" type="checkbox" id="cbSamochody" checked={samochody} onClick={() => setSamochody(!samochody)} />
          <label className="form-check-label">Samochody</label>
        </div>
      </div>

      <div className="row">
        {dane
          .filter((d) => (d.category === 1 && kwiaty) || (d.category === 2 && zwierzeta) || (d.category === 3 && samochody))
          .map((d, idx) => {


            return <Fragment key={d.id}>
              <div className="col">
                <img src={"./assets/" + d.filename} alt={d.filename} />
                <h4>Liczba pobrań: {pobrania[idx]}</h4>
                <input type="button" className="btn btn-success" value="Pobierz" onClick={() => {
                  setPobrania(prev => {
                    const nowe = [...prev];
                    nowe[d.id] += 1;
                    return nowe;
                  });
                }} />
              </div>
              {idx % 3 == 2 ? <div className='w-100' /> : <></>}
            </Fragment>
          }
          )}
      </div>
    </div>
  </>;
}
