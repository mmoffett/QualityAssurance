using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;
using Xamarin.UITest.Android;

namespace Test1
{
    [TestFixture(Platform.Android)]
    public class Test
    {
        AndroidApp app;
        public Test()
        {

        }

        [SetUp]
        public void BeforeEachTest()
        {
                 app = ConfigureApp.Android
                .ApkFile ("/data/app/com.laloosh.textmuse.app-1/base.apk").StartApp();
        }

        [Test]
        public void AppLaunches()
        {
            app.Screenshot("First screen.");
            Assert.Pass();
        }
    }
}

