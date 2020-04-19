using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Unity.UIWidgets.animation;
using Unity.UIWidgets.engine;
using Unity.UIWidgets.foundation;
using Unity.UIWidgets.material;
using Unity.UIWidgets.painting;
using Unity.UIWidgets.ui;
using Unity.UIWidgets.widgets;
using FontStyle = Unity.UIWidgets.ui.FontStyle;
using Unity.UIWidgets.rendering;
using RSG;

namespace Samples.UIWidgets.Sample6
{
    class Router : StatelessWidget
    {
        static readonly GlobalKey globalKey = GlobalKey.key("main-router");
        static readonly RouteObserve<PageRoute> _routeObserve = new RouteObserve<PageRoute>();
        static readonly HeroController _heroController = new HeroController();

        static Dictionary<string, WidgetBuilder> fullScreenRoutes
        {
            get
            {
                return new Dictionary<string, WidgetBuilder> {
                    //{MainNavigatorRoutes.Search, context => new SearchScreenConnector()},
                    //{MainNavigatorRoutes.Login, context => new LoginScreen()},
                    //{MainNavigatorRoutes.ForceUpdate, context => new ForceUpdateScreen()}
                };
            }
        }

        public override Widget build(BuildContext context)
        {
            return new WillPopScope(
               onWillPop: () => {
                           //TipMenu.dismiss();
                           var promise = new Promise<bool>();
                           //if (VersionManager.needForceUpdate())
                           //{
                           //    promise.Resolve(false);
                           //}
                           //else if (LoginScreen.navigator?.canPop() ?? false)
                           //{
                           //    LoginScreen.navigator.pop();
                           //    promise.Resolve(false);
                           //}
                           //else if (Screen.orientation != ScreenOrientation.Portrait)
                           //{
                           //     //视频全屏时禁止物理返回按钮
                           //     EventBus.publish(sName: EventBusConstant.fullScreen, new List<object> { true });
                           //    promise.Resolve(false);
                           //}
                           //else if (navigator.canPop())
                           //{
                           //    navigator.pop();
                           //    promise.Resolve(false);
                           //}
                           //else
                           //{
                           //    if (Application.platform == RuntimePlatform.Android)
                           //    {
                           //        if (this._exitApp)
                           //        {
                           //            CustomToast.hidden();
                           //            promise.Resolve(true);
                           //            if (this._timer != null)
                           //            {
                           //                this._timer.Dispose();
                           //                this._timer = null;
                           //            }
                           //        }
                           //        else
                           //        {
                           //            this._exitApp = true;
                           //            CustomToast.show(new CustomToastItem(
                           //                context: context,
                           //                "再按一次退出",
                           //                TimeSpan.FromMilliseconds(2000)
                           //            ));
                           //            this._timer = Window.instance.run(TimeSpan.FromMilliseconds(2000),
                           //                () => { this._exitApp = false; });
                           //            promise.Resolve(false);
                           //        }
                           //    }
                           //    else
                           //    {
                           //        promise.Resolve(true);
                           //    }
                           //}

                           return promise;
               },
               child: new Navigator(
                   //    key: globalKey,
                   observers: new List<NavigatorObserver> {
                                _routeObserve,
                                _heroController
                   }
                   //, onGenerateRoute: settings => new CustomPageRoute(
                   //    //settings: settings,
                   //    //fullscreenDialog: fullScreenRoutes.ContainsKey(key: settings.name),
                   //    //builder: context1 => mainRoutes[key: settings.name](context: context1)
                   //)
               )
           );
        }
    }
}