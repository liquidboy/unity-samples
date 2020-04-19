using UnityEngine;
using System.Collections;
using Unity.UIWidgets.widgets;
using Unity.UIWidgets.animation;

namespace Samples.UIWidgets.Sample6
{
    public class CustomPageRoute : PageRoute
    {
        readonly WidgetBuilder builder;

        public CustomPageRoute(
            WidgetBuilder builder,
            RouteSettings settings = null,
            string title = "",
            bool maintainState = true,
            bool fullscreenDialog = false,
            bool push = false,
            RouteTransitionsBuilder overrideTransitionsBuilder = null
        ) : base(settings: settings, fullscreenDialog: fullscreenDialog)
        {
            //D.assert(builder != null);
            //D.assert(this.opaque);
            this.builder = builder;
            //this.title = title;
            //this.maintainState = maintainState;
            //this.push = push;
            //this.overrideTransitionsBuilder = overrideTransitionsBuilder;
        }

        public override Widget buildPage(BuildContext context, Animation<float> animation, Animation<float> secondaryAnimation)
        {
            Widget result = this.builder(context);
            return result;
        }
    }
}