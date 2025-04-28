using CoursRapideBlazorWasm.Infrastructures;
using Microsoft.JSInterop;

namespace CoursRapideBlazorWasm.Components
{
    public partial class ChildComponent5 : IDisposable
    {
        private string? _toto;

        protected override void OnInitialized()
        {
            Mediator<string>.Instance.Broadcaster += OnMessage;
        }

        private void OnClick()
        {
            Mediator<string>.Instance.Send(this, $"Message envoyé à {DateTime.Now}");
        }

        private void OnMessage(object sender, string value)
        {
            if (sender == this)
                return;

            _toto = value;
            StateHasChanged();
            _js.InvokeVoidAsync("alert", value);
        }

        public void Dispose()
        {
            Mediator<string>.Instance.Broadcaster -= OnMessage;
        }
    }
}