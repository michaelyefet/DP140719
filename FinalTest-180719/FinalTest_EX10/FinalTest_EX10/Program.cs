using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTest_EX10
{
    class Program
    {
        static void Main(string[] args)
        {
            IWindow window = new BaseWindow();

            IWindow windowWithColorfulFrame = new ColorfulFrameDecoration(window);

            IWindow windowWithColorfulFrameAndShadowingDecorations = new ShadowingDecoration(windowWithColorfulFrame);

            IWindow windowWithColorfulFrameAndShadowingDecorationsand3D = new ThreeDimensionLightDecoration(windowWithColorfulFrameAndShadowingDecorations);

            Console.WriteLine(windowWithColorfulFrameAndShadowingDecorationsand3D.GetDetails());

            IWindow windowWithColorfulFrameAndShadowingDecorationsand3DAndSemiReflection = new SemiReflectionDecoration(windowWithColorfulFrameAndShadowingDecorationsand3D);

            IWindow windowWithColorfulFrameAndShadowingDecorationsand3DAndSemiReflectionAndFlickeringBackground = new FlickeringBackgroundDecoration(windowWithColorfulFrameAndShadowingDecorationsand3DAndSemiReflection);

            Console.WriteLine();

            Console.WriteLine(windowWithColorfulFrameAndShadowingDecorationsand3DAndSemiReflectionAndFlickeringBackground.GetDetails());
            
        }
    }
}
