using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WNG_Test
{
    public partial class NSC : System.Web.UI.Page
    {
        Helper objHelper = new Helper();
        Sequences objSequence = new Sequences();

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        //This function will be called on submit event of submit button.
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            Page.Validate();
            if (Page.IsValid)
            {
                var inputText = txtNumber.Text;
                objSequence = objHelper.GetNumericSequences(inputText);
                ltResultNumbers.Text = "Numbers:" + objSequence.Numbers;
                ltResultEvenNumbers.Text = "EvenNumbers:" + objSequence.EvenNumbers;
                ltResultOddNumbers.Text = "OddNumbers:" + objSequence.OddNumbers;
                ltResultNumbersWithCharacters.Text = "NumbersWithCharacters:" + objSequence.NumbersWithCharacters;
                ltResultFibonacciNumbers.Text = "FibonacciNumbers:"+objSequence.FibonacciNumbers;
            }
        }
    }
}