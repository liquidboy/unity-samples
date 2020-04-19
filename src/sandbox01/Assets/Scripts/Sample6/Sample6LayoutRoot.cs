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
    public class Sample6LayoutRoot : UIWidgetsPanel
    {
        protected override void OnEnable()
        {
            // if you want to use your own font or font icons.
            // FontManager.instance.addFont(Resources.Load<Font>(path: "path to your font"), "font family name");

            // load custom font with weight & style. The font weight & style corresponds to fontWeight, fontStyle of
            // a TextStyle object
            // FontManager.instance.addFont(Resources.Load<Font>(path: "path to your font"), "Roboto", FontWeight.w500,
            //    FontStyle.italic);

            // add material icons, familyName must be "Material Icons"
            FontManager.instance.addFont(Resources.Load<Font>(path: "fonts/MaterialIcons-Regular"), "Material Icons");

            base.OnEnable();
        }

        protected override Widget createWidget()
        {
            return new WidgetsApp(
                    home: new ExampleApp(),
                    pageRouteBuilder: (RouteSettings settings, WidgetBuilder builder) =>
                        new PageRouteBuilder(
                            settings: settings,
                            pageBuilder: (BuildContext context, Animation<float> animation,
                                Animation<float> secondaryAnimation) => builder(context)
                        )
                );
        }

        class ExampleApp : StatefulWidget
        {
            public ExampleApp(Key key = null) : base(key)
            {
            }

            public override State createState()
            {
                return new ExampleState();
            }
        }

        class ExampleState : State<ExampleApp>
        {
            int counter = 0;

            public override Widget build(BuildContext context)
            {
                return new WidgetsApp(
                    home: new Router(),
                    pageRouteBuilder: pageRouteBuilder
                );

                //return new MaterialApp(
                //    home: new Scaffold(
                //        appBar: new AppBar(title: new Text("sample 6 title"), centerTitle: true),
                //        body: new Card(
                //            child: new Center(
                //                child: new Row(
                //                    mainAxisSize: MainAxisSize.max,
                //                    crossAxisAlignment: CrossAxisAlignment.center,
                //                    mainAxisAlignment: MainAxisAlignment.center,
                //                    children: new List<Widget>() {
                //                        new Icon(Icons.directions_car, size:128.0f, color: Colors.black),
                //                        new RaisedButton(child: new Text("Next Mode"))
                //                    }
                //                )
                //            )
                //        ),
                //        floatingActionButton: new FloatingActionButton(
                //            backgroundColor: Colors.redAccent,
                //            child: new Icon( 
                //                icon: Icons.add_alert, 
                //                size:32.0f,
                //                color: Colors.white
                //            ),
                //            onPressed: () => { }
                //        )
                //    )
                //);

            }

            static PageRouteFactory pageRouteBuilder
            {
                get
                {
                    return (settings, builder) =>
                        new PageRouteBuilder(
                            settings: settings,
                            (context, animation, secondaryAnimation) => builder(context)
                        );
                }
            }
        }
    }
}