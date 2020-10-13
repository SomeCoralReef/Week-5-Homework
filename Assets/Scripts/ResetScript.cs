using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetScript : MonoBehaviour
{   
    public state state;
    public float lerpSpeed;
    public A A;
    public B B;
    public C C;
    public D D;
    public E E;
    public F F;
    public G G;
    public H H;
    public I I;
    public J J;
    public K K;
    public L L;
    public M M;
    public N N;
    public O O;
    public P P;
    public Q Q;
    public R R;
    public S S;
    public T T;
    public U U;
    public V V;
    public W W;
    public X X;
    public Y Y;
    public Z Z;

    void Update(){
        if(state.GoldWin == true){
            A.transform.position=A.spawnPos;
            B.transform.position=B.spawnPos;
            C.transform.position=C.spawnPos;
            D.transform.position=D.spawnPos;
            E.transform.position=E.spawnPos;
            F.transform.position=F.spawnPos;
            G.transform.position=G.spawnPos;
            H.transform.position=H.spawnPos;
            I.transform.position=I.spawnPos;
            J.transform.position=J.spawnPos;
            K.transform.position=K.spawnPos;
            L.transform.position=L.spawnPos;
            M.transform.position=M.spawnPos;
            N.transform.position=N.spawnPos;
            O.transform.position=O.spawnPos;
            P.transform.position=P.spawnPos;
            Q.transform.position=Q.spawnPos;
            R.transform.position=R.spawnPos;
            S.transform.position=S.spawnPos;
            T.transform.position=T.spawnPos;
            U.transform.position=U.spawnPos;
            V.transform.position=V.spawnPos;
            W.transform.position=W.spawnPos;
            X.transform.position=X.spawnPos;
            Y.transform.position=Y.spawnPos;
            Z.transform.position=Z.spawnPos;

            A.transform.rotation = A.spawnRot;
            B.transform.rotation = B.spawnRot;
            C.transform.rotation = C.spawnRot;
            D.transform.rotation = D.spawnRot;
            E.transform.rotation = E.spawnRot;
            F.transform.rotation = F.spawnRot;
            G.transform.rotation = G.spawnRot;
            H.transform.rotation = H.spawnRot;
            I.transform.rotation = I.spawnRot;
            J.transform.rotation = J.spawnRot;
            K.transform.rotation = K.spawnRot;
            L.transform.rotation = L.spawnRot;
            M.transform.rotation = M.spawnRot;
            N.transform.rotation = N.spawnRot;
            O.transform.rotation = O.spawnRot;
            P.transform.rotation = P.spawnRot;
            Q.transform.rotation = Q.spawnRot;
            R.transform.rotation = R.spawnRot;
            S.transform.rotation = S.spawnRot;
            T.transform.rotation = T.spawnRot;
            U.transform.rotation = U.spawnRot;
            V.transform.rotation = V.spawnRot;
            W.transform.rotation = W.spawnRot;
            X.transform.rotation = X.spawnRot;
            Y.transform.rotation = Y.spawnRot;
            Z.transform.rotation = Z.spawnRot;
            state.GoldWin = false;
    }
    }
    void OnTriggerEnter2D(Collider2D activator){
        Debug.Log("aiya");
        if(activator.tag == "Player"){
            float interpolation = lerpSpeed * Time.deltaTime;
            A.transform.position=A.spawnPos;
            B.transform.position=B.spawnPos;
            C.transform.position=C.spawnPos;
            D.transform.position=D.spawnPos;
            E.transform.position=E.spawnPos;
            F.transform.position=F.spawnPos;
            G.transform.position=G.spawnPos;
            H.transform.position=H.spawnPos;
            I.transform.position=I.spawnPos;
            J.transform.position=J.spawnPos;
            K.transform.position=K.spawnPos;
            L.transform.position=L.spawnPos;
            M.transform.position=M.spawnPos;
            N.transform.position=N.spawnPos;
            O.transform.position=O.spawnPos;
            P.transform.position=P.spawnPos;
            Q.transform.position=Q.spawnPos;
            R.transform.position=R.spawnPos;
            S.transform.position=S.spawnPos;
            T.transform.position=T.spawnPos;
            U.transform.position=U.spawnPos;
            V.transform.position=V.spawnPos;
            W.transform.position=W.spawnPos;
            X.transform.position=X.spawnPos;
            Y.transform.position=Y.spawnPos;
            Z.transform.position=Z.spawnPos;

            A.transform.rotation = A.spawnRot;
            B.transform.rotation = B.spawnRot;
            C.transform.rotation = C.spawnRot;
            D.transform.rotation = D.spawnRot;
            E.transform.rotation = E.spawnRot;
            F.transform.rotation = F.spawnRot;
            G.transform.rotation = G.spawnRot;
            H.transform.rotation = H.spawnRot;
            I.transform.rotation = I.spawnRot;
            J.transform.rotation = J.spawnRot;
            K.transform.rotation = K.spawnRot;
            L.transform.rotation = L.spawnRot;
            M.transform.rotation = M.spawnRot;
            N.transform.rotation = N.spawnRot;
            O.transform.rotation = O.spawnRot;
            P.transform.rotation = P.spawnRot;
            Q.transform.rotation = Q.spawnRot;
            R.transform.rotation = R.spawnRot;
            S.transform.rotation = S.spawnRot;
            T.transform.rotation = T.spawnRot;
            U.transform.rotation = U.spawnRot;
            V.transform.rotation = V.spawnRot;
            W.transform.rotation = W.spawnRot;
            X.transform.rotation = X.spawnRot;
            Y.transform.rotation = Y.spawnRot;
            Z.transform.rotation = Z.spawnRot;
            Debug.Log("go back");
    }

}
}
