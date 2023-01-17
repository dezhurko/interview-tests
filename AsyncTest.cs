using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

public class AsyncTest : MonoBehaviour
{
    [SerializeField]
    private Text caption;
    private async void Start()
    {
        caption.text = "Starting..";
        await Task.Delay(1000).ConfigureAwait(false);
        caption.text = "Done!";
    }
}
