// --------------------------------------------------------------------------------------------------------------------
// <summary>
//    Defines the HomeView type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System;
using Android.App;
using Android.OS;
using Android.Support.V7.Widget;
using Android.Views;
using System.Collections.Generic;
using Android.Support.V4.View;
//using PagerSlidingTabStrip = com.refractored.PagerSlidingTabStrip;
using ViewPagerTest.Core.ViewModels;
using ViewPagerTest.Droid.Adapters;
using ViewPagerTest.Droid.Views.Fragments;

namespace ViewPagerTest.Droid.Views
{
	using Android.App;
	using Android.OS;
    using MvvmCross.Droid.Support.V7.AppCompat;

    /// <summary>
    /// Defines the HomeView type.
    /// </summary>
    [Activity(Label = "View for HomeView")]
	public class HomeView : MvxAppCompatActivity<HomeViewModel>
	{
		private ViewPager _viewPager;
		//private PagerSlidingTabStrip _pageIndicator;
		private ViewPagerTestFragmentAdapter _adapter;

		public new HomeViewModel ViewModel
		{
			get { return (HomeViewModel)base.ViewModel; }
			set { base.ViewModel = value; }
		}

		/// <summary>
		/// Called when [create].
		/// </summary>
		/// <param name="bundle">The bundle.</param>
		protected override void OnCreate(Bundle bundle)
		{
			base.OnCreate(bundle);
			this.SetContentView(Resource.Layout.HomeView);

			var fragments = new List<ViewPagerTestFragmentAdapter.FragmentInfo>
			  {
				new ViewPagerTestFragmentAdapter.FragmentInfo
				{
				  FragmentType = typeof(FirstFragment),
				  Title = "First Fragment",
				  ViewModel = ViewModel.First
				},
				new ViewPagerTestFragmentAdapter.FragmentInfo
				{
				  FragmentType = typeof(SecondFragment),
				  Title = "Second Fragment",
				  ViewModel = ViewModel.Second
				},
				new ViewPagerTestFragmentAdapter.FragmentInfo
				{
				  FragmentType = typeof(ThirdFragment),
				  Title = "Third Fragment",
				  ViewModel = ViewModel.Third
				}
			  };

			_viewPager = FindViewById<ViewPager>(Resource.Id.viewPager);
			_adapter = new ViewPagerTestFragmentAdapter(this, SupportFragmentManager, fragments);
			_viewPager.Adapter = _adapter;

			//_pageIndicator = FindViewById<PagerSlidingTabStrip>(Resource.Id.viewPagerIndicator);
			//_pageIndicator.SetViewPager(_viewPager);
		}
	}
}
