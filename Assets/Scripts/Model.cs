using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public struct Model {

    public struct awake
    {
        public string prefix { get; set; }
        public List<string> body { get; set; }
        public string description { get; set; }
    }

    public struct fixedUpdate
    {
        public string prefix { get; set; }
        public List<string> body { get; set; }
        public string description { get; set; }
    }

    public struct lateUpdate
    {
        public string prefix { get; set; }
        public List<string> body { get; set; }
        public string description { get; set; }
    }

    public struct onAnimatorIK
    {
        public string prefix { get; set; }
        public List<string> body { get; set; }
        public string description { get; set; }
    }

    public struct onAnimatorMove
    {
        public string prefix { get; set; }
        public List<string> body { get; set; }
        public string description { get; set; }
    }

    public struct onApplicationFocus
    {
        public string prefix { get; set; }
        public List<string> body { get; set; }
        public string description { get; set; }
    }

    public struct onApplicationPause
    {
        public string prefix { get; set; }
        public List<string> body { get; set; }
        public string description { get; set; }
    }

    public struct onApplicationQuit
    {
        public string prefix { get; set; }
        public List<string> body { get; set; }
        public string description { get; set; }
    }

    public struct onAudioFilterRead
    {
        public string prefix { get; set; }
        public List<string> body { get; set; }
        public string description { get; set; }
    }

    public struct onBecameInvisible
    {
        public string prefix { get; set; }
        public List<string> body { get; set; }
        public string description { get; set; }
    }

    public struct onBecameVisible
    {
        public string prefix { get; set; }
        public List<string> body { get; set; }
        public string description { get; set; }
    }

    public struct onCollisionEnter
    {
        public string prefix { get; set; }
        public List<string> body { get; set; }
        public string description { get; set; }
    }

    public struct onCollisionEnter2D
    {
        public string prefix { get; set; }
        public List<string> body { get; set; }
        public string description { get; set; }
    }

    public struct onCollisionExit
    {
        public string prefix { get; set; }
        public List<string> body { get; set; }
        public string description { get; set; }
    }

    public struct onCollisionExit2D
    {
        public string prefix { get; set; }
        public List<string> body { get; set; }
        public string description { get; set; }
    }

    public struct onCollisionStay
    {
        public string prefix { get; set; }
        public List<string> body { get; set; }
        public string description { get; set; }
    }

    public struct onCollisionStay2D
    {
        public string prefix { get; set; }
        public List<string> body { get; set; }
        public string description { get; set; }
    }

    public struct onConnectedToServer
    {
        public string prefix { get; set; }
        public List<string> body { get; set; }
        public string description { get; set; }
    }

    public struct onControllerColliderHit
    {
        public string prefix { get; set; }
        public List<string> body { get; set; }
        public string description { get; set; }
    }

    public struct onDestroy
    {
        public string prefix { get; set; }
        public List<string> body { get; set; }
        public string description { get; set; }
    }

    public struct onDisable
    {
        public string prefix { get; set; }
        public List<string> body { get; set; }
        public string description { get; set; }
    }

    public struct onDisconnectedFromServer
    {
        public string prefix { get; set; }
        public List<string> body { get; set; }
        public string description { get; set; }
    }

    public struct onDrawGizmos
    {
        public string prefix { get; set; }
        public List<string> body { get; set; }
        public string description { get; set; }
    }

    public struct onDrawGizmosSelected
    {
        public string prefix { get; set; }
        public List<string> body { get; set; }
        public string description { get; set; }
    }

    public struct onEnable
    {
        public string prefix { get; set; }
        public List<string> body { get; set; }
        public string description { get; set; }
    }

    public struct onFailedToConnect
    {
        public string prefix { get; set; }
        public List<string> body { get; set; }
        public string description { get; set; }
    }

    public struct onFailedToConnectToMasterServer
    {
        public string prefix { get; set; }
        public List<string> body { get; set; }
        public string description { get; set; }
    }

    public struct onGUI
    {
        public string prefix { get; set; }
        public List<string> body { get; set; }
        public string description { get; set; }
    }

    public struct onJointBreak
    {
        public string prefix { get; set; }
        public List<string> body { get; set; }
        public string description { get; set; }
    }

    public struct onLevelWasLoaded
    {
        public string prefix { get; set; }
        public List<string> body { get; set; }
        public string description { get; set; }
    }

    public struct onMasterServerEvent
    {
        public string prefix { get; set; }
        public List<string> body { get; set; }
        public string description { get; set; }
    }

    public struct onMouseDown
    {
        public string prefix { get; set; }
        public List<string> body { get; set; }
        public string description { get; set; }
    }

    public struct onMouseDrag
    {
        public string prefix { get; set; }
        public List<string> body { get; set; }
        public string description { get; set; }
    }

    public struct onMouseEnter
    {
        public string prefix { get; set; }
        public List<string> body { get; set; }
        public string description { get; set; }
    }

    public struct onMouseExit
    {
        public string prefix { get; set; }
        public List<string> body { get; set; }
        public string description { get; set; }
    }

    public struct onMouseOver
    {
        public string prefix { get; set; }
        public List<string> body { get; set; }
        public string description { get; set; }
    }

    public struct onMouseUp
    {
        public string prefix { get; set; }
        public List<string> body { get; set; }
        public string description { get; set; }
    }

    public struct onMouseUpAsButton
    {
        public string prefix { get; set; }
        public List<string> body { get; set; }
        public string description { get; set; }
    }

    public struct onNetworkInstantiate
    {
        public string prefix { get; set; }
        public List<string> body { get; set; }
        public string description { get; set; }
    }

    public struct onParticleCollision
    {
        public string prefix { get; set; }
        public List<string> body { get; set; }
        public string description { get; set; }
    }

    public struct onPlayerConnected
    {
        public string prefix { get; set; }
        public List<string> body { get; set; }
        public string description { get; set; }
    }

    public struct onPlayerDisconnected
    {
        public string prefix { get; set; }
        public List<string> body { get; set; }
        public string description { get; set; }
    }

    public struct onPostRender
    {
        public string prefix { get; set; }
        public List<string> body { get; set; }
        public string description { get; set; }
    }

    public struct onPreCull
    {
        public string prefix { get; set; }
        public List<string> body { get; set; }
        public string description { get; set; }
    }

    public struct onPreRender
    {
        public string prefix { get; set; }
        public List<string> body { get; set; }
        public string description { get; set; }
    }

    public struct onRectTransformRemoved
    {
        public string prefix { get; set; }
        public List<string> body { get; set; }
        public string description { get; set; }
    }

    public struct onRenderImage
    {
        public string prefix { get; set; }
        public List<string> body { get; set; }
        public string description { get; set; }
    }

    public struct onRenderObject
    {
        public string prefix { get; set; }
        public List<string> body { get; set; }
        public string description { get; set; }
    }

    public struct onSerializeNetworkView
    {
        public string prefix { get; set; }
        public List<string> body { get; set; }
        public string description { get; set; }
    }

    public struct onServerInitialized
    {
        public string prefix { get; set; }
        public List<string> body { get; set; }
        public string description { get; set; }
    }

    public struct onTriggerEnter
    {
        public string prefix { get; set; }
        public List<string> body { get; set; }
        public string description { get; set; }
    }

    public struct onTriggerEnter2D
    {
        public string prefix { get; set; }
        public List<string> body { get; set; }
        public string description { get; set; }
    }

    public struct onTriggerExit
    {
        public string prefix { get; set; }
        public List<string> body { get; set; }
        public string description { get; set; }
    }

    public struct onTriggerExit2D
    {
        public string prefix { get; set; }
        public List<string> body { get; set; }
        public string description { get; set; }
    }

    public struct onTriggerStay
    {
        public string prefix { get; set; }
        public List<string> body { get; set; }
        public string description { get; set; }
    }

    public struct onTriggerStay2D
    {
        public string prefix { get; set; }
        public List<string> body { get; set; }
        public string description { get; set; }
    }

    public struct onValidate
    {
        public string prefix { get; set; }
        public List<string> body { get; set; }
        public string description { get; set; }
    }

    public struct onWillRenderObject
    {
        public string prefix { get; set; }
        public List<string> body { get; set; }
        public string description { get; set; }
    }

    public struct reset
    {
        public string prefix { get; set; }
        public List<string> body { get; set; }
        public string description { get; set; }
    }

    public struct start
    {
        public string prefix { get; set; }
        public List<string> body { get; set; }
        public string description { get; set; }
    }

    public struct update
    {
        public string prefix { get; set; }
        public List<string> body { get; set; }
        public string description { get; set; }
    }

    public struct onBeginDrag
    {
        public string prefix { get; set; }
        public List<string> body { get; set; }
        public string description { get; set; }
    }

    public struct onDeselect
    {
        public string prefix { get; set; }
        public List<string> body { get; set; }
        public string description { get; set; }
    }

    public struct onDrag
    {
        public string prefix { get; set; }
        public List<string> body { get; set; }
        public string description { get; set; }
    }

    public struct onDrop
    {
        public string prefix { get; set; }
        public List<string> body { get; set; }
        public string description { get; set; }
    }

    public struct onEndDrag
    {
        public string prefix { get; set; }
        public List<string> body { get; set; }
        public string description { get; set; }
    }

    public struct onInitializePotentialDrag
    {
        public string prefix { get; set; }
        public List<string> body { get; set; }
        public string description { get; set; }
    }

    public struct onMove
    {
        public string prefix { get; set; }
        public List<string> body { get; set; }
        public string description { get; set; }
    }

    public struct onRebuildRequested
    {
        public string prefix { get; set; }
        public List<string> body { get; set; }
        public string description { get; set; }
    }

    public struct onScroll
    {
        public string prefix { get; set; }
        public List<string> body { get; set; }
        public string description { get; set; }
    }

    public struct onSelect
    {
        public string prefix { get; set; }
        public List<string> body { get; set; }
        public string description { get; set; }
    }

    public struct onSubmit
    {
        public string prefix { get; set; }
        public List<string> body { get; set; }
        public string description { get; set; }
    }

    public struct onTransformChildrenChanged
    {
        public string prefix { get; set; }
        public List<string> body { get; set; }
        public string description { get; set; }
    }

    public struct onBeforeSerialize
    {
        public string prefix { get; set; }
        public List<string> body { get; set; }
        public string description { get; set; }
    }

    public struct onBeforeTransformParentChanged
    {
        public string prefix { get; set; }
        public List<string> body { get; set; }
        public string description { get; set; }
    }

    public struct onCanvasGroupChanged
    {
        public string prefix { get; set; }
        public List<string> body { get; set; }
        public string description { get; set; }
    }

    public struct onDidApplyAnimationProperties
    {
        public string prefix { get; set; }
        public List<string> body { get; set; }
        public string description { get; set; }
    }

    public struct onFillVBO
    {
        public string prefix { get; set; }
        public List<string> body { get; set; }
        public string description { get; set; }
    }

    public struct onPointerClick
    {
        public string prefix { get; set; }
        public List<string> body { get; set; }
        public string description { get; set; }
    }

    public struct onPointerDown
    {
        public string prefix { get; set; }
        public List<string> body { get; set; }
        public string description { get; set; }
    }

    public struct onPointerEnter
    {
        public string prefix { get; set; }
        public List<string> body { get; set; }
        public string description { get; set; }
    }

    public struct onPointerExit
    {
        public string prefix { get; set; }
        public List<string> body { get; set; }
        public string description { get; set; }
    }

    public struct onPointerUp
    {
        public string prefix { get; set; }
        public List<string> body { get; set; }
        public string description { get; set; }
    }

    public struct onRectTransformDimensionsChange
    {
        public string prefix { get; set; }
        public List<string> body { get; set; }
        public string description { get; set; }
    }

    public struct onSiblingGraphicEnabledDisabled
    {
        public string prefix { get; set; }
        public List<string> body { get; set; }
        public string description { get; set; }
    }

    public struct onTransformParentChanged
    {
        public string prefix { get; set; }
        public List<string> body { get; set; }
        public string description { get; set; }
    }

    public struct onUpdateSelected
    {
        public string prefix { get; set; }
        public List<string> body { get; set; }
        public string description { get; set; }
    }

    public struct updateGeometry
    {
        public string prefix { get; set; }
        public List<string> body { get; set; }
        public string description { get; set; }
    }

    public struct updateMaterial
    {
        public string prefix { get; set; }
        public List<string> body { get; set; }
        public string description { get; set; }
    }

    public struct onAssignMaterialModel
    {
        public string prefix { get; set; }
        public List<string> body { get; set; }
        public string description { get; set; }
    }

    public struct onHierarchyChange
    {
        public string prefix { get; set; }
        public List<string> body { get; set; }
        public string description { get; set; }
    }

    public struct onInspectorUpdate
    {
        public string prefix { get; set; }
        public List<string> body { get; set; }
        public string description { get; set; }
    }

    public struct onLostFocus
    {
        public string prefix { get; set; }
        public List<string> body { get; set; }
        public string description { get; set; }
    }

    public struct onPostprocessAllAssets
    {
        public string prefix { get; set; }
        public List<string> body { get; set; }
        public string description { get; set; }
    }

    public struct onPostprocessAssetbundleNameChanged
    {
        public string prefix { get; set; }
        public List<string> body { get; set; }
        public string description { get; set; }
    }

    public struct onPostprocessAudio
    {
        public string prefix { get; set; }
        public List<string> body { get; set; }
        public string description { get; set; }
    }

    public struct onPostprocessGameObjectWithUserProperties
    {
        public string prefix { get; set; }
        public List<string> body { get; set; }
        public string description { get; set; }
    }

    public struct onPostprocessModel
    {
        public string prefix { get; set; }
        public List<string> body { get; set; }
        public string description { get; set; }
    }

    public struct onPostprocessSpeedTree
    {
        public string prefix { get; set; }
        public List<string> body { get; set; }
        public string description { get; set; }
    }

    public struct onPostprocessSprites
    {
        public string prefix { get; set; }
        public List<string> body { get; set; }
        public string description { get; set; }
    }

    public struct onPostprocessTexture
    {
        public string prefix { get; set; }
        public List<string> body { get; set; }
        public string description { get; set; }
    }

    public struct onPreprocessAudio
    {
        public string prefix { get; set; }
        public List<string> body { get; set; }
        public string description { get; set; }
    }

    public struct onPreprocessModel
    {
        public string prefix { get; set; }
        public List<string> body { get; set; }
        public string description { get; set; }
    }

    public struct onPreprocessSpeedTree
    {
        public string prefix { get; set; }
        public List<string> body { get; set; }
        public string description { get; set; }
    }

    public struct onPreprocessTexture
    {
        public string prefix { get; set; }
        public List<string> body { get; set; }
        public string description { get; set; }
    }

    public struct onProjectChange
    {
        public string prefix { get; set; }
        public List<string> body { get; set; }
        public string description { get; set; }
    }

    public struct onSceneGUI
    {
        public string prefix { get; set; }
        public List<string> body { get; set; }
        public string description { get; set; }
    }

    public struct onSelectionChange
    {
        public string prefix { get; set; }
        public List<string> body { get; set; }
        public string description { get; set; }
    }

    public struct onWillCreateAsset
    {
        public string prefix { get; set; }
        public List<string> body { get; set; }
        public string description { get; set; }
    }

    public struct onWillDeleteAsset
    {
        public string prefix { get; set; }
        public List<string> body { get; set; }
        public string description { get; set; }
    }

    public struct onWillMoveAsset
    {
        public string prefix { get; set; }
        public List<string> body { get; set; }
        public string description { get; set; }
    }

    public struct onWillSaveAssets
    {
        public string prefix { get; set; }
        public List<string> body { get; set; }
        public string description { get; set; }
    }

    public struct onWizardCreate
    {
        public string prefix { get; set; }
        public List<string> body { get; set; }
        public string description { get; set; }
    }

    public struct onWizardOtherButton
    {
        public string prefix { get; set; }
        public List<string> body { get; set; }
        public string description { get; set; }
    }

    public struct onWizardUpdate
    {
        public string prefix { get; set; }
        public List<string> body { get; set; }
        public string description { get; set; }
    }

    public awake Awake { get; set; }
    public fixedUpdate FixedUpdate { get; set; }
    public lateUpdate LateUpdate { get; set; }
    public onAnimatorIK OnAnimatorIK { get; set; }
    public onAnimatorMove OnAnimatorMove { get; set; }
    public onApplicationFocus OnApplicationFocus { get; set; }
    public onApplicationPause OnApplicationPause { get; set; }
    public onApplicationQuit OnApplicationQuit { get; set; }
    public onAudioFilterRead OnAudioFilterRead { get; set; }
    public onBecameInvisible OnBecameInvisible { get; set; }
    public onBecameVisible OnBecameVisible { get; set; }
    public onCollisionEnter OnCollisionEnter { get; set; }
    public onCollisionEnter2D OnCollisionEnter2D { get; set; }
    public onCollisionExit OnCollisionExit { get; set; }
    public onCollisionExit2D OnCollisionExit2D { get; set; }
    public onCollisionStay OnCollisionStay { get; set; }
    public onCollisionStay2D OnCollisionStay2D { get; set; }
    public onConnectedToServer OnConnectedToServer { get; set; }
    public onControllerColliderHit OnControllerColliderHit { get; set; }
    public onDestroy OnDestroy { get; set; }
    public onDisable OnDisable { get; set; }
    public onDisconnectedFromServer OnDisconnectedFromServer { get; set; }
    public onDrawGizmos OnDrawGizmos { get; set; }
    public onDrawGizmosSelected OnDrawGizmosSelected { get; set; }
    public onEnable OnEnable { get; set; }
    public onFailedToConnect OnFailedToConnect { get; set; }
    public onFailedToConnectToMasterServer OnFailedToConnectToMasterServer { get; set; }
    public onGUI OnGUI { get; set; }
    public onJointBreak OnJointBreak { get; set; }
    public onLevelWasLoaded OnLevelWasLoaded { get; set; }
    public onMasterServerEvent OnMasterServerEvent { get; set; }
    public onMouseDown OnMouseDown { get; set; }
    public onMouseDrag OnMouseDrag { get; set; }
    public onMouseEnter OnMouseEnter { get; set; }
    public onMouseExit OnMouseExit { get; set; }
    public onMouseOver OnMouseOver { get; set; }
    public onMouseUp OnMouseUp { get; set; }
    public onMouseUpAsButton OnMouseUpAsButton { get; set; }
    public onNetworkInstantiate OnNetworkInstantiate { get; set; }
    public onParticleCollision OnParticleCollision { get; set; }
    public onPlayerConnected OnPlayerConnected { get; set; }
    public onPlayerDisconnected OnPlayerDisconnected { get; set; }
    public onPostRender OnPostRender { get; set; }
    public onPreCull OnPreCull { get; set; }
    public onPreRender OnPreRender { get; set; }
    public onRectTransformRemoved OnRectTransformRemoved { get; set; }
    public onRenderImage OnRenderImage { get; set; }
    public onRenderObject OnRenderObject { get; set; }
    public onSerializeNetworkView OnSerializeNetworkView { get; set; }
    public onServerInitialized OnServerInitialized { get; set; }
    public onTriggerEnter OnTriggerEnter { get; set; }
    public onTriggerEnter2D OnTriggerEnter2D { get; set; }
    public onTriggerExit OnTriggerExit { get; set; }
    public onTriggerExit2D OnTriggerExit2D { get; set; }
    public onTriggerStay OnTriggerStay { get; set; }
    public onTriggerStay2D OnTriggerStay2D { get; set; }
    public onValidate OnValidate { get; set; }
    public onWillRenderObject OnWillRenderObject { get; set; }
    public reset Reset { get; set; }
    public start Start { get; set; }
    public update Update { get; set; }
    public onBeginDrag OnBeginDrag { get; set; }
    public onDeselect OnDeselect { get; set; }
    public onDrag OnDrag { get; set; }
    public onDrop OnDrop { get; set; }
    public onEndDrag OnEndDrag { get; set; }
    public onInitializePotentialDrag OnInitializePotentialDrag { get; set; }
    public onMove OnMove { get; set; }
    public onRebuildRequested OnRebuildRequested { get; set; }
    public onScroll OnScroll { get; set; }
    public onSelect OnSelect { get; set; }
    public onSubmit OnSubmit { get; set; }
    public onTransformChildrenChanged OnTransformChildrenChanged { get; set; }
    public onBeforeSerialize OnBeforeSerialize { get; set; }
    public onBeforeTransformParentChanged OnBeforeTransformParentChanged { get; set; }
    public onCanvasGroupChanged OnCanvasGroupChanged { get; set; }
    public onDidApplyAnimationProperties OnDidApplyAnimationProperties { get; set; }
    public onFillVBO OnFillVBO { get; set; }
    public onPointerClick OnPointerClick { get; set; }
    public onPointerDown OnPointerDown { get; set; }
    public onPointerEnter OnPointerEnter { get; set; }
    public onPointerExit OnPointerExit { get; set; }
    public onPointerUp OnPointerUp { get; set; }
    public onRectTransformDimensionsChange OnRectTransformDimensionsChange { get; set; }
    public onSiblingGraphicEnabledDisabled OnSiblingGraphicEnabledDisabled { get; set; }
    public onTransformParentChanged OnTransformParentChanged { get; set; }
    public onUpdateSelected OnUpdateSelected { get; set; }
    public updateGeometry UpdateGeometry { get; set; }
    public updateMaterial UpdateMaterial { get; set; }
    public onAssignMaterialModel OnAssignMaterialModel { get; set; }
    public onHierarchyChange OnHierarchyChange { get; set; }
    public onInspectorUpdate OnInspectorUpdate { get; set; }
    public onLostFocus OnLostFocus { get; set; }
    public onPostprocessAllAssets OnPostprocessAllAssets { get; set; }
    public onPostprocessAssetbundleNameChanged OnPostprocessAssetbundleNameChanged { get; set; }
    public onPostprocessAudio OnPostprocessAudio { get; set; }
    public onPostprocessGameObjectWithUserProperties OnPostprocessGameObjectWithUserProperties { get; set; }
    public onPostprocessModel OnPostprocessModel { get; set; }
    public onPostprocessSpeedTree OnPostprocessSpeedTree { get; set; }
    public onPostprocessSprites OnPostprocessSprites { get; set; }
    public onPostprocessTexture OnPostprocessTexture { get; set; }
    public onPreprocessAudio OnPreprocessAudio { get; set; }
    public onPreprocessModel OnPreprocessModel { get; set; }
    public onPreprocessSpeedTree OnPreprocessSpeedTree { get; set; }
    public onPreprocessTexture OnPreprocessTexture { get; set; }
    public onProjectChange OnProjectChange { get; set; }
    public onSceneGUI OnSceneGUI { get; set; }
    public onSelectionChange OnSelectionChange { get; set; }
    public onWillCreateAsset OnWillCreateAsset { get; set; }
    public onWillDeleteAsset OnWillDeleteAsset { get; set; }
    public onWillMoveAsset OnWillMoveAsset { get; set; }
    public onWillSaveAssets OnWillSaveAssets { get; set; }
    public onWizardCreate OnWizardCreate { get; set; }
    public onWizardOtherButton OnWizardOtherButton { get; set; }
    public onWizardUpdate OnWizardUpdate { get; set; }


}
