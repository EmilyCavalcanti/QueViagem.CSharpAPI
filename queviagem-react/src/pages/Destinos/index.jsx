import React, { useState, useEffect } from 'react';
import { api } from '../../Routs/api';
import style from './style.module.css'
 
const Destinations = () => {
  const [dataFromAPI, setDataFromAPI] = useState(null);
 
  useEffect(() => {
    const fetchData = async () => {
      try {
        const response = await api.get('/Destinos');
        setDataFromAPI(response.data);
      } catch (error) {
        console.error('Error fetching data from the API:', error);
      }
    };
    fetchData();
  }, []);
 
  return (
    <div className={style.card}>
      <h1 className={style.titulo}>OS DESTINOS MAIS PROCURADOS</h1>
      <div>
        {dataFromAPI ? (dataFromAPI.map((destination) => (
          <div key={destination.id}>
            <div className={style.moldura}>
              <h3 className={style.cidade}> - {`${destination.cidade}`} -</h3>
              <img src={destination.imagemDestino} alt={destination.cidade} className={style.imagem} /> 
              <h4 className={style.pais}>{destination.pais}</h4> <hr /> <p className={style.valor}> R${destination.valor}</p>

            </div>
 
            <div>

              <button className={style.botao}> Quero conhecer já</button>
            </div>
          </div>
        ))) : (<div>Carregando...</div>) }
      </div>
    </div>
  );
}
 
export default Destinations;