using System;

namespace DogsVsCatsWeb.Models
{
    public class PredictionResult
    {
        public Guid Id { get; set; }
        public double DogProbability { get; set; }
        public double CatProbability { get; set; }
    }
}