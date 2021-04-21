using System.Collections.Generic;
using System.Data;
using WindowsFormsApp1.models;
using WindowsFormsApp1.Service;

namespace WindowsFormsApp1.Controller
{
    public class Controller
    {
        private IService _service;
        public DataSet _dataSet { get; }

        public Controller(IService service,DataSet dataSet)
        {
            _service = service;
            _dataSet = dataSet;
        }

        public void getAllRestaurants()
        {
            _service.getAllRestaurants();
        }

        public void getAngajatiOfRestaurant(Restaurant restaurant)
        {
            _service.getAllAngajatiOfRestaurant(restaurant);
        }

        public void addAngajat(int angajatID, string numeAngajat, string functie, int salariu, Restaurant restaurant)
        {
            Angajat angajat = new Angajat()
            {
                functie = functie,
                Nume = numeAngajat,
                Salariu = salariu,
                ID = angajatID,
                ID_Restaurant = restaurant.ID
            };
            _service.addAngajat(angajat);
        }

        public void deleteAngajat(Angajat angajat)
        {
            _service.deleteAngajat(angajat);
        }

        public void updateAngajat(Angajat angajat)
        {
            _service.updateAngajat(angajat);
        }
    }
}