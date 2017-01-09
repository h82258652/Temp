using System;
using System.Numerics;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.UI.Composition;
using Windows.UI.Xaml.Hosting;
using Windows.UI.Xaml.Navigation;

namespace AcArticle.Uwp.Views
{
    public abstract class AcArticleViewBase : ViewBase
    {
        protected override Task PlayEnterAnimationAsync()
        {
            if (Frame.BackStackDepth > 0 && Frame.CanGoForward == false)
            {
                var visual = ElementCompositionPreview.GetElementVisual(this);
                var compositor = visual.Compositor;
                var tcs = new TaskCompletionSource<object>();
                var batch = compositor.CreateScopedBatch(CompositionBatchTypes.Animation);
                TypedEventHandler<object, CompositionBatchCompletedEventArgs> handler = null;
                handler = (sender, args) =>
                {
                    batch.Completed -= handler;
                    visual.Offset = Vector3.Zero;
                    tcs.SetResult(null);
                };
                batch.Completed += handler;
                var linear = compositor.CreateLinearEasingFunction();
                var animation = compositor.CreateVector3KeyFrameAnimation();
                animation.InsertKeyFrame(0f, new Vector3((float)Frame.ActualWidth, 0f, 0f), linear);
                animation.InsertKeyFrame(1f, new Vector3(0f, 0f, 0f), linear);
                animation.Duration = TimeSpan.FromSeconds(0.3);
                visual.StartAnimation("Offset", animation);
                batch.End();
                return tcs.Task;
            }
            else
            {
                return Task.CompletedTask;
            }
        }

        protected override Task PlayLeaveAnimationAsync(NavigationMode currentPageNavigationMode)
        {
            if (currentPageNavigationMode == NavigationMode.New)
            {
                // 当前导航的页面是新页面，将旧页面往左推。
                var visual = ElementCompositionPreview.GetElementVisual(this);
                var compositor = visual.Compositor;
                var tcs = new TaskCompletionSource<object>();
                var batch = compositor.CreateScopedBatch(CompositionBatchTypes.Animation);
                TypedEventHandler<object, CompositionBatchCompletedEventArgs> handler = null;
                handler = (sender, args) =>
                {
                    batch.Completed -= handler;
                    visual.Offset = Vector3.Zero;
                    tcs.SetResult(null);
                };
                batch.Completed += handler;
                var linear = compositor.CreateLinearEasingFunction();
                var animation = compositor.CreateVector3KeyFrameAnimation();
                animation.InsertKeyFrame(0f, new Vector3(0f, 0f, 0f), linear);
                animation.InsertKeyFrame(1f, new Vector3((float)(0 - Frame.ActualWidth), 0f, 0f), linear);
                animation.Duration = TimeSpan.FromSeconds(0.3);
                visual.StartAnimation("Offset", animation);
                batch.End();
                return tcs.Task;
            }
            else if (currentPageNavigationMode == NavigationMode.Back)
            {
                // 导航后退，将页面往右推。
                var visual = ElementCompositionPreview.GetElementVisual(this);
                var compositor = visual.Compositor;
                var tcs = new TaskCompletionSource<object>();
                var batch = compositor.CreateScopedBatch(CompositionBatchTypes.Animation);
                TypedEventHandler<object, CompositionBatchCompletedEventArgs> handler = null;
                handler = (sender, args) =>
                {
                    batch.Completed -= handler;
                    visual.Offset = Vector3.Zero;
                    tcs.SetResult(null);
                };
                batch.Completed += handler;
                var linear = compositor.CreateLinearEasingFunction();
                var animation = compositor.CreateVector3KeyFrameAnimation();
                animation.InsertKeyFrame(0f, new Vector3(0f, 0f, 0f), linear);
                animation.InsertKeyFrame(1f, new Vector3((float)Frame.ActualWidth, 0f, 0f), linear);
                animation.Duration = TimeSpan.FromSeconds(0.3);
                visual.StartAnimation("Offset", animation);
                batch.End();
                return tcs.Task;
            }
            else
            {
                return Task.CompletedTask;
            }
        }
    }
}