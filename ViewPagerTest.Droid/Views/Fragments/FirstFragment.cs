using Android;
using Android.OS;
using Android.Runtime;
using Android.Views;
using MvvmCross.Droid.Support.V4;
using MvvmCross.Binding.Droid.BindingContext;
using MvvmCross.Platform.IoC;

namespace ViewPagerTest.Droid.Views.Fragments
{
	[MvxUnconventional]
	[Register("viewpagertest.droid.views.fragments.FirstFragment")]
    public class FirstFragment : MvxFragment
    {
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            var ignore =  base.OnCreateView(inflater, container, savedInstanceState);
            return this.BindingInflate(Resource.Layout.FirstView, null);
        }
    }
}