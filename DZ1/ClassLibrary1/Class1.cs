using System;

namespace Zad_1_Lib
{
    public class Episode
    {
        private int viewers;
        private double sum_grade;
        private double max_grade;
        public Episode() { }
        public Episode(int viewers, double sum_grade, double max_grade)
        {
            this.viewers = viewers;
            this.sum_grade = sum_grade;
            this.max_grade = max_grade;
        }
        public void AddView(double randomNum)
        {
            viewers++;
            sum_grade += randomNum;
            if (max_grade < randomNum)
            {
                max_grade = randomNum;
            }
        }
        public float GetMaxScore()
        {
            float numFloat = Convert.ToSingle(max_grade);
            return numFloat;
        }
        public double GetAverageScore()
        {
            return sum_grade / viewers;
        }
        public int GetViewerCount()
        {
            return viewers;
        }
    }
}
