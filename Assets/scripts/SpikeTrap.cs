using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(Collider))]
public class SpikeTrap : MonoBehaviour
{
    [Header("Configuración")]
    [SerializeField] private float appearTime = 1f;      // Tiempo que tarda en aparecer
    [SerializeField] private string playerTag = "Player"; // Tag del jugador
    private bool isActive = false;

    private Renderer rend;
    private Material mat;
    private Color originalColor;
    private Collider trapCollider;

    private void Start()
    {
        trapCollider = GetComponent<Collider>();
        trapCollider.isTrigger = true; // Trigger para detectar al jugador

        rend = GetComponentInChildren<Renderer>();
        if (rend == null)
        {
            Debug.LogError("SpikeTrap requiere un Renderer.");
            return;
        }

        mat = rend.material;
        originalColor = mat.color;

        // Habilitar transparencia para el fade
        SetupMaterialWithTransparency(mat);

        // Inicialmente invisible
        SetAlpha(0f);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (isActive) return;

        // Detectamos jugador
        player playerScript = other.GetComponentInParent<player>();
        if (playerScript != null)
        {
            isActive = true;
            StartCoroutine(MaterializeAndDefeat());
        }
    }

    private IEnumerator MaterializeAndDefeat()
    {
        float t = 0f;
        while (t < 1f)
        {
            t += Time.deltaTime / appearTime;
            SetAlpha(Mathf.Lerp(0f, 1f, t));
            yield return null;
        }
        SetAlpha(1f);

        // Trampa completa: cargar escena de derrota
        SceneManager.LoadScene("derrota");
    }

    private void SetAlpha(float a)
    {
        mat.color = new Color(originalColor.r, originalColor.g, originalColor.b, a);
    }

    private void SetupMaterialWithTransparency(Material m)
    {
        m.SetFloat("_Mode", 2); // Fade
        m.SetInt("_SrcBlend", (int)UnityEngine.Rendering.BlendMode.SrcAlpha);
        m.SetInt("_DstBlend", (int)UnityEngine.Rendering.BlendMode.OneMinusSrcAlpha);
        m.SetInt("_ZWrite", 0);
        m.DisableKeyword("_ALPHATEST_ON");
        m.EnableKeyword("_ALPHABLEND_ON");
        m.DisableKeyword("_ALPHAPREMULTIPLY_ON");
        m.renderQueue = (int)UnityEngine.Rendering.RenderQueue.Transparent;
    }
}
