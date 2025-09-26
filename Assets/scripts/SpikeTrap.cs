using System.Collections;
using UnityEngine;

public class SpikeTrap : MonoBehaviour
{
    [Header("Trap Settings")]
    [SerializeField] private float appearTime = 2.0f;   // Tiempo en aparecer
    [SerializeField] private float solidDelay = 0.5f;   // Tiempo extra antes de volverse letal
    [SerializeField] private float damage = 999f;       // Daño letal al jugador

    private Collider trapCollider;
    private Renderer trapRenderer;
    private Material materialInstance;
    private Color originalColor;
    private bool isActive = false;

    private void Start()
    {
        trapCollider = GetComponent<Collider>();
        trapRenderer = GetComponentInChildren<Renderer>();

        // Crear instancia del material (para no modificarlo globalmente)
        materialInstance = trapRenderer.material;
        originalColor = materialInstance.color;

        // Habilitar transparencia
        SetupMaterialWithTransparency(materialInstance);

        // Inicialmente invisible y sin colisión
        SetAlpha(0f);
        trapCollider.enabled = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        
            Debug.Log("Algo entró al trigger: " + other.name);

            if (!isActive && other.GetComponent<player>() != null)
            {
                Debug.Log("El jugador activó la trampa");
                StartCoroutine(AppearAndActivate(other.GetComponent<player>()));
            }
        

        if (!isActive && other.GetComponent<player>() != null)
        {
            StartCoroutine(AppearAndActivate(other.GetComponent<player>()));
        }
    }

    private IEnumerator AppearAndActivate(player player)
    {
        isActive = true;
        float t = 0f;

        // Fase de aparición visual
        while (t < 1f)
        {
            t += Time.deltaTime / appearTime;
            SetAlpha(Mathf.Lerp(0f, 1f, t));
            yield return null;
        }

        // Un pequeño retraso antes de volverse letal
        yield return new WaitForSeconds(solidDelay);

        trapCollider.enabled = true;

        // Si el jugador sigue dentro, lo mata
        if (player != null)
        {
            player.getdamage(damage);
        }
    }

    private void SetAlpha(float alpha)
    {
        materialInstance.color = new Color(
            originalColor.r,
            originalColor.g,
            originalColor.b,
            alpha
        );
    }

    // Configura el material en modo transparente (Fade)
    private void SetupMaterialWithTransparency(Material mat)
    {
        mat.SetFloat("_Mode", 2); // 2 = Fade
        mat.SetInt("_SrcBlend", (int)UnityEngine.Rendering.BlendMode.SrcAlpha);
        mat.SetInt("_DstBlend", (int)UnityEngine.Rendering.BlendMode.OneMinusSrcAlpha);
        mat.SetInt("_ZWrite", 0);
        mat.DisableKeyword("_ALPHATEST_ON");
        mat.EnableKeyword("_ALPHABLEND_ON");
        mat.DisableKeyword("_ALPHAPREMULTIPLY_ON");
        mat.renderQueue = (int)UnityEngine.Rendering.RenderQueue.Transparent;
    }
}
