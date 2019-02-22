using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Rect
{
    public class Rect
    {
        int ln;
        int w;
        IRectMethod rectMethod;

        public Rect(int ln, int w, IRectMethod rectMethod)
        {

            if (ln <= 0 || w <= 0)
            {
                throw new ArgumentException();
            }

            if (rectMethod == null)
            {
                throw new ArgumentNullException();
            }
            this.rectMethod = rectMethod;
            this.ln = ln;
            this.w = w;
        }

        public void Draw()
        {
            this.rectMethod.rectDraw(this.ln, this.w);
        }
    }
    public interface IRectMethod
    {
        void rectDraw(int ln, int w);
    }
}
