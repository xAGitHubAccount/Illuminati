using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Moq;
using NUnit.Framework;
using MvvmCross.Tests;
using Illuminati.Core.ViewModels;
using Illuminati.Core.Models.Card.GroupCard;
using NUnit.Framework.Legacy;
using Assert = NUnit.Framework.Assert;
using Illuminati.Core.Models.Card;
using System.Collections.ObjectModel;
using MvvmCross.Base;
using MvvmCross.Views;
using MvvmCross.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace UnitTestProject1
{
	[TestFixture]
	public class UnitTest1 : MvxIoCSupportingTest
	{
		MainViewModel vm = new MainViewModel(0);

		public MockDispatcher MockDispatcher { get; private set; }
		protected override void AdditionalSetup()
		{
			MockDispatcher = new MockDispatcher();
			Ioc.RegisterSingleton<IMvxViewDispatcher>(MockDispatcher);
			Ioc.RegisterSingleton<IMvxMainThreadDispatcher>(MockDispatcher);
			Ioc.RegisterSingleton<IMvxMainThreadAsyncDispatcher>(MockDispatcher);
		}

		[Test]
		public void TestMethod1()
		{
			//Arrange
			bool a = true;

			//Act
			a = vm.DiceRoll(9, 10, 0);

			//Assert
			ClassicAssert.AreEqual(false, a);
		}

		[Test]
		public void TestMethod2()
		{
			//Arrange
			Deck d = new Deck();
			int c = d.GetDeck().Count - 1;

			//Act
			var k = d.DrawCard();

			//Assert
			ClassicAssert.IsTrue(c > d.GetDeck().Count - 1);
		}

		[Test]
		public void TestMethod3()
		{
			//Arrange
			base.Setup();
			Airlines a = new Airlines();
			GroupViewModel gvm = new GroupViewModel();

			//Act
			gvm.BoardGrid.Add(a);

			//Assert
			ClassicAssert.AreEqual(a, gvm.BoardGrid[0]);
		}

		[Test]
		public void TestMethod4()
		{
			//Arrange
			base.Setup();
			Airlines a = new Airlines();
			GroupViewModel gvm = new GroupViewModel();

			//Act
			gvm.BoardGrid.Add(a);
			gvm.OnOffTest();

			//Assert
			ClassicAssert.IsTrue(gvm.BoardGrid[0].OnOff == true);
		}

		[Test]
		public void TestMethod5()
		{
			//Arrange
			base.Setup();
			Airlines a = new Airlines();
			GroupViewModel gvm = new GroupViewModel();

			//Act
			gvm.BoardGrid.Add(a);
			gvm.OnOffTest();
			gvm.OnOffReverse();

			//Assert
			ClassicAssert.IsTrue(gvm.BoardGrid[0].OnOff == false);
		}
		
		[Test]
		public void TestMethod6()
		{
			//Arrange
			base.Setup();
			Airlines a = new Airlines();
			GroupViewModel gvm = new GroupViewModel();

			//Act
			gvm.BoardGrid.Add(a);
			gvm.CollectAllIncome();
			gvm.CollectAllIncome();
			gvm.CollectAllIncome();

			//Assert
			ClassicAssert.AreEqual(3, gvm.BoardGrid[0].GetBalance());
		}
	}

	public class MockDispatcher : MvxMainThreadDispatcher, IMvxViewDispatcher, IMvxMainThreadAsyncDispatcher
	{
		public readonly List<MvxViewModelRequest> Requests = new List<MvxViewModelRequest>();
		public readonly List<MvxPresentationHint> Hints = new List<MvxPresentationHint>();

		public override bool IsOnMainThread => throw new NotImplementedException();

		public bool RequestMainThreadAction(Action action)
		{
			action();
			return true;
		}

		public bool ShowViewModel(MvxViewModelRequest request)
		{
			Requests.Add(request);
			return true;
		}

		public bool ChangePresentation(MvxPresentationHint hint)
		{
			Hints.Add(hint);
			return true;
		}

		Task<bool> IMvxViewDispatcher.ShowViewModel(MvxViewModelRequest request)
		{
			throw new NotImplementedException();
		}

		Task<bool> IMvxViewDispatcher.ChangePresentation(MvxPresentationHint hint)
		{
			throw new NotImplementedException();
		}

		public Task ExecuteOnMainThreadAsync(Func<Task> action, bool maskExceptions = true)
		{
			throw new NotImplementedException();
		}

		public override bool RequestMainThreadAction(Action action, bool maskExceptions = true)
		{
			throw new NotImplementedException();
		}

		public Task ExecuteOnMainThreadAsync(Action action, bool maskExceptions = true)
		{
			return Task.CompletedTask;
		}
	}
}
