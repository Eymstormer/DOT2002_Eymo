using UnityEngine;

namespace Ursaanimation.CubicFarmAnimals
{
    public class AnimationController : MonoBehaviour
    {
        public Animator animator;
        public string walkAnimation = "walk_forward";
        public string idleAnimation = "idle";
        public float moveSpeed = 1.5f;
        public Rigidbody Rigidbody;

        float timer;
        bool walking = false;

        void Start()
        {
            animator = GetComponent<Animator>();
            Rigidbody = GetComponent<Rigidbody>();
            PlayIdle();
        }

        void Update()
        {
            timer += Time.deltaTime;

            if (timer > 5f)
            {
                RandomAnimation();
                timer = 0;
            }
            if (walking)
            {
                Rigidbody.MovePosition(Rigidbody.position + transform.forward * moveSpeed * Time.fixedDeltaTime);
            }
        }

        void RandomAnimation()
        {
            int rand = Random.Range(0, 2);

            if (rand == 0)
            {
                walking = true;
                transform.Rotate(0, Random.Range(-90, 90), 0);
                animator.Play(walkAnimation);
            }
            else
            {
                walking = false;
                animator.Play(idleAnimation);
            }
        }

        void PlayIdle()
        {
            animator.Play(idleAnimation);
        }
    }
}