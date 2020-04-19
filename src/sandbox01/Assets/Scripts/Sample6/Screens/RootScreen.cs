//using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Unity.UIWidgets.painting;
using Unity.UIWidgets.rendering;
using Unity.UIWidgets.ui;
using Unity.UIWidgets.widgets;

namespace Samples.UIWidgets.Sample6.Screen
{
    public class RootScreen : StatelessWidget
    {
        public override Widget build(BuildContext context)
        {
            return new Container(
                color: new Color(0xFFFFFFFF),
                child: new CustomSafeArea(
                    top: false,
                    child: new Column(
                        mainAxisAlignment: MainAxisAlignment.end,
                        children: new List<Widget> {
                            new Container(
                                width: 182,
                                height: 32,
                                child: Unity.UIWidgets.widgets.Image.asset("image/iOS/unityConnectBlack.imageset/unityConnectBlack")
                            ),
                            new Container(
                                width: 101,
                                height: 22,
                                margin: EdgeInsets.only(top: 6, bottom: 20),
                                child: Unity.UIWidgets.widgets.Image.asset("image/iOS/madeWithUnity.imageset/madeWithUnity")
                            )
                        })
                ));
        }
    }

    public class CustomSafeArea : StatelessWidget
    {
        public CustomSafeArea(
            Unity.UIWidgets.foundation.Key key = null,
            bool top = true,
            bool bottom = true,
            Widget child = null
        ) : base(key: key)
        {
            Unity.UIWidgets.foundation.D.assert(child != null);
            this.child = child;
            this.top = top;
            this.bottom = bottom;
        }

        readonly Widget child;
        readonly bool top;
        readonly bool bottom;

        public override Widget build(BuildContext context)
        {
            bool topValue = UnityEngine.Application.platform != UnityEngine.RuntimePlatform.Android;
            if (this.top == false)
            {
                topValue = false;
            }

            return new SafeArea(
                top: topValue,
                bottom: this.bottom,
                child: this.child
            );
        }
    }
}