using MvvmGen;

namespace mvvmgen_nullable_71_sample
{
    [ViewModel]
    partial class SampleViewModel
    {
        [Property]
        private string m_text;

        [Property]
        private int m_counter;

        partial void OnInitialize()
        {
            Text = "Test";
            Counter = 0;
        }

        [Command]
        public void OnClick()
        {
            Counter++;            
        }
    }
}