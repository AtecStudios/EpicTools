using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evil_Operator
{
    public class Nuke
    {
        [DllImport("user32.dll")]
        static extern bool SetCursorPos(int X, int Y);
        public void NukeIt()
        {
        }
    }
}
/*
#     # #     # #    #  #######           ###   #######   ###
##    # #     # #   #   #                  #       #      ###
# #   # #     # #  #    #                  #       #      ###
#  #  # #     # ###     #####              #       #       #
#   # # #     # #  #    #                  #       #
#    ## #     # #   #   #                  #       #      ###
#     #  #####  #    #  #######           ###      #      ###


               / (    ------- )   \                              
               (   /(/ (  )  ) )\                                 
             (    ( ( ( | | ) ) )\   )                       
              (   /(| / ( )) ) ) )) )        
            (     ( ((((_(|)_)))))     )     
             (        \(|(|)|/       )         
           (           |(||)|           ) 
             (         (|||)|         )
           (          //||||\\          )       
--------------------------------------------------------------------------------
while(true)
{
   SetCursorPos(Cursor.Position.X * 2, Cursor.Position.Y * 2);
}
--------------------------------------------------------------------------------    
*/
