using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{

    public float var_speed;
    public float var_jumpForce;

    private Rigidbody2D var_rig;
    private bool var_isJumping;

    // Start is called before the first frame update
    void Start()
    {
        var_rig = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //aqui faz o player ir para frente
        var_rig.velocity = new Vector2(var_speed, var_rig.velocity.y);

        //aqui faz o player pular quando clicar com o botão esquerdo do mouse na tela sendo a variavel isJumping false
        if(Input.GetMouseButtonDown(0) && !var_isJumping)
        {
            var_rig.AddForce(Vector2.up * var_jumpForce, ForceMode2D.Impulse);
            var_isJumping = true;
        }
    }

    //esse método checa todas as vezes que o player colide com o chão e transforma a variavel isJumping em verdadeiro, permitindo o player pular novamente

    void OnCollisionEnter2D(Collision2D void_collider)
    {
        if(void_collider.gameObject.layer == 6)
        {
            var_isJumping = false;
        }
    }
}
