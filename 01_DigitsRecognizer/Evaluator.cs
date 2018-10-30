using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_DigitsRecognizer
{
    public class Evaluator
    {
        public static double Correct(IEnumerable<Observation> validationSet, IClassifier classifier)
        {
            return validationSet
                    .Select(_obs => Score(_obs, classifier))
                    .Average();
        }

        private static double Score(Observation obs, IClassifier classifier)
        {
            if (classifier.Predict(obs.Pixels) == obs.Label)
                return 1.0;
            else
                return 0.0;
        }
    }
}
