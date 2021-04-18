using System.Collections.Generic;
using WindowsFormsApp1.models;

namespace WindowsFormsApp1.Repository
{
    public interface IRepoRestaurant
    { 
        List<Restaurant> getAll();
        
    }
}