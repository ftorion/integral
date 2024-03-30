# Интегрл
Решить проблему с преоброзованием формулы в части кода 
'''bash
static double Function(double x, double y, string formul)
        {
            string x1 = Convert.ToString(x);
            string y1 = Convert.ToString(y);
            string zam = formul.Replace('x', x1);
            zam = zam.Replace('y', y1);
            double value = Convert.ToDouble( new DataTable().Compute(zam, null));  

            return value;
        }
'''
