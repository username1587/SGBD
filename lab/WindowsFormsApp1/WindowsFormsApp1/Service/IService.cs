using System.Collections.Generic;
using WindowsFormsApp1.models;

namespace WindowsFormsApp1.Service
{
    public interface IService
    {
        void getAllRestaurants();

        void getAllAngajatiOfRestaurant(Restaurant restaurant);

        /**
         * throws ValidationException
         */
        void addAngajat(Angajat angajat);
        
        /**
         * throws ValidationException
         */
        void deleteAngajat(Angajat angajat);

        /**
         * throws ValidationException
         */
        void updateAngajat(Angajat angajat);

    }
}