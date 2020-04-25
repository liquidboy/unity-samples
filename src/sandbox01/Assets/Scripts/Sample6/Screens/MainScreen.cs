//using UnityEngine;
using Shared;
using System.Collections;
using System.Collections.Generic;
using Unity.UIWidgets.painting;
using Unity.UIWidgets.rendering;
using Unity.UIWidgets.ui;
using Unity.UIWidgets.widgets;

namespace Samples.UIWidgets.Sample6.Screen
{
    public class MainScreen : StatelessWidget
    {
        public override Widget build(BuildContext context)
        {
            return new Container(
                color: CColors.DarkGray,
                child: new CustomSafeArea(
                    top: false,
                    child: new Column(
                        mainAxisAlignment: MainAxisAlignment.end,
                        children: new List<Widget> {
                            new Container(
                                width: 182,
                                height: 32,
                                child: Unity.UIWidgets.widgets.Image.asset("image/unityConnectBlack.imageset/unityConnectBlack")
                            ),
                            new Container(
                                width: 101,
                                height: 22,
                                margin: EdgeInsets.only(top: 6, bottom: 20),
                                child: Unity.UIWidgets.widgets.Image.asset("image/madeWithUnity.imageset/madeWithUnity")
                            )
                        })
                ));
        }

    }
}