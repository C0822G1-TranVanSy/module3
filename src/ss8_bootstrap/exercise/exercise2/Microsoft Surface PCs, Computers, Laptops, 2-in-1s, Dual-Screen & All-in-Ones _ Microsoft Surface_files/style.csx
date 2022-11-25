/*1Rf video player*/
.c-dialog.f-lightbox > [role=presentation] + button.c-glyph {
    z-index: 1111;
    top: 10px;
}

.yt-video-inline-height {
    /*padding-bottom: 49%;*/
    max-height: 600px;
}

.Firefox .c-dialog.surface-lightbox-preview.f-lightbox [role=dialog], .Edge .c-dialog.surface-lightbox-preview.f-lightbox [role=dialog] {
    height: 80% !important;
}

.Firefox .c-dialog.surface-lightbox-preview [role=dialog] [role=document], .Edge .c-dialog.surface-lightbox-preview [role=dialog] [role=document] {
    height: 100%;
}

.Firefox .surface-lightbox-preview .c-video-player, .Edge .surface-lightbox-preview .c-video-player {
    height: 100% !important;
}

.surface-lightbox-preview.c-dialog.f-lightbox [role=dialog] {
    width: 70%;
}

@media only screen and (max-width:540px) {
    .c-video-player.youtubeplayerRH {
        min-width: 245px;
    }
}

@media only screen and (max-width: 767px) {
    .surface-lightbox-preview.c-dialog.f-lightbox [role=dialog] {
        padding: 0px;
          width: 85%;
    }
}


.fulllivearea-video.c-video .c-glyph {
    position: absolute;
    top: 50%;
    left: 50%;
    transform: translate(-50%);    
    background: rgba(0,0,0,.6);
    border: transparent;
    border-radius: 50%;
    margin-top: -23px;
    height: 3.55vw;
    width: 3.55vw;
}
.fulllivearea-video.c-video .c-glyph:before {
    font-size: 1.5vw;
    margin-top: 3px;
}
.fulllivearea-video.c-video.playing .glyph-play{
    display:none;
}

.fulllivearea-video.c-video .glyph-pause{
    display:none;
}
@media only screen and (min-width:1600px){
    .fulllivearea-video.c-video .custom-poster img {
        width: 100%;
        height: 57vw;
    }    
}
.fluid-iframe {
    position: relative;
    padding-bottom: 56.25%;
    /*padding-top: 30px;*/
    height: 0;
    overflow: hidden;
    min-width: 320px;
}
.fluid-iframe iframe {
    position: absolute;
    top: 0;
    left: 0;
    width: 100%;
    height: 100%;
} .reduced-animation-toggle {
	 width: 100%;
	 display: flex;
	 flex-flow: row-reverse;
	 padding: 10px;
	 background-color: #f2f2f2;
	 height: 40px;
	 padding-right: 150px;
}
 @media screen and (max-width: 1920px) {
	 .reduced-animation-toggle {
		 padding-right: 70px;
	}
}
 @media screen and (max-width: 1400px) {
	 .reduced-animation-toggle {
		 padding-right: 56px;
	}
}
 @media screen and (max-width: 1083px) {
	 .reduced-animation-toggle {
		 padding-right: 12px;
	}
}
 .reduced-animation-toggle div.c-toggle > label + button {
	 clear: none;
}
 .reduced-animation-toggle div.c-toggle {
	 display: flex;
	 align-items: center;
}
 .reduced-animation-toggle div.c-toggle button {
	 margin-top: 0;
}
 .reduced-animation-toggle div.c-toggle span {
	 font-weight: 400;
	 font-size: 15px;
	 line-height: 20px;
     pointer-events: none;
}
 .reduced-animation-toggle div.c-toggle .c-label {
	 margin-top: 0;
	 padding-bottom: 0;
	 font-weight: 600;
	 font-size: 13px;
	 line-height: 16px;
	 text-align: center;
}
 .reduced-animation-toggle div.c-toggle .toggle-seperator {
	 width: 15px;
	 height: 0;
	 border: 1px solid #d5d5d5;
	 -ms-transform: rotate(90deg);
	 -webkit-transform: rotate(90deg);
	 transform: rotate(90deg);
	 margin-right: 15px;
	 margin-left: 15px;
}
/*------START Linknav------*/
.rtl .surface-home .Surface-F22-LinkNav-Panel .m-link-navigation
{
    padding-right: 0px;
}
.surface-home .Surface-F22-LinkNav-Panel {
    padding-bottom: 40px;
    padding-top: 88px;
}

.surface-home .Surface-F22-LinkNav-Panel .m-link-navigation{
    padding-left: 0;
}

.surface-home .Surface-F22-LinkNav-Panel .m-link-navigation nav.c-link-navigation{
    padding-top: 5px;
}


    .surface-home .Surface-F22-LinkNav-Panel .m-link-navigation .c-link-navigation ul,
    .surface-home .Surface-F22-LinkNav-Panel .c-link-navigation ul li,
    .surface-home .Surface-F22-LinkNav-Panel .c-link-navigation ul li a.c-hyperlink.f-image {
        display: flex;
        align-items: center;
        flex-wrap: wrap;
        justify-content: flex-start;
        flex-direction: row;
    }
    
    .surface-home .Surface-F22-LinkNav-Panel .linknavmoretext ul li {
        flex-wrap: nowrap;
    }
   
    .surface-home .Surface-F22-LinkNav-Panel .c-link-navigation ul li picture {
        margin-bottom: 0;
    }
    

    .surface-home .Surface-F22-LinkNav-Panel li a.c-call-to-action {
        display: inline-block;
        align-items: flex-end;
        justify-content: center;
        text-align: left;
        padding-right: 10px;  /*ak changed*/
        margin-left: 10px;
         width: 60%;
    }

 .surface-home .Surface-F22-LinkNav-Panel .linknavmoretext li a.c-call-to-action {
        width: 68%;
    }
    
       .surface-home .Surface-F22-LinkNav-Panel li a.c-call-to-action:hover span {
            box-shadow: inherit;
        }
/*,
        .surface-home .Surface-F22-LinkNav-Panel li a.c-call-to-action:not(.glyph-play):after */
        .surface-home .Surface-F22-LinkNav-Panel li a span{
            display: inline;
        }

        /*.surface-home .Surface-F22-LinkNav-Panel li a.c-call-to-action:not(.glyph-play):after {
            vertical-align: middle;
        }*/

body:not(.rtl) .surface-home .Surface-F22-LinkNav-Panel li a.c-call-to-action:not(.glyph-play) > span:hover:after,
body:not(.rtl) .surface-home .Surface-F22-LinkNav-Panel li a.c-call-to-action:not(.glyph-play):hover:after {
    right: -4px !important;
    position: relative;
}

@media only screen and (min-width: 1400px) {
    .surface-home .Surface-F22-LinkNav-Panel .c-link-navigation ul li,
    .surface-home .Surface-F22-LinkNav-Panel .linknavmoretext ul li {
        width: 16.5%;
    }
}

@media only screen and (min-width: 1084px) and (max-width: 1400px) {
    .surface-home .Surface-F22-LinkNav-Panel .c-link-navigation ul li,
    .surface-home .Surface-F22-LinkNav-Panel .linknavmoretext ul li {
        width: 20%;
    }
}

@media only screen and (min-width: 768px) and (max-width: 1083px) {
    .surface-home [data-grid="container"].Surface-F22-LinkNav-Panel{
        padding-left:15%;
        padding-right:15%;
    }
    
    .surface-home .Surface-F22-LinkNav-Panel{
        padding-bottom:20px;
    }
    .surface-home .Surface-F22-LinkNav-Panel .m-link-navigation nav.c-link-navigation{
        margin-top: 26px;
    }
    .surface-home .Surface-F22-LinkNav-Panel .c-link-navigation ul li {
        width: 33.333%;
        padding: 10px 5px 10px 5px;
        clear: none;
    }
    
.surface-home .Surface-F22-LinkNav-Panel .linknavmoretext li a.c-call-to-action{
       font-size: 11px;
   }
}

@media only screen and (max-width: 767px) {
    .surface-home [data-grid="container"].Surface-F22-LinkNav-Panel{
        padding-left: 56px;
    }
    
    .surface-home .Surface-F22-LinkNav-Panel{
        padding-top: 63px;
        padding-bottom: 72px;
    }
    
    .surface-home .Surface-F22-LinkNav-Panel .m-link-navigation nav.c-link-navigation{
    padding-top: 0px;
    }

    .surface-home .Surface-F22-LinkNav-Panel .c-link-navigation ul li {
        width: 50%;
        clear: none;
        padding: 10px 5px 10px 5px;
    }
    
    .surface-home .Surface-F22-LinkNav-Panel li a.c-call-to-action{
        font-size: 18px;
    }   
    .surface-home .Surface-F22-LinkNav-Panel .linknavmoretext.linknavchevron li a.c-call-to-action,
    .surface-home .Surface-F22-LinkNav-Panel .linknavchevron li a.c-call-to-action{
        font-size: 13px;
    }
}

@media only screen and (max-width: 539px) {
    .surface-home [data-grid="container"].Surface-F22-LinkNav-Panel{
        padding-left: 20px;
        padding-right:20px;
    }

}

@media only screen and (max-width: 400px) {
    .surface-home .Surface-F22-LinkNav-Panel .c-link-navigation ul li {
        width: 100%;
    }
}

/*------END Linknav------*/
/* ------ Family Devices - START (surface-family-devices) ------ */

.surface-home .surface-family-devices .surface-family-devices-section.devices-left-align {
    display: flex;
    flex-direction: row;
    justify-content: space-between;
}

.surface-home .surface-family-devices .surface-family-devices-section.devices-right-align {
    display: flex;
    flex-direction: row-reverse;
    justify-content: space-between;
}


.surface-home .surface-family-devices-section .m-ambient-video.surface-family-devices-video {
    flex-basis: calc(50% - 35px);
    padding: 0px;
    box-shadow: 0 0 12px 2px rgb(0 0 0 / 16%);  /* Added for video box shadow */
    background-color: #fff; /* Added for video box shadow */
    border-radius: 10px; /* Added for video box shadow from below to here */
}

    .surface-home .surface-family-devices-section .m-ambient-video.surface-family-devices-video video {      
        -o-object-fit: fill;
        object-fit: fill;
    }

.surface-home .surface-family-devices-section .desktop-family-devivces-tiles {
    flex-basis: calc(50% - 23px);
    position: relative;
}

    .surface-home .surface-family-devices-section .desktop-family-devivces-tiles ul {
        display: flex;
        flex-direction: row;
        flex-wrap: wrap;
        justify-content: space-between;
    }

        .surface-home .surface-family-devices-section .desktop-family-devivces-tiles ul li {
            flex-basis: calc(50% - 25px);       
            box-shadow: 0 0 12px 2px rgb(0 0 0 / 16%);
            background-color: #fff;
            border-radius: 10px;
            padding: 15px;
            position: relative;
        }
        .surface-home .surface-family-devices-section .desktop-family-devivces-tiles ul li .tile-item{
            display: flex;
            flex-direction: column;
            align-items: center;
            width: 100%;
        }
        
        .surface-home .surface-family-devices-section .desktop-family-devivces-tiles ul li .tile-item .tile-cta,
        .surface-home .surface-family-devices-section .desktop-family-devivces-tiles ul li .tile-item .tile-cta a.c-call-to-action{
               
                display: block;
                width: inherit;
                text-align: left;
        }

            .surface-home .surface-family-devices-section .desktop-family-devivces-tiles ul li .tile-image img {
                height: auto;
                width: 100%;
            }

            .surface-home .surface-family-devices-section .desktop-family-devivces-tiles ul li:nth-child(-n + 2) {
                margin-bottom: 44px;
            }

.surface-home .surface-family-devices-section .videobutton {
    width: 55px !important;
    height: 55px !important;
    bottom: auto !important; 
    left: 4% !important;
    top: 4% !important; 
}
@media only screen and (min-width: 350px) and (max-width: 540px) {
.surface-home .surface-family-devices-section .videobutton {
    width: 40px !important;
    height: 40px !important;
}
}
@media only screen and (min-width: 1084px) and (max-width: 1200px) {
.surface-home .surface-family-devices-section .videobutton {
    left: 3% !important;
    top: 3% !important; 
}
}

/*ROW device family CTA headings*/
:not(.en-us) .surface-home .surface-family-devices h3.c-heading-6{
    font-size: 30px;
    color: #000000;
    font-weight: 600;
    /*margin-top: 60px;*/
    margin-bottom: 24px;
    opacity: 0;
    display: inline-block;
    padding-right: 10px;
}
/*en-us device family CTA headings START*/
.en-us .surface-home .surface-family-devices h3.c-heading-6{
   margin-top: 0px; 
   color: #000000;
   display: inline-block;
   padding-right: 10px;
}
.en-us .surface-home .surface-family-devices a.surface-seeall{
    font-size: 24px;
    opacity: 0;
    color: #0067bc;
    /*line-height: 24px;*/
    padding: 0 24px;
    border: 0px;
    display: inline-flex;
}
/*.surface-home .surface-hero-heading{
    padding-right: 10px;
}*/

/*en-us device family CTA headings END*/

/*Banners Font weights START*/
.surface-home .innovation-banner h2.c-heading,
.surface-home .Surface-F22-LinkNav-Panel h2.c-heading{
    font-weight: 600;
    font-size: 48px;
    line-height: 58px;
}
/*updated as per feedback*/
/*.surface-home .surface-imi-banner{
margin-top:30px;
}*/

.surface-home .innovation-banner{
    text-align: left;
    padding-left: 0;
    margin-bottom: 80px; /*updated as per feedback*/
    /*margin-top:30px;*/
    float: left;
}

@media screen and (min-width: 768px) and (max-width: 1083px) {
    
    .surface-home .surface-imi-banner{
        margin-top: 70px;
    }
   .surface-home .innovation-banner {
    padding-left: 10%;
}
}

@media screen and (max-width: 767px) {
   .surface-home .innovation-banner {
    padding-left: 48px;
}
}
/*Banners Font weights END*/

.surface-home .surface-family-devices .surface-family-devices-section .surface-family-devices-video,
.surface-home .surface-family-devices .surface-family-devices-section .desktop-family-devivces-tiles{
    opacity: 0;
}
.surface-home .surface-family-devices h3.c-heading-6.is-scrollDown,
.surface-home .surface-family-devices h3.c-heading-6.is-scrollTop,
.en-us .surface-home .surface-family-devices h3.c-heading-6.is-scrollDown a,
.en-us .surface-home .surface-family-devices h3.c-heading-6.is-scrollTop a,
.en-us .surface-home .surface-family-devices a.surface-seeall.is-scrollTop,
.en-us .surface-home .surface-family-devices a.surface-seeall.is-scrollDown,
.surface-home .surface-family-devices .surface-family-devices-section.devices-left-align .surface-family-devices-video.is-scrollDown,
.surface-home .surface-family-devices .surface-family-devices-section.devices-left-align .surface-family-devices-video.is-scrollTop,
.surface-home .surface-family-devices .surface-family-devices-section.devices-right-align .desktop-family-devivces-tiles.is-scrollDown,
.surface-home .surface-family-devices .surface-family-devices-section.devices-right-align .desktop-family-devivces-tiles.is-scrollTop,
.surface-home .surface-family-devices-small ul.device-family-flex.is-scrollDown,
.surface-home .surface-family-devices-small ul.device-family-flex.is-scrollTop{
    animation: contentfadein 2s ease-in-out forwards;
}
.surface-home .surface-family-devices .surface-family-devices-section.devices-left-align .desktop-family-devivces-tiles.is-scrollDown,
.surface-home .surface-family-devices .surface-family-devices-section.devices-left-align .desktop-family-devivces-tiles.is-scrollTop,
.surface-home .surface-family-devices .surface-family-devices-section.devices-right-align .surface-family-devices-video.is-scrollDown,
.surface-home .surface-family-devices .surface-family-devices-section.devices-right-align .surface-family-devices-video.is-scrollTop{
    animation: contentfadein 2s ease-in-out 1s forwards;
}
.surface-home .surface-family-devices a.mscom-link{
    font-size: 24px;
    font-weight: 600;  
}

.surface-home .surface-family-devices .surface-family-devices-video img{
        border-radius: 10px;
    -o-object-fit: fill;
    object-fit: fill;
    width: 100%;
    height: 100%;
    display: block;
}

@media screen and (min-width: 768px) and (max-width: 1083px){
.surface-home .surface-family-devices.surface-right-video-with-images,
.surface-home .surface-family-devices.surface-left-image-with-images{
    padding-top:25px;
}  
    
.surface-home .surface-family-devices h3.c-heading-6{
    padding-left: 15%;
}

.surface-home .surface-family-devices .surface-family-devices-section.devices-left-align,
.surface-home .surface-family-devices .surface-family-devices-section.devices-right-align{
    display: block;
    padding:0 15%;
}
.surface-home h3.offer-carousel-heading{
padding-left:15%;
padding-right: 15%;
}

/*.surface-home .surface-family-devices .surface-family-devices-section .surface-family-devices-video,*/
.surface-home .surface-family-devices .surface-family-devices-section .desktop-family-devivces-tiles{
    padding-top: 60px;
}
}
/* ------ Family Devices - END (surface-family-devices) ------ */
/* ------ Family Devices - START (Dual Tiles) ------ */
.surface-home .surface-family-devices-small ul {
    display: flex;
    flex-direction: row;
    justify-content: space-between;
}
.surface-home .surface-family-devices-small ul.device-family-flex{
    opacity: 0;
}


    .surface-home .surface-family-devices-small ul li {
        flex-basis: calc(50% - 28px);
    }

        .surface-home .surface-family-devices-small ul li .tile-item {
            flex-basis: calc(50% - 28px);
            display: flex;
            flex-direction: row;
            align-items: center;
            box-shadow: 0 0 12px 2px rgb(0 0 0 / 16%);
            background-color: #fff;
            border-radius: 10px;
            justify-content: flex-start;
            padding: 15px;
        }

        .surface-home .surface-family-devices-small ul li .tile-image img {
            height: auto;
            width: 100%;
        }

.surface-home .surface-family-devices-small h3.c-heading-6{
    font-size: 30px;
    color: #000000;
    font-weight: 600;
    margin-top: 60px;
    margin-bottom: 20px;
}
.surface-home h3.offer-carousel-heading{
    font-size: 30px;
    color: #000000;
    font-weight: 600;
    margin-bottom: 20px;
}
.surface-home .surface-family-devices-small a.mscom-link{
    font-size: 24px;
    font-weight: 600;
}

@media screen and (min-width: 768px) and (max-width: 1083px){
.surface-home .surface-family-devices-small ul{
    display: block;
    padding: 0 15%;
}
}
/* ------ Family Devices - END (Dual Tiles) ------ */
/* ------ Family Devices - START (Popup) ------ */
.surface-home .surface-family-devices button.glyph-circleplus {
    border: none;
    background: transparent;
    position: absolute;
    top: 20px;
    right: 20px;
    font-size: 40px;
    font-weight: 500;
}
 
    .surface-home .surface-family-devices button.glyph-circleplus:focus {
        border: 2px dashed #fff;
    }


.surface-home .surface-family-devices .family-device-model-popup {
    position: absolute;
    z-index: 999;
    background: #000;
    border-radius: 10px;
    width: 98%;
    height: 98%;
}

    .surface-home .surface-family-devices .family-device-model-popup.popupShow {
       display: block;
    }

    .surface-home .surface-family-devices .family-device-model-popup.popupHide {
        display: none;
    }

    .surface-home .surface-family-devices .family-device-model-popup .device-poup {
        display: grid;
        place-content: center;
        position: relative;
        width:100%;
        height:100%;
        padding: 0 40px;
    }

        .surface-home .surface-family-devices .family-device-model-popup .device-poup img {           
            height: auto;
            width: 100%;
        }

        .surface-home .surface-family-devices .family-device-model-popup .device-poup p.c-paragraph-2 {
            color: #fff !important;
            font-size: 24px; 
            font-weight: 600; 
            line-height: 30px;
        }

        .surface-home .surface-family-devices .family-device-model-popup .device-poup .c-glyph.glyph-cancel {
            background: transparent;
            position: absolute;
            margin-top: 36px;
            margin-bottom: 36px;
            right: 36px;
            border-radius: 100%;
            border: 2px solid #ffffff;
            height: 40px;
            width: 40px;
            top: 0px; 
        }

            .surface-home .surface-family-devices .family-device-model-popup .device-poup .c-glyph.glyph-cancel:focus {
                border: 2px dashed #fff;
            }

            .surface-home .surface-family-devices .family-device-model-popup .device-poup .c-glyph.glyph-cancel:before {
                font-size: 24px;
                color: #fff;
                font-weight: 600;
            }

/* ------ Family Devices - END (Popup) ------ */

/* ------ Family Devices - START (Mobile Design) ------ */
.surface-home .surface-family-devices .mobile-family-devices {
  display: none;  
}

@media only screen and (max-width: 767px) {
    .en-us .surface-home .mobile-family-devices h3.c-heading-6 a span{
    font-size: 24px;
}

   .surface-home .surface-family-devices .mobile-family-devices {
    display: block;  
    margin-bottom: 100px;
    position: relative;
    }
    .surface-home .surface-family-devices .mobile-family-devices .c-carousel .c-flipper {
        position: absolute;
        top: 58%;
        -ms-transform: translateY(-42%);
        transform: translateY(-42%);
        z-index: 100;
        display: block;
        width: 55px;
        height: 55px;
        border-radius: 50%;
        opacity: 1;
    }
    
    .surface-home .surface-family-devices .mobile-family-devices .c-carousel .c-flipper:focus,
    .surface-home .surface-family-devices .mobile-family-devices .c-carousel .c-flipper:hover{
        border: 1px dashed #000000;
    }
    
    .surface-home .surface-family-devices .mobile-family-devices .c-carousel .c-flipper.f-previous {
        left: 20px;
    }
   .surface-home .surface-family-devices .mobile-family-devices .c-carousel .c-flipper.f-next {
        right: 20px;
    }
     .surface-home .surface-family-devices .mobile-family-devices .c-sequence-indicator button{
         pointer-events: none;
     }
    
     .surface-home .surface-family-devices .mobile-family-devices .family-device-model-popup {
         width: 90%;
        top: 20%;
        left: 5%;
     }
    .surface-home .surface-family-devices .desktop-family-devivces-tiles,
    .en-us .surface-home .surface-family-devices h3.c-heading-6,
    :not(.en-us) .surface-home .surface-family-devices h3.c-heading-6,
    .en-us .surface-home .surface-family-devices > a.surface-seeall {
    display: none;  
    }
    
    .surface-home .surface-family-devices .surface-family-devices-section.devices-left-align,
    .surface-home .surface-family-devices .surface-family-devices-section.devices-right-align
    {
        flex-direction: column;
        padding-left:  18px;
        padding-right: 18px;
    }
    
    .surface-home .surface-family-devices .mobile-family-devices h3.c-heading-6 {
        width: 85%;
        margin: auto;
        display: block;
            }
      
      .surface-home .surface-family-devices .mobile-family-devices h3.c-heading-6,
      .surface-home .surface-family-devices-small h3.c-heading-6{      
        font-size: 34px;
        line-height: 44px;
      }
      .surface-home h3.offer-carousel-heading{
           font-size: 34px;
        line-height: 44px;
        width: 88%;
        margin-left: 10%;
        margin-right: 10%;
        padding-top: 0px;
      }
      .surface-home .surface-family-devices-small ul li {
        width:88%;
        margin:auto;
    }
      
      .surface-home .surface-family-devices .mobile-family-devices h3.c-heading-6 .surface-hero-heading{
          margin-right: 34px;
      }
      .rtl .surface-home .surface-family-devices .mobile-family-devices h3.c-heading-6 .surface-hero-heading
      {
          margin-left: 34px; 
           margin-right: 0px; 
      }
      .en-us .surface-home .surface-family-devices a.surface-seeall{
          padding: 0px;
      }
    
    .surface-home .surface-family-devices .mobile-family-devices .c-carousel.f-multi-slide ul{
        display: flex;
    flex-direction: row;
    width: 85%;
    perspective: 1000px;
    margin: auto;
    display: flex;
    align-items: stretch;
    }
   .surface-home .surface-family-devices .mobile-family-devices .c-carousel.f-multi-slide li {
       box-shadow: 0 0 12px 2px rgb(0 0 0 / 16%);
   background-color: #fff;
                border-radius: 10px;
                padding: 15px;
                position: relative;
                margin-bottom: 10px;
                margin-top: 10px;
                float: left;
                display: flex;
                width: 100%;
                margin-right: -100%;
                backface-visibility: hidden;
                background: 0 0;
                 visibility: hidden; 
                 opacity: 0; 
                 z-index: 0; 
                background-color: #fff;
                justify-content: center;
        }
         .surface-home .surface-family-devices .mobile-family-devices .c-carousel.f-multi-slide li.f-active {
                        visibility: visible;
                        opacity: 1;
                    }
                .surface-home .surface-family-devices .mobile-family-devices .c-carousel.f-multi-slide li.item-next {
                        visibility: visible;
                        opacity: 1;
                        z-index: 1;
                        transform: translateX(105%);
                    }

                    .surface-home .surface-family-devices .mobile-family-devices .c-carousel.f-multi-slide li.item-previous {
                        visibility: visible;
                        opacity: 1;
                        z-index: 1;
                        transform: translateX(-105%);
                    }
.surface-home .surface-family-devices .surface-family-devices-section .mobile-family-devices .c-carousel ul li a
{
    text-align: left;
}

.surface-home .surface-family-devices-small ul li .tile-item .text,
.surface-home .surface-family-devices-small ul li .tile-item .text-2{
    align-self: baseline;
}

 .surface-home .surface-family-devices .mobile-family-devices .c-carousel.f-multi-slide li img {
    width: 100%;
    height: auto;
}
.surface-home .surface-family-devices .mobile-family-devices .c-carousel.f-multi-slide .c-sequence-indicator {
    bottom: -24px;
}


.surface-home .surface-family-devices-small ul{
    flex-direction: column;
    justify-content: space-between;
    margin: 5%;
}

.surface-home .surface-family-devices-small ul li:first-child{
    margin-bottom: 6%;
}
.surface-home .surface-family-devices-small ul li .tile-item{
        flex-direction: column;
}

.surface-home .surface-family-devices-small h3.c-heading-6{
    margin-top: 0px;
    padding-top: 0px;
}

}
/*NEW badge issue for CTA*/
@media only screen and (max-width: 767px) {
    .surface-home .mobile-family-devices ul li a.c-call-to-action {
    display: block;
}
}
/* ------ Family Devices - END (Mobile Design) ------ */

/* ------ Animated Hero - Start ------ */
@keyframes moveInCopy {
    from {
        opacity: 0;
    }

    to {
        opacity: 1;
    }
}

@keyframes slide-in-herocontent {
		from {
			opacity: 0;
		
		}

		to {
			opacity: 1;
			
		}
	}
    
  
.surface-home .animated-hero{
    position: relative;
    clear: both;
}
/*Hero animated video related post publish video replacement START*/
@media screen and (min-width: 1084px) {
.surface-home .animated-hero .m-ambient-video .animated-hero-media.desktop-video {
    display: block;
}
.surface-home .animated-hero .m-ambient-video .animated-hero-media.tablet-video {
        display: none;
    }
.surface-home .animated-hero .m-ambient-video .animated-hero-media.mobile-video {
        display: none;
    }

}
@media screen and (min-width: 768px) and (max-width: 1083px) {
 .surface-home .animated-hero .m-ambient-video .animated-hero-media.tablet-video {
    display: block;
}
.surface-home .animated-hero .m-ambient-video .animated-hero-media.desktop-video {
    display: none;
}

.surface-home .animated-hero .m-ambient-video .animated-hero-media.mobile-video {
    display: none;
}
}

@media screen and (max-width: 767px) {
.surface-home .animated-hero .m-ambient-video .animated-hero-media.mobile-video {
        display: block;
    }
  .surface-home .animated-hero .m-ambient-video .animated-hero-media.desktop-video {
    display: none;
}  
.surface-home .animated-hero .m-ambient-video .animated-hero-media.tablet-video {
        display: none;
    }
}
/*Hero animated video related post publish video replacement END*/
.surface-home .animated-hero picture img
{
    width: 100%;
    height: auto;
}
.surface-home .animated-hero .animated-hero-main-content {
    position: absolute;
    right: 5%;
    top: 48%;
    max-width: 35%;
    transform: translateY(-52%);
}

.surface-home .animated-hero .animated-hero-content h1.c-heading-2{
    font-size: 90px;
    font-weight: 600;
    line-height: 100px;  
}

.surface-home .animated-hero .animated-hero-content .c-group{
display: inline-block;
}

.surface-home .animated-hero .animated-hero-content .c-group a{
margin-right:20px;
}

.surface-home .animated-hero .animated-hero-content .c-group a.c-call-to-action.c-glyph.glyph-play:before,
.surface-obd .lifestyle-video-content .c-group a.c-call-to-action.c-glyph.glyph-play:before{
    top:-2px;
}
 .animation-on .surface-home .animated-hero.Surface_2022_Home_Hero_Animated_Video .animated-hero-content.slide-in-hero{
    display: none;
}
.surface-home .animated-hero .animated-hero-content.slide-in-hero .c-badge,
.surface-home .animated-hero .animated-hero-content.slide-in-hero h1.c-heading-2,
.surface-home .animated-hero .animated-hero-content.slide-in-hero div.c-paragraph-2 p,
.surface-home .animated-hero .animated-hero-content.slide-in-hero .c-group a{
    /*opacity: 0;*/
    animation-fill-mode: forwards;
    
}

.surface-home .animated-hero .animated-hero-content.slide-in-hero .c-badge,
.surface-home .animated-hero .animated-hero-content.slide-in-hero.is-scrollTop .c-badge {
    animation-name: slide-in-herocontent;
    animation-delay: .4s;
    animation-duration: 1s;
    animation-fill-mode: forwards;
}

.surface-home .animated-hero .animated-hero-content.slide-in-hero.is-scrollDown h1.c-heading-2,
.surface-home .animated-hero .animated-hero-content.slide-in-hero.is-scrollTop h1.c-heading-2{
    animation-name: slide-in-herocontent;
    animation-delay: .6s;
    animation-duration: 1s;
    animation-fill-mode: forwards;
}

.surface-home .animated-hero .animated-hero-content.slide-in-hero.is-scrollDown div.c-paragraph-2 p,
.surface-home .animated-hero .animated-hero-content.slide-in-hero.is-scrollTop div.c-paragraph-2 p {
    animation-name: slide-in-herocontent;
    animation-delay: .8s;
    animation-duration: 1s;
    animation-fill-mode: forwards;
}

.surface-home .animated-hero .animated-hero-content.slide-in-hero.is-scrollDown .c-group a,
.surface-home .animated-hero .animated-hero-content.slide-in-hero.is-scrollTop .c-group a {
    animation-name: slide-in-herocontent;
    animation-delay: 1s;
    animation-duration: 1s;
    animation-fill-mode: forwards;
}

.surface-home .animated-hero .animated-hero-content div.c-paragraph-2 p{
    font-size: 26px;
    font-weight: 600;
     line-height: 36px;
      padding-top: 10px;
      padding-bottom: 16px;
}

.surface-home .animated-hero .animated-hero-content .c-group a,
.surface-home .animated-hero .animated-hero-content .c-group a span,
.surface-home .animated-hero .animated-hero-content .c-group a:focus:not(.x-hidden-focus) span{
    font-size: 20px;
    font-weight: 600;
    color: #0067bc;
}

.surface-home .animated-hero picture.animated-hero-media.mobile {
    display: none;
}

.surface-home .animated-hero .animated-hero-main-content animated-hero-content.slide-in-m-banner {
    animation-name: moveInCopy;
    animation-duration: 2s;
    animation-fill-mode: both;
}

@media screen and (min-width: 1400px){
.Chrome .surface-home .animated-hero .animated-hero-main-content .animated-hero-content .c-group a.c-call-to-action:not(.glyph-play) > span:after{
    padding-bottom: 8px;
}
}
/*fall22 font change to 1500 */
@media screen and (min-width: 1084px) and (max-width: 1400px){
.surface-home .animated-hero .animated-hero-content h1.c-heading-2 {
    font-size: 52px;
    line-height: 62px;
    padding: 5px 0 0 0;
    font-weight: 600;
    }
.surface-home .animated-hero .animated-hero-content div.c-paragraph-2 p {
        font-size: 20px;
        line-height: 30px;
        padding: 10px 0 0 0;
    }
    
.surface-home .animated-hero .animated-hero-content .c-group a,    
.surface-home .animated-hero .animated-hero-content .c-group a span,
.surface-home .animated-hero .animated-hero-content .c-group a:focus:not(.x-hidden-focus) span{
    font-size: 16px;
}
}

@media screen and (min-width: 768px) and (max-width: 1083px) {
.surface-home .animated-hero .animated-hero-main-content{
    left: 50%;
    top: 1px;
    right:0;
    max-width: 90%;
    width:60%;
    transform: translateX(-50%);
    text-align: center;
    }
    
.surface-home .animated-hero .animated-hero-main-content h1.c-heading-2 {
        font-size: 50px;
        line-height: 60px;
        padding-top: 25%;
    }
    
.surface-home .animated-hero .animated-hero-main-content div.c-paragraph-2 p{
        font-size: 20px;
        line-height: 30px;
        padding-top: 20px;
    }
    
.surface-home .animated-hero .animated-hero-content .c-group{
        justify-content: center;
        margin-top: 5px;
    }
 
.surface-home .animated-hero .animated-hero-content .c-group a,    
.surface-home .animated-hero .animated-hero-content .c-group a span,
.surface-home .animated-hero .animated-hero-content .c-group a:focus:not(.x-hidden-focus) span{
    font-size: 16px;
    padding-top: 15px;
}
}

@media screen and (max-width: 767px) {
.surface-home .animated-hero .animated-hero-main-content{
    left: 50%;
    top: 30px;
    right:0;
    max-width: 100%;
    width: 75%;
    transform: translateX(-50%);
    text-align: left;
    }
    
.surface-home .animated-hero .animated-hero-main-content h1.c-heading-2 {
        font-size: 50px;
        line-height: 60px;
        padding: 15px 0 0 0;
    }
    
.surface-home .animated-hero .animated-hero-main-content  div.c-paragraph-2 p {
        font-size: 18px;
        line-height: 28px;
        padding: 6px 0 0 0;
    }
    
.surface-home .animated-hero .animated-hero-content .c-group a,    
.surface-home .animated-hero .animated-hero-content .c-group a span,
.surface-home .animated-hero .animated-hero-content .c-group a:focus:not(.x-hidden-focus) span{
    font-size: 15px;
    text-align: left;
}
.surface-home .animated-hero picture.animated-hero-media.desktop {
        display: none;
    }
    
.surface-home .animated-hero picture.animated-hero-media.mobile {
        display: block;
    }
}

@media only screen and (max-width: 767px) {

.surface-home .animated-hero .animated-hero-main-content .hero-content .c-paragraph-2 {
    font-weight: 400;
}
}

@media only screen and (max-width: 500px) {
.surface-home .animated-hero .animated-hero-content .c-group{
    display: block;
}
}

/* ------ Animated Hero - end ------ */

/* ------ lifestyle-video  - start ------ */

@keyframes slide-in-lifeStylecontent {
		from {
			opacity: 0;
			transform: translate3d(0, 50px, 0);
		}

		to {
			opacity: 1;
			transform: translate3d(0, 0, 0);
		}
	}

.surface-home .animated-lifestyle-video {
    position: relative;
}

.surface-home .animated-lifestyle-video .lifestyle-video-content.is-scrollTop,
.surface-home .animated-lifestyle-video .lifestyle-video-content.is-scrollDown{
    animation-name: slide-in-lifeStylecontent;
    animation-delay: .6s;
    animation-duration: 1s;
    animation-fill-mode: both;
}
   .surface-home .animated-lifestyle-video .lifestyle-video {
        position: -webkit-sticky;
        position: sticky;
        top: -48px;
    }
        .surface-home .animated-lifestyle-video .lifestyle-video .lifestylevideoautoplay {
            -o-object-fit: initial;
            object-fit: initial;
        }

        .surface-home .wdg-lifestyle-video .lifestyle-video .videobutton.c-call-to-action.c-glyph,
        .surface-home .animated-lifestyle-video .lifestyle-video .videobutton.c-call-to-action.c-glyph:focus {
            border: 1px solid #FFFFFF;
        }

            .surface-home .animated-lifestyle-video .lifestyle-video .videobutton.c-call-to-action.c-glyph.bottom-right,
            .surface-home .animated-lifestyle-video .lifestyle-video .videobutton.c-call-to-action.c-glyph.bottom-right:focus {
                right: 25px;
                bottom: 25px;
                left: auto;
                top: auto;
            }

            .surface-home .animated-lifestyle-video .lifestyle-video .videobutton.c-call-to-action.c-glyph,
            .surface-home .animated-lifestyle-video .lifestyle-video .videobutton.c-call-to-action.c-glyph:focus {
                width: 55px;   /*40px to 55px changed to match device family video button*/
                height: 55px;  /*40px to 55px changed to match device family video button*/
                background: transparent;
                border-radius: 100%;
                position: absolute;
                margin: 0;
                padding: 0;
            }

                .surface-home .animated-lifestyle-video .lifestyle-video .videobutton.c-call-to-action.c-glyph:before {
                    color: #FFFFFF !important;
                }

                .surface-home .animated-lifestyle-video .lifestyle-video .videobutton.c-call-to-action.c-glyph:before {
                    margin-left: 4px;
                    margin-top: 0px;
                }

        .surface-home .animated-lifestyle-video .lifestyle-video .videobutton.glyph-pause:after,
        .surface-home .animated-lifestyle-video .lifestyle-video .videobutton.glyph-play:after {
            content: "" !important;
        }

    .surface-home .animated-lifestyle-video .lifestyle-video-content {
        -webkit-box-sizing: initial;
        box-sizing: initial;
        width: 40%;
        position: absolute;
        top: 10%;
        right: 8%;
    }
    .surface-home .animated-lifestyle-video .lifestyle-video-content.align-text-left {
        left: 8%;
        right: unset;
        width: 30%;
    }
    
    .surface-home .animated-lifestyle-video .lifestyle-video-content.align-text-left .c-paragraph-2,
    .surface-home .animated-lifestyle-video .lifestyle-video-content.align-text-right .c-paragraph-2{
        font-size: 20px;
        font-weight: 600;
        line-height: 30px;
    }
    
    .surface-home .animated-lifestyle-video img{
        width: 100%;
        height: auto;
    }
      .surface-home .animated-lifestyle-video .lifestyle-video-content h2.c-heading-2{
          font-size: 74px;
          color:#000000;
          font-weight: 600;
          line-height: 84px;
      }
      .surface-home .surface-obd.animated-lifestyle-video .lifestyle-video-content p.c-heading-2{
          font-size: 74px;
          color:#000000;
          font-weight: 600;
          line-height: 84px;
      }
      .surface-home .surface-obd.animated-lifestyle-video .lifestyle-video-content p.c-heading-2{
    padding-bottom:20px;
    }
       .surface-home .animated-lifestyle-video .lifestyle-video-content .c-group a{
          font-size: 18px;
          color:#0067BC;
          font-weight: 600;
          margin-right: 20px;
      }

@media screen and (min-width: 1084px) and  (max-width: 1400px){
.surface-home .surface-obd.animated-lifestyle-video .lifestyle-video-content.align-text-left {
    width: 40%;
}

.surface-home .surface-obd-masker{
    background: linear-gradient(90deg,#f7ede3, transparent);
    position: absolute;
    top: 0;
    height: 100%;
    width: 60%;
}
}
@media screen and (min-width: 767px) {
    .surface-home .m-ambient-video.lifestyle-video2 {
        display: none;
    }
}


@media screen and (min-width: 768px) and  (max-width: 1083px){
.surface-home .animated-lifestyle-video .lifestyle-video-content{
    top:7.5%;
}    
.surface-home .animated-lifestyle-video .lifestyle-video-content.align-text-left{
left:10%;
width: 80%;
}
}

@media screen and (max-width: 767px){
.surface-home .animated-lifestyle-video .lifestyle-video-content h2.c-heading-2{
    font-size: 52px;
    line-height: 62px;
}    
.surface-home .surface-obd.animated-lifestyle-video .lifestyle-video-content p.c-heading-2{
    font-size: 52px;
    line-height: 62px;
}    

.surface-home .surface-obd.animated-lifestyle-video .lifestyle-video-content p.c-heading-2{
    padding-top: 0px;
}
.surface-home .animated-lifestyle-video .lifestyle-video-content.align-text-left,
.animated-lifestyle-video .lifestyle-video-content.align-text-right{
left:48px;
width: 80%;
}

.surface-home .animated-lifestyle-video .lifestyle-video-content.align-text-left .c-paragraph-2, 
.surface-home .animated-lifestyle-video .lifestyle-video-content.align-text-right .c-paragraph-2,
.surface-home .animated-lifestyle-video .lifestyle-video-content .c-group a{
    font-size: 13px;
    line-height: 23px;
}

.surface-home .animated-lifestyle-video .lifestyle-video-content .c-group a{
padding-top:0px;
}

.surface-home .surface-obd.animated-lifestyle-video .lifestyle-video-content .c-group a.c-call-to-action.c-glyph.glyph-play:before{
    vertical-align: text-bottom;
    top:-3px;
}

.surface-home .animated-lifestyle-video .lifestyle-video-content{
    top: 3%;
}
.surface-home .animated-lifestyle-video.surface-sustainability .lifestyle-video-content h2.c-heading-2{
    font-size: 52px;
    line-height: 62px;
}
}

.surface-home .animated-lifestyle-video .lifestyle-video-content .lifestyle-video-main-content {
    background-color: rgba(255, 255, 255, 0.9);
    color: #000;
    padding: 30px;
    border-radius: 10px;
}

    .surface-home .animated-lifestyle-video .lifestyle-video-content .lifestyle-video-main-content .c-heading-2 {
        padding: 0 0 30px 0;
    }

    .surface-home .animated-lifestyle-video .lifestyle-video-content .lifestyle-video-main-content .c-paragraph {
        padding: 0 0 30px 0;
    }

    .surface-home .animated-lifestyle-video .lifestyle-video-content .lifestyle-video-main-content .c-button {
        width: 60%;
        background-color: transparent;
        border: 2px solid #000;
        color: #000;
    }

        .surface-home .animated-lifestyle-video .lifestyle-video-content .lifestyle-video-main-content .c-button:active {
            background-color: #FFFFFF;
            border-color: transparent;
        }

        .surface-home .animated-lifestyle-video .lifestyle-video-content .lifestyle-video-main-content .c-button:hover {
            background-color: #FFFFFF;
            border-color: transparent;
        }

        .surface-home .animated-lifestyle-video .lifestyle-video-content .lifestyle-video-main-content .c-button:focus {
            background-color: #FFFFFF;
            border-color: transparent;
            text-decoration: none;
        }

        .surface-home .animated-lifestyle-video .lifestyle-video-content .lifestyle-video-main-content .c-button::after {
            font-family: "MWF-MDL2";
            content: "\E768";
            display: inline-block;
            margin: 0 0 0 5px;
            vertical-align: middle;
            padding: 5px;
            border-radius: 50%;
            background-color: #fff;
        }

@media screen and (max-width: 540px) {
    .surface-home .wdg-lifestyle-video .lifestyle-video-content .lifestyle-video-main-content .c-button {
        width: 80%;
    }
}

.surface-home .animated-lifestyle-video .lifestyle-video-content .c-button {
    width: 60%;
    background-color: transparent;
    border: 2px solid #fff;
    color: #fff;
}

    .surface-home .animated-lifestyle-video .lifestyle-video-content .c-button:active {
        background-color: #FFFFFF;
        border-color: transparent;
        color: #000;
    }

    .surface-home .animated-lifestyle-video .lifestyle-video-content .c-button:hover {
        background-color: #FFFFFF;
        border-color: transparent;
        color: #000;
    }

    .surface-home .animated-lifestyle-video .lifestyle-video-content .c-button:focus {
        background-color: #FFFFFF;
        border-color: transparent;
        text-decoration: none;
        color: #000;
    }

    .surface-home .animated-lifestyle-video .lifestyle-video-content .c-button::after {
        font-family: "MWF-MDL2";
        content: "\E768";
        display: inline-block;
        margin: 0 0 0 5px;
        vertical-align: middle;
        padding: 5px;
        border-radius: 50%;
        background-color: #FFFFFF;
        color: #000;
    }

@media screen and (max-width: 540px) {
    .surface-home .animated-lifestyle-video .lifestyle-video-content .c-button {
        width: 80%;
    }
}

.surface-home .animated-lifestyle-video .lifestyle-video-content2 {
    color: #FFFFFF;
    padding: 5%;
    -webkit-box-sizing: initial;
    box-sizing: initial;
    position: absolute;
    right: 0%;
    top: 62%;
    max-width: 30%;
    transform: translateY(-85%);
}

@media screen and (max-width: 540px) {
    .surface-home .animated-lifestyle-video .lifestyle-video-content2 {
        width: 80%;
        left: 6%;
        max-width: 73%;
    }
}


.surface-home .lifestyle-video-content {
    animation: fadeIn ease 10s;
    -webkit-animation: fadeIn ease 10s;
    -moz-animation: fadeIn ease 10s;
    -o-animation: fadeIn ease 10s;
    -ms-animation: fadeIn ease 10s;
}

@keyframes lifestyle-video-content {
    0% {
        opacity: 0;
    }

    100% {
        opacity: 1;
    }
}

@-moz-keyframes lifestyle-video-content {
    0% {
        opacity: 0;
    }

    100% {
        opacity: 1;
    }
}

@-webkit-keyframes lifestyle-video-content {
    0% {
        opacity: 0;
    }

    100% {
        opacity: 1;
    }
}

@-o-keyframes lifestyle-video-content {
    0% {
        opacity: 0;
    }

    100% {
        opacity: 1;
    }
}

@-ms-keyframes lifestyle-video-content {
    0% {
        opacity: 0;
    }

    100% {
        opacity: 1;
    }
}

.surface-home .lifestyle-video-content2 {
    animation: fadeIn ease 10s;
    -webkit-animation: fadeIn ease 10s;
    -moz-animation: fadeIn ease 10s;
    -o-animation: fadeIn ease 10s;
    -ms-animation: fadeIn ease 10s;
}

@keyframes lifestyle-video-content2 {
    0% {
        opacity: 0;
    }

    100% {
        opacity: 1;
    }
}

@-moz-keyframes lifestyle-video-content2 {
    0% {
        opacity: 0;
    }

    100% {
        opacity: 1;
    }
}

@-webkit-keyframes lifestyle-video-content2 {
    0% {
        opacity: 0;
    }

    100% {
        opacity: 1;
    }
}

@-o-keyframes lifestyle-video-content2 {
    0% {
        opacity: 0;
    }

    100% {
        opacity: 1;
    }
}

@-ms-keyframes lifestyle-video-content2 {
    0% {
        opacity: 0;
    }

    100% {
        opacity: 1;
    }
}
/*_ _ _ _Life style video_ _ _ _ _end*/

/*surface-featurewithautoplayvti-ctvo start */

.surface-home .surface-featurewithautoplayvti-content {
    -webkit-animation-name: contentfadein;
    animation-name: contentfadein;
    -webkit-animation-duration: 3s;
    animation-duration: 3s;
    width: 50%;
}

.surface-home .surface-featurewithautoplayvti-image picture {
    position: relative;
    opacity: 0;
}

.surface-home .surface-featurewithautoplayvti-image.is-scrollDown .surface-featurewithautoplayvti-image-2 {
    -webkit-animation-delay: 1s;
    animation-delay: 1s;
}

.surface-home .surface-featurewithautoplayvti-image.is-scrollDown .surface-featurewithautoplayvti-image-3 {
    -webkit-animation-delay: 2s;
    animation-delay: 2s;
}

.surface-home .surface-featurewithautoplayvti-image.is-scrollDown .surface-featurewithautoplayvti-image-4 {
    -webkit-animation-delay: 3s;
    animation-delay: 3s;
}

.surface-home .surface-featurewithautoplayvti-image.is-scrollDown .surface-featurewithautoplayvti-image-5 {
    -webkit-animation-delay: 4s;
    animation-delay: 4s;
}

.surface-home .videobutton.c-call-to-action.c-glyph,
.surface-home .videobutton.c-call-to-action.c-glyph:focus {
    border: 2px solid #0067b8;
    outline-color: transparent;
}

    .surface-home .videobutton.c-call-to-action.c-glyph.bottom-right,
    .surface-home .videobutton.c-call-to-action.c-glyph.bottom-right:focus {
        right: 15px;
        bottom: 20px;
        left: auto;
        top: auto;
    }

    .surface-home .videobutton.c-call-to-action.c-glyph,
    .surface-home .videobutton.c-call-to-action.c-glyph:focus {
        width: 40px;
        height: 40px;
        background: rgba(255,255,255,.9);
        border-radius: 100%;
        position: absolute;
        margin: 0;
        padding: 0;
        z-index: 9999;
    }
    .surface-home .videobutton.c-call-to-action.c-glyph:before {
        color:  #0067b8;
    }

    .surface-home .videobutton.c-call-to-action.c-glyph:before {
        margin-left: 9px;
        margin-top: 5px;
    }
    .surface-home .videobutton.c-call-to-action.c-glyph.glyph-pause:before {
        margin-left: 4px;
    }

.surface-home .videobutton.glyph-pause:after,
.surface-home .videobutton.glyph-play:after {
    content: "" !important;
}

.surface-home .surface-featurewithautoplayvti-ctvo {
    position: relative;
    -webkit-box-pack: justify;
    -ms-flex-pack: justify;
    justify-content: space-between;
}
.surface-home .surface-featurewithautoplayvti-video {
    width: 30%;
}
    .surface-home .surface-featurewithautoplayvti-video video {
        height: 100%;
        -o-object-fit: cover;
        object-fit: cover;
    }

.surface-home .surface-featurewithautoplayvti-image {
    position: relative;
    padding-top: 50px;
    display: -webkit-box;
    display: -ms-flexbox;
    display: flex;
    z-index: 1;
    padding-left: 48px;   
}
    .surface-home .surface-featurewithautoplayvti-image img {
        width: 165px;
    }

    .surface-home .surface-featurewithautoplayvti-image.is-scrollDown picture {
        animation: imageanimation 1s forwards;
    }

@-webkit-keyframes imageanimation {
    0% {
        top: 50px;
        opacity: 0;
    }

    100% {
        top: 0px;
        opacity: 1;
    }
}

@keyframes imageanimation {
    0% {
        top: 50px;
        opacity: 0;
    }

    100% {
        top: 0px;
        opacity: 1;
    }
}

@-webkit-keyframes contentfadein {
    0% {
        opacity: 0;
    }

    100% {
        opacity: 1;
    }
}

@keyframes contentfadein {
    0% {
        opacity: 0;
    }

    100% {
        opacity: 1;
    }
}

@media screen and (min-width: 768px) {
    .surface-home .surface-featurewithautoplayvti-ctvo {
        display: -webkit-box;
        display: -ms-flexbox;
        display: flex;
    }
}
@media screen and (max-width: 539px) {
    .surface-home .surface-featurewithautoplayvti-video {
        width: 100%;
        padding-left: 10px;
    }

    .surface-home .surface-featurewithautoplayvti-image {
        overflow: hidden;
    }

    .surface-home .surface-featurewithautoplayvti-content {
        width: 70%;
        padding-left: 5%;
    }
}
/*surface-featurewithautoplayvti-ctvo end */
/*sustainability and adaptability video START*/
@media screen and (min-width: 1920px) {
.surface-home .animated-lifestyle-video.surface-sustainability .lifestyle-video-content.align-text-left {
    width: 40%;
}

.surface-home .animated-lifestyle-video.surface-sustainability .lifestyle-video-content.align-text-left .c-paragraph-2,
.surface-home .animated-lifestyle-video .lifestyle-video-content.align-text-right .c-paragraph-2{
    padding-top:35px;
}
}

@media screen and (min-width: 1500px) and (max-width: 1900px) {
.surface-home .animated-lifestyle-video.surface-sustainability .lifestyle-video-content.align-text-left {
    width: 50%;
}
}
@media screen and (min-width: 1084px) and (max-width: 1499px) {
.surface-home .animated-lifestyle-video.surface-sustainability .lifestyle-video-content.align-text-left {
    width: 52%;
}
.surface-home .animated-lifestyle-video .lifestyle-video-content.align-text-right {
        right: 6%;
}
.surface-home .animated-lifestyle-video.surface-sustainability .lifestyle-video-content h2.c-heading-2{
    font-size: 74px;
    line-height: 60px;
    padding-top: 0px;
}
}

@media screen and (min-width: 768px) and (max-width: 1083px) {
/*.surface-home .animated-lifestyle-video.surface-sustainability .lifestyle-video-content.align-text-left{
    padding-top: 30px;
}*/

.surface-home .animated-lifestyle-video .lifestyle-video-content.align-text-right {
        left: 8%;
        right: initial;
        width: 80%;
}
}


.surface-home .animated-lifestyle-video.surface-sustainability video{
    vertical-align: initial;
}
/*sustainability video END*/
/*Hero CTA fix START*/
@media screen and (min-width: 1084px) and (max-width: 1275px) {
.surface-home .animated-hero .animated-hero-main-content{
    max-width: 38%;
}
}
/*Hero CTA fix END*/
.surface-home .surface-home-video-bg{
    background-color: #f2f3f2;
}

/*No duo 2 locales tile fix*/
.surface-home .surface-family-devices-small .desktop-family-devivces ul li.surface-no-duo-2 {
    display: none;
}
/*CEE link nav banner*/
.surface-home .surface-linknav-cee-banner h2.c-heading{
    font-weight: 600;
    font-size: 48px;
    line-height: 58px;
}
.surface-home .surface-linknav-cee-banner{
    text-align: left;
    padding-left: 0;
    float: left;
    
}
@media screen and (min-width: 1084px){
.surface-home .surface-linknav-cee-banner {
    margin-top: 46px !important;
    margin-bottom: 35px;
}
}
@media screen and (min-width: 768px) and (max-width: 1083px){
.surface-home .surface-linknav-cee-banner {
    padding-left: 15%;
    margin-top: 46px !important;
    margin-bottom: 25px;
}
}
@media screen and (max-width: 767px){
.surface-home .surface-linknav-cee-banner {
    padding-left: 48px;
    margin-top: 35px !important;
    margin-bottom: 60px;
}
}
/*Device showcase badge radius fall 22 samll devices added*/
.surface-home .surface-family-devices .c-badge,
.desktop-family-devivces .c-badge {
    border-radius: 10px;
}
@media (prefers-reduced-motion: reduce) {
    .animation-off .surface-home .animated-hero .animated-hero-content.slide-in-hero .c-badge,
.animation-off .surface-home .animated-hero .animated-hero-content.slide-in-hero.is-scrollTop .c-badge,
.animation-off .surface-home .animated-hero .animated-hero-content.slide-in-hero.is-scrollDown h1.c-heading-2,
.animation-off .surface-home .animated-hero .animated-hero-content.slide-in-hero.is-scrollTop h1.c-heading-2,
.animation-off .surface-home .animated-hero .animated-hero-content.slide-in-hero.is-scrollDown div.c-paragraph-2 p,
.animation-off .surface-home .animated-hero .animated-hero-content.slide-in-hero.is-scrollTop div.c-paragraph-2 p,
.animation-off .surface-home .animated-hero .animated-hero-content.slide-in-hero.is-scrollDown .c-group a,
.animation-off .surface-home .animated-hero .animated-hero-content.slide-in-hero.is-scrollTop .c-group a,
.animation-off .surface-home .surface-family-devices h3.c-heading-6.is-scrollDown,
.animation-off .surface-home .surface-family-devices h3.c-heading-6.is-scrollTop,
.animation-off .surface-home .surface-family-devices h3.c-heading-6.is-scrollDown a,
.animation-off .surface-home .surface-family-devices h3.c-heading-6.is-scrollTop a,
.en-us.animation-off .surface-home .surface-family-devices a.surface-seeall.is-scrollTop,
.en-us.animation-off .surface-home .surface-family-devices a.surface-seeall.is-scrollDown,
.animation-off .surface-home .surface-family-devices .surface-family-devices-section.devices-left-align .surface-family-devices-video.is-scrollDown,
.animation-off .surface-home .surface-family-devices .surface-family-devices-section.devices-left-align .surface-family-devices-video.is-scrollTop,
.animation-off .surface-home .surface-family-devices .surface-family-devices-section.devices-right-align .desktop-family-devivces-tiles.is-scrollDown,
.animation-off .surface-home .surface-family-devices .surface-family-devices-section.devices-right-align .desktop-family-devivces-tiles.is-scrollTop,
.animation-off .surface-home .surface-family-devices-small ul.device-family-flex.is-scrollDown,
.animation-off .surface-home .surface-family-devices-small ul.device-family-flex.is-scrollTop,
.animation-off .surface-home .surface-family-devices .surface-family-devices-section.devices-left-align .desktop-family-devivces-tiles.is-scrollDown,
.animation-off .surface-home .surface-family-devices .surface-family-devices-section.devices-left-align .desktop-family-devivces-tiles.is-scrollTop,
.animation-off .surface-home .surface-family-devices .surface-family-devices-section.devices-right-align .surface-family-devices-video.is-scrollDown,
.animation-off .surface-home .surface-family-devices .surface-family-devices-section.devices-right-align .surface-family-devices-video.is-scrollTop,
.animation-off .surface-home .animated-lifestyle-video .lifestyle-video-content.is-scrollTop,
.animation-off .surface-home .animated-lifestyle-video .lifestyle-video-content.is-scrollDown{
    animation: none;
}
    .animation-off .surface-home .animated-hero .animated-hero-content.slide-in-hero .c-badge,
    .animation-off .surface-home .animated-hero .animated-hero-content.slide-in-hero h1.c-heading-2,
    .animation-off .surface-home .animated-hero .animated-hero-content.slide-in-hero div.c-paragraph-2 p,
    .animation-off .surface-home .animated-hero .animated-hero-content.slide-in-hero .c-group a,
  .en-us.animation-off .surface-home .surface-family-devices h3.c-heading-6,
    .en-us.animation-off .surface-home .surface-family-devices h3.c-heading-6 a,
    :not(.en-us).animation-off .surface-home .surface-family-devices h3.c-heading-6,
    .en-us.animation-off .surface-home .surface-family-devices a.surface-seeall.is-scrollTop,
.en-us.animation-off .surface-home .surface-family-devices a.surface-seeall.is-scrollDown,
    .animation-off .surface-home .surface-family-devices .surface-family-devices-section .surface-family-devices-video,
.animation-off .surface-home .surface-family-devices .surface-family-devices-section .desktop-family-devivces-tiles,
.animation-off .surface-home .surface-family-devices-small ul.device-family-flex,
.animation-off .surface-home .animated-lifestyle-video .lifestyle-video-content{
        opacity: 1;
    }
.animation-off .surface-home .animated-hero.surface-animated-link.Surface_2022_Home_Hero_Animated_Video video{
    display: none;
}
.animation-off  .surface-home .animated-hero.surface-animated-link.Surface_2022_Home_Hero_Animated_Video .animated-hero-content.slide-in-hero{
    display: block !important;
}
}
 .animation-off .surface-home .animated-hero .animated-hero-content.slide-in-hero .c-badge,
.animation-off .surface-home .animated-hero .animated-hero-content.slide-in-hero.is-scrollTop .c-badge,
.animation-off .surface-home .animated-hero .animated-hero-content.slide-in-hero.is-scrollDown h1.c-heading-2,
.animation-off .surface-home .animated-hero .animated-hero-content.slide-in-hero.is-scrollTop h1.c-heading-2,
.animation-off .surface-home .animated-hero .animated-hero-content.slide-in-hero.is-scrollDown div.c-paragraph-2 p,
.animation-off .surface-home .animated-hero .animated-hero-content.slide-in-hero.is-scrollTop div.c-paragraph-2 p,
.animation-off .surface-home .animated-hero .animated-hero-content.slide-in-hero.is-scrollDown .c-group a,
.animation-off .surface-home .animated-hero .animated-hero-content.slide-in-hero.is-scrollTop .c-group a,
.animation-off .surface-home .surface-family-devices h3.c-heading-6.is-scrollDown,
.animation-off .surface-home .surface-family-devices h3.c-heading-6.is-scrollTop,
.animation-off .surface-home .surface-family-devices h3.c-heading-6.is-scrollDown a,
.animation-off .surface-home .surface-family-devices h3.c-heading-6.is-scrollTop a,
.en-us.animation-off .surface-home .surface-family-devices a.surface-seeall.is-scrollTop,
.en-us.animation-off .surface-home .surface-family-devices a.surface-seeall.is-scrollDown,
.animation-off .surface-home .surface-family-devices .surface-family-devices-section.devices-left-align .surface-family-devices-video.is-scrollDown,
.animation-off .surface-home .surface-family-devices .surface-family-devices-section.devices-left-align .surface-family-devices-video.is-scrollTop,
.animation-off .surface-home .surface-family-devices .surface-family-devices-section.devices-right-align .desktop-family-devivces-tiles.is-scrollDown,
.animation-off .surface-home .surface-family-devices .surface-family-devices-section.devices-right-align .desktop-family-devivces-tiles.is-scrollTop,
.animation-off .surface-home .surface-family-devices-small ul.device-family-flex.is-scrollDown,
.animation-off .surface-home .surface-family-devices-small ul.device-family-flex.is-scrollTop,
.animation-off .surface-home .surface-family-devices .surface-family-devices-section.devices-left-align .desktop-family-devivces-tiles.is-scrollDown,
.animation-off .surface-home .surface-family-devices .surface-family-devices-section.devices-left-align .desktop-family-devivces-tiles.is-scrollTop,
.animation-off .surface-home .surface-family-devices .surface-family-devices-section.devices-right-align .surface-family-devices-video.is-scrollDown,
.animation-off .surface-home .surface-family-devices .surface-family-devices-section.devices-right-align .surface-family-devices-video.is-scrollTop,
.animation-off .surface-home .animated-lifestyle-video .lifestyle-video-content.is-scrollTop,
.animation-off .surface-home .animated-lifestyle-video .lifestyle-video-content.is-scrollDown{
    animation: none;
}
    .animation-off .surface-home .animated-hero .animated-hero-content.slide-in-hero .c-badge,
    .animation-off .surface-home .animated-hero .animated-hero-content.slide-in-hero h1.c-heading-2,
    .animation-off .surface-home .animated-hero .animated-hero-content.slide-in-hero div.c-paragraph-2 p,
    .animation-off .surface-home .animated-hero .animated-hero-content.slide-in-hero .c-group a,
  .en-us.animation-off .surface-home .surface-family-devices h3.c-heading-6,
    .en-us.animation-off .surface-home .surface-family-devices h3.c-heading-6 a,
    :not(.en-us).animation-off .surface-home .surface-family-devices h3.c-heading-6,
    .en-us.animation-off .surface-home .surface-family-devices a.surface-seeall.is-scrollTop,
.en-us.animation-off .surface-home .surface-family-devices a.surface-seeall.is-scrollDown,
    .animation-off .surface-home .surface-family-devices .surface-family-devices-section .surface-family-devices-video,
.animation-off .surface-home .surface-family-devices .surface-family-devices-section .desktop-family-devivces-tiles,
.animation-off .surface-home .surface-family-devices-small ul.device-family-flex,
.animation-off .surface-home .animated-lifestyle-video .lifestyle-video-content{
        opacity: 1;
    }
.animation-off  .surface-home .animated-hero.f-animated-22-hero.surface-animated-link.Surface_2022_Home_Hero_Animated_Video video{
    display: none;
}
.animation-off  .surface-home .animated-hero.surface-animated-link.Surface_2022_Home_Hero_Animated_Video .animated-hero-content.slide-in-hero{
    display: block !important;
}

.animation-on .surface-home .animated-hero.surface-animated-link.Surface_2022_Home_Hero_Animated_Video .m-ambient-video+picture > img{
    display: none;
}
.animation-off .surface-home .animated-hero.surface-animated-link.Surface_2022_Home_Hero_Animated_Video .m-ambient-video+picture > img{
    display: block;
}




/*arabic markets*/
@media screen and (max-width: 1083px){
.rtl .surface-home .surface-family-devices .mobile-family-devices .c-carousel.f-multi-slide li {
    margin-left: -100%;
    margin-right: 0px;
}

.rtl .surface-home .surface-family-devices .mobile-family-devices .c-carousel .c-flipper.f-previous{
    right: 20px;
    left: 0;
}

.rtl .surface-home .surface-family-devices .mobile-family-devices .c-carousel .c-flipper.f-next{
    left: 0px;
    right: 88%;
}
}

@media screen and (min-width: 768px) and (max-width: 1083px){
.rtl .surface-home .animated-hero .animated-hero-main-content {
    width:auto;
}
}

@media screen and (max-width: 767px){
.rtl .surface-home .animated-hero .animated-hero-main-content {
    width:auto;
    left:40%;
}

.rtl .surface-home .surface-family-devices .surface-family-devices-section .mobile-family-devices .c-carousel ul li a{
    text-align: right;
}
}

/*CEE markets without buy page link*/
.bg-bg .surface-home .surface-family-devices-section ul li,
.et-ee .surface-home .surface-family-devices-section ul li,
.hr-hr .surface-home .surface-family-devices-section ul li,
.lt-lt .surface-home .surface-family-devices-section ul li,
.lv-lv .surface-home .surface-family-devices-section ul li,
.sl-si .surface-home .surface-family-devices-section ul li
 {
    pointer-events: none;
}
/*family devices mobile vp resizing issue*/
.surface-home .surface-family-devices-section .mobile-family-devices ul li .mobfamilydeviceheading a.mscom-link.c-call-to-action.c-glyph.f-lightweight{
    min-height: 55px;
}
/*Hero CTA more content*/
@media screen and (min-width: 1084px){
.animated-hero-main-content .animated-hero-content a.mscom-link.c-call-to-action.surface-home-cta-left-align {
    text-align: left;
}
}

/*400% zoom accessibility issues*/
@media screen and (max-width: 320px){
    .surface-home .animated-lifestyle-video .lifestyle-video-content h2.c-heading-2,
    .surface-home .surface-obd.animated-lifestyle-video .lifestyle-video-content p.c-heading-2,
    .surface-home .animated-lifestyle-video.surface-sustainability .lifestyle-video-content h2.c-heading-2{
        font-size: 38px;
        line-height: 45px;
    }
    .surface-home .animated-lifestyle-video .lifestyle-video-content.align-text-left .c-paragraph-2, 
    .surface-home .animated-lifestyle-video .lifestyle-video-content.align-text-right .c-paragraph-2{
        font-weight: 400;
    }
    .surface-home .animated-lifestyle-video .lifestyle-video-content.align-text-left .c-paragraph-2, 
    .surface-home .animated-lifestyle-video .lifestyle-video-content.align-text-right .c-paragraph-2, 
    .surface-home .animated-lifestyle-video .lifestyle-video-content .c-group a{
        font-size: 10px;
        line-height: 17px;
    }
}

@media screen and (prefers-contrast: more) {
.surface-home a.c-call-to-action{
     border:none !important;
   outline: none !important;
}
}

@media screen and (prefers-contrast: less) {
.surface-home a.c-call-to-action{
     border:none !important;
   outline: none !important;
}
}
/*400% zoom accessibility issues End*/
/* Back to top*/
a.m-back-to-top,a.c-back-to-top {
outline: 1px #ffffff dotted;
}

.surface-home .surface-obd.animated-lifestyle-video .lifestyle-video-content p.c-heading-2{
     padding-bottom:20px;
    }
/*Arabic locales device showcase heading issue*/
@media screen and (min-width: 768px) and (max-width: 1083px){
    .rtl .surface-home .surface-family-devices h3.c-heading-6{
        padding-right: 15%;
    }
}
/*2in1, laptops cta alignment issue*/
@media screen and (min-width: 370px) and (max-width: 420px){
    .en-us .surface-home .surface-family-devices a.surface-seeall{
        text-align: left;
    }
}
/*sk-sk back up version*/
/*.sk-sk .surface-home .surface-family-devices-section.devices-right-align ul li:nth-child(2) {
    pointer-events: none;
}*/

/*Fall 22 changed 540 to 510 @media query*/
@media only screen and (min-width: 300px) and (max-width: 510px) {
    /* home hero holiday updates wave2 11/17 publish, has to be removed after 11/25 START*/
    .es-es .surface-home .animated-hero .animated-hero-main-content,
    .it-it .surface-home .animated-hero .animated-hero-main-content {
    top: 2px;
    }
    .sv-se .surface-home .animated-hero .animated-hero-main-content,
    .pt-pt .surface-home .animated-hero .animated-hero-main-content {
        width: 87%;
    }
    .it-it .surface-home .animated-hero .animated-hero-content .c-group,
    .fr-fr .surface-home .animated-hero .animated-hero-content .c-group {
    margin-top: 2px;
    line-height: 1px;
    }
    /* home hero holiday updates wave2 11/17 publish, has to be removed after 11/25 END*/
    .surface-home .animated-hero .animated-hero-main-content
    {
        top:10px;
    }
    .surface-home .animated-hero .animated-hero-main-content h1.c-heading-2
    {
        font-size: 34px;
    line-height: 43px;
    padding: 15px 0 0 0;
    }
    .surface-home .animated-hero .animated-hero-main-content div.c-paragraph-2 p
    {
        font-size: 15px;
    line-height: 20px;
    padding: 6px 0 0 0;
    }
    .surface-home .animated-hero .animated-hero-content .c-group
    {
        margin-top: 5px;
    }
    .surface-home .animated-hero .animated-hero-main-content .c-paragraph-2
    {
        padding-top: 10px;
    }
}
@media only screen and (min-width: 300px) and (max-width: 390px) {
    .de-at .surface-home .animated-hero .animated-hero-main-content,
    .de-ch .surface-home .animated-hero .animated-hero-main-content,
    .de-de .surface-home .animated-hero .animated-hero-main-content
    {
        top:2px;
        width: 85%;
    }
    
    }
@media only screen and (min-width: 300px) and (max-width: 575px) {
    .fr-ca .surface-home .animated-hero .animated-hero-main-content,
    .fr-ch .surface-home .animated-hero .animated-hero-main-content,
    .fr-fr .surface-home .animated-hero .animated-hero-main-content,
    .fr-be .surface-home .animated-hero .animated-hero-main-content,
    .fr-lu .surface-home .animated-hero .animated-hero-main-content,
    .fi-fi .surface-home .animated-hero .animated-hero-main-content
    {
        top:2px;
        width: 85%;
    }
    }
    /*need to remove after holiday updates fi-fi*/
  @media only screen and (min-width: 768px) and (max-width: 800px) {
      .fi-fi .surface-home .animated-hero .animated-hero-main-content{
      width: 85%;
      }
  }  
/*CR: 148504 adaptability panel cta fix*/
@media only screen and (min-width: 300px) and (max-width: 410px) {
    .surface-home .animated-lifestyle-video .lifestyle-video-content .c-group a.mscom-link.c-call-to-action.c-glyph.f-lightweight.ada-sus-home-cta{
        margin-right: 5px;
    }
}
/*Hero pride updates START CR:148427 */
@media only screen and (min-width: 300px) and (max-width: 410px) {
.en-us .surface-home .animated-hero .animated-hero-content .c-group a,
.en-ca .surface-home .animated-hero .animated-hero-content .c-group a,
.en-gb .surface-home .animated-hero .animated-hero-content .c-group a,
.fr-ca .surface-home .animated-hero .animated-hero-content .c-group a{
    font-size: 12px;
    margin-right: 5px;
    padding: 6px 3px 6px 0;

}
}
@media only screen and (min-width: 768px) and (max-width: 820px) {
.en-us .surface-home .animated-hero .animated-hero-content .c-group a,
.en-ca .surface-home .animated-hero .animated-hero-content .c-group a,
.en-gb .surface-home .animated-hero .animated-hero-content .c-group a,
.fr-ca .surface-home .animated-hero .animated-hero-content .c-group a{
    margin-right: 5px;
}
}
@media screen and (min-width: 1084px) and (max-width: 1550px){
.fr-ca .surface-home .animated-hero .animated-hero-content h1.c-heading-2{
    font-size: 52px;
    line-height: 62px;
    padding: 5px 0 0 0;
    font-weight: 600;
    }
}
@media screen and (min-width: 768px) and (max-width: 1000px){
.fr-ca .surface-home .animated-hero .animated-hero-main-content h1.c-heading-2{
    font-size: 40px;
    line-height: 50px;
    padding-top: 10%;
}
.fr-ca .surface-home .animated-hero .animated-hero-content .c-group a{
    padding-top: 1px;
}
}
@media only screen and (min-width: 300px) and (max-width: 460px) {
.fr-ca .surface-home .animated-hero .animated-hero-main-content h1.c-heading-2{
    font-size: 25px;
    line-height: 35px;
    padding: 15px 0 0 0;
}
.fr-ca .surface-home .animated-hero .animated-hero-content .c-group a{
padding: 4px 3px 4px 0;
}
}
/*.surface-home .animated-hero .animated-hero-content .c-group a{
    -moz-only-whitespace: nowrap;
    whitespace: nowrap;
    
}*/

/*Hero pride updates END*/

/*it-it OBD panel START*/
.surface-home .surface-obd.home-italy-obd.animated-lifestyle-video .lifestyle-video-content p.c-heading-2,
.surface-home .surface-obd.home-italy-obd.animated-lifestyle-video .lifestyle-video-content.align-text-left .c-paragraph-2,
.surface-home .surface-obd.home-italy-obd.animated-lifestyle-video .lifestyle-video-content .c-group a{
    color: #ffffff;
}

.Chrome .surface-home .surface-obd.home-italy-obd.animated-lifestyle-video .lifestyle-video-content .c-group a.c-call-to-action:not(.glyph-play) > span:after,
.Firefox .surface-home .surface-obd.home-italy-obd.animated-lifestyle-video .lifestyle-video-content .c-group a.c-call-to-action:not(.glyph-play) > span:after,
.Safari .surface-home .surface-obd.home-italy-obd.animated-lifestyle-video .lifestyle-video-content .c-group a.c-call-to-action:not(.glyph-play) > span:after{
        background-color: #ffffff;
}
.surface-home .surface-obd.home-italy-obd.animated-lifestyle-video .lifestyle-video-content .c-group a.c-call-to-action:focus:not(.x-hidden-focus):not(.wdg-f-blue-button){
    outline: #ffffff dashed 2px !important;
}
/*.surface-home .surface-obd.home-italy-obd{
margin-top: 100px;
}*/
@media screen and (min-width: 1084px) {
.surface-home .surface-italy-obd-masker{
    background: linear-gradient(90deg,#262626, transparent);
    position: absolute;
    top: 0;
    height: 100%;
    width: 60%;
}
}
.surface-home .surface-obd.home-italy-obd.animated-lifestyle-video .lifestyle-video-content .c-group{
    flex-wrap: wrap;
}
/*it-it OBD panel END*/
/* 400% zoom accesbility issues  */
@media only screen and (max-width: 369px) {

.en-us .surface-home .animated-hero .animated-hero-main-content{
     width: 90%;
 }
 
 .en-us .surface-home .animated-hero .animated-hero-content .c-group a{
     line-height: 1
 }
}
/* 400% zoom accesbility issues end  */

/*Offer carousel border radius*/
#surface-shopdeals-offer .body-new-border{
    border-radius: 10px;
}


/*animation toogle start*/
/* .reduced-animation-toggle {
            width: 100%;
            display: flex;
            flex-flow: row-reverse;
            padding: 10px;
            background-color: #f2f2f2;
            height: 40px;
            padding-right: 150px;
        }

        @media screen and (max-width: 1920px) {
             .reduced-animation-toggle {
                padding-right: 70px;
            }
        }

        @media screen and (max-width: 1400px) {
             .reduced-animation-toggle {
                padding-right: 56px;
            }
        }

        @media screen and (max-width: 1083px) {
             .reduced-animation-toggle {
                padding-right: 12px;
            }
        }

         .reduced-animation-toggle div.c-toggle > label + button {
            clear: none;
        }

         .surface-home .reduced-animation-toggle .c-label {
            margin-top: 0;
            padding-right: 20px;
            padding-bottom: 0px;
            float: left;
        }
        .reduced-animation-toggle div.c-toggle .toggle-seperator {
	 width: 15px;
	 height: 0;
	 border: 1px solid #d5d5d5;
	 -ms-transform: rotate(90deg);
	 -webkit-transform: rotate(90deg);
	 transform: rotate(90deg);
	 margin-right: 15px;
	 margin-left: 15px;
}*/
        /*animation toogle end*/
/*BUG:150338 Start*/
@media screen and (min-width: 768px) and (max-width: 800px){
.surface-home .surface-obd .lifestyle-video-content {
    top: 3.5%;
}
}
/*BUG:150338 End*/
/*CR:152620 fixes start Need to remove this code after this CR TD*/
@media screen and (min-width: 300px) and (max-width: 400px){
.de-lu .surface-home .animated-hero .animated-hero-main-content h1.c-heading-2,
.fr-lu .surface-home .animated-hero .animated-hero-main-content h1.c-heading-2,
.pt-pt .surface-home .animated-hero .animated-hero-main-content h1.c-heading-2,
.fr-be .surface-home .animated-hero .animated-hero-main-content h1.c-heading-2, 
.nl-be .surface-home .animated-hero .animated-hero-main-content h1.c-heading-2,
.pl-pl .surface-home .animated-hero .animated-hero-main-content h1.c-heading-2,
.cs-cz .surface-home .animated-hero .animated-hero-main-content h1.c-heading-2,
.sv-se .surface-home .animated-hero .animated-hero-main-content h1.c-heading-2,
.nl-nl .surface-home .animated-hero .animated-hero-main-content h1.c-heading-2{
    padding: 7px 0 0 0;
}
.de-lu .surface-home .animated-hero .animated-hero-main-content,
.fr-lu .surface-home .animated-hero .animated-hero-main-content,
.pt-pt .surface-home .animated-hero .animated-hero-main-content,
.fr-be .surface-home .animated-hero .animated-hero-main-content,
.nl-be .surface-home .animated-hero .animated-hero-main-content,
.pl-pl .surface-home .animated-hero .animated-hero-main-content,
.cs-cz .surface-home .animated-hero .animated-hero-main-content,
.sv-se .surface-home .animated-hero .animated-hero-main-content,
.nl-nl .surface-home .animated-hero .animated-hero-main-content,
.fi-fi .surface-home .animated-hero .animated-hero-main-content{
    top: 1px;
}
/* home hero holiday updates wave2 11/17 publish, has to be removed after 11/25 START*/
.fr-be .surface-home .animated-hero .animated-hero-main-content,
.fr-lu .surface-home .animated-hero .animated-hero-main-content,
.de-lu .surface-home .animated-hero .animated-hero-main-content,
.es-mx .surface-home .animated-hero .animated-hero-main-content,
.pl-pl .surface-home .animated-hero .animated-hero-main-content,
.ko-kr .surface-home .animated-hero .animated-hero-main-content {
    width: 89%;
}
/* home hero holiday updates wave2 11/17 publish, has to be removed after 11/25 END*/
.de-lu .surface-home .animated-hero .animated-hero-main-content .c-group a.c-call-to-action.f-lightweight,
.fr-lu .surface-home .animated-hero .animated-hero-main-content .c-group a.c-call-to-action.f-lightweight,
.pt-pt .surface-home .animated-hero .animated-hero-main-content .c-group a.c-call-to-action.f-lightweight,
.fr-be .surface-home .animated-hero .animated-hero-main-content .c-group a.c-call-to-action.f-lightweight,
.nl-be .surface-home .animated-hero .animated-hero-main-content .c-group a.c-call-to-action.f-lightweight,
.pl-pl .surface-home .animated-hero .animated-hero-main-content .c-group a.c-call-to-action.f-lightweight,
.cs-cz .surface-home .animated-hero .animated-hero-main-content .c-group a.c-call-to-action.f-lightweight,
.sv-se .surface-home .animated-hero .animated-hero-main-content .c-group a.c-call-to-action.f-lightweight,
.nl-nl .surface-home .animated-hero .animated-hero-main-content .c-group a.c-call-to-action.f-lightweight{
    
    padding: 4px 3px 4px 0;
}
.es-es .surface-home .animated-hero .animated-hero-main-content h1.c-heading-2,
.fi-fi .surface-home .animated-hero .animated-hero-main-content h1.c-heading-2 {
    padding: 1px 0 0 0;
}
.es-es .surface-home .animated-hero .animated-hero-main-content .c-paragraph-2,
.fi-fi .surface-home .animated-hero .animated-hero-main-content .c-paragraph-2{
        padding-top: 6px;
}
.es-es .surface-home .animated-hero .animated-hero-main-content .c-group a.c-call-to-action.f-lightweight,
.fi-fi .surface-home .animated-hero .animated-hero-main-content .c-group a.c-call-to-action.f-lightweight {
    padding: 1px 3px 2px 0;
}
.fi-fi .surface-home .animated-hero .animated-hero-main-content h1.c-heading-2{
font-size: 32px;
line-height: 37px;
    }
}
/*CR:152620 fixes end*/

/*****FALL 22 Updates start*****/
/*Fall adapatability panel start*/
.falladaptabilitymodule {
                position: relative;
                overflow: hidden;
}
.falladaptabilitymodule.sandstone {
                background-color: #f9ece1;
}
.falladaptabilitymodule.battleship {
                background-color: #e8f1e9;
}
.falladaptabilitymodule.white {
                background-color: #fff;
}
.falladaptabilitymodule.purple {
                background-color: #c9cce9;
}
.falladaptabilitymodule.whiteandgray {
                background-color: #f2f2f2;
}
.falladaptabilitymodule .bgtext-main {
                /*position: absolute;
                top: 28%;
                */
                font-weight: 600;
                font-size: 400px;
                line-height: 520px;
                margin-top: -173px;
                /*right: 0;
                */
                color: transparent;
                -webkit-text-stroke-width: 1px;
                -webkit-text-stroke-color: #fff;
                white-space: nowrap;
                /*left: 0;
                */
                z-index: 1;
}
@media screen and (min-width: 1084px) and (max-width: 1399px) {
                .falladaptabilitymodule .bgtext-main {
                                font-size: 160px;
                                line-height: 210px;
                                margin-top: -70px;
                                /*top: 29%;
                                */
                }
}
@media screen and (min-width: 768px) and (max-width: 1083px) {
                .falladaptabilitymodule .bgtext-main {
                                font-size: 175px;
                                line-height: 230px;
                                margin-top: -76px;
                                margin-bottom: -76px;
                                /*top: 27%;
                                */
                }
}
@media screen and (min-width: 540px) and (max-width: 767px) {
                .falladaptabilitymodule .bgtext-main {
                                font-size: 105px;
                                line-height: 140px;
                                margin-top: -46px;
                                margin-bottom: -46px;
                                opacity: 0.4;
                                /*top: 14%;
                                */
                }
}
@media screen and (max-width: 540px) {
                .falladaptabilitymodule .bgtext-main {
                                font-size: 111px;
                                line-height: 140px;
                                margin-top: -46px;
                                margin-bottom: -46px;
                                opacity: 0.4;
                                /*top: 29%;
                                */
                }
}
@media (prefers-color-scheme: dark) {
                .falladaptabilitymodule .bgtext-main .bgtext {
                                opacity: 0.5;
                }
}
.falladaptabilitymodule .bgtext-main .bgtext.is-scrollDown {
                animation: animate-backInRight 2s ease-in-out forwards;
}
@media screen and (min-width: 1920px) {
                .falladaptabilitymodule .bgtext-main .bgtext.is-scrollDown {
                                animation: animate-backInRight2 2s ease-in-out forwards;
                }
}
.falladaptabilitymodule .bgtext-main .bgtext.is-scrollTop {
                animation: animate-backInRight 2s ease-in-out forwards;
}
@media screen and (min-width: 1920px) {
                .falladaptabilitymodule .bgtext-main .bgtext.is-scrollTop {
                                animation: animate-backInRight2 2s ease-in-out forwards;
                }
}
.falladaptabilitymodule .user-adapatability {
                padding: 0px;
                padding-top: 70px;
                display: flex;
                flex-direction: column;
}
@media screen and (max-width: 1083px) {
                .falladaptabilitymodule .user-adapatability {
                                padding-top: 50px;
                }
}
.falladaptabilitymodule .user-adapatability .adapt-first {
                display: flex;
                /*@media screen and (min-width: 1083px) {
                                width: 50%;
                }
                */
}
.falladaptabilitymodule .user-adapatability .adapt-first .img-col {
                width: 21%;
}
@media screen and (max-width: 1083px) and (min-width: 540px) {
                .falladaptabilitymodule .user-adapatability .adapt-first .img-col {
                                width: 25%;
                }
}
@media screen and (max-width: 540px) {
                .falladaptabilitymodule .user-adapatability .adapt-first .img-col {
                                width: 45%;
                                padding-right: 40px;
                                padding-top: 25px;
                }
}
.falladaptabilitymodule .user-adapatability .adapt-first .img-col .img-col-content {
                transform: translateY(50px);
}
.falladaptabilitymodule .user-adapatability .adapt-first .img-col .img-col-content.is-scrollDown {
                animation: animate-backInUp 2s ease-in-out forwards;
}
.falladaptabilitymodule .user-adapatability .adapt-first .img-col .img-col-content.is-scrollTop {
                animation: animate-backInUp 2s ease-in-out forwards;
}
.falladaptabilitymodule .user-adapatability .adapt-first .img-col .img-col-content picture img {
                width: 100%;
                height: auto;
}
/*.falladaptabilitymodule .user-adapatability .adapt-first .text-col {
                @media screen and (max-width: 540px) {
                                text-indent: -60px;
                                padding-left: 50px;
                }
                
}*/
@media screen and (min-width: 767px) {
                .falladaptabilitymodule .user-adapatability .adapt-first .text-col {
                                width: 50%;
                }
}
@media screen and (max-width: 767px) {
                .falladaptabilitymodule .user-adapatability .adapt-first .text-col {
                                width: 75%;
                }
}
@media screen and (max-width: 540px) {
                .falladaptabilitymodule .user-adapatability .adapt-first .text-col {
                                width: 100%;
                }
}
.falladaptabilitymodule .user-adapatability .adapt-first .text-col .text-col-content {
                transform: translateY(50px);
}
.falladaptabilitymodule .user-adapatability .adapt-first .text-col .text-col-content.is-scrollDown {
                animation: animate-backInUp 2s ease-in-out forwards;
}
.falladaptabilitymodule .user-adapatability .adapt-first .text-col .text-col-content.is-scrollTop {
                animation: animate-backInUp 2s ease-in-out forwards;
}
.falladaptabilitymodule .user-adapatability .adapt-first .text-col h2 {
                font-weight: 600;
                font-size: 71px;
                line-height: 84px;
                padding-left: 100px;
                /*@media screen and (max-width: 540px) {
                                padding-left: 80px;
                                padding-right: 125px;
                }
                @media screen and (max-width: 358px) {
                                padding-left: 50px;
                }
                */
}
@media only screen and (min-width: 768px) {
                .falladaptabilitymodule .user-adapatability .adapt-first .text-col h2 {
                                display: flex;
                                flex-direction: column;
                }
}
@media screen and (max-width: 1399px) {
                .falladaptabilitymodule .user-adapatability .adapt-first .text-col h2 {
                                font-size: 50px;
                                line-height: 60px;
                }
}
@media screen and (max-width: 1083px) {
                .falladaptabilitymodule .user-adapatability .adapt-first .text-col h2 {
                                font-size: 46px;
                                line-height: 56px;
                                padding-left: 20px;
                                padding-top: 0px;
                }
}
@media screen and (max-width: 767px) {
                .falladaptabilitymodule .user-adapatability .adapt-first .text-col h2 {
                                font-size: 37px;
                                line-height: 47px;
                                padding-top: 0px;
                }
}
.falladaptabilitymodule .user-adapatability .adapt-first .text-col h2 span {
                display: block;
}
@media screen and (max-width: 540px) {
                .falladaptabilitymodule .user-adapatability .adapt-first {
                                flex-direction: column-reverse;
                }
}
.falladaptabilitymodule .user-adapatability .adapt-second {
                display: flex;
                margin-top: -367px;
                z-index: 2;
}
@media screen and (min-width: 1084px) and (max-width: 1399px) {
                .falladaptabilitymodule .user-adapatability .adapt-second {
                                margin-top: -190px;
                }
}
@media screen and (max-width: 1083px) {
                .falladaptabilitymodule .user-adapatability .adapt-second {
                                margin-top: initial;
                }
}
@media screen and (max-width: 767px) {
                .falladaptabilitymodule .user-adapatability .adapt-second {
                                flex-direction: column-reverse;
                }
}
.falladaptabilitymodule .user-adapatability .adapt-second .text-cont {
                align-self: flex-end;
                padding: 0px 60px 100px 100px;
}
@media screen and (max-width: 1399px) {
                .falladaptabilitymodule .user-adapatability .adapt-second .text-cont {
                                padding: 0px 30px 50px 50px;
                }
}
@media screen and (max-width: 1083px) {
                .falladaptabilitymodule .user-adapatability .adapt-second .text-cont {
                                padding: 0px 30px 30px 50px;
                                align-self: auto;
                }
}
@media screen and (max-width: 767px) {
                .falladaptabilitymodule .user-adapatability .adapt-second .text-cont {
                                width: 100%;
                                padding: 40px 130px 30px 15px;
                }
}
@media screen and (max-width: 540px) {
                .falladaptabilitymodule .user-adapatability .adapt-second .text-cont {
                                padding: 40px 10px 50px 10px;
                }
}
.falladaptabilitymodule .user-adapatability .adapt-second .text-cont .text-cont-content {
                transform: translateY(50px);
}
.falladaptabilitymodule .user-adapatability .adapt-second .text-cont .text-cont-content.is-scrollDown {
                animation: animate-backInUp 2s ease-in-out forwards;
}
.falladaptabilitymodule .user-adapatability .adapt-second .text-cont .text-cont-content.is-scrollTop {
                animation: animate-backInUp 2s ease-in-out forwards;
}
.falladaptabilitymodule .user-adapatability .adapt-second .text-cont p {
                font-weight: 400;
                font-size: 16px;
                line-height: 24px;
}
@media only screen and (max-width: 1399px) {
                .falladaptabilitymodule .user-adapatability .adapt-second .text-cont p {
                                font-size: 16px;
                                line-height: 24px;
                }
}
@media only screen and (max-width: 1083px) and (min-width: 768px) {
                .falladaptabilitymodule .user-adapatability .adapt-second .text-cont p {
                                font-size: 15px;
                                line-height: 20px;
                }
}
.falladaptabilitymodule .user-adapatability .adapt-second .text-cont .two-ctas {
                display: flex;
                padding-top: 20px;
}
@media only screen and (max-width: 1083px) and (min-width: 768px) {
                .falladaptabilitymodule .user-adapatability .adapt-second .text-cont .two-ctas {
                                flex-direction: column;
                                float: left;
                }
}
.falladaptabilitymodule .user-adapatability .adapt-second .text-cont .two-ctas a.non-transparent.c-call-to-action:not(.glyph-play):after {
                content: none;
}
.falladaptabilitymodule .user-adapatability .adapt-second .text-cont .two-ctas .non-transparent {
                margin-right: 10px;
                font-weight: 600;
                font-size: 18px;
                line-height: 26px;
                min-width: auto;
                color: #fff;
                background: #0067b8;
                padding: 10px 10px 6px 10px;
}
@media only screen and (max-width: 1083px) and (min-width: 768px) {
                .falladaptabilitymodule .user-adapatability .adapt-second .text-cont .two-ctas .non-transparent {
                                width: 145px;
                }
}
.falladaptabilitymodule .user-adapatability .adapt-second .text-cont .two-ctas .non-transparent span {
                display: inline;
                white-space: normal;
                left: 0;
}
@media screen and (max-width: 540px) {
                .falladaptabilitymodule .user-adapatability .adapt-second .text-cont .two-ctas .non-transparent {
                                padding: 10px 5px 6px 5px;
                }
}
.falladaptabilitymodule .user-adapatability .adapt-second .text-cont .two-ctas .transparent.c-call-to-action:not(.glyph-play):after {
                margin-top: 0px;
}
.falladaptabilitymodule .user-adapatability .adapt-second .text-cont .two-ctas .transparent {
                font-weight: 600;
                font-size: 16px;
                line-height: 24px;
                color: #0067b8;
                background: none;
                min-width: none;
                padding: 10px 15px 6px 15px;
                text-align: left;
}
.falladaptabilitymodule .user-adapatability .adapt-second .text-cont .two-ctas .transparent span {
                display: inline;
                white-space: normal;
                left: 0;
}
@media only screen and (max-width: 1083px) and (min-width: 768px) {
                .falladaptabilitymodule .user-adapatability .adapt-second .text-cont .two-ctas .transparent {
                                padding-left: 1px;
                                padding-top: 20px;
                }
}
@media screen and (max-width: 540px) {
                .falladaptabilitymodule .user-adapatability .adapt-second .text-cont .two-ctas .transparent {
                                padding: 10px 5px 6px 5px;
                }
}
.falladaptabilitymodule .user-adapatability .adapt-second .img-cont {
                width: 50%;
}
@media screen and (min-width: 1400px) {
                .falladaptabilitymodule .user-adapatability .adapt-second .img-cont {
                                padding-right: 100px;
                }
}
@media screen and (max-width: 767px) {
                .falladaptabilitymodule .user-adapatability .adapt-second .img-cont {
                                width: 100%;
                                padding-left: 100px;
                }
}
@media screen and (max-width: 540px) {
                .falladaptabilitymodule .user-adapatability .adapt-second .img-cont {
                                padding-left: 70px;
                }
}
@media screen and (max-width: 358px) {
                .falladaptabilitymodule .user-adapatability .adapt-second .img-cont {
                                padding-left: 20px;
                }
}
.falladaptabilitymodule .user-adapatability .adapt-second .img-cont .img-cont-content {
                transform: translateY(50px);
}
.falladaptabilitymodule .user-adapatability .adapt-second .img-cont .img-cont-content.is-scrollDown {
                animation: animate-backInUp 2s ease-in-out forwards;
}
.falladaptabilitymodule .user-adapatability .adapt-second .img-cont .img-cont-content.is-scrollTop {
                animation: animate-backInUp 2s ease-in-out forwards;
}
.falladaptabilitymodule .user-adapatability .adapt-second .img-cont .img-cont-content picture img {
                width: 100%;
                height: auto;
}
body.animation-off .falladaptabilitymodule .bgtext {
                margin-left: -5%;
}
@media screen and (max-width: 358px) {
                body.animation-off .falladaptabilitymodule .bgtext {
                                margin-left: -12%;
                }
}
body.animation-off .falladaptabilitymodule .bgtext.is-scrollDown {
                animation: none;
                opacity: 1;
}
body.animation-off .falladaptabilitymodule .bgtext.is-scrollTop {
                animation: none;
                opacity: 1;
}
body.animation-off .falladaptabilitymodule .user-adapatability .adapt-first .img-col .img-col-content {
                opacity: 1;
                transform: translateY(0);
}
body.animation-off .falladaptabilitymodule .user-adapatability .adapt-first .img-col .img-col-content.is-scrollDown {
                animation: none;
}
body.animation-off .falladaptabilitymodule .user-adapatability .adapt-first .img-col .img-col-content.is-scrollTop {
                animation: none;
}
body.animation-off .falladaptabilitymodule .user-adapatability .adapt-first .text-col .text-col-content {
                transform: translateY(0);
}
body.animation-off .falladaptabilitymodule .user-adapatability .adapt-first .text-col .text-col-content.is-scrollDown {
                animation: none;
                opacity: 1;
}
body.animation-off .falladaptabilitymodule .user-adapatability .adapt-first .text-col .text-col-content.is-scrollTop {
                animation: none;
                opacity: 1;
}
body.animation-off .falladaptabilitymodule .user-adapatability .adapt-second .text-cont .text-cont-content {
                transform: translateY(0);
}
body.animation-off .falladaptabilitymodule .user-adapatability .adapt-second .text-cont .text-cont-content.is-scrollDown {
                animation: none;
                opacity: 1;
}
body.animation-off .falladaptabilitymodule .user-adapatability .adapt-second .text-cont .text-cont-content.is-scrollTop {
                animation: none;
                opacity: 1;
}
body.animation-off .falladaptabilitymodule .user-adapatability .adapt-second .img-cont .img-cont-content {
                transform: translateY(0);
}
body.animation-off .falladaptabilitymodule .user-adapatability .adapt-second .img-cont .img-cont-content.is-scrollDown {
                animation: none;
                opacity: 1;
}
body.animation-off .falladaptabilitymodule .user-adapatability .adapt-second .img-cont .img-cont-content.is-scrollTop {
                animation: none;
                opacity: 1;
}
.rtl .falladaptabilitymodule .bgtext {
                margin-right: -5%;
}
@media screen and (max-width: 540px) {
                .rtl  .falladaptabilitymodule .user-adapatability .adapt-first .img-col {
                                padding-right: 0px;
                                padding-left: 40px;
                }
}
  .rtl .falladaptabilitymodule .user-adapatability .adapt-first .text-col .c-heading {
                padding-right: 100px;
}
@media screen and (max-width: 1083px) {
                  .rtl .falladaptabilitymodule .user-adapatability .adapt-first .text-col .c-heading {
                                padding-right: 20px;
                }
}
@media screen and (max-width: 540px) {
                  .rtl .falladaptabilitymodule .user-adapatability .adapt-first .text-col .c-heading {
                                padding-right: 80px;
                                padding-left: 125px;
                }
}
@media screen and (max-width: 358px) {
                  .rtl .falladaptabilitymodule .user-adapatability .adapt-first .text-col .c-heading {
                                padding-right: 50px;
                }
}
  .rtl .falladaptabilitymodule .user-adapatability .adapt-first .text-col h4 {
                padding-right: 100px;
}
@media screen and (max-width: 540px) {
                .rtl .falladaptabilitymodule .user-adapatability .adapt-first .text-col h4 {
                                padding-right: 80px;
                                padding-left: 125px;
                }
}
@media screen and (max-width: 358px) {
                  .rtl .falladaptabilitymodule .user-adapatability .adapt-first .text-col h4 {
                                padding-left: 50px;
                }
}
  .rtl .falladaptabilitymodule .user-adapatability .adapt-second .text-cont {
                padding: 0px 100px 100px 60px;
}
@media screen and (max-width: 1399px) {
                  .rtl .falladaptabilitymodule .user-adapatability .adapt-second .text-cont {
                                padding: 0px 50px 50px 30px;
                }
}
@media screen and (max-width: 767px) {
                  .rtl .falladaptabilitymodule .user-adapatability .adapt-second .text-cont {
                                width: 100%;
                                padding: 40px 15px 30px 130px;
                }
}
@media only screen and (max-width: 1083px) and (min-width: 768px) {
                  .rtl .falladaptabilitymodule .user-adapatability .adapt-second .text-cont .two-ctas {
                                float: left;
                }
}
@media screen and (min-width: 1400px) {
                  .rtl .falladaptabilitymodule .user-adapatability .adapt-second .img-cont {
                                padding-right: 0px;
                                padding-left: 100px;
                }
}
@media screen and (max-width: 767px) {
                .rtl .falladaptabilitymodule .user-adapatability .adapt-second .img-cont {
                                padding-left: 0px;
                                padding-right: 100px;
                }
}
@media screen and (max-width: 540px) {
                  .rtl .falladaptabilitymodule .user-adapatability .adapt-second .img-cont {
                                padding-left: 0px;
                                padding-right: 70px;
                }
}
@media screen and (max-width: 358px) {
                  .rtl .falladaptabilitymodule .user-adapatability .adapt-second .img-cont {
                                padding-left: 20px;
                }
}
@keyframes animate-backInRight2 {
                0% {
                                margin-left: 10%;
                }
                100% {
                                margin-left: -12%;
                }
}
@keyframes animate-backInUp {
    0% {
        transform: translateY(50px);
    }



   100% {
        transform: translateY(0);
    }
}
@keyframes animate-backInRight{
    0% {
        margin-left: 10%;
    }



   100% {
        margin-left: -1%;
    }
}

/*Fall adapatability panel end*/

/*Fall 22 Hero start*/
@media screen and (min-width: 1084px) {
.surface-home .f-animated-22-hero .animated-hero-main-content{
    left: 5%;
}
.rtl .surface-home .f-animated-22-hero .animated-hero-main-content{
    left: 8%;
    right: auto;
}

/*.surface-home .f-animated-22-hero .animated-hero-main-content .c-paragraph-2 {
    padding-right: 45px;
}
.surface-home .f-animated-22-hero .animated-hero-content h1.c-heading-2{
    padding-right: 40px;
}*/
}
/*if hero image is 60/40 then uncomment below code*/
/*@media only screen and (min-width: 1084px) and (max-width: 1300px) {
.rtl .surface-home .f-animated-22-hero .animated-hero-content .c-group a{
    margin-right: 30px;
}
.rtl .surface-home .f-animated-22-hero .animated-hero-main-content .c-paragraph-2,
.rtl .surface-home .f-animated-22-hero .animated-hero-content h1.c-heading-2{
    padding-right: 30px;
}
}*/
@media only screen and (min-width: 1084px) {
.rtl .surface-home .f-animated-22-hero .animated-hero-content .c-group a{
    margin-right: 0px;
}
.rtl .surface-home .f-animated-22-hero .animated-hero-main-content .c-paragraph-2,
.rtl .surface-home .f-animated-22-hero .animated-hero-content h1.c-heading-2{
    padding-right: 0px;
}
}
@media only screen and (min-width: 540px) and (max-width: 590px){

.rtl .surface-home .f-animated-22-hero .animated-hero-main-content .c-paragraph-2,
.rtl .surface-home .f-animated-22-hero .animated-hero-content h1.c-heading-2{
    padding-top: 10px;
}
.rtl .surface-home .f-animated-22-hero .animated-hero-content h1.c-heading-2{
    font-size: 45px;
    line-height: 55px;
    }
}
/*@media only screen and (min-width: 1500px) and (max-width: 1600px) {
.bg-bg .surface-home .f-animated-22-hero .animated-hero-content h1.c-heading-2{
    font-size: 84px;
}
}*/
.surface-home .f-animated-22-hero .animated-hero-content .c-group a, 
.surface-home .f-animated-22-hero .animated-hero-content .c-group a span, 
.surface-home .f-animated-22-hero .animated-hero-content .c-group a:focus:not(.x-hidden-focus) span {
    color: #000000;
}
.surface-home .f-animated-22-hero .animated-hero-main-content .animated-hero-content .c-group a.c-call-to-action:not(.glyph-play) > span:after{
    background-color: #000000;
}
@media screen and (min-width: 1084px) and (max-width: 1900px){
.surface-home .f-animated-22-hero.f22-hero-moretext .animated-hero-content h1.c-heading-2 {
    font-size: 52px;
    line-height: 62px;
    padding: 5px 0 0 0;
    font-weight: 600;
    }
.surface-home .f-animated-22-hero.f22-hero-moretext .animated-hero-content div.c-paragraph-2 p {
        font-size: 20px;
        line-height: 30px;
        padding: 10px 0 0 0;
    }
    
.surface-home .f-animated-22-hero.f22-hero-moretext .animated-hero-content .c-group a,    
.surface-home .f-animated-22-hero.f22-hero-moretext .animated-hero-content .c-group a span,
.surface-home .f-animated-22-hero.f22-hero-moretext .animated-hero-content .c-group a:focus:not(.x-hidden-focus) span{
    font-size: 16px;
}
}
@media screen and (min-width: 1400px) and (max-width: 1600px){
    .surface-home .animated-hero.f22-hero-moretext-en .animated-hero-main-content{
            top: 37%;
    }
/*.surface-home .f-animated-22-hero.f22-hero-moretext-en .animated-hero-content h1.c-heading-2 {
    font-size: 52px;
    line-height: 62px;
    padding: 5px 0 0 0;
    font-weight: 600;
    }
.surface-home .f-animated-22-hero.f22-hero-moretext-en .animated-hero-content div.c-paragraph-2 p {
        font-size: 20px;
        line-height: 30px;
        padding: 10px 0 0 0;
    }
    
.surface-home .f-animated-22-hero.f22-hero-moretext-en .animated-hero-content .c-group a,    
.surface-home .f-animated-22-hero.f22-hero-moretext-en .animated-hero-content .c-group a span,
.surface-home .f-animated-22-hero.f22-hero-moretext-en .animated-hero-content .c-group a:focus:not(.x-hidden-focus) span{
    font-size: 16px;
}*/
}
@media screen and (min-width: 1501px) and (max-width: 1585px){
.surface-home .f-animated-22-hero.f22-hero-moretext.f22-hero-extream-text .animated-hero-content h1.c-heading-2 {
    font-size: 52px;
    line-height: 62px;
    padding: 5px 0 0 0;
    font-weight: 600;
    }
.surface-home .f-animated-22-hero.f22-hero-moretext.f22-hero-extream-text .animated-hero-content div.c-paragraph-2 p {
        font-size: 20px;
        line-height: 30px;
        padding: 10px 0 0 0;
    }
    
.surface-home .f-animated-22-hero.f22-hero-moretext.f22-hero-extream-text .animated-hero-content .c-group a,    
.surface-home .f-animated-22-hero.f22-hero-moretext.f22-hero-extream-text .animated-hero-content .c-group a span,
.surface-home .f-animated-22-hero.f22-hero-moretext.f22-hero-extream-text .animated-hero-content .c-group a:focus:not(.x-hidden-focus) span{
    font-size: 16px;
}
}
@media screen and (min-width: 1084px) {
    .surface-home .animated-hero.f-animated-22-hero .m-ambient-video .animated-hero-media.desktop-video {
        display: block;
    }

    .surface-home .animated-hero.f-animated-22-hero .m-ambient-video .animated-hero-media.tablet-video {
        display: none;
    }

    .surface-home .animated-hero.f-animated-22-hero .m-ambient-video .animated-hero-media.mobile-video {
        display: none;
    }

    .surface-home .animated-hero.f-animated-22-hero .m-ambient-video .animated-hero-media.mobile-2-video {
        display: none;
    }

}

@media screen and (min-width: 768px) and (max-width: 1083px) {
    .surface-home .animated-hero.f-animated-22-hero .m-ambient-video .animated-hero-media.tablet-video {
        display: block;
    }

    .surface-home .animated-hero.f-animated-22-hero .m-ambient-video .animated-hero-media.desktop-video {
        display: none;
    }

    .surface-home .animated-hero.f-animated-22-hero .m-ambient-video .animated-hero-media.mobile-video {
        display: none;
    }

    .surface-home .animated-hero.f-animated-22-hero .m-ambient-video .animated-hero-media.mobile-2-video {
        display: none;
    }
}

@media screen and (min-width: 540px) and (max-width: 767px) {
    
   .surface-home .animated-hero.f-animated-22-hero .m-ambient-video .animated-hero-media.mobile-video {
        display: block;
    }
    .surface-home .animated-hero.f-animated-22-hero .m-ambient-video .animated-hero-media.desktop-video {
        display: none;
    }
    .surface-home .animated-hero.f-animated-22-hero .m-ambient-video .animated-hero-media.tablet-video {
        display: none;
    }

    .surface-home .animated-hero.f-animated-22-hero .m-ambient-video .animated-hero-media.mobile-2-video {
        display: none;
    }
}

@media screen and (max-width: 539px) {
    .surface-home .animated-hero.f-animated-22-hero .m-ambient-video .animated-hero-media.mobile-2-video {
        display: block;
    }

    .surface-home .animated-hero.f-animated-22-hero .m-ambient-video .animated-hero-media.mobile-video {
        display: none;
    }

    .surface-home .animated-hero.f-animated-22-hero .m-ambient-video .animated-hero-media.desktop-video {
        display: none;
    }

    .surface-home .animated-hero.f-animated-22-hero .m-ambient-video .animated-hero-media.tablet-video {
        display: none;
    }
}

/*Fall 22 Hero end*/
/*fr-ca en-ca PM disable on 10/11 launch day for 2 hours*/

/*.en-sg .surface-home .surface-family-devices-small .desktop-family-devivces ul li:nth-child(1) {
    pointer-events: none;
}*/
/*Fall 22 sustainability start*/
.surface-home .surface-sustainability .lifestyle-video-content .c-group a.c-call-to-action.c-glyph.glyph-play:before {

    top:-2px;
}
@media only screen and (min-width: 1084px) and (max-width: 1200px) {
.surface-home .surface-sustainability .lifestyle-video-content p.c-paragraph-2{

    padding-top:10px;
}
}
@media only screen and (min-width: 350px) and (max-width: 400px) {
.surface-home .surface-sustainability .lifestyle-video-content p.c-paragraph-2{

    padding-top:15px;
}
}
/*Fall 22 sustainability END*/

/*Fall 22 adapatability start*/
.surface-home .adapt-second .text-cont .text-cont-content .two-ctas a.c-call-to-action.non-transparent:not(.glyph-play) > span:after {
    content: none;
}
/*big tile issue fix start*/
@media screen and (min-width: 1084px) and (max-width: 1516px) {
    .surface-home .surface-family-devices-section .desktop-family-devivces-tiles ul li:nth-child(-n + 2)
{
margin-bottom: 15px;
}
.surface-home .surface-family-devices-section .desktop-family-devivces-tiles ul li
{
padding: 4px;
}
.surface-home .surface-family-devices a.mscom-link{
    font-size: 16px;
    font-weight: 600;  
}
}
/*big tile issue fix end*/

/*Post launch video update for Laptop big tile need to uncomment*/
.surface-home .m-ambient-video.surface-home-devices-video{
    display: none;
}
.de-at .surface-home .m-ambient-video.surface-home-devices-video,
.de-ch .surface-home .m-ambient-video.surface-home-devices-video,
.de-de .surface-home .m-ambient-video.surface-home-devices-video,
.en-au .surface-home .m-ambient-video.surface-home-devices-video,
.en-ca .surface-home .m-ambient-video.surface-home-devices-video,
.en-gb .surface-home .m-ambient-video.surface-home-devices-video,
.en-hk .surface-home .m-ambient-video.surface-home-devices-video,
.en-ie .surface-home .m-ambient-video.surface-home-devices-video,
.en-nz .surface-home .m-ambient-video.surface-home-devices-video,
.fr-ca .surface-home .m-ambient-video.surface-home-devices-video,
.fr-ch .surface-home .m-ambient-video.surface-home-devices-video,
.fr-fr .surface-home .m-ambient-video.surface-home-devices-video,
.ja-jp .surface-home .m-ambient-video.surface-home-devices-video,
.zh-cn .surface-home .m-ambient-video.surface-home-devices-video,
.zh-hk .surface-home .m-ambient-video.surface-home-devices-video,
.zh-tw .surface-home .m-ambient-video.surface-home-devices-video,
.en-us .surface-home .m-ambient-video.surface-home-devices-video{
    display: block;
}
/*.en-us .surface-home .m-ambient-video.surface-home-devices-video{
    display: block;
}*/

.de-at .surface-home .m-ambient-video.surface-home-devices-image,
.de-ch .surface-home .m-ambient-video.surface-home-devices-image,
.de-de .surface-home .m-ambient-video.surface-home-devices-image,
.en-au .surface-home .m-ambient-video.surface-home-devices-image,
.en-ca .surface-home .m-ambient-video.surface-home-devices-image,
.en-gb .surface-home .m-ambient-video.surface-home-devices-image,
.en-hk .surface-home .m-ambient-video.surface-home-devices-image,
.en-ie .surface-home .m-ambient-video.surface-home-devices-image,
.en-nz .surface-home .m-ambient-video.surface-home-devices-image,
.fr-ca .surface-home .m-ambient-video.surface-home-devices-image,
.fr-ch .surface-home .m-ambient-video.surface-home-devices-image,
.fr-fr .surface-home .m-ambient-video.surface-home-devices-image,
.ja-jp .surface-home .m-ambient-video.surface-home-devices-image,
.zh-cn .surface-home .m-ambient-video.surface-home-devices-image,
.zh-hk .surface-home .m-ambient-video.surface-home-devices-image,
.zh-tw .surface-home .m-ambient-video.surface-home-devices-image,
.en-us .surface-home .m-ambient-video.surface-home-devices-image{
    display: none;
}
/*.en-us .surface-home .m-ambient-video.surface-home-devices-image{
    display: none;
}*/

/*Fall 22 adapatability End*/
/*****FALL 22 Updates End*****/

/*homepage cache collete update*/
#inspiration {
    margin-top: 120px;
}
@media screen and (max-width: 1083px){
#inspiration {
    display: flex;
    flex-direction: column;
    margin-top: 84px;
}
#inspiration  .m-ambient-video{
    order: 2;
}
#inspiration .lifestyle-video-content{
    order: 1;
    position: initial;
    padding-left: 10%;
    margin-bottom: 40px;
}
.surface-home .innovation-banner{margin-bottom: 0px}
}
/*homepage cache collete update END*/
/*animation toggle high contrast white mode*/
@media screen and (-ms-high-contrast: active){
.reduced-animation-toggle div.c-toggle button {
    color: HighlightText !important;
    background-color: Highlight !important;
}
.reduced-animation-toggle div.c-toggle button#toggle-button {
    -ms-high-contrast-adjust: none;
}
}
/*Holiday CR's Nov 158318,158317 START*/
.surface-home .f-animated-22-hero .animated-hero-content.surface-hl-nov-white h1.c-heading-2,
.surface-home .f-animated-22-hero .animated-hero-content.surface-hl-nov-white .c-paragraph-2,
.surface-home .f-animated-22-hero .animated-hero-content.surface-hl-nov-white .c-group a, 
.surface-home .f-animated-22-hero .animated-hero-content.surface-hl-nov-white .c-group a span, 
.surface-home .f-animated-22-hero .animated-hero-content.surface-hl-nov-white .c-group a:focus:not(.x-hidden-focus) span {
    color: #ffffff;
}
.surface-home .f-animated-22-hero .animated-hero-main-content .animated-hero-content.surface-hl-nov-white .c-group a.c-call-to-action:focus:not(.x-hidden-focus):not(.wdg-f-blue-button) {
    outline: #ffffff dashed 2px !important;
}
.surface-home .f-animated-22-hero .animated-hero-main-content .animated-hero-content.surface-hl-nov-white .c-group a.c-call-to-action:not(.glyph-play) > span:after{
    background-color: #ffffff;
}
/*Holiday CR's Nov 158318,158317 END*/



/* Start Surface deals CTA Blue color */    

#surface-deals-new.c-uhf-nav-link {     

    background-color: #0067b8 !important;    
    color: white;    
}    

/* End Surface deals CTA Blue color */

/*Cr:160415-10Year video*/
@media screen and (min-width: 1084px) and (max-width: 1120px) {
.surface-home .surface-obd.animated-lifestyle-video.tenyear-heading .lifestyle-video-content p.c-heading-2{
    padding-top: 15px;
}
}/*for sentence case*/



body[class*="en-"] #mainContent.wdg-global a.c-call-to-action span,
body[class*="en-"] #mainContent.wdg-global.surfacecom a.c-call-to-action,
body[class*="en-"] #mainContent.wdg-global a.c-hyperlink:not(.supBlink),
body[class*="en-"] #mainContent.wdg-global a.c-hyperlink:not(.supLink),
body[class*="en-"] #mainContent.wdg-global a.c-hyperlink.f-image span,
body[class*="en-"] #mainContent.wdg-global .design-18 button.c-button,
body[class*="en-"] #mainContent.wdg-global .compare-design-en-us #filtercompareButton,
body[class*="en-"] #mainContent.wdg-global .compare-design-en-us .sticky-compare-content #compareButton
/*body[class*="en-"] #mainContent.wdg-global .hmc-results .mobile_wrapper .swatch-color .surface-swatch-color-name*/
/*body[class*="en-"] #mainContent.wdg-global .design-18 .results .m-content-placement [class*='device-'].m-content-placement-item .swatch-color .surface-swatch-color-name*/
/*#mainContent.wdg-global .design-18 button.c-button:not(.back)*/
{
    text-transform : lowercase;
   
}

body[class*="en-"] #mainContent.wdg-global a.c-call-to-action span,
body[class*="en-"] #mainContent.wdg-global.surfacecom a.c-call-to-action,
body[class*="en-"] #mainContent.wdg-global a.c-hyperlink:not(.supBlink),
body[class*="en-"] #mainContent.wdg-global a.c-hyperlink:not(.supLink),
body[class*="en-"] #mainContent.wdg-global a.c-hyperlink.f-image span,
body[class*="en-"] #mainContent.wdg-global .design-18 button.c-button:not(.back),
body[class*="en-"] #mainContent.wdg-global .design-18 button.c-button:not(.start-over),
body[class*="en-"] #mainContent.wdg-global .design-18 button.c-button:not(.see-result),
body[class*="en-"] #mainContent.wdg-global .compare-design-en-us #filtercompareButton,
body[class*="en-"] #mainContent.wdg-global .compare-design-en-us .sticky-compare-content #compareButton
/*body[class*="en-"] #mainContent.wdg-global .design-18 .results .m-content-placement [class*='device-'].m-content-placement-item .swatch-color .surface-swatch-color-name*/
/*#mainContent.wdg-global .design-18 button.c-button:not(.back,.start-over,.see-result)*/
{
    text-transform : inherit !important;
   
}

body[class*="en-"] #mainContent .compare-design-en-us .c-button::first-letter,
body[class*="en-"] #mainContent.wdg-global a.c-call-to-action span::first-letter,
body[class*="en-"] #mainContent.wdg-global .design-18 button.c-button::first-letter,
body[class*="en-"] #mainContent.wdg-global .compare-design-en-us #filtercompareButton::first-letter,
body[class*="en-"] #mainContent.wdg-global .compare-design-en-us .sticky-compare-content #compareButton::first-letter
{
 text-transform : capitalize;
}
/*end of sentence case*/


 .theme-light a.c-hyperlink.normal:active,.theme-light a.c-hyperlink.normal:hover,.theme-light a.c-hyperlink.normal
{
    font-weight: normal !important;
}

  .surface-margin-top-120px {
    margin-top: 50px;
}
.high-contrast-mode .surface-hero-pivot-multi-img :not(.f-disabled).c-pivot > ul > a.f-active:focus{background:transparent;}
.surface-margin-bottom-120px {
    margin-bottom: 80px; 
}
.overflow-x-hidden{
    overflow-x: hidden;
}
/*.en-sg .c-price{visibility:hidden !important;display: none;}*/
/* Adding css to make direction:rtl in ar-qa locale*/
html[lang="ar-qa"]{
        direction: rtl;
}
html[lang="ar-qa"] a.m-skip-to-main, a.m-skip-to-main:hover{
    left: 0;
}

/*End */
/** Spacings added by v-vinsan **/
.zh-cn .surface-j-panes [data-accprodbuyid=""].surface-bg-cta-blue {
    display: none;
}
.INTL-bussiness-product-placement li {
    width: 50% !important;
    float: none !important;
    margin: 0 auto;
}

.surface-margin-bottom-34px {
    margin-bottom: 34px;
}

.surface-margin-top-40px {
    margin-top: 30px;
}

.responsive-surface-margin-bottom-120px {
    margin-bottom: 100px;
}

.surface-margin-top-112px {
    margin-top: 115px;
}

.surface-margin-top-64px {
    margin-top: 64px;
}

.surface-margin-top-20px {
    margin-top: 20px;
}

.responsive-surface-margin-top-70px {
    margin-top: 55px;
}

.cos_surface-margin-top-50px {
    margin-top: 50px;
}
.cos-banner-margin-top-120 {
    margin-top: 15px;       
}

.price-margin-top-15 {
    margin-top: 15px;
}
.surface-margin-top-55px {
    margin-top: 55px;
}

.surface-margin-top-105px {
    margin-top: 105px;
}

.surface-margin-top-90px {
    margin-top: 90px;
}

.sp4home-margin-top-rich-content {
    margin-top: 120px;
}

.sp4home-margin-top-feature {
    margin-top: 90px;
}

.sp4home-5-hero-top-margin {
    margin-top: 50px;
}

.sp4home-3-hero-top-margin {
    margin-top: 110px;
}

.sp4home-ratings-top-margin {
    margin-top: 75px;
}

.sp4home-ratings-bottom-margin {
    margin-bottom: 28px;
}

.surface-margin-top-32px {
    margin-top: 32px;
}

.surface-margin-top-80px {
    margin-top: 80px;
}
.surface-pad-top-44px.wdg-pad-medium{
    padding-top: 44px;
}
.surface-pad-top-50px.wdg-pad-medium{
    padding-top: 50px;
}

.wdg-global .c-group a.c-call-to-action.x-hidden+a.c-call-to-action.surface-link-zero-padding-zero-margin {
    margin: 0;
    padding:0;
}

.wdg-pad-68 {
    padding-top:68px;
}

.wdg-pad-37 {
    padding-top:34px;
}

.wdg-pad-60 {
    padding-top:60px;
}

.wdg-pad-medium.title-banner {
    padding-top:30px;
    padding-bottom:40px;
}

.wdg-pad-medium.title-banner h1 {
    padding-top:0;
}


/*comparetomacipad css*/
.comparetomacipadbanner h2 {
    display: none;
}

.comparetomacipadbanner h2:first-child {
    display: block;
}
/*comparetomacipad css*/
.surface-top-banner-80px
{
    margin-top: -60px;
}


@media only screen and (max-width:1400px) {
    .sp4home-5-hero-top-margin {
        margin-top: 93px;
    }   
}

@media only screen and (min-width:1084px) {
/*    .hp-mosaic li.double div section
{
    padding-left: 72px !important;
}*/
    
.hp-mosaic .m-image-intro.f-align-bottom > div {

padding-left: 7% !important;
}
}



@media only screen and (max-width:1083px) {
        
    .sp4home-ratings-bottom-margin {
        margin-bottom: 6px;
    }

    .sp4home-ratings-top-margin {
        margin-top: 35px;
    }

    .sp4home-3-hero-top-margin {
        margin-top: 70px;
    }
    
    .sp4home-5-hero-top-margin {
        margin-top: 12px;
    }

    .sp4home-margin-top-feature {
        margin-top: 80px;
    }
    
    .sp4home-margin-top-rich-content {
        margin-top: 35px;
    }
   
    .surface-margin-top-112px {
        margin-top: 95px;
    } 
    
    .responsive-surface-margin-bottom-120px {
        margin-bottom: 80px;
    } 
    
    .responsive-surface-margin-top-70px {
        margin-top: 33px;
    }
    
    .surface-margin-top-20px {
        margin-top: 0px;
    }
    
    .cos_surface-margin-top-50px {
        margin-top: 30px;
    }
    
    .cos-banner-margin-top-120 {
        margin-top: 40px;       
    }
    
    .surface-margin-top-40px {
        margin-top: 40px;
    }
    
    .surface-margin-top-55px {
        margin-top: 35px;
    }
    
    .surface-margin-top-90px {
        margin-top: 70px;
    }
    
    .surface-margin-top-100px {
        margin-top: 85px;
    }
    
    .surface-image-richblock picture {
        display: inline-block;
        width:100%;
    } 
    
    .surface-margin-top-32px {
        margin-top: 12px;
    }
    
    .surface-margin-top-80px {
        margin-top: 60px;
    }
    .en-us .wdg-global .Surface_Lg_hero-panel .c-group a.c-call-to-action.x-hidden+a.c-call-to-action
    {
        color:#fff !important;
      /*  margin-top:25px;*/
    }
    
    .en-us .wdg-global .Surface_Lg_hero-panel .c-group a.c-call-to-action.x-hidden+a.c-call-to-action.surface-secondary-cta {
        color: #0067b8 !important;
    }
    } 

.en-us .wdg-global .Surface_Lg_hero-panel .c-group a.c-call-to-action.x-hidden+a.c-call-to-action.surface-secondary-cta {
    padding-left: 0;
}

@media only screen and (max-width: 539px) {
    
    .sp4home-ratings-bottom-margin {
        margin-bottom: -12px;
    }
    
    .sp4home-ratings-top-margin {
        margin-top: 8px;
    }

    .sp4home-3-hero-top-margin {
        margin-top: 40px;
    }
    
    .sp4home-mobile-padding {
        padding-left: 17%;
        padding-right: 17%;
    }
    
    .sp4home-generic-product-placement-padding-top {
        margin-top: 21px;
    }

    .sp4home-5-hero-top-margin {
        margin-top: 33px;
    }
    
    .sp4home-margin-top-feature {
        margin-top: 60px;
    }
    
    .sp4home-margin-top-rich-content {
        margin-top: 30px;
    }
    
    .surface-margin-top-112px {
        margin-top: 75px;
    } 
    
    .surface-margin-top-64px {
        margin-top: 28px;
    }
    
    .responsive-surface-margin-top-70px {
        margin-top: -20px;
    } 
    
    .responsive-surface-margin-bottom-120px {
        margin-bottom: 60px;
    } 
    
    .cos_surface-margin-top-50px {
        margin-top: 0px;
    } 
    
    .cos-banner-margin-top-120 {
        margin-top:20px;       
    }
     #surface_cos_fp .createdonsurface-feature-panel .c-caption-1{
        margin-top: 20px;
    }
    .surface-margin-top-20px {
        margin-top: -20px;
    }
    
    .surface-margin-top-40px {
        margin-top: 22px;
    }
    
    
    .surface-margin-top-55px {
        margin-top: 15px;
    }
    
    .surface-margin-top-90px {
        margin-top: 50px;
    }
    
    .surface-margin-top-100px {
        margin-top: 65px;
    }

    .surface-margin-top-32px {
        margin-top: -8px;
    }
    
    .surface-margin-top-80px {
        margin-top: 40px;
    }
.IE11 .surface-custom-srm .m-system-requirements.f-single-column .c-table th{
    display:block;
}
.IE11 .surface-custom-srm .m-system-requirements.f-single-column .c-table{
    overflow:hidden;
}
}

/** ------------------------------------------------ **/
/**    Spacings added by v-vinsan in order to fix vertical spacing       **/

.cleanVerticalSpace {
    margin-top: 0px !important;
    padding-top: 0px !important;
}

.negative10pxVerticalSpace {
    margin-top: -10px !important;
    padding-top: 0px !important;
}

.negative15pxVerticalSpace {
    margin-top: -15px !important;
    padding-top: 0px !important;
}

.surface-banner-divider .m-banner.headingAdjusted {
    margin: 33px 0 30px 0;
    padding: 0px;
    max-width: 100%; /* default value of 1000 px overwrite */
}

@media only screen and (max-width: 539px) {
    .surfaceMobileMarginTop28 {
        margin-top: 28px !important;
    }  
.surface-caption-text .surface-featurevideo-text .c-caption-1
{
padding-top:15px;
}
 .createdonsurace_top .c-caption-1
{
padding-top:40px;
}
.c-mosaic [data-f-mosaic~=f-height-large].theme-dark
{
height:400px;
}
}
@media only screen and (max-width: 768px) {
.c-mosaic [data-f-mosaic~=f-height-large].theme-dark
{
height:400px;
}
}

/** ------------------------------------------------ **/

.surface-margin-top-15px {
    margin-top: -20px;
}

.surface-padding-top-15px {
    margin-top: 15px;
}

.surface-margin-bottom-15px {
    margin-bottom: 20px;
}

.surface-margin-top-70px
{
     margin-top: 15px;
}
.c-divider.surface-margin-top-70px {
    margin-top: 30px;
}

.surface-margin-bottom-70px {
    margin-bottom: 30px;
}

.surface-margin-top-50px {
    margin-top: 10px;
}

.surface-linebreak {
    font-weight: inherit;
    display: block;
}

#surface-Studio-Innovation .surface-studio-feature-play-panel .m-feature,#surface-book-innovation .surface-book-feature-play-panel .m-feature {
    margin-top: 20px;
}

/**Techspecs css*/
#surface-Studio-techspec .surface-studio-Video {
    margin-top: 45px;
}

@media only screen and (min-width: 540px) {  
   /*.Chrome .surface-accessoriesgrid .surface-product-items{
        display: table;
    }*/
    .surface-margin-top-120px {
        margin-top: 70px;
    }
    
    .surface-margin-top-15px {
        margin-top: 0px;
    }

    .surface-margin-top-70px
    {
        margin-top:35px
    }
    
    .c-divider.surface-margin-top-70px {
        margin-top: 55px;
    }
    
    .surface-margin-bottom-70px {
        margin-bottom: 55px;
    }
    
    .surface-margin-bottom-120px {
        margin-bottom: 100px;
    }
    
    .surface-margin-top-50px {
        margin-top: 30px;
    }
  .surface-top-banner-80px
{
    margin-top: -40px;
}
    
}
/*@media only screen and (min-width: 1567px) and (max-width: 1580px){  
   .Chrome .surface-accessoriesgrid .surface-product-items{
        display: block;
    }
    }*/
@media only screen and (min-width: 1084px) {
    .surface-margin-top-120px {
        margin-top: 84px;
    }
    
    .surface-margin-top-15px {
        margin-top: -20px;
    }
    
    .surface-margin-top-70px
    {
        margin-top:55px;
    } 
    
    .c-divider.surface-margin-top-70px {
        margin-top: 70px;
    }
    
    .surface-margin-bottom-70px {
        margin-bottom: 70px;
    }
    
    .surface-margin-bottom-120px {
        margin-bottom: 120px;
    }
    
    .surface-margin-top-50px {
        margin-top: 50px;
    }
    
    .surface-pivot-hero-mob-margin .c-pivot {
        padding-top: 20px;
    }
   .surface-top-banner-80px
{
    margin-top: -20px;
}

}

@media only screen and (max-width: 539px) {
    
    .surface-Pivot-mob-margin.surface-margin-top-15px {
        margin-top: 0px;
    }
    
    #surface-Studio-Innovation .surface-Pivot-mob-margin {
        margin-top: 70px;
        margin-bottom: 70px;
    }
    
    #surface-Studio-Innovation .m-hero-item .c-pivot>header>a,
    #surface-book-innovation .m-hero-item .c-pivot>header>a {
        padding-right: 0px;
    }
    
    #surface-Studio-Overview .surface-hth-mob-margin {
        margin-top: 70px!important;
    }
    
    .surface-studio-Generic-Banner {
        margin-top: -14px;
    }
    
     #surface-Studio-Overview .surface-studio-transparent-hero .m-hero-item:before{
    padding-bottom:50.5%;
}

    .m-banner a.c-call-to-action.c-glyph.surface-cta-stacked {
        margin-left:0px;
        margin-right:0px;
    }

    .surface-specsbanner .m-rich-content-block .surface-indivspecs-container {
        padding-bottom: 36px;
    }
    
    .surface-specsbanner .m-rich-content-block .surface-indivspecs-container:last-child {
        padding-bottom: 0px;
    } 
    
    .sp4-officeapps .c-apps-panel .apps-wrapper{
        padding-top:24px;
}

    .sp4-officeapps .m-banner .c-paragraph-3,.sp4-officeapps .m-image{
        padding-top:30px;
}
}
 #surface-Studio-Innovation .surface-specsbanner hr:last-child{
         border:none;
     }

/*-----------------youtube player custom css-------------------*/

.surface-youtubevidplayer {
    position: relative;
}



.surface-youtubevidplayer .surface-youtubevidplayer-playicon {
    top: 50%;
    left: 50%;
    transform: translate(-50%,-50%);
    -webkit-transform: translate(-50%,-50%);
    -moz-transform: translate(-50%,-50%);
    -o-transform: translate(-50%,-50%); 
    position: absolute;
}

.surface-youtubevidplayer .multivideosplayer .mscom-link.mscom-popup-link {
    display: none;
} 

.surface-youtubevidplayer .surface-youtubevidplayer-posterimagewrap img {
    width: 100%;
    max-width: 100%;
    height: auto;
}

.surface-youtubevidplayer .mscom-popup-content  {
    text-align: center;
}

@media only screen and (min-width:1084px) {
    .surface-youtubevidplayer.f-no-image-priority {
    overflow: auto;
}
    .surface-youtubevidplayer.f-no-image-priority .surface-youtubevidplayer-playicon {
        left: 25%;
    }
}
.c-feature.f-align-left.f-image-priority .surface-youtubevidplayer
{
    float:right;
}
.surface-youtubevidplayer .m-hero-item.f-transparent .c-heading-1
{
    padding-top:0px;
} 
/*************************youtube player custom css end*****************/

/******OnePlayer video css*******/

.oneplayer-video .wdg-oneplayer-inline {
    height:0;
    padding-bottom: 41.7%;
    position: relative;
}

.oneplayer-video .wdg-oneplayer-inline iframe {
    position:absolute;
    top:0;
    bottom:0;
    height:100%;
    width:100%;
}

/***************End**************/

/*-------------------------MP4 video custom CSS-------------------------*/

.surface-video-overlay-controls {
    top: 0;
    position: absolute;
    width: 100%;
    height: 100%;
    z-index: 2;
}

.surface-video-overlay-controls>* {
    top: 50%;
    left: 50%;
    position: absolute;
    transform: translate(-50%,-50%);
    -webkit-transform:translate(-50%,-50%);
    -moz-transform:translate(-50%,-50%);
    -o-transform:translate(-50%,-50%);    
}

.surface-video-overlay-controls>.c-glyph {
    font-size: 50px;
    display: none;
}

.video.playing .surface-video-overlay-controls>.glyph-pause:focus,
.video.playing:hover .surface-video-overlay-controls>.glyph-pause,
.video.paused .surface-video-overlay-controls>.glyph-play,
.video.ended .surface-video-overlay-controls>.glyph-play {
    display: inline;
}

.video.playing .surface-video-overlay-controls>.glyph-play {
    display: none;
}
.video .c-video video{
    background: none;
}
    
/***************************MP4 Video custom css END*********************/

/*-------------------Compare to Mac Panel overrides START----------------------------*/

.surface-compare-text [class*=Compare-block-] {
   /* display: table;  --for compare table accessibility */
    width: 100%;
    padding-bottom: 10px;
}

.surface-compare-imgs>div>div>div,
.surface-compare-text [class*=Compare-block-]>[data-grid="col-6"] {
    width: 50%;
   /* display: table-cell; --for compare table accessibility*/
    padding-right: 6px;
}

.surface-compare-text [class*=techspecs-block-] [class*="c-heading"] {
    padding-top:10px;
}
        
@media only screen and (min-width:1084px) and (max-width:1400px) { 
     .sp4home-3-hero-top-margin {
        margin-top: 140px;
    }
  .m-hero-item.surface-content-width-450>div>div,
  .c-hero.surface-content-width-450>div>div {
        max-width: 450px;        
   }
 /*  .m-hero-item.f-y-center.f-transparent>div>div{
    top:120px;
    transform:none;
}*/

.surface-lowdesk-max-height:before
{
padding-bottom :55%; 
}

#surface-Studio-Overview .surface-studio-transparent-hero .m-hero-item:before{
    padding-bottom:62.2%;
}

}
@media only screen and (min-width:1084px) and (max-width:1200px) { 
    .m-hero-item.f-y-center.f-transparent.surface-lowdesk-lesstop>div>div{
         top:40px;
         transform: none;
    }
    
    #surface-Studio-Overview .surface-studio-transparent-hero .m-hero-item>div>div{
bottom:30px;
}
}

@media only screen and (max-width: 767px) {
    .m-system-requirements.surface-techspecspanel>div[data-grid='col-6']:nth-child(3) .c-table{
        padding-top: 10px;
        border-top: 1px solid rgba(0,0,0,.2);
    } 
    
    .surface-z-techspecs .m-system-requirements>div[data-grid='col-6']:nth-child(3) .c-table
    {
        border-top: 0;
    }
    .surface-compare-text [class*=techspecs-block-] [class*="c-heading"] {
        padding-top: 15px;
    }
    
    .c-apps-panel .apps-wrapper .apps-right-section {
        padding-bottom: 5px;
    }
    .surface-td-fontweight table tr:first-child td{
        padding-top:0px;
        padding-bottom:1px;
        }
        .surface-z-techspecs .surface-td-fontweight table tr:first-child td
        {
            padding-top:10px;
            padding-bottom:10px;
        }
        .m-system-requirements .surface-td-fontweight table tr:first-child td{padding-bottom:12px;}
        .m-system-requirements.surface-techspecspanel .c-heading-3{
         padding-bottom:15px;}
              .surface-compare-deviceimgblock.surface-compare2-deviceimgblock .m-content-placement>div>div{
           width:50%;
           display:inline-block;
           
              }          
}

@media only screen and (max-width: 767px) {
    
     #surfaceComparedevices-2 .surface-compare-deviceimgblock .surface-compare-2 {
        width: 50%;
        /*display: inline-block;*/
        float: left;
    }    
    
    .m-content-placement .surface-compare-2 {
        width:50%;
        float:left;
    }
    
}

@media only screen  and (max-width:539px) {
    
    .m-hero-item.surface-content-mob-height-330>div,
    .c-hero.surface-content-mob-height-330>div {
        height: 330px; 
    }
    
    .m-hero-item.surface-content-mob-height-380>div,
    .c-hero.surface-content-mob-height-380>div {
        height: 380px;    
    }  
    
   
    
}

.m-hero-item.surface-content-fullbleedmaxwidth>div,
.c-hero.surface-content-fullbleedmaxwidth>div {
    max-width: 1600px;
}

/*****************Compare to Mac Panel overrides END *****************/

/*
.surface-techspec-Popup-images .m-content-placement-item picture {
    cursor: pointer;   
}
*/

.surface-pivot-image {
    width: 36px; 
    height: 36px;
}



/*-------------------Specs Banner Panel overrides START----------------------------*/

.surface-specsbanner .m-rich-content-block,
.surface-specsbanner .c-divider {
    margin: 0 auto;
    float: none;
}

.dividers + .dividers .c-divider {
    display:none;
}

.surface-specsbanner .surface-indivspecs-container > div > *, 
.surface-performance-specsbanner .surface-indivspecs-container > div > *{
    display: inline-block;
}


.surface-specsbanner .spec-val,
.surface-specsbanner .spec-name,
.surface-performance-specsbanner .spec-val,
.surface-performance-specsbanner .spec-desc {
     padding-top: 0;
     padding-bottom: 0;
} 

.surface-performance-specsbanner .m-rich-content-block {
    margin-top: 0;
    position: relative;
    padding-top: 0;
}

@media only screen and (min-width: 540px) {

    .surface-performance-specsbanner {
        display: -webkit-flex;
        display: -moz-flex;
        display: -ms-flexbox;
        display: -o-flex;
        display: flex;        
        -ms-flex-pack:center;
        -ms-flex-align:center;  
        justify-content: center;
        align-items: center;
    }
    
    .m-banner a.c-call-to-action.c-glyph.surface-cta-stacked {
        margin-left: 0px;
    }

}

@media only screen and (min-width:1084px) { 
  .wdg-global .surface-specsbanner .m-rich-content-block,
   .surface-performance-specsbanner .surface-indivspecs-container {
       padding-top: 34px;
       padding-bottom: 44px;
   }
} 

@media only screen and (max-width:1083px) {
  .c-feature .surface-youtubevidplayer {
      z-index:2;
      
  }
    .surface-specsbanner .m-rich-content-block,
    .surface-specsbanner .c-divider, 
    .surface-performance-specsbanner .m-rich-content-block, 
    .surface-performance-specsbanner .c-divider {
        width: 100%;
    }
  .surface-performance-specsbanner .surface-performance-specswrap {
        margin-top: 48px;
    }
    .surface-specsbanner .m-rich-content-block,
    .surface-performance-specsbanner .surface-indivspecs-container {
        padding-top: 20px;
        padding-bottom: 32px;
    }
  
   /*specific to tablet*/
    .surface-studio-Generic-Banner{
        margin-top:40px;
    }
    .createdonsurface-hero .c-caption-1{
padding-bottom:10px;
}
    
}  
 
@media only screen and (max-width:539px) { 
    
    /* Changed by v-vinsan in order to reduce vertical space in mobile viewports*/ 
    
    .surface-specsbanner .m-rich-content-block,
    .surface-performance-specsbanner .surface-indivspecs-container {
        padding-top: 10px;
        padding-bottom: 10px;
    }
    
    /**.surface-specsbanner .surface-indivspecs-container[data-grid='col-3']{float:left;width:25%;}
    .surface-performance-specsbanner .surface-indivspecs-container[data-grid='col-4']{float:left;width: 33.3333333333%;}**/
    
    .surface-performance-specsbanner .surface-performance-article {
        text-align: center;
    }
    
    

}     

/*************************************Specs Banner Panel overrides END**********************************/

@media only screen and (min-width:768px) and (max-width:1083px) {
    .c-hero.surface-content-height-450>div, 
    .m-hero-item.surface-content-height-450>div {
        height: 450px;
    }
}

/***Call to action with glyph-play override START***/

.c-call-to-action.c-glyph.glyph-play:before {
    margin-right: 4px;
    top:-1px;
    position: relative;
}
/*.Safari .c-call-to-action.c-glyph.glyph-play:before {
    top:2px;
}*/

/***Call to action with glyph-play override END***/

/***Overwrite for the price float START***/

@media only screen and (max-width:1083px) {
    .c-price.x-type-center span {
        float: none;
    }
}

/***Overwrite for the price float END***/


/***Overwrite for the heading that goes after the paragraph START***/

.c-paragraph-2+.c-heading-2 {
    padding-top: 20px;
}

/***Overwrite for the heading that goes after the paragraph END***/

/*** Overwrite c-call-action to align with c-action-trigger in c-group***/

.surface-youtubevidplayer .c-group .c-call-to-action.c-glyph {
    font-size: 15px;
    margin-left: 0px;
    padding-bottom: 0px;
}

/*** Overwrite c-call-action to align with c-action-trigger in c-group END***/

/*-----------------Compare Page device selection logic----------------*/

.surface-compare-deviceimgblock .c-checkbox,
.surface-compare-deviceimgblock .m-content-placement .surface-devices-button button.c-button,
.surface-compare-banner .surface-compare-mobview {
    display: none;
}

.surface-compare-stickybar {
    display: none;
}

.surface-compare-stickybar.stick {    
    width: 100%;    
    position: fixed;
    z-index: 10;
    top: 0;  
    background-color: rgba(255,255,255,1);    
}

.surface-compare-stickybar .m-content-placement-item {
    margin-top: 0;
}

/*.surface-compare-stickybar .m-content-placement-item>a>* {
    display: inline-block;
}*/

@media only screen and (min-width:540px) {
    
    .surface-compare-stickybar.stick {
        display: block;    
        left: 50%;
        transform: translateX(-50%);
        -webkit-transform: translateX(-50%);
        -moz-transform: translateX(-50%);
        -o-transform: translateX(-50%); 
    }
    
    .surface-compare-c-chart{
        padding-top: 15px;
    }
   
}

/* MWF consider max-width: 768px to override there css we are considering max-width 768px*/
/*
@media only screen and (max-width:768px) {
   
    .surface-compare-devices tr[class*='Compare-block-']>[class*='c-heading'] {
        width:100%;
    }
    
    .surface-compare-devices tr[class*='Compare-block-']>[class*='techspecs-block-'] {
        width:33.3333333333%;
    }
    
    .surface-compare-devices tr[class*='Compare-block-']>[class*='techspecs-block-'][data-grid="col-6"] {
        width:50%;
    }

}
*/
@media only screen and (max-width:767px) {
    
    .wdg-global .surface-compare-deviceimgblock .m-content-placement>div>div~div .m-content-placement-item:not(.wdg-mar-pad-x-reset) {
        margin-top: 0;
    }
    
    .surface-compare-stickybar {
        display: none;
    }
    #surfaceComparedevices-2 .surface-compare-stickybar.stick,
    .surface-compare-stickybar.surface-compare-active.stick {
        display: block;
    }
    #surfaceComparedevices-2 .surface-compare-stickybar.stick .m-content-placement>div>div,
    .surface-compare-deviceimgblock.surface-compare-active .m-content-placement>div>div,
    .surface-compare-stickybar.surface-compare-active.stick .m-content-placement>div>div {
        width: 50%;
        float: left;
    }
    
   /* .surface-compare-devices tr[class*='Compare-block-']>[class*='techspecs-block-'] {
        width: 50%;
    }*/
    
    .surface-compare-devices,
    .surface-compare-banner p,
    .surface-compare-banner.surface-compare-active p.surface-compare-mobview {
        display: none;
    }
    
    #surfaceComparedevices-2 .surface-compare-devices,
    .surface-compare-devices.surface-compare-active,
    .surface-compare-banner p.surface-compare-mobview,
    .surface-compare-banner.surface-compare-active a.surface-compare-mobview {
        display: block;
    }
    
    .surface-compare-banner.surface-compare-active a.surface-compare-mobview {
        margin: 0 auto;
    }
    
    #surfaceComparedevices-2 .surface-compare-devices td[class*='techspecs-block-'],
   /* .surface-compare-devices.surface-compare-active td[class*='techspecs-block-']*/ {
       float:left;
    }
    
    .surface-compare-deviceimgblock .c-checkbox,
    .surface-compare-deviceimgblock .m-content-placement .surface-devices-button button.c-button {
        display: block;
    }
    
    .surface-compare-deviceimgblock.surface-compare-active .c-checkbox,
    .surface-compare-deviceimgblock.surface-compare-active .m-content-placement .surface-devices-button button.c-button {
        display: none;
    }
    
    .surface-compare-deviceimgblock .m-content-placement  .surface-devices-button{
        width: 100%;
        display: inline-block;
    }
    
    .surface-compare-deviceimgblock .m-content-placement .surface-devices-button .c-button {
        text-align: center;
        margin: 0 auto;
        margin-top: 50px;
        display: block;
    }
    
    .surface-compare-stickybar .hide {
        display: none!important;
    }
    
    .surface-compare-devices.surface-compare-active td.hide[class*='techspecs-block-'],
     .surface-compare-devices.surface-compare-active th.hide[class*='techspecs-block-'] {
        display: none;
    } 

}

@media only screen and (min-width:540px) and (max-width:1083px) {
    #surface-Studio-Overview .surface-studio-transparent-hero .m-hero-item:before {
        padding-bottom:42.5%;
    }
}
/***  ContentRichBlock with Image CSS ***/
  
.surface-image-richblock .m-rich-content-block .c-paragraph-3 {
    padding-bottom: 20px;
}

.surface-image-richblock .m-rich-content-block {
    margin-bottom: 48px;
}

.surface-image-richblock .c-menu {
    width: 100%;
}

.surface-image-richblock .c-select-menu {
    margin-bottom: 20px;
    display: inline-block;
}

.surface-image-richblock .c-select-menu ul {
    border-left-width: 0px;
}

.surface-image-richblock .c-select-menu .surface-dropdown:hover, a.back-to-top-button {
    cursor:pointer;
}

@media only screen and (min-width: 1400px) {
    
    .surface-image-richblock .c-select-menu.f-border {
        width: 100%;
        max-width: 365px;
    }
    .surface-image-richblock a.surface-dropdown {
        width:inherit;
        height:inherit;
    }
}

@media only screen and (min-width: 1084px) and (max-width: 1399px) {
    .surface-image-richblock .c-select-menu.f-border {
        width: 100%;
        max-width: 373px;
    }
    .surface-image-richblock a.surface-dropdown {
        width:inherit;
    }
        .surface-image-richblock .c-menu {
         max-width: 373px;
    }
}

@media only screen and (min-width: 540px) and (max-width: 1083px) {
    
    .surface-image-richblock .c-select-menu.f-border {
        width: 100%;
        max-width: 368px;
    }
    
    .surface-image-richblock a.surface-dropdown {
        width: 100%;
        height: inherit;
    }
}

@media only screen and (max-width: 539px) {
    
    .surface-image-richblock .c-select-menu.f-border {
        width: 100%;
    }
    
    .surface-image-richblock .c-select-menu.f-border .surface-dropdown {
        width: 100%;
        max-width: 368px;
    }
}

@media only screen and (max-width:1083px) {
    /*
    .surface-image-richblock .surface-contentrich-block {
        width: 83.3%;
    }
    */
    
    .surface-contentrich-block .c-price span {
        float: none;
    }
    
}

/*** ContentRichBlock with Image CSS END***/

/*** Accessories Browse page css ***/

.surface-accessoriesgrid .surface-productcategoryfilter.dropdownActive .surface-products-category {
    display: none;
}
.surface-product-items {
    width: 25%;
   padding-left: 12px;padding-right:12px;
    float:left;
}
.surface-accessoriesgrid .surface-productcategoryfilter.dropdownActive .surface-products-category.userSelected {
    display: block;
}

.surface-accessoriesgrid .hide {
    display: none;
}

.surface-accessories-categories {
       margin-top: 25px;
    }

.surface-accessoriesgrid .c-choice-summary.surface-selections {
    background: none;
    padding: 9px 0 10px 0px;
}

.surface-accessoriesgrid .c-choice-summary {
    margin-top:24px;
}


.surface-accessoriesgrid li[data-tagid="all"] button {
    display: none;
}

.surface-accessoriesgrid .c-pivot img,
.surface-accessoriesgrid .c-group img {
    width: 100%;
}

#surfaceAllAccessories_Browse .surface-collections a:active {
    border-color: #000;
}

/*#surfaceAllAccessories_Browse .surface-devicetype .c-menu-item a:focus {
    outline: none!important;
}
*/

.surface-accessoriesgrid .surface-collections .c-menu-item .c-label span {
    padding-top: 2px;
    padding-bottom: 0px;
    background: none;
    pointer-events: none;
}

.surface-accessoriesgrid .c-menu-item a {
    cursor: default;
}

.surface-accessoriesgrid .surface-devicetype a,.surface-accessoriesgrid a.showdrop{
     cursor: pointer;
    
}

.surface-accessoriesgrid  .surface-collections .c-menu-item a{
     padding: 0px;
}
.surface-accessoriesgrid  .c-menu-item .c-label {
    display: inline-block;
    cursor: pointer;
    margin-top: 0px;
}

.surface-accessoriesgrid .surface-collections .c-menu-item .c-label  {
     display: block;
     padding: 11px 12px 13px;
     margin-right: 0px;
}
.surface-accessoriesgrid .surface-devicetype a, 
.surface-accessoriesgrid .surface-collections a, 
.surface-accessoriesgrid .surface-collections .c-menu, 
.surface-accessoriesgrid .surface-devicetype .c-menu {
    width: 365px;
}

.surface-accessoriesgrid .surface-devicetype {
    padding-left: 38px;
}

.surface-productcategoryfilter .surface-products-category .padding-top-48px h2,
.surface-productcategoryfilter .surface-products-category .padding-top-48px h3,
.surface-productcategoryfilter .surface-products-category .padding-top-48px p,
.surface-nomatchFoundText {
    padding-left: 36px;
    padding-right: 36px;
}

.surface-collections .c-menu .c-menu-item a, .surface-accessoriesgrid .surface-devicetype a,.surface-collections .c-menu .c-menu-item a:hover,.surface-collections .c-menu .c-menu-item a:focus {
    background: rgba(0,0,0,0);color:#000;
}

	/*.surface-collections .c-menu .c-menu-item a:active,.surface-collections .c-menu .c-menu-item a:focus  {
    background: rgba(0,0,0,.3);
    outline: 0;
}*/

.surface-accessoriesgrid .surface-collections .c-menu, .surface-accessoriesgrid .surface-devicetype .c-menu{
    border:1px solid rgba(0,0,0,1);
    border-top:0;
}
.IE11 .surface-accessoriesgrid .surface-collections .c-menu,.IE11 .surface-accessoriesgrid .surface-devicetype .c-menu{
    border:1px solid rgba(0,0,0,1)!important;
    border-top:0 !important;
    bottom:auto !important;
}
.surface-accessoriesgrid .surface-devicetype .c-menu .c-radio:active {
    outline: 0;
}

#surfaceAllAccessories_Browse .surface-accessoriesgrid .surface-tags {
      padding-left: 38px;
}

#surfaceAllAccessories_Browse .surface-tags button.c-action-trigger:hover,
{
    text-decoration: none ;
}

#surfaceAllAccessories_Browse .surface-accessoriesgrid .surface-tags li:first-child {
    background-color: inherit;
    color: inherit;
}

#surfaceAllAccessories_Browse .surface-accessoriesgrid .surface-accessories-divider {
    margin-top: 24px;
}

#surfaceAllAccessories_Browse .surface-product-items .c-heading-3,
#surfaceAllAccessories_Browse .m-content-placement .surface-product-items .m-content-placement-item .c-heading-4 {
    padding-top: 0px;
}

.surface-accessories-text {
    font-size: 11px;
}

.surface-accessories-text sup {
    font-size: 8px;
}

.surface-accessoriesgrid .c-group.surface-swatch-colors .surface-multiview-trigger {
    display: inline-block;
    margin: 6px 5px 0 0;
    position: relative;
    overflow: visible;
    width: 25%;
    max-width: 40px;
    height: 20px;
    cursor: pointer;
   
 }
 .surface-accessoriesgrid .c-group.surface-swatch-colors .surface-multiview-trigger span {
  border:2px solid;
  }

.surface-accessoriesgrid .c-group.surface-swatch-colors .surface-multiview-trigger.swatchhover span {
     display: block;    
}

.surface-accessoriesgrid .c-group.surface-swatch-colors{
    text-align: center;
    display: inherit;
}

.surface-accessoriesgrid .c-group.surface-swatch-colors .surface-multiview-trigger span {
    display: block;
    position: absolute;
    top: -30px;
    left: 0;
    white-space: nowrap;
    background: #fff;
    height: 25px;
    padding: 0 10px;
    z-index: 1;
    display: none;
}

.surface-accessoriesgrid .c-group.surface-swatch-colors .surface-multiview-trigger.swatchclick {
    cursor: default;
}
    
/*.surface-product-items .c-group .c-call-to-action {
    margin-right: 14px;
    padding-right: 40px;
}*/

.surface-accessoriesgrid .surface-product-items picture img {
    min-height: 110px;
}

*::-ms-backdrop,.surface-accessoriesgrid .surface-product-items .accessories-tout-images{
    display: inline-flex;

}

/*.surface-accessoriesgrid .surface-product-items .surface-multiview-trigger{
     margin-top:12px;
}*/

.surface-accessoriesgrid .surface-product-items .c-group.surface-swatch-colors{
    margin-top:0px;
}
/*.surface-accessoriesgrid .surface-product-items .accessories-touts-margin{
   margin-top:6px;
}*/

.surface-accessoriesgrid .surface-nomatchFoundText.hide {
    display: none;
}

/*updating for release accessability issues as version change is causing the issue*/

#surfaceAllAccessories_Browse .surface-accessories-browse-hero.m-hero-item>div>div{
max-width:520px !important;
width:100%;
}

/*Accessories browse new checkbox functionality*/
.surface-collections-1 .c-checkbox label.c-label, .surface-collections-2 .c-checkbox label.c-label{
    width:100%;
}

.selectdevcat:after{
    content: "\E70E" !important;
}

.surface-filter-list{
    margin-top: 15px;
}
.surface-filterby{
    padding:0 36px 20px 36px;
}
.surface-clearfilters .c-button{
font-size: 13px;
background: #006cc2;
}

.surface-clearfilters{
padding-top:34px;
}

.surface-filter-list .c-select-menu .c-checkbox label.c-label{
    line-height:22px;
}

.surface-filter-list .c-select-menu .c-checkbox label.c-label input:focus{
    border:2px dotted black;
}

.c-badge.f-small.sfc-accessories-newtext{
    vertical-align:top;
    height:20px;
    line-height: 20px;
}

.c-checkbox input[type=checkbox]:disabled+span .c-badge.f-highlight.sfc-accessories-newtext{
    color:rgba(0,0,0,.2);
}

.c-badge.sfc-accessories-newtext:empty{
    display: none;
}



@media only screen and (min-width: 768px) {
.surface-collections-1 .c-checkbox div>div, .surface-collections-2 .c-checkbox div>div{
    column-count: 2;
}

.surface-filter-list .c-checkbox .c-label.dropdown-desktop{
padding: 4px 0 8px;
font-weight: 200;
font-size: 24px;
line-height: 28px
}

.c-select-menu.surface-devicetype.f-border{
    margin-top:12px;
}

.surface-filter-list .c-select-menu .c-checkbox>div{
    display: block !important;
}

.c-divider.surface-accessories-divider.surface-filterby-divider{
clear:both;
margin-left:36px;
margin-right:36px;

}

}

@media only screen and (max-width: 767px) {
.dropdown-mobile{
    display: block !important;
    width: 100%;
    padding-bottom:15px;
    padding-top:10px;
    cursor: pointer;
}
.dropdown-desktop{
    display: none;
}
.c-select-menu.surface-collections{
    display:block;
    float: none;    
}

.surface-accessories-categories .surface-filter-list .c-select-menu{
    clear:both;
}

.dropdown-mobile:after {
    content: "\E70D";
    display: inline-block;
    vertical-align: top;
    font-family: MWF-MDL2;
    position: absolute;
    right: 10px;
}

.surface-accessories-categories .surface-filter-list .c-select-menu.f-border [aria-expanded]{
border-bottom:1px solid rgba(0, 0, 0, .2) !important;
border-top:none;
border-left:none;
border-right: none;
margin-left:0px;
}

.surface-filter-list [data-grid~=col-6]{
width:95%;
}

.surface-filter-list .c-select-menu .c-checkbox>div{
    display: none;
}

.c-select-menu.surface-devicetype .dropdown-mobile.selectdevcat+div{
    padding-bottom:35px;
}

.surface-accessories-divider{
    width:95%;
}

.surface-filterby div{
    width:50%;
}

.surface-filterbyhdng{
    float:left;    
}

.surface-clearfilters{
    float:right;
}

.surface-filterby{
    padding:0 36px 5px 36px;
}
}

@media only screen and (max-width: 539px) {
    .c-select-menu.surface-devicetype .dropdown-mobile.selectdevcat+div{
    padding-bottom:25px;
}
}
/*Accessories browse new checkbox functionality end*/


@media only screen and (min-width: 1400px) {
    
    .surface-accessoriesgrid .surface-product-items picture img {
        min-height: 150px;
    }
    
    .surface-accessoriesgrid .surface-devicetype {
        padding-left: 48px;
    }
 
    #surfaceAllAccessories_Browse .surface-accessoriesgrid .surface-tags {
        padding-left: 48px;
    }

    .surface-productcategoryfilter .surface-products-category .padding-top-48px h2,
    .surface-productcategoryfilter .surface-products-category .padding-top-48px h3,
    .surface-productcategoryfilter .surface-products-category .padding-top-48px p,
    .surface-nomatchFoundText {
        padding-left: 48px;
        padding-right: 48px;
    }
    
    #surface-Studio-Overview .surface-studio-transparent-hero .m-hero-item:before {
        padding-bottom:62.2%;
    }
    
    #surface-Studio-Overview .surface-studio-transparent-hero .m-hero-item>div>div {
        bottom:15%;
    }

}

@media (min-width: 768px) and (max-width: 1083px) {
    
    .surface-accessoriesgrid .surface-devicetype a,
    .surface-accessoriesgrid .surface-collections a,
    .surface-accessoriesgrid .surface-collections .c-menu,
    .surface-accessoriesgrid .surface-devicetype .c-menu {
        width: 325px;
    }
    
    .surface-accessoriesgrid {
        margin-top: 30px;
    }
}

@media screen and (max-width: 767px) {

    .surface-accessoriesgrid .surface-collections, 
    .surface-accessoriesgrid .surface-devicetype,
    #surfaceAllAccessories_Browse .surface-accessoriesgrid .surface-tags {
        padding-left: 26px;
    }

    .surface-productcategoryfilter .surface-products-category .padding-top-48px h2,
    .surface-productcategoryfilter .surface-products-category .padding-top-48px h3,
    .surface-productcategoryfilter .surface-products-category .padding-top-48px p {
        padding-left: 24px;
        padding-right: 24px;
    }
    
    .surface-accessoriesgrid {
        margin-top: 30px;
    }
    
    .surface-compare-deviceimgblock .c-checkbox {
        margin-top:10px;
    }
    
    .wdg-global #surfaceAllAccessories_Browse .m-content-placement>div>div~div .m-content-placement-item, 
    .wdg-global #surfaceAllAccessories_Browse .m-content-placement>div>div~div>div .m-content-placement-item{
    margin-top:0px;
    }
 }

@media only screen and (max-width: 539px) { 
     
     .surface-accessoriesgrid .surface-product-items picture img {
        min-height: auto;
    }
    
    .surface-accessoriesgrid .surface-devicetype a, 
    .surface-accessoriesgrid .surface-collections a, 
    .surface-accessoriesgrid .surface-collections .c-menu, 
    .surface-accessoriesgrid .surface-devicetype .c-menu {
        width: 275px;
    }
    
    .surface-accessoriesgrid .surface-collections, 
    .surface-accessoriesgrid .surface-devicetype,
    #surfaceAllAccessories_Browse .surface-accessoriesgrid .surface-tags {
        padding-left: 12px;
    }
    
    .surface-productcategoryfilter .surface-products-category .padding-top-48px h2,
    .surface-productcategoryfilter .surface-products-category .padding-top-48px h3,
    .surface-productcategoryfilter .surface-products-category .padding-top-48px p, 
    .surface-nomatchFoundText {
        padding-left: 12px;
        padding-right: 12px;
    }

}

@media screen and (max-width: 1083px){
  
    .surface-accessoriesgrid  .surface-product-items {
        width: 50%;
    }
    
   /* #surfaceAllAccessories_Browse .surface-accessories-browse-hero:before {
        padding-top: 55.2%;
    }*/
}

@media screen and (max-width: 539px){
    .surface-accessoriesgrid .surface-product-items {
        width: 100%;
    }
}

.configpanelcarousel .surface-wmr-text:empty {
    background:none;
    border:none;
}

.surface-accessoriesgrid .surface-product-items .c-badge:empty,.c-badge:empty {
    display: block;
    background: none;
}
.m-content-placement-item .c-badge:empty{
    display: block;
}
.confgpanel-specsandprice .confgprice .c-badge:empty {
    background:none;
    display:none;
}

.m-content-placement .c-badge.f-highlight:empty {
    background:none;
}

.surface-accessoriesgrid .c-group.surface-swatch-colors .surface-multiview-trigger[data-color-code=""]{
    display: none;
}

@media only screen and (device-width: 768px) {
    .surface-accessoriesgrid .f-wrap-items.surface-tags li button.c-action-trigger:active,
    .surface-accessoriesgrid .f-wrap-items.surface-tags li button.c-action-trigger:active+span,
    .surface-accessoriesgrid .f-wrap-items.surface-tags li button.c-action-trigger:hover,
    .surface-accessoriesgrid .f-wrap-items.surface-tags li button.c-action-trigger:hover+span {
        background:none !important;
    }
}

/*** Accessories Browse page css END***/

/*** Business Overview Product Placement Item ***/

.m-product-placement.surface-business-touts ul li {
    float:left;
}

.m-product-placement.surface-business-touts .m-product-placement-item.f-size-medium>a>div {
    padding-right:0px;
}

.m-product-placement.surface-business-touts .m-product-placement-item.f-size-medium {
    width: auto;
}

.m-product-placement.surface-business-touts .m-product-placement-item picture img, 
.m-product-placement.surface-business-touts .m-product-placement-item picture {
    display: block;
    outline: transparent;
}

.m-product-placement.surface-business-touts picture.c-image img {
    margin:0 auto;
    
}

.m-product-placement.surface-business-touts {
    padding-top:0px;
}

.m-product-placement.surface-business-touts .m-product-placement-item {
    margin-top: 0px;
    margin-left: 24px;
}

.m-product-placement.surface-business-touts .c-heading-6 {
    padding-top:10px;
}

@media (min-width: 768px) and (max-width: 1083px) {

    .m-product-placement.surface-business-touts {
        width: 75%;
        float: none;
        margin: 0 auto;
    }
    .m-product-placement.surface-business-touts li {
        width: 33.33%;
    }

}

@media screen and (max-width: 767px) {
    
    .m-product-placement.surface-business-touts li {
        width: 50%;
    }
    
    .surface-compare-deviceimgblock .c-checkbox .c-label {
         margin-top: 0px;
    }
    .surface-360slider .surface-slidercomp{
        display: none!important;
    }
.surface-360slider .surface-rotatebox .surface-sliderimages{
    display: none!important;
}
.surface-360slider .surface-posterimage{
    display: block!important;
}
}

@media screen and (min-width: 1084px) {
    
    .m-product-placement.surface-business-touts .surface-touts-list {
        margin: 0 auto;
        float: none;
    }
    
    .m-product-placement.surface-business-touts ul li {
        width: 16.66%;
    }
    
    .m-product-placement.surface-business-touts ul li:last-child .m-product-placement-item {
        margin-right: 0px;
    }
    
}

/*** Business Overview Product Placement Item END ***/

.surface-business-twoup .m-content-placement a.mscom-link {
    border-left-width: 0px;
}

/*** Business Overview Pivot Panel ***/

.surface-hero-pivot .surface-pivot-content,
.m-feature .surface-pivot-content {
    margin: 0 auto;
    float: none;
    text-align: center;
}

.surface-hero-pivot .c-pivot>header {
    text-align: center;
    display: block;
}

.surface-hero-pivot .c-pivot>header>a,
.m-feature .c-pivot>header>a {
    padding-left: 0;
}

.m-multi-feature .c-logo.f-active .surface-grey-pivot-icon, 
.m-multi-feature .c-logo .surface-blue-pivot-icon {
    display: none;
}

.m-multi-feature .c-logo.f-active .surface-blue-pivot-icon {
    display: block;
}

@media screen and (max-width: 539px) {
    .surface-hero-pivot .surface-pivot-content,
    .m-feature .surface-pivot-content {
        padding-left: 24px;
        padding-right: 24px;
    }
}

@media screen and (min-width: 1084px) {
    .sp4-officeapps .m-banner .c-paragraph-3 {
        padding-top:55px;
    }
}

/*** Business Overview Pivot Panel END***/

/*** Content rich block center align***/
.m-feature .c-price a.supBLink,.m-multi-feature .c-price a.supBLink
{
    display: inline-flex;
    
}


.surface-crb {
    text-align: center;
    float: none;
    margin: auto;
}

.surface-accessories-pdp-rcb .m-rich-content-block {   
    float: none;
    margin: 0 auto;
    text-align: center;
}



.surface-slider-content .c-price span {
    float: none;
}


/*** Pivot panel on Compare to Mac page adjustments ***/

.c-pivot>header.c-subheading-4 {
    display: block;
    text-align: center;
    margin-top: 27px;
}

/***click to chat css ***/

/*.shell-category-header #callchat,
.shell-category-header #callchat-mobile {
    display: none;
}*/

/***click to chat css ***/

/***start of accessory pdp switch panel hero ***/

.surface-accessory-pdp .c-carousel {
    width: 50%;
}

.surface-accessory-pdp .c-feature.f-align-left picture,
.surface-accessory-pdp .c-feature.f-align-right picture 
.surface-accessory-pdp.m-feature.f-align-left picture,
.surface-accessory-pdp.m-feature.f-align-right picture{
    width: 100%;
}

.surface-accessory-pdp .c-feature {
    display: none;
}

.surface-accessory-pdp .c-group button.c-select-button {
    border: none!important;
    border: 1px solid rgba(0,0,0,.4) !important;
    padding: 6px 10px !important;
    width: auto;
    min-width: 250px;
}

.surface-accessory-pdp button.selected.c-select-button {
    border-width: 2px!important;
    border-color: #000!important;
    padding: 5px 9px!important;
}

.surface-accessory-pdp .c-price {
      padding-bottom: 0px;
}

.surface-accessory-pdp .ratingPlugin.bv-stars-container, 
.surface-accessory-pdp.switch-panel .c-price {
        padding-bottom: 17px;
}

.surface-accessory-pdp .c-group.f-wrap-items {
        padding-bottom: 14px;
}

.surface-accessory-pdp .c-feature>div .c-group {
        margin-top: 0px;
}

.surface-accessory-pdp .c-call-to-action.c-glyph {
    margin-bottom: 12px;
    margin-top: 21px
}

.surface-accessory-pdp.switch-panel .c-call-to-action.c-glyph {
    margin-top: 10px;
}

.surface-accessory-pdp  .c-paragraph-3 {
    padding-top: 12px;
}
  
.c-feature.hero-active {
    display: block;
}

.surface-accessory-pdp .c-carousel .c-sequence-indicator {
    bottom: 0px;    
}

.surface-accessory-pdp .bv-rating-stars-container .c-rating.f-community-rated.f-aggregate {
    display: inline-block;
} 

.surface-accessory-pdp .ratingPlugin.bv-stars-container .bvseo-ratingValue {
    display: none;
}

@media screen and (max-width: 1083px) {
    
    .surface-accessory-pdp .c-carousel {
        width: 100%;
    }
    
    .surface-accessory-pdp .c-price {
        margin: 0 auto;
        text-align: center;
    }
    
   .surface-slider-content .c-feature a.c-call-to-action.c-glyph.surface-bg-cta-blue {
        margin-left: 24px;
    }   
}

@media screen and (min-width: 1084px) {
    /*#surface-accessories-keyboard .utube-video.fulllivearea-video.c-video{
        padding-top:60px;
    }
    
    #surface-accessories-mouse .utube-video.fulllivearea-video.c-video{
        padding-top:20px;
    }
    
    #surface-accessories-Ekeyboard .utube-video.fulllivearea-video.c-video{
        padding-top:80px;
    }*/

/*

This part of style is breaking the design

#surface-nighthawk-Innovation .surface-pivot-hero-mob-margin .c-pivot img{
width:36px;
height:36px;
}

#surface-nighthawk-Innovation .surface-pivot-hero-mob-margin .c-pivot a{
padding-left:6px;
}*/

}

@media screen and (min-width: 540px) and (max-width: 1083px) {
   
    .surface-accessory-pdp .c-feature.f-align-left>div,
    .surface-accessory-pdp .c-feature.f-align-right>div,.surface-accessory-pdp.m-feature.f-align-left>div,
    .surface-accessory-pdp.m-feature.f-align-right>div{
        width: 83.3%;
        margin-left: 0px;
    }
   
    .sp4-officeapps .c-apps-panel .apps-wrapper {
        padding-top: 36px;
    }

    .sp4-officeapps .m-banner .c-paragraph-3 {
        padding-top: 42px;
    }
    
}

/***end of accessory pdp switch panel hero ***/


/*** Surface Pro 4 pages Rich Content Block ***/

/*
.surface-divider-container .c-divider {
    width: 91.6666666667%;
    margin: 0 auto;
}
*/

@media only screen and (min-width: 1400px) {

    .surface-divider-container {
        padding-left: 48px;
        padding-right: 48px;
    }

}

@media only screen and (min-width: 768px) {
    
    .surface-divider-container {
        padding-left: 36px;
        padding-right: 36px;
    }
    #surface_rotationslider.surface-top-84{
margin-bottom:125px;
}

}

@media only screen and (min-width: 540px) {
    
    .surface-divider-container {
        padding-left: 24px;
        padding-right: 24px;
    }

}

@media only screen and (max-width: 539px) {
    
    .surface-divider-container {
        padding-left: 12px;
        padding-right: 12px;
    }
    
    .surface-accessory-pdp.switch-panel .c-feature.f-align-left>div, 
    .surface-accessory-pdp.switch-panel .c-feature.f-align-right>div {
        padding-left: 12px;
        Padding-right: 12px;
    }

}

.surface-contentrich-block .c-price {
    margin-top: 5px;
}

/*** Surface Pro 4 Home page Raitings panel adjustments ***/

.surface-histogram-container {
    padding-top: 0;
} 

.surface-histogram-container .m-histogram {
    padding-top: 40px;
    padding-bottom: 90px;
}

/*** Firefox fixes ***/

@-moz-document url-prefix() {
    .surface-youtubevidplayer a.c-action-trigger.c-glyph::before,
    .surface-youtubevidplayer button.c-action-trigger.c-glyph::before {
        margin-top: -2px;
    }
}

/*** surface plus prefooter for en-us ***/

.wdg-m-prefooter.prefooter-9-links nav.c-link-navigation ul li {
    width:10%;
}

@media only screen and (max-width: 1083px) and (min-width: 540px) {
    .wdg-m-prefooter.prefooter-9-links nav.c-link-navigation ul li {
        width:31%;
    }
}

@media only screen and (max-width: 539px) {
    .wdg-m-prefooter.prefooter-9-links nav.c-link-navigation ul li {
        width:100%;
    }
}

/*** Social Share footnotes prefooter ***/

.wechat:hover .qrcode {
    display:inline-block;
}

.qrcode {
    width: 90px;
    height: 90px;
    position: absolute;
    background: #ffffff;
    display: none;
    margin-top: 41px;
    margin-left: -26px;
}

.qrcode img {
    height:90px;
    width:90px;
}

.m-social > ul > li > a img {
    height:32px;
    width:32px;
}

.surface-section-footnotes sup {
    font-size: 8px;
}
.surface-section-footnotes p,.surface-section-footnotes li.c-caption-2 {
    font-size: 11px;
    margin-bottom: 10px;
}
.en-us .surface-section-footnotes p,
.en-ca .surface-section-footnotes p,
.fr-ca .surface-section-footnotes p,
.zh-cn .surface-section-footnotes p,
.fr-fr .surface-section-footnotes p,
.compare-load .surface-section-footnotes p,
.surface-home .surface-section-footnotes p
 {
    font-size: 11px;
    outline: none;
    /*margin-bottom: 10px;*/
}
.en-us .surface-section-footnotes p:focus,
.en-ca .surface-section-footnotes p:focus,
.fr-ca .surface-section-footnotes p:focus,
.zh-cn .surface-section-footnotes p:focus,
.fr-fr .surface-section-footnotes p:focus,
.compare-load .surface-section-footnotes p:focus,
.surface-home .surface-section-footnotes p:focus
{
    outline:#fff 2px dotted;
    
}

.surface-section-footnotes a.mscom-link {
    color:#00bcf2;
}

.surface-section-footnotes .c-hyperlink.supLink,.surface-section-footnotes .c-hyperlink.supLink:hover{
     color: #fff!important;
}
.en-us .surface-section-footnotes .c-hyperlink.supLink,.en-us .surface-section-footnotes .c-hyperlink.supLink:hover,
.en-ca .surface-section-footnotes .c-hyperlink.supLink,.en-ca .surface-section-footnotes .c-hyperlink.supLink:hover,
.fr-ca .surface-section-footnotes .c-hyperlink.supLink,.fr-ca .surface-section-footnotes .c-hyperlink.supLink:hover,
.zh-cn .surface-section-footnotes .c-hyperlink.supLink,.zh-cn .surface-section-footnotes .c-hyperlink.supLink:hover,
.fr-fr .surface-section-footnotes .c-hyperlink.supLink,.fr-fr .surface-section-footnotes .c-hyperlink.supLink:hover,
.compare-load .surface-section-footnotes .c-hyperlink.supLink, .compare-load .surface-section-footnotes .c-hyperlink.supLink:hover,
.compare-design-en-us .surface-section-footnotes .c-hyperlink.supLink, .compare-design-en-us .surface-section-footnotes .c-hyperlink.supLink:hover,
.surface-home .surface-section-footnotes .c-hyperlink.supLink, .surface-home .surface-section-footnotes .c-hyperlink.supLink:hover{
     /*color: #00bcf2!important;*/
     color: #fff !important;
         background-color: #2f2f2f !important;
}

/*Need to remove for footnotes implete for all locales*/
/*.en-us .surface-hmc-interested .c-price span[itemprop='price'] sup, .en-us surface-hmc-recommended .c-price span[itemprop='price'] sup, .en-us .m-panes-product-placement-item .c-price span[itemprop='price'] sup,
.en-ca .surface-hmc-interested .c-price span[itemprop='price'] sup, .en-ca surface-hmc-recommended .c-price span[itemprop='price'] sup, .en-ca .m-panes-product-placement-item .c-price span[itemprop='price'] sup,
.fr-ca .surface-hmc-interested .c-price span[itemprop='price'] sup, .fr-ca surface-hmc-recommended .c-price span[itemprop='price'] sup, .fr-ca .m-panes-product-placement-item .c-price span[itemprop='price'] sup,
.zh-cn .surface-hmc-interested .c-price span[itemprop='price'] sup, .zh-cn surface-hmc-recommended .c-price span[itemprop='price'] sup, .zh-cn .m-panes-product-placement-item .c-price span[itemprop='price'] sup,
.compare-load .surface-hmc-interested .c-price span[itemprop='price'] sup, .compare-load surface-hmc-recommended .c-price span[itemprop='price'] sup, .compare-load .m-panes-product-placement-item .c-price span[itemprop='price'] sup  {
    float: right;
}*/


/*.en-us .c-price sup,en-ca .c-price sup,.fr-ca .c-price sup ,.ko-kr .c-price sup{
  border-bottom: 1px solid;
}*/
/*Need to remove for footnotes implete for all locales*/
.en-us .c-price a.supBLink span.supText,
.en-ca .c-price a.supBLink span.supText,
.fr-ca .c-price a.supBLink span.supText,
.zh-cn .c-price a.supBLink span.supText,
.fr-fr .c-price a.supBLink span.supText,
.compare-load .c-price a.supBLink span.supText,
{
  text-decoration: underline;
}
/*Need to remove for footnotes implete for all locales*/
/*.en-us .m-panes a.supBLink span.supText,
.en-ca .m-panes a.supBLink span.supText,
.fr-ca .m-panes a.supBLink span.supText,
.zh-cn .m-panes a.supBLink span.supText,
.fr-fr .m-panes a.supBLink span.supText,
.compare-load .m-panes a.supBLink span.supText
{
text-decoration:underline;
}*/
/*Need to remove for footnotes implete for all locales*/
.en-us .m-content-placement a.supBLink span.supText,
.en-ca .m-content-placement a.supBLink span.supText,
.fr-ca .m-content-placement a.supBLink span.supText,
.zh-cn .m-content-placement a.supBLink span.supText,
.fr-fr .m-content-placement a.supBLink span.supText,
.compare-load .m-content-placement a.supBLink span.supText
{
    text-decoration:underline;
}
/*Need to remove for footnotes implete for all locales*/
 /*.en-us .m-multi-feature .c-price sup ,.en-us .configpanelcarousel .c-price sup,
 .en-ca .m-multi-feature .c-price sup ,.en-ca .configpanelcarousel .c-price sup,
 .fr-ca .m-multi-feature .c-price sup ,.fr-ca .configpanelcarousel .c-price sup,
 .zh-cn .configpanelcarousel .c-price sup ,.zh-cn .m-multi-feature .c-price sup,
.compare-load .m-multi-feature .c-price sup , .compare-load .configpanelcarousel .c-price sup
{
    border-bottom: none !important;
}*/

/*Need to remove for footnotes implete for all locales*/
.en-us .m-feature .c-price sup ,
.en-ca .m-feature .c-price sup ,
.fr-ca .m-feature .c-price sup ,
.zh-cn .m-feature .c-price sup ,
.fr-fr .m-feature .c-price sup ,
.compare-load .m-feature .c-price sup
{
    border-bottom: none !important;
}
.en-us .surface-section-footnotes p:focus,
.en-ca .surface-section-footnotes p:focus,
.fr-ca .surface-section-footnotes p:focus,
.zh-cn .surface-section-footnotes p:focus,
.fr-fr .surface-section-footnotes p:focus,
.compare-load .surface-section-footnotes p:focus,
.surface-home .surface-section-footnotes p:focus
{
    outline: #fff 2px dotted;
}
.en-us .surface-section-footnotes p,
.en-ca .surface-section-footnotes p,
.fr-ca .surface-section-footnotes p,
.zh-cn .surface-section-footnotes p,
.fr-fr .surface-section-footnotes p,
.compare-load .surface-section-footnotes p,
.surface-home .surface-section-footnotes p
{    
    font-size: 11px;
}
.sj-overview .c-price sup
{
    border-bottom: none !important;
}
.surface-section-footnotes a.mscom-link:hover,.surface-section-footnotes a.mscom-link {
    text-decoration: underline;
}

.surface-section-footnotes {
    background-color: #2F2F2F;
    color: white;
    padding-top: 20px;
    padding-bottom: 20px;
}
.surface-section-footnotes p a.mscom-link:focus,.surface-section-footnotes p a.c-hyperlink:focus {
    outline: 2px dotted #FFFFFF !important;
    background: #FFFFFF;
    color: #0067b8 !important;
}
.surface-locale-picker > div {
    margin-top: 40px;
}
.surface-locale-picker li {
    margin-bottom: 23px;
}
.surface-locale-picker a.mscom-link {
    color: #0060ac;
}
.surface-locale-picker a.mscom-link:hover {
    text-decoration: underline;
}

.surface-social-share .m-social {
    margin-top: 0px;
}

.surface-social-share {
    padding-top: 15px;
    padding-bottom: 15px;
}

.surface-social-share .sfc-socialshare{
    font-size: 15px;  
    line-height: 20px;  
    color: rgba(0,0,0,.6);
    padding-right: 12px;
    margin-bottom: 4px;
    font-weight:400;
}

.rtl .surface-social-share .sfc-socialshare{    
    padding-left: 12px; 
    padding-right: 0px; 
}

@media only screen and (min-width: 899px) and (max-width: 1083px) {
    .surface-social-share, 
    .surface-section-footnotes>div, 
    .surface-prefooter {
        width: 90%;
    }
}

@media only screen and (min-width: 540px) {
    .surface-social-share .m-social.f-share {
        float: right;
    }
}

@media only screen and (max-width: 898px) {
    .surface-social-share, 
    .surface-section-footnotes>div, 
    .surface-prefooter {
        padding-left: 40px;
        padding-right: 40px;
    }
}

@media only screen and (max-width: 539px) {
    .surface-social-share, 
    .surface-section-footnotes>div, 
    .surface-prefooter {
        padding-left: 12px;
        padding-right: 12px;
    }
}

/*** Social Share footnotes prefooter END ***/

/*** UHF override starts ***/
.shell-footer .shell-footer-wrapper {
    overflow: hidden !important;
}

.shell-category-top-level li {
    font-size: 0.9em;
}

.shell-header-nav-wrapper .shell-header-nav a,
.shell-footer a:link {
    font-family: "wf_segoe-ui_normal" ,"Arial",sans-serif;
    font-weight: normal;
}

#shell-category-header-cta {
    background-color: #0067B8;
    /*background-color: #0078D7; Changed color as per accessibility*/
    font-family: 'Segoe UI',Tahoma,Helvetica,Arial,Verdana,sans-serif;
}

#shell-category-header-cta.show-button {
    display: inline-block !important;
}

#shell-category-header-cta:hover, 
#shell-category-header-cta:focus {  
    background: #006cc2;
    border-color: rgba(0, 0, 0, 0.4); 
}

.shell-header-wrapper .msame_Header {
    display: block;
}

.shell-footer {
    line-height: 1.5;
    font-weight: normal;
}

.shell-category-header .shell-category-nav .logo-text-label {
    font-size: 20px !important;
}

.shell-header-dropdown-tab-list li {
     font-size: 15px;
}

.shell-footer a:link,
.ctl_footerCopyright {
    font-size: 12px;
    font-family: "Segoe UI","wf_segoe-ui_normal","Arial",sans-serif;
}

.shell-category-header .shell-category-nav .shell-category-top-level span {
    font-size: 15px;
}

.shell-header-dropdown-label,
.shell-category-header .shell-category-nav .shell-category-top-level,
.shell-footer {
    font-size: 15px;
}

.shell-category-header .c-nav-pagination.c-nav-pagination-next{
    right: -4.9%!important;
}

/*** UHF override END ***/

/*** Ratings and Reviews ***/

.m-ratings-and-reviews .bv-rating-stars-container .c-rating {
    padding-top: 0px;
}

@media only screen and (min-width: 540px) {
    .m-ratings-and-reviews .surface-rating-content {
        overflow: hidden;
        padding-left: 28px;
    }
}

/*** Ratings and Reviews End***/

/*** UHF ***/

@media(min-width: 899px) {
    .shell-search button {
        background-color:transparent;
        position: static;
        border: 1px solid #a9a9a9;
        border-left: none;
        height: 36px !important;
    }
}

@media all and (max-width: 767px) {
    .shell-header-brand img {
        width:auto !important
    }
}

.c-menu-container #surfacehome-nav{
    display: none !important;
}

@media all and (min-width: 899px) {
 .shell-category-header .shell-category-nav a[aria-expanded="true"] + .c-nav-dropdown-menu {
        overflow:visible !important; width:100% !important;
    }
}

/*** UHF End***/
.bv-rating-stars-container[data-productid=""] {
    display: none;
}

.createdonsurface-content-panel .c-caption-1 {
    padding-top:20px;
}

.createdonsurface-content-panel .c-heading-4 {
    padding-top:10px;
}

.createdonsurface-content-panel .c-paragraph-3 {
    padding-top:10px;
}

.createdonsurface-feature-panel .c-heading-3 {
    padding-top:20px;
}


/****** Offer banner ******/

.body-new-border {
    border: 1px solid rgba(0,0,0,0.2);
}
.body-new-border img {
    padding-top:1px;
    padding-bottom:1px;
}
#surface-offer-banner .m-banner a.c-call-to-action {
    margin-left: 0;
}

#surface-offer-banner .m-banner {
    padding-top: 0px;
}

#surface-offer-banner .c-divider.surface-no-ctabuttons{
    margin-top:36px;
} 
/****** surfacebk-techspec-hero specific css ******/

@media only screen and (min-width: 1084px) and (max-width: 1558px) {
    .m-hero-item.surfacebook-techspec-hero.f-y-center.f-transparent>div>div {  
        top:calc(42%);
    }
}

/****** Home page feature panel with video ******/

@media (max-width: 539px) {
    .surface-caption-text .c-caption-1 {
        display: block;
        margin-top: 20px;
    }
}

/****** Home page multi feature panel fix ******/

.m-multi-feature header[role=tablist] {
    display:block;
}

@media only screen and (min-width: 540px) {
    .surface-hero-pivot .m-multi-feature.f-align-center .c-pivot {
        width:66.6%;
    }
}

/**** Multifeature pivot panel ****/

.surface-multifeature-pivot .m-content-placement-item .c-call-to-action:active {
    background: none;
}

@media only screen and (min-width: 1084px) {
    
    /*.surface-multifeature-pivot .m-multi-feature.f-align-left .surface-multifeatureimage {
        left:50%;
    }
    .surface-multifeature-pivot .m-multi-feature .surface-multifeature-icon-content {
        left:0;
        padding-right:48px;
    }*/
    .m-hero-item.surfacepro4-techspec-hero.f-y-center.f-transparent>div>div {   
        top:calc(42%);
    }

}

/*@media only screen and (min-width: 540px) and (max-width: 1083px) {
    .surface-multifeature-pivot .m-multi-feature [role=tabpanel].f-active {
        width:66.67%;
        margin:0 auto;
    }
}*/

.surface-fingerprint-pdp .m-multi-feature .c-logo{
    display: inline-block;
}

@media only screen and (max-width: 1083px) {
    .surface-hmc-interested .c-price span[itemprop='price'] sup, surface-hmc-recommended .c-price span[itemprop='price'] sup,.m-panes-product-placement-item .c-price span[itemprop='price'] sup {
    float: none;
}
    /*.surface-multifeature-pivot .m-multi-feature.f-align-left>section>div:first-child {
        display: block;
        position: relative;
        left: 0;
        padding: 0;
        -webkit-transform: none;
        -ms-transform: none;
        transform: none
    }

    .surface-multifeature-pivot .m-multi-feature.f-align-left>section>div,
    .surface-fingerprint-pdp .m-multi-feature.f-align-left>section>div,
    .surface-typecover-pdp .m-multi-feature.f-align-left>section>div {
        left: 0;
        width: 100%;
        max-width: 100%;
        margin: 0 auto;
        top: calc(50%);
        -webkit-transform: none;
        -ms-transform: none;
        transform: none;
        position: relative;
        text-align: center;
        display: block;
        padding-right: 36px;
        padding-left: 36px;
    }*/

    [dir="rtl"] .surface-multifeature-pivot .m-multi-feature.f-align-left>section>div,
    [dir="rtl"] .c-feature.f-align-right>div,.rtl .c-feature.f-align-right>div, .rtl .c-feature.f-align-right.f-image-priority>div {
        
        right:0;
    }

    /*.surface-multifeature-pivot .m-multi-feature.f-align-left>section>div>ul[role=tablist],
     .surface-fingerprint-pdp .m-multi-feature.f-align-left>section>div>ul[role=tablist],
    .surface-typecover-pdp .m-multi-feature.f-align-left>section>div>ul[role=tablist] {
        padding-top: 24px;
        padding-bottom: 24px;
        -ms-flex-pack: center;
        justify-content: center
    }*/
    
    .clear-top {
        padding-top: 0px;
        margin-top: 0px;
    }

}

.surface-multifeature-pivot .m-multi-feature [role=tablist] li img.mscom-image.c-image {
    height: 40px;
    width: 40px;
}

.surface-multifeature-pivot .m-multi-feature [role=tablist] li>a.f-active,
.surface-multifeature-pivot .m-multi-feature [role=tablist] li>a {
    background: none;
    outline: none;
}

.surface-multifeature-pivot .m-multi-feature [role=tablist] li>a .c-image {
     border:none;
 }
 
.surface-multifeature-pivot .c-carousel li.f-animate-next>picture.c-image img,
.surface-multifeature-pivot .c-carousel li.f-animate-previous>picture.c-image img {
    animation: none;
    -webkit-animation: none;
}

.surface-multifeature-pivot .m-multi-feature [role=tablist] li>a .c-image.surface-blueimg {
     display: none;
}

.surface-multifeature-pivot .m-multi-feature [role=tablist] li>a.c-logo.f-active .c-image.surface-blueimg {
     display: block;
}

.surface-multifeature-pivot .m-multi-feature [role=tablist]  li>a.c-logo.f-active .c-image.surface-greyimg {
     display: none;
}

.createdonsurace_top .c-heading-1 {
    padding-top: 15px;
}

/*----Mosaic with Features Panel CSS START-----*/
@media only screen and (min-width:1400px){
    
    .surface-mosaic-with-features .c-mosaic [data-f-mosaic~=f-vp5-whole] {
        width: 100%;
    }
    
    .surface-mosaic-with-features .c-mosaic [data-f-mosaic~=f-height-large] {
        border-right: 1px solid rgba(0,0,0,0.2);
    }
    
    .surface-mosaic-with-features .c-mosaic [data-f-mosaic~=f-height-medium] {
        padding-left:12px;
        padding-right:12px;
    }
       
}

@media only screen and (min-width:1084px) and (max-width:1399px) {
   
   .surface-mosaic-with-features .c-feature[class*='f-align']>div {
        width: 100%;
        position: relative;
        top: 0;
        left: 0;
        transform: translateY(0);
        padding-left: 0;
        padding-right: 0;
    }
    
    .surface-mosaic-with-features .c-feature[class*='f-align']>picture {
        width:100%;
    }
    
    .surface-mosaic-with-features .c-mosaic [data-f-mosaic~=f-height-large] {
        border-right:1px solid rgba(0,0,0,0.2);
    }
    
    .surface-mosaic-with-features .c-mosaic [data-f-mosaic~=f-height-large] {
        height:auto;
    }
    
    .surface-mosaic-with-features .c-mosaic [data-f-mosaic~=f-height-medium] {
        padding-left: 12px;
        padding-right: 12px;
        height: auto;
    }
}

@media only screen and (max-width:1083px){
    
    .surface-mosaic-with-features .c-mosaic [data-f-mosaic~=f-height-large], 
    .surface-mosaic-with-features .c-mosaic [data-f-mosaic~=f-height-medium] {
        height:auto;
    }
    
    .surface-mosaic-with-features .c-mosaic {
        padding-left: 3.5%;
        padding-right: 3.5%;
    }
    
    .surface-mosaic-with-features .m-content-placement-item {
        margin-top:0;
    }
    
    .surface-mosaic-with-features .c-feature[class*='f-align']>div {
        width: 100%;
        text-align: left;
        padding-left: 0;
        padding-right: 0;
        margin-top: 0;
    }
    
    .surface-mosaic-with-features .c-mosaic [data-f-mosaic~=f-height-large] {
        border-bottom: 1px solid rgba(0,0,0,0.2);
        padding-bottom: 25px;
    }
    
    /*.surface-mosaic-with-features .m-feature .c-price>* {float: none;}*/
    .surface-mosaic-with-features .c-mosaic [data-f-mosaic~=f-height-medium] {
        padding-left: 12px;
        padding-right: 12px;
    }
}

@media only screen and (max-width: 539px) {
    .mosaic-mobile-height .c-mosaic [data-f-mosaic~=f-height-large] {
        height: 360px;
    }
    
    .c-mosaic-placement.f-height-large.f-width-large {
        padding-left: 6%;
        padding-right: 6%;
    }
    
    .surface-mosaic-with-features .c-mosaic {
        padding-left: 12px;
        padding-right: 12px;
    }
    
    .surface-mosaic-with-features .c-mosaic [data-f-mosaic~=f-height-medium] {
        padding-left: 0;
        padding-right: 0;
    }
    
}

/********Mosaic with Features Panel CSS END*******/

.createdonsurface-hero .c-heading-2 {
    padding-top: 15px;
}

/*.surface-pivot-hero-mob-margin .c-pivot a .surface-blue-pivot-icon,
.surface-pivot-hero-mob-margin .c-pivot a:first-child .surface-grey-pivot-icon {
    display: none;
}

.surface-pivot-hero-mob-margin .c-pivot a:first-child .surface-blue-pivot-icon {
     display: inline-block;
}
*/
@media only screen and (min-width:1084px) and (max-width:1350px) {
    .surface-pivot-hero-mob-margin .c-pivot>header>a {
        padding-left: 6px;
        padding-right: 6px;
    }
}
 
.c-price.studio-price meta+span {
     float: none !important;
}
  
.c-price.studio-price meta+span, 
.c-center {
     float: none !important;
}
 
.c-group.c-center {
     display: block !important;
}

.surface-Pivot-mob-margin .m-hero-item .c-pivot>header>a {
    cursor: default; 
} 

.surface-slider-content.m-feature .c-feature .c-price.cos-c-price {
    margin-bottom: 10px;
}

.surface-slider-content.m-feature {
    padding-top: 0px;
    margin-top: 0px;
}

.surface-mp4-video .c-glyph.glyph-play:before,
.surface-mp4-video .c-glyph.glyph-pause:before {
    color: #fff;
}

.surface-anim .c-feature .c-heading-3, 
.surface-anim .c-feature .c-paragraph-3 {
    padding-top: 0px;
}

.msw-page picture img[data-src] {
    visibility:hidden;
    height:0;
}

meta[content~="business"] .shell-category-header-cta-wrapper {
    display: none;
}

/**** Video with text CSS Start****/
.surface-videowithtext .c-video video
{
    background: none;
    width:100%;
    min-height:auto;
}
.surface-videowithtext .c-video
{
    left: 0;
    width:50%;
    padding-left:6%;
    right:auto;
}
@media only screen and (min-width:1084px){
.surface-videowithtext picture
{
    display: none;
}
  }
.hcmode-white .video_pp_button:focus,.hcmode-black .video_pp_button:focus,.hcmode-black .fulllivearea-video.c-video.utube-video button.c-glyph.glyph-play:focus,.hcmode-white .fulllivearea-video.c-video.utube-video button.c-glyph.glyph-play:focus  {
         outline: 3px dashed #fff;
         }
         
@media only screen and (max-width:1083px){
.surface-videowithtext .c-video video
{
    display: none;
}

}
/**** Video with text CSS End****/

.feature-mp4 .surface-video-overlay-controls span.c-glyph.glyph-play,
.feature-mp4.ended .surface-video-overlay-controls span.c-glyph.glyph-play,
.feature-mp4 video.plyng + .surface-video-overlay-controls:hover span.c-glyph.glyph-pause,
.feature-mp4 video.paused + .surface-video-overlay-controls:hover span.c-glyph.glyph-pause {    
    display: block;
}

.feature-mp4 video.plyng + .surface-video-overlay-controls span.c-glyph.glyph-play,
.feature-mp4 video.paused + .surface-video-overlay-controls:hover span.c-glyph.glyph-pause,
.feature-mp4 video.paused + .surface-video-overlay-controls span.c-glyph.glyph-pause {    
    display: none;
}

/***********HIGH CONTRAST CSS*************/

.high-contrast-mode   .surface-hero-high-contrast .m-hero-item>div>div {
        background-color:#000;
    }
 .high-contrast-mode .c-social > a:focus::before,
 .high-contrast-mode .c-social > a:hover::before,
 .high-contrast-mode .c-social > ul > li > a:focus::before,
 .high-contrast-mode .c-social > ul > li > a:hover::before,
 .high-contrast-mode .m-social > a:focus::before,
 .high-contrast-mode .m-social > a:hover::before,
 .high-contrast-mode .m-social > ul > li > a:focus::before,
 .high-contrast-mode .m-social > ul > li > a:hover::before{
        background: none !important;
    }
@media screen and (-ms-high-contrast: active) { 
   
    .surface-hero-high-contrast .m-hero-item>div>div {
        background-color:#000;
    }
    .surface-fingerprint-pdp .m-multi-feature .c-logo {
        outline:2px solid #fff;
    }
    .surface-fingerprint-pdp .m-multi-feature .c-logo:focus {
        outline:2px dotted #fff;
    }
    .c-radio.swatch-color-list label.c-label input + img , .c-radio.swatch-color-list label.c-label input + img + img{
        border:1px solid #fff;
    }
    
    .surface-accessoriesgrid .surface-multiview-trigger img {
        border: solid 1px;
        display: block;
    }
  /*  .c-carousel.f-multi-slide .c-sequence-indicator button:focus
      {         
          outline:1px solid #000 !important;
      }*/
     .c-carousel.f-multi-slide  .c-sequence-indicator a:before{
        border: 1px solid #000 !important;
    }
   
    .c-carousel.f-multi-slide .c-sequence-indicator button[aria-selected=true]::before
    {
        background: #000 !important;
    }
     #surface-Studio-Innovation section[data-vg='SurfaceStudioInnovation_6_HeroFullBleedPivot_VG'] .c-pivot .f-active, #surface-Studio-Innovation section[data-vg='SurfaceStudio_3_HeroFullBleedPanel_VG'] .c-pivot .f-active{
background:transparent;
background-color:transparent;
}  
   .surface-expando .c-action-trigger{
    border:none;
} .surface-expando .c-action-trigger:focus{
    border:2px solid #000;
} 

.wdg-m-prefooter nav.c-link-navigation ul li a.c-hyperlink:focus span
{
    border: 2px dashed;

}
}

@media screen and (-ms-high-contrast: white-on-black) {
.video_pp_button:focus,.fulllivearea-video.c-video.utube-video button.c-glyph.glyph-play:focus{
         outline: 3px dashed #fff;
         }
    .surface-hero-high-contrast .m-hero-item>div>div {
        background-color: #000;
        color:#fff;
    }
     .surface-fingerprint-pdp .m-multi-feature .c-logo {
        outline:2px solid #fff;
    }
     .surface-fingerprint-pdp .m-multi-feature .c-logo:focus {
        outline:2px dotted #fff;
    }
     .c-radio.swatch-color-list label.c-label input + img , .c-radio.swatch-color-list label.c-label input + img + img{
        border:1px solid #fff;
    }
}

@media screen and (-ms-high-contrast: black-on-white) {
   .video_pp_button:focus,.fulllivearea-video.c-video.utube-video button.c-glyph.glyph-play:focus {
         outline: 3px dashed #000;
         }
    .surface-hero-high-contrast .m-hero-item>div>div {
        background-color: #fff; 
        color:#000;
     }
     .surface-fingerprint-pdp .m-multi-feature .c-logo {
        outline:2px solid #000;
    }
     .surface-fingerprint-pdp .m-multi-feature .c-logo:focus {
        outline:2px dotted #000;
    }
     .c-radio.swatch-color-list label.c-label input + img , .c-radio.swatch-color-list label.c-label input + img + img{
        border:1px solid #000;
    }
}

/*------------------HIGH CONTRAST CSS END---------------*/

/*Inline Video CSS----*/
.fulllivearea-video.c-video.utube-video{
    height: 56.25vw;
}
.m-ambient-video.c-video {
    height: 56.25vw;
}
/*.fulllivearea-video iframe{min-height:33.75vw}
.c-feature.f-image-priority.utube-video iframe{min-height:32.51vw}
.m-content-placement-item.c-video{min-width:50px}
.full-grid-2-up .m-content-placement-item.c-video iframe{min-height: 24.5vw;}
@media screen and (min-width:1600px){
    .c-feature.f-image-priority.utube-video iframe{min-height: 585px;}
}
@media screen and (max-width:1083px) {
 .fulllivearea-video iframe{min-height:56.25vw}
 .c-feature.f-image-priority.utube-video iframe{min-height:56.25vw}
}
@media screen and (max-width:539px) {
 .full-grid-2-up .m-content-placement-item.c-video iframe{min-height: 51.75vw;}
}*/
.surface-hero-pivot-multi-img .c-pivot .mscom-link img.mscom-image.icons
{
    z-index: -1;
    position: relative;
}
.surface-hero-pivot-multi-img .c-pivot ul li
{
    padding-right: 0px;
    margin-right: 12px;
    margin-left: 12px;
}
.wdg-global a.c-action-trigger, button.c-action-trigger .COS-video
{
padding-top:0px;
padding-bottom:13px;
font-size:13px;
}
@media screen and (min-width: 540px) and (max-width: 767px) {
.createdonsurface-padding a.c-action-trigger.c-glyph:before{
margin-left:0px;
}
}
/*----------------------Art-harmony video Component--------------------*/
.poster .glyph-play{
    font-size: 45px;
    color: white;
    position: absolute;
    transform: translate(-50%,-50%);
}
.poster .glyph-play:focus{
    outline:dotted 2px #000;
}
@media screen and (min-width: 1084px){
   .poster .glyph-play{    
    left: 32.5%;
    top: 50%;   
}
}
@media screen and (max-width: 1083px){
   .poster .glyph-play{    
    left: 50%;
    top: 37%;   
}}
@media screen and (max-width: 539px){
   .poster .glyph-play{    
    left: 50%;
    top: 32.5%;   
}}

/*** Surface Innovation css changes ***/

.surface-youtubevidplayer a.c-call-to-action {
    padding: 10px 16px 7px 0;
}

.surface-bg-gray
{
    background-color: #e3e3e3;
}

@media screen and (min-width: 768px) and (max-width: 1083px){
.surface-feature-logo .c-feature.f-align-right>div .c-logo img
{
    margin:0 auto;
}
}

@media screen and (max-width: 427px)
{
.surfaceinnovation-pivotmosaic.m-multi-feature [role=tablist]
{
    display:block;
}
}
@media screen and (min-width: 540px)
{
.surface-animated-video picture
{
    display:none;
}
}
@media screen and (max-width: 539px)
{
.surface-animated-video .c-video
{
    display:none;
}
.surface-animated-video picture
{
    display:block;
}
}
.surface-animated-video .c-video video {
    max-height: none;
}

.surface-animated-video picture img
{
    max-width:100%;
} 

/*** Surface Innovation css changes END ***/
/*** compare surface devices table css start ***/
.c-table .specification-title{
    border-bottom: 1px solid rgba(0, 0, 0, 0.2);
    outline: transparent;
 }
/***.c-table .specification-title:last-child{
       border-bottom:none;
}***/
.c-table .specification-title::before{
    width:auto;
}
.specification-title td,h2.specification-title{
    padding-left: 12px;
}
.specification-title td:first-child,h2.specification-title{
    padding-bottom: 0px;
}
.surface-compare-c-chart.c-table tbody tr:first-child td {
    padding-bottom: 10px !important;
   padding-top:38px;
}
.surface-compare-c-chart.c-table tbody tr td:first-child p:first-child{
    font-weight: 600;
    padding: 0px;
}
.surface-compare-c-chart.c-table{
    padding-left: 48px;
    padding-right: 48px;
 }
 
 
 .surface-compare-c-chart table {
     width:100%;
 }
 
/*compare table border
.surface-compare-c-chart tbody tr .c-heading-6 {
    padding-top:16px;
    font-weight: 700;
}*/
/*.surface-compare-c-chart tbody tr:not(:first-child) {
    margin-top: 16px;
    border-top: 1px solid rgba(0,0,0,.2);
    outline: transparent;
}*/


@media only screen and (min-width:768px) and (max-width:1399px) {
 .surface-compare-c-chart.c-table{
    padding-left: 36px;
    padding-right: 36px;
 }
}
  @media only screen and (min-width:539px) and (max-width:767px) {
 .surface-compare-c-chart.c-table{
    padding-left: 24px;
    padding-right: 24px;
 }
 }
  @media only screen and (max-width:539px) {
 .surface-compare-c-chart.c-table{
    padding-left: 12px;
    padding-right: 12px;
 }
 }
 @media only screen and (max-width:539px) {
    a.ctalink span{
    overflow: visible;
 }
 }
 
 a.dummy-anchor
{
display:none;
}
#surface-lightbox-preview a.dummy-anchor{

    display:block;font-size:0px;
}

/*Accolade carousel*/

section[data-vg='Surface_Book_2_AccoladeCarousel_VG'] {
    display:none;
}

.accoladecarousel .m-banner{
    padding-top:80px;
    padding-bottom:96px;
}

.accoladecarousel .accoladeimage a[href=""] {
    pointer-events: none;
}
 
.accoladecarousel .m-banner .accoladetext{
    padding-left:46px;
}

.accoladecarousel .m-banner .c-caption-1{
    font-size:13px;
}

.accoladecarousel .m-banner .accoladeimage{
transform: translateY(20%);
}

@media only screen and (max-width:1083px) {
#accoladepanel{
   margin-top:50px; 
}
}

@media only screen and (min-width:738px) and (max-width:1083px) {
.accoladecarousel .m-banner{
    padding-top:68px;
    padding-bottom:84px;
}
.accoladecarousel .m-banner .accoladeimage{
    transform: translateY(20%);
}
}

@media only screen and (max-width:737px) {
.accoladecarousel .m-banner{
    padding-top:52px;
    padding-bottom:68px;
}
}
@media only screen and (max-width:539px) {
    
  #accoladepanel{
   margin-top:31px; 
}

.accoladecarousel .m-banner
{
    width:83.33%;
}

.accoladecarousel .m-banner .accoladeimage{
transform: translateY(50%);
width:25%;
}

.accoladecarousel .m-banner .accoladetext{
width:75%;
}

.accoladecarousel .m-banner{
    padding-top:55px;
    padding-bottom:55px;
}

.accoladecarousel .m-banner [data-grid*="col-"]{
float:left;
}

.accoladecarousel .m-banner .accoladetext {
    padding-left: 70px;
}
}


/*AccoladeSingle*/

#accoladepanelSingle .m-banner{
    padding-bottom:100px;
}

/* Page Bar CSS */
.m-page-bar .context-menu .mscom-link.c-hyperlink, .m-page-bar .mscom-link.c-call-to-action.c-glyph {
font-weight: normal;
}
.surface-page-bar .m-page-bar>div>div
{
    width:100%;
}

.surface-page-bar .m-page-bar
{
    padding-left: 0px;
    padding-right: 0px;
}
 .m-page-bar .c-menu-item a[aria-selected="true"]
{
    background: #0067B8;
    /*background: #0078D7; Changed color as per accessibility*/
    color: #FFF;
}
.m-page-bar>div .context-menu .c-list li .c-hyperlink{
    color:#000000;
}

@media only screen and (min-width: 899px) and (max-width: 1083px)
{
 .surface-page-bar .m-page-bar
{
    padding-left: 48px;
    padding-right: 48px;
}
}
@media only screen and (max-width: 899px)
{
    .surface-page-bar .m-page-bar .context-menu
    {
        padding-left: 10px;
    }
}
@media only screen and (max-width: 539px)
{
    .m-page-bar>div
    {
        display: inline-table;
    }
}
/* Page Bar CSS End*/

@media only screen and (max-width: 767px) {
    .m-area-heading .c-paragraph {
        max-width:60%
    }

    a.c-back-to-top,a.m-back-to-top {
        position: fixed;
        bottom: 24px;
        right: 24px;
        width: 48px;
        height: 48px;
        background: rgba(0,0,0,.1);
        visibility: visible;
        float: right;
        padding: 12px;
        z-index: 500;
        opacity: 1;
        transition: opacity .6s cubic-bezier(.19,1,.22,1)
    }

    a.c-back-to-top:focus,a.c-back-to-top:hover,a.m-back-to-top:focus,a.m-back-to-top:hover {
        background: rgba(0,0,0,.2)
    }

    a.c-back-to-top:focus,a.m-back-to-top:focus {
        outline: #000 dashed 2px
    }

    a.c-back-to-top:active,a.m-back-to-top:active {
        background: rgba(0,0,0,.3)
    }

    a.c-back-to-top .c-glyph.glyph-up,a.m-back-to-top .c-glyph.glyph-up {
        font-size: 24px
    }

    a.c-back-to-top .c-glyph.glyph-up:before,a.m-back-to-top .c-glyph.glyph-up:before {
        width: 24px;
        height: 24px
    }

    a.c-back-to-top[aria-disabled=true],a.m-back-to-top[aria-disabled=true] {
        visibility: hidden;
        opacity: 0;
        transition: visibility .6s cubic-bezier(.19,1,.22,1),opacity .6s cubic-bezier(.19,1,.22,1)
    }
    .m-page-bar>div>div {
    width: 100%;    
}
}

/*Banner Padding fix 20170125*/
.surface-grey-banner .m-banner
{
padding-top: 0;
margin-top: 0;
}

.surface-grey-banner .m-banner .c-heading-3
{
padding-top: 0;
}

.surface-grey-banner .surface-bg-gray
{
padding-top:60px;
padding-bottom:60px;
}
.surface-banner-ctas a:first-child
{
    margin-right:14px;
}
/*End of Banner Padding Fix code*/

/*Accolade4up*/
.accimages{
    padding-right:12px;
    padding-left: 12px;
}

@media only screen and (max-width: 767px) {
    .accimages{
        width:50%;
        display: inline-block;
    }
}
/*---------Adding seventh item in product placement panel------------*/
/*.en-us .m-product-placement.surface-business-touts .surface-touts-list-seven-items ul li {
    width: 14.28%;
}
.en-us .m-product-placement.surface-business-touts .surface-touts-list-seven-items ul li:last-child .m-product-placement-item{
    margin-right: 24px;
}
}
@media only screen and (max-width: 1083px) and (min-width:768px) {
   .en-us .m-product-placement.surface-business-touts .surface-touts-list-seven-items ul li:last-child {
    margin-left: 33.5%;
}
}
@media only screen and (max-width: 767px){
  .en-us .m-product-placement.surface-business-touts .surface-touts-list-seven-items ul li:last-child {
    margin-left: 25%;
}
}
*/
@media only screen and (min-width:1084px) {
.m-product-placement.surface-business-touts .surface-touts-list-seven-items ul li {
    width: 14.28%;
}
.m-product-placement.surface-business-touts .surface-touts-list-seven-items ul li:last-child .m-product-placement-item{
    margin-right: 24px;
}
}
@media only screen and (max-width: 1083px) and (min-width:768px) {
.m-product-placement.surface-business-touts .surface-touts-list-seven-items ul li:last-child {
    margin-left: 33.5%;
}
html[lang^=ar-] .m-product-placement.surface-business-touts .surface-touts-list-seven-items ul li:last-child {
    margin-right: 33.5%;
}
}
@media only screen and (max-width: 767px){
  .m-product-placement.surface-business-touts .surface-touts-list-seven-items ul li:last-child {
    margin-left: 25%;
}

html[lang^=ar-] .m-product-placement.surface-business-touts .surface-touts-list-seven-items ul li:last-child {
    margin-right: 25%;
}

}

/*---------Adding seventh item in product placement panel END------------*/


/*Configuration Panel CSS*/
.confgpanelbanner .m-banner{
padding-top:38px;
}

.confgpanel{
    padding-left:36px;
    padding-right:36px;
}

.config-intel-heading{
    padding-bottom:26px;
}


.confgpanel-surface-IC .confgpanel-specs
{
    border: 1px solid #767676;
    margin-top:4px;
    padding-top:20px;
    padding-bottom:8px;
}

.confgpanel-specs .c-subheading-5{
margin-right:28px;
}

.confgpanel-surface-IC .confgpanel-specs .c-heading-5, .confgpanel-surface-IC .confgpanel-specs .c-price, .confgpanel-surface-IC .confgpanel-specs .c-heading-6{
    padding-left: 12px;   
}
.confgpanel-surface-IC .confgpanel-specs .confgspec .c-paragraph-3,.confgpanel-surface-IC .confgpanel-specs .confgspec .specindconfg{
    padding:0; 
  padding-left: 12px;    
}

.confgpanel-surface-IC .confgpanel-specs .c-price{
    padding-right: 4px;
}

/*Newly added for fontweight*/
.confgpanel-surface-IC .confgpanel-specs .c-heading-5{
    font-weight:300;
}

.confgpanel-surface-IC .confgpanel-specs .c-heading-5, .confgpanel-surface-IC .confgpanel-specs .c-price.c-heading-3, .confgpanel-surface-IC .confgpanel-specs .c-heading-6
{
padding-top:0px;
}

.confgpanel-surface-IC .confgpanel-specs .c-badge{
    margin-right:2%;
    margin-left: 12px;
    margin-bottom: 10px;
}

.confgprice .c-price meta+span, .confgprice .c-price span {
    float: none;
}

@media only screen and (min-width:1400px) {
/*.confgpanel-surface-IC .confgpanel-specs .c-badge{
    margin-right:30%;
}*/

.confgpanel{
    padding-left:48px;
    padding-right:10px;
}

.cfgpanel .confgpanel-surface-IC{
    padding-right:8px;
}
}
.cfgpanel{
    clear:both;
}
@media only screen and (min-width:1084px) and (max-width:1160px) {
    
.confgpanel-surface-IC .confgpanel-specs .c-price{
    padding-right: 0px;
}
}

@media only screen and (min-width: 1084px) {
  
/*1-4 CHANGES*/
.configpanelcarousel{
    padding-top:30px;
}

.configpanelcarousel .m-banner{
    max-width:initial;
    padding-top:0px;
}

.cfgpanel
{
    width:49%;
    display:inline-block;
    vertical-align: top;
}

.cfgpanel .confgcarousel .c-sequence-indicator,.cfgpanel .c-carousel.confgcarousel .c-flipper{
    display:none;
}

.cfgpanel .c-carousel.f-multi-slide li{
    display: inline-block;
    width:50%;
}

.cfgpanel .m-banner>[data-grid~=col-1]{
display:none;
}

.cfgpanel .c-carousel{
    clear:both;
}
}

@media only screen and (max-width: 1083px) {
   .confgpanelbanner .m-banner{
    max-width:initial;
}
  
   /*.confgpanel-surface-IC .confgpanel-specs .c-badge{
       margin-right:25px;
   } */
   
   .confgpanel-specs .c-subheading-5{
    margin-right:2px;
    }
   
    .configpanel-carousel-cta span:hover{
        text-decoration: underline;
    }
     
    /*1-6 changes*/
.configpanelcarousel .c-divider{
    margin-top:25px;
}
}
	@media only screen and (min-width:768px) and (max-width:1083px) {
   .cfgpanel .m-banner>[data-grid~=col-1]{
    display:none;
    }
    .cfgpanel .m-banner>[data-grid~=col-10]{
    padding:0 36px;
    }
}
@media only screen and (max-width: 767px) {

.confgcarousel .confgpanel-surface-IC{
    padding-left:4%;
    padding-right:4%;
}

  .confgcarousel{
        clear:both;
    }
    
     .confgcarousel.c-carousel .c-flipper{
         top: 40%;
         transform: translateY(-60%);
     }
}

@media only screen and (max-width: 539px) {

.confgcarousel .confgpanel-surface-IC{
    padding-left:2%;
    padding-right:2%;
}
   .configpanelcarousel .m-banner{   
    padding-left:44px;
    padding-right:44px;
}

.m-hero-item .confgpanel-specsandprice .c-price{
display:block;
}

.confgpanel-specs .confgpanel-specsandprice [data-grid~="col-6"]{
width:50%;
float:left;
}
}

@media only screen and (max-width: 340px) {
.confgcarousel .confgpanel-specsandprice .c-price.c-heading-3{
    font-size:19px;
    line-height: 30px;
}
}

@media only screen and (min-width:540px) and (max-width:1083px) {
   .configpanelcarousel:not(.sl-config) .m-banner{
    max-width: initial;
    padding-left:0px;
    padding-right:0px;
}
}

.confgcarousel{
    padding-bottom: 60px;
}

a.c-call-to-action.c-glyph.configpanel-carousel-cta.surface-secondary-cta {
    margin-left:20px;
    margin-top:20px;
}

/*a.c-call-to-action.configpanel-carousel-cta.surface-secondary-cta:focus:not(.x-hidden-focus) span
{
    text-decoration: underline;
}*/

a.c-call-to-action.c-glyph.configpanel-carousel-cta.surface-secondary-cta:active{
    transform:none;
}

.confgcarousel .confgpanel-specsandprice{
    padding-left:8px;
}


@media only screen and (min-width: 768px)  and (max-width: 1399px){
    .cfgpanel {
            width: 100%;
    }
     .cfgpanel .c-carousel.f-multi-slide li {
     display: inline-block;
     width: 50%;
     }
      .cfgpanel .c-carousel{
          position: static;
      }     
      .confgpanel li:nth-child(2n+1){
          padding-right: 8px;         
      }
     
}
@media only screen and (min-width:540px) and (max-width:767px) {
    .confgpanel
    {
        padding-left: 12px;
        padding-right: 12px;
    }
}
/*------------Mac Fixes-------------------------*/
@media only screen and (min-width: 768px) {    
    .Mac.Safari .m-content-placement .surface-popup-video{
        padding-bottom: 7px;
    }
}
.Mac.Safari .c-video video{object-fit:fill;}

/*---- Fix to hide the Carousel Dots and Flippers above 768px -----*/


@media only screen and (min-width: 768px)
{
    .cfgpanel .c-sequence-indicator, .cfgpanel .c-flipper{
    display:none;
}
}
.high-contrast-mode.Firefox .surface-hmc-questionairePanel .surface-hmc-quesAns-container  .c-checkbox input[type="checkbox"]{
opacity:1;
}
 .high-contrast-mode.Firefox .surface-expando .c-action-trigger{
    border:none;
}
.high-contrast-mode.Firefox .surface-expando .c-action-trigger:focus{
    border:2px solid #000;
} 

.high-contrast-mode.Firefox .wdg-m-prefooter nav.c-link-navigation ul li a.c-hyperlink:focus span 
{
    border: 2px dashed;
} 

.high-contrast-mode.Firefox .surface-button-progress progress.c-progress[value]{
border: 2px solid #fff;
}
.surface-accessoriesgrid .c-group.surface-swatch-colors .surface-multiview-trigger:focus {
    outline: 0 !important;
}
.surface-accessoriesgrid .c-group.surface-swatch-colors .surface-multiview-trigger:focus img.accessories-tout-images{
outline:2px dotted #000;
}

/*Finger print and type cover css */

.surface-typecover-pdp .c-carousel li.f-animate-next>picture.c-image img,
.surface-typecover-pdp .c-carousel li.f-animate-previous>picture.c-image img,
.surface-multiview-feature .c-carousel li.f-animate-next>picture.c-image img,
.surface-multiview-feature .c-carousel li.f-animate-previous>picture.c-image img,
.surface-fingerprint-pdp .c-carousel li.f-animate-next>picture.c-image img,
.surface-fingerprint-pdp .c-carousel li.f-animate-previous>picture.c-image img
{
    animation: none;
    -webkit-animation: none;
}
.surface-fingerprint-pdp .c-price span, .surface-typecover-pdp .c-price span, .surface-multifeature-pivot .c-price span
{
    float:none;
}
.surface-fingerprint-pdp .c-price, .surface-typecover-pdp .c-price{
   padding-top:10px;
   padding-bottom:20px;  
}
.surface-typecover-pdp .view-thumbs li img,.surface-typecover-pdp .c-carousel li .c-image,.surface-multiview-feature .view-thumbs li img,.surface-multiview-feature .c-carousel li .c-image
{
    display:none;
}
.surface-typecover-pdp .view-thumbs li img.current-color, .surface-typecover-pdp .c-carousel li .c-image.current-color,
.surface-multiview-feature .view-thumbs li img.current-color, .surface-multiview-feature .c-carousel li .c-image.current-color
{
    display:block;
}
.surface-typecover-pdp .m-multi-feature.f-align-left>section>div ul,
.surface-multiview-feature .m-multi-feature.f-align-left>section>div ul,
.surface-fingerprint-pdp .m-multi-feature.f-align-left>section>div ul
{
    padding-bottom:0px;
}
.surface-fingerprint-pdp .swatch-color
{
    padding-bottom:10px;
}

[data-vg='Surface_L_Generic_PivotPanel_VG'].surface-multiview-feature .swatch-color-list
{
    display:inline;
}

.surface-typecover-pdp .swatch-color-list,
.surface-multiview-feature .swatch-color-list
{
    display:flex;
    padding-top:10px;
}

.surface-typecover-pdp .swatch-color-list li,.surface-multiview-feature .swatch-color-list li
{
    float:left;
    margin-right:10px;
}
/*.surface-typecover-pdp .swatch-color-list li.current-color,.surface-multiview-feature .swatch-color-list li.current-color
{
     border: #000 solid 1px;
}*/
.surface-typecover-pdp .swatch-color-list label input:focus,
.surface-multiview-feature .swatch-color-list label input:focus,
.surface-typecover-pdp .swatch-color-list label input:focus,
.surface-multiview-feature .swatch-color-list label input:focus
{
     outline: #000 dashed 2px !important;
     display:block;
}

.surface-typecover-pdp .swatch-color-list label input:hover,
.surface-multiview-feature .swatch-color-list label input:hover
{
    cursor: pointer;
}

.m-multi-feature [role=tabpanel] .c-group .c-call-to-action
{
    color:#000;
    background: none;
    font-weight: normal;
    border:1px solid #000;
    margin-right:10px;
    padding: 10px 22px 7px 24px;
    margin-left: 0;
}
.m-multi-feature [role=tabpanel] .surface-switch-selection.c-group .c-call-to-action{border:1px #000 solid;}
.surface-switch-selection a.c-call-to-action:after{
    content:"";
}
.m-multi-feature [role=tabpanel] .c-group .c-call-to-action.c-call-to-action:focus:not(.x-hidden-focus),
.m-multi-feature [role=tabpanel] .c-group .c-call-to-action.c-call-to-action:hover{
    text-decoration: none;
    color:#000;
    background:none;
}
.surface-switch-selection a.c-call-to-action:focus:not(.x-hidden-focus) span,
.surface-switch-selection a.c-call-to-action:hover span
{
    text-decoration: none;
}
.m-multi-feature [role=tabpanel] .surface-switch-selection a.c-call-to-action:focus:not(.x-hidden-focus)
{
    outline: #000 dashed 2px;
}
.m-multi-feature [role=tabpanel] .surface-switch-selection a.c-call-to-action.active
{
    outline: 2px solid #000;
}
.surface-typecover-pdp .m-multi-feature.f-align-left>section>div [role=tablist],
.surface-fingerprint-pdp .m-multi-feature.f-align-left>section>div [role=tablist]
{
    padding-top:10px;
}

/*override for blue bg cta in multi-feature*/
.m-multi-feature [role=tabpanel] .c-call-to-action.surface-bg-cta-blue:hover,.m-hero-item .c-group>.c-call-to-action+.c-call-to-action.surface-bg-cta-blue {color:#fff;}


@media only screen and (min-width: 1084px) {
/*#surface-accessories-typecover_fingerprint .surface-accessories-pdp-rcb .m-banner{
    margin-top:150px;
}*/
}
@media only screen and (max-width: 1083px) {
    .surface-typecover-pdp .swatch-color-list, .surface-switch-selection, .surface-multiview-feature .swatch-color-list
    {
        -ms-flex-pack: center;
        justify-content: center;
    }
}


@media only screen and (max-width: 767px) {
    
.m-multi-feature [role=tabpanel] .c-group.surface-switch-selection{
    display: inline-block !important;
}
     .surface-switch-selection a:first-child
     {
         margin-bottom:10px;
     }
      .m-multi-feature [role=tabpanel] .c-group .c-call-to-action.c-call-to-action.c-glyph
      {
          display:block;
      }
      /*.surface-techspecspanel .c-table th{padding:0px}*/
}
.surface-dock-hero .c-carousel .c-sequence-indicator
{
    bottom:-20px;
}
.surface-dock-ports ol li{
    float: left;
    margin-right: 5%;
    height: 30px;
    margin-left: 5%;
}
@media only screen and (min-width: 540px) and (max-width: 1083px) {
#surface-pen .surface-multifeature-pivot .m-multi-feature.f-align-left>section>div
{
    width: 83.3%;
    margin: 0 auto;
    text-align: center;
    float: none;
}
}

#surface-accessories-typecover_fingerprint .surface-typecover-pdp .c-group.surface-switch-selection a,
#surface-accessories-typecover_fingerprint .surface-fingerprint-pdp .c-group.surface-switch-selection a{
padding-left:24px;
} 

/*Removing blue border in chrome - Hot fix*/
main:focus, section:focus, div:focus{
    outline: none;
}
.rtl #headerUniversalHeader a.m-skip-to-main{
display:none;
}

/* removing disabled cta*/
a.c-call-to-action.surface-disabled-cta:after{
    content:none !important;
}
a.c-call-to-action.surface-disabled-cta span{text-decoration:none!important;}
a.c-call-to-action.surface-disabled-cta{
    text-decoration:none!important;
    color: rgba(0, 0, 0, 0.6)!important;
    background-color: transparent!important;
    /*cursor: default!important;*/   
}
.m-content-placement-item a.c-call-to-action.surface-disabled-cta{text-align:left;padding-left:0!important;margin-left:-2px!important;padding-right: 0 !important;}

/*.confgpanel-specs .surface-replace-text.surface-disabled-cta{display:none;}*/

/*.zh-cn .surface-disabled-cta,.en-hk .surface-disabled-cta,.zh-hk .surface-disabled-cta,.ja-jp .surface-disabled-cta,.zh-tw .surface-disabled-cta{display:none!important;}*/
.zh-cn .confgpanel-specs .surface-disabled-price,.en-hk .confgpanel-specs .surface-disabled-price,.zh-hk .confgpanel-specs .surface-disabled-price,.ja-jp .confgpanel-specs .surface-disabled-price,.zh-tw .confgpanel-specs .surface-disabled-price{visibility:hidden!important;}
.zh-cn .m-panes-product-placement-item .surface-disabled-price,.en-hk .m-panes-product-placement-item .surface-disabled-price,.zh-hk .m-panes-product-placement-item .surface-disabled-price,.ja-jp .m-panes-product-placement-item .surface-disabled-price,.zh-tw .m-panes-product-placement-item .surface-disabled-price{visibility:hidden!important;}
.surface-disabled-cta:not(.configpanel-carousel-cta){padding-left:0!important;margin-left:0!important;}
.SurfaceHome_Lg_Banner_Panel_10 a.c-call-to-action.surface-disabled-cta {color:white!important;}
.surface-f-background .m-banner div a.c-call-to-action.surface-disabled-cta span {color:rgba(0,0,0,.6)!important;}

@media only screen and (min-width:540px) and (max-width:560px) { 
.surface-social-share .m-social.f-horizontal.f-follow ul>li
{
    width:40px;
}
}
@media only screen and (min-width:768px) and (max-width:1083px) {
     .surface-single-accolade{
        width:38%;
    }
}
@media only screen and (min-width:540px) and (max-width:767px) {
     .surface-single-accolade{
        width:50%;
    }
}
.surface-x-center-align{
    margin:0 auto;
    float:none;
} 
.surface-single-accolade{
    padding-bottom: 48px;
    padding-top: 48px;
}

/*******font size issues in for students at certain viewports*******/
@media screen and (min-width:768px) and (max-width:1275px) {
    .surface-indivspecs-container .spec-val.c-heading-1 {
        font-size: 36px;
    }
}

.surface-hero-pivot .m-multi-feature .m-area-heading{
    padding-top:0;
}
.surface-multifeature-pivot .m-rich-content-block{padding-left:0;padding-right:0;}	
.surface-multifeature-pivot .m-rich-content-block+ul[role='tablist']{display:inline-block;} 

.surface-adjustable-4up .m-area-heading{float:none;margin:0 auto;padding-left:0;padding-right:0;}
.surface-adjustable-4up .c-price{margin-top:15px;}
/*.surface-adjustable-4up .c-price span.pricecurrnecy{margin-left:5px;}*/
.m-area-heading.surface-areaHeadingpanel{float:none;margin:0 auto;}

.surface-padding-12px{
padding-bottom:12px !important;
} 

.surface-no-border *{
border:none !important;
} 

.c-price.surface-stacked-price>span{
    float:none;
}

.c-price.surface-stacked-price:before{
    justify-content: center;
    margin: 0 auto;
}


.surface-acc-pdp-m-hero  .c-price{
     padding-top: 16px;
    padding-bottom: 30px;
}
.surface-acc-pdp-m-hero  .m-multi-feature.f-align-left>section>div [role=tablist]{
    padding-top: 20px;
}

.surface-acc-pdp-m-hero a.c-call-to-action.c-glyph.surface-bg-cta-blue{
    margin-top: 0px;
    margin-bottom: 8px;
}
.surface-acc-pdp-m-hero p.c-paragraph{
    padding-top: 15px;
}
.surface-multifeature-pivot.surface-acc-pdp-m-hero .c-carousel li>picture.c-image img {
    margin-left: 0px;
    margin-right: 0px;
}
.surface-remove-top{
    padding-top: 0px !important;
    margin-top: 0px !important;
}
.surface-top-84{
    margin-top: 84px !important;
}


.surface-video-top-48{
    margin-top: 48px !important;
}
.surface-cp-top-84{
    margin-top: 36px !important;
}
.float_none{
    float: none;
}

@media only screen and (min-width: 540px) and (max-width: 1083px) {
    .surface-top-84{
    margin-top: 64px !important;
}

.surface-cp-top-84{
    margin-top: 16px !important;
}
}
@media only screen and  (max-width: 539px) {
    .surface-top-84{
    margin-top: 44px !important;
}
.surface-cp-top-84{
    margin-top: 0px !important;
}
}
/*.surfaceinnovation-pivotmosaic .c-mosaic-placement .c-paragraph
{
    text-align: left;
    margin-left: 5px;
}*/
.surface-config-hr-top{
    margin-top: 20px !important;
}
.surface-top-84 .accoladecarousel .m-banner .accoladeimage {
    transform: initial;
}
@media only screen and  (max-width: 767px) {
 .surface-top-84.surface-specsbanner .m-rich-content-block .surface-indivspecs-container {
    padding-bottom: 36px !important;
}
 .surface-top-84  .surface-indivspecs-container .spec-val {
    padding-top: 0px !important;
}


.surface-specsbanner.surface-top-84 .m-rich-content-block{
    padding-top: 32px;
}
}
@media only screen and (min-width: 540px) and  (max-width: 767px) {
 .surface-specsbanner.surface-top-84 .m-rich-content-block .surface-indivspecs-container:first-child .spec-val{
    padding-top: 36px !important;
}
}
.clean-vertical-paddings{
    padding-top: 0px !important;
    padding-bottom: 0px !important;
}


@media only screen and (max-width: 1399px){
.surface-top-84 .m-panes section.f-stacked {
    padding-bottom:0px;
}
}

.sl-config .config-intel-heading {
   padding-top:10px;
    padding-bottom: 16px;
}
/**.surface-adjustable-4up.surface-top-84 .m-content-placement-item .c-call-to-action{
margin-left:24px;
}**/
.surface-students-panes-top{
    margin-top:48px; 
}

/*******font size issues in for students at certain viewports
@media screen and (min-width:768px) and (max-width:1275px) {
    .surface-indivspecs-container .spec-val {
        font-size: 36px;
    }
}*******/

@media only screen and (min-width: 768px) and (max-width: 1083px){

.sl-config .cfgpanel .m-banner>[data-grid~=col-10]{
padding-left:0px;
padding-right:0px;
}
}
@media only screen and (min-width: 540px) and (max-width: 767px){

.sl-config.cfgpanel .m-banner>[data-grid~=col-10],.cfgpanel .m-banner.config-intel-heading>[data-grid~=col-10]{
margin-left:6%;
margin-right:6%;
}
}
@media only screen and (max-width: 539px){

.sl-config .cfgpanel .m-banner>[data-grid~=col-10]{
margin-left:0%;
margin-right:0%;
}
}
.specs-5up-wrapper .specs-5up-unit,.specs-5up-wrapper .specs-5up-name{
    display: inline-block;
}
/*compare css*/

@media only screen and (max-width: 350px){
    .surface-banner-ctas a:first-child
    {
        margin-right: 0px;
    }
    .surface-banner-ctas a.mscom-link.c-call-to-action.c-glyph
    {
        display:block;
    }
}
.surface-3upcompare-devices .surface-linebreak a.c-call-to-action{
margin-right:0px;
}

@media only screen and (min-width: 1399px){
.surface-vc .c-hero.f-y-center.f-transparent>div>div,.surface-vc .m-hero-item.f-y-center.f-transparent>div>div
{
    top: calc(50%);
}
}

@media only screen and (min-width:768px) and (max-width:1083px) {
.surface-top-84 .c-feature.f-align-left>div .c-heading, .surface-top-84 .c-feature.f-align-right>div .c-heading{
padding-top:24px;
}
}

/*---------------------------Pivot Hero Dynamic Text Color--------------------*/
.sur-pivot-custom-color picture{display:none;}
.sur-pivot-custom-color picture.f-active{display:block;}
@media only screen and (min-width: 1084px){
.sur-pivot-custom-color .sur-color-burgundy *,
.sur-pivot-custom-color .sur-color-blue *,
.sur-pivot-custom-color .sur-color-gold *,
.en-au .sur-pivot-custom-color .sur-color-silver *
{
	color:#fff!important;
}
}
.sur-color-undefined  .c-group  a.c-call-to-action.c-glyph{
margin-right:0px;
}

@media only screen and (min-width: 1084px){
#Innovation-in-every-detail .m-hero-item.f-y-center>div>div 
{
    color: #FFF;
}
.surface-bottom-84{
    margin-bottom: 84px;
}
.m-hero-item.f-transparent-LV5-padtop66:before{
    padding-bottom:66%;
}
}
.surface-hero-pivot-multi-img.sur-pivot-custom-color .c-pivot:not(.f-disabled)>ul>a.f-active:focus {
    background: initial;
}

.sel-piv-heading{
    margin-top: 18px;
}

html:not([lang='en-us']) .sur-pivot-custom-color.surface-pivot-hero-mob-margin .c-pivot
{
padding-top:0px;
margin-top: 0px;
}


/****rich content w/o dialogue box style****/
.surface-richcontentimage-dialogbox {padding-bottom: 6px;}
.surface-richcontentimage-dialogbox .m-rich-heading {margin-top: 84px;}

@media screen and (min-width: 768px) {
    .surface-richcontentimage-dialogbox .richcontentimage-content > p {padding-top:0px;}
    .surface-richcontentimage-dialogbox .richcontentimage-content > h3 {padding-top:0px;}
    .surface-richcontentimage-dialogbox .richcontentimage-content {
        position:absolute;
        top:50%;
        transform:translateY(-50%);
    }
}


/****Surface Laptop Techspecs hero Image fix****/
@media only screen and (min-width: 1084px) and (max-width: 1399px) {
.m-hero-item.f-transparent-LV4-padtop66:before{
    padding-bottom:66%;
}
}

.sj-config.configpanelcarousel
{
    padding-top:0px;
}

@media only screen and (min-width: 768px){
.sj-config .confgcarousel
{
    padding-bottom:0px;
}
}
@media only screen and (min-width: 1084px){
.wdg-global.surfacecom .wdg-pad-bottom-medium {
   padding-bottom: 84px;
}
}

.sj-overview .mscom-link.c-call-to-action.c-glyph.wdg-f-blue-button
{
    max-width: 150px;
    width:100%;
    margin:0 auto 5px auto;
}

.sj-overview .mscom-link.c-call-to-action.c-glyph.wdg-f-blue-button
{
    max-width: 250px;
}

@media only screen and (min-width: 540px) and (max-width: 560px)
{
.sj-overview .c-feature.f-align-center>div
{
    width: auto;
}
}
.surface-j-panes .m-panes-product-placement-item .c-group
{
    display:block;
}


/*.en-qa #surfaceAllAccessories_Browse .surface-accessoriesgrid .surfaceEssentials .surfaceJ.x-hidden,
.ar-qa #surfaceAllAccessories_Browse .surface-accessoriesgrid .surfaceEssentials .surfaceJ.x-hidden{
display:block !important;
}*/
.surface-compare-devices .surface-compare-c-chart .specification-title.compare-spacing-head2 td:first-child{
padding-bottom:16px;
}


.m-rich-heading.f-image.bannerWithImage
{
    background-color: #e3e3e3;
    color: #000;
}

.bannerWithImage.m-rich-heading>picture.c-image:after {
    background:none;
}

@media only screen and (max-width: 767px)
{
.m-rich-heading>picture.c-image+div
{
    z-index: 99;
}
.m-rich-heading.f-image.bannerWithImage
{ 
    color: #FFF;
}
}

#headerArea .surface-disabled-cta {
    background-color: transparent !important;
    color: #262626 !important;
    border:none;
}
#headerArea .surface-disabled-cta#mobile-buy-now{
    padding-left: 18px !important;
}
.m-panes .c-badge {
margin:12px 0 4px;
}
/*--------------------Surface MultiView-------------------*/
.surface-multiview-feature .swatch-color-list .surface-greyimg{display:none;}
.surface-multiview-feature .m-multi-feature .view-thumbs[role='tablist'] .c-logo.f-active .c-image:not(.current-color){display:none;}
.surface-multiview-feature .swatch-color{padding-top:10px;}
@media only screen and (max-width: 1083px) and (min-width: 540px){
    .surface-multiview-feature.surface-multifeature-pivot .m-multi-feature [role=tabpanel].f-active {
        width: 100%;    
    }
}
/*.wdg-global .wdg-pad-medium.surface-multifeature-pivot .c-paragraph-3.swatch-color
{
    display:none;
}

.en-us .wdg-global .wdg-pad-medium.surface-multifeature-pivot .c-paragraph-3.swatch-color
{
    display:block;
}*/
.surface-hero-pivot-multi-img .c-pivot:not(.f-disabled)>ul>a.f-active:focus{
    background: initial;
}
/*
.m-content-placement-item .surface-bg-cta-blue.c-call-to-action:hover span{
    
    text-decoration: none !important;
}
*/
.icon-banner #image-slide-one .m-banner {
     padding-top:0px;
     padding-bottom: 0px;
}
.icon-banner .c-heading-4.x-type-left{
    padding-bottom: 24px;
}

/*.wdg-pad-small {
    padding-top: 64px;
}*/
.banner-image .accoladecarousel{
padding-top:6px;
padding-bottom:18px;
}
.bannerimage .m-banner{
padding-top:0px;
}
#accolade-content .m-rich-content-block{
    padding-bottom: 84px;
}
.bannerimage1 .c-divider{
    padding-top: 84px;
}
@media only screen and (min-width: 1084px) and (max-width: 1126px){
.f-align-left .students-para-btm{
padding-bottom:100px;
}
.f-align-left .students-para-btm1{
padding-bottom:20px;
}
}
@media only screen and (max-width: 539px) {
.center-list .c-list{
    text-align: left;
}
}

.wdg-global .m-hero-item.wdg-f-ratio-16-9:before{padding-bottom:62.5%
    }
.c-feature>div .c-call-to-action.video-padding {
    padding-right: 15px;
}
.feature-space .c-heading-2{
padding-bottom:15px;
}
.surface-hr-contentrichblock hr.c-divider
{
    width:100%;
    clear:both;
}
.c-radio.swatch-color-list label.c-label {
    display: inline-block;
    margin-right: 10px;
}
.c-radio.swatch-color-list label.c-label input {
    width:100%;
    height:100%;
    z-index:2;
}
.c-radio.swatch-color-list label.c-label input:focus+img,
.c-radio.swatch-color-list label.c-label input:focus+img+img {
    border:#000 2px dashed;
}
@media only screen and (min-width: 768px)
{
.surface-multifeature-pivot .m-multi-feature.f-align-left>section>div,
.surface-fingerprint-pdp .m-multi-feature.f-align-left>section>div, 
.surface-typecover-pdp .m-multi-feature.f-align-left>section>div,
.m-multi-feature.f-align-left>section>div.c-carousel, 
.m-multi-feature.f-align-right>section>div
{
text-align:left;
}

.rtl .surface-multifeature-pivot .m-multi-feature.f-align-left>section>div,
.rtl .surface-fingerprint-pdp .m-multi-feature.f-align-left>section>div, 
.rtl .surface-typecover-pdp .m-multi-feature.f-align-left>section>div,
.rtl .m-multi-feature.f-align-left>section>div.c-carousel, 
.rtl .m-multi-feature.f-align-right>section>div
{
text-align:right;
}

.surface-multifeature-pivot .m-multi-feature.f-align-left>section>div>ul[role=tablist], 
.surface-fingerprint-pdp .m-multi-feature.f-align-left>section>div>ul[role=tablist], 
.surface-typecover-pdp .m-multi-feature.f-align-left>section>div>ul[role=tablist] {   
justify-content: flex-start;
}
}

.m-multi-feature [role=tabpanel] .c-group {
    display: flex;    
}
@media only screen and (max-width: 767px){
.c-radio.f-inline legend+div, .c-radio.f-inline legend+div>div
{
display:block;
}
}

.Surface_J_Overview_12_MultiFeature_Pivot_Centeralign p.c-paragraph-3
{
    order: 2;
    -ms-flex-order: 2;
    -webkit-box-ordinal-group: 3;
}
.surface-grey-banner>div{padding-top:60px;padding-bottom:60px;}

.wdg-global .wdg-theme-dark-banner {
    color: #fff;
    background-color: #5e5e5e;
}

.wdg-theme-dark-banner {
    color: #fff;
    background-color: #5e5e5e;
}

.wdg-theme-dark-banner a.c-call-to-action.c-glyph,.wdg-theme-dark-banner a.c-call-to-action.c-glyph.surface-secondary-cta {    
    color: #fff; 
    border:none;  
    background:none !important; 
}
.wdg-theme-dark-banner .m-banner .c-call-to-action:focus:not(.x-hidden-focus), 
.wdg-theme-dark-banner .m-banner .c-call-to-action:hover
{
    color: #fff;
}
.surface-sp4-banner .m-rich-heading [class^='c-paragraph'] {
    padding-top: 12px;
    padding-bottom: 16px;
}
@media only screen and (max-width: 767px){
    .surface-sp4-banner .m-rich-heading>picture.c-image {
        display:none;
    }
    .m-rich-heading>picture.c-image+div [class^='c-heading']{
        position:relative;
        bottom: initial;
        padding-top: 40px;
        padding-left: 0;        
    }
    .m-rich-heading [class^='c-heading']{
        display: block;     
    }
}
.m-content-placement-item .c-hyperlink
{
pointer-events:auto;
}

.IE11 .c-content-placement .c-hyperlink, .IE11 .m-content-placement-item .c-hyperlink
 {
     display:inline-block;
}

.surface-typecover-pdp .c-radio.swatch-color-list label.c-label{    
    margin-left: 0px;
}

/* Hot fix for IE carousel*/
.m-multi-feature.f-align-center .c-carousel.f-multi-slide.theme-light
{
    height:100%;
}

.Edge .c-content-placement .c-hyperlink, .Edge .m-content-placement-item .c-hyperlink
 {
     display:inline-block;
}

@media only screen and (max-width: 1083px) and (min-width: 768px)
{
.wdg-global .m-feature>div
{
width:100%;
}
}


.surface-remove-bottom{
    padding-bottom: 0px !important;
}

.m-content-placement-item .c-badge:empty+[class*='c-heading'] {
    padding-top: 43px;
}
.surface-compare-deviceimgblock.surface_specific_locale .m-content-placement-item .c-badge:empty+[class*='c-heading'] {
    padding-top:0px;
    margin-top: 51px;
}

@media only screen and (max-width: 1083px){
.wdg-global .wdg-pad-small>.m-banner {
    padding-top: 36px;
}
}
@media only screen and (max-width: 539px)
{
.surface-margin-top-20px {
    margin-top: -15px !important;
}
}


@media only screen and (max-width: 768px)
{
.cfgpanel.wdg-pad-thin {
    padding-top: 40px;
}
}
@media only screen and (max-width: 1083px){

.wdg-global div.c-toggle.wdg-ambient-video-toggle
{
    text-align: left;
}
}
.m-feature .c-feature .video-padding1 .surface-popup-video{
padding-right:15px;
}
.vertical-center{
    display: -ms-flexbox;
    display: flex;
    -ms-flex-pack: justify;
    justify-content: space-between;
    -ms-flex-align: center;
    align-items: center 
}
/*new sp4 banner*/
.newsp4bannertext .c-heading-4{
padding-top:25px;
}
.newsp4bannertext .c-paragraph-2 {
padding-top:5px;
padding-bottom: 20px;
}  
@media only screen and (min-width:540px){
.newsp4bannercta .c-glyph:after
{
position: absolute;
}
}
@media only screen and (min-width:768px) and (max-width:1083px){
.newsp4bannertext{
    padding-left: 20px ;
}
}

.new-sp4-banner.m-banner {
    max-width:none;
}

.new-sp4-banner.m-banner .newsp4bannertext {
    text-align:left;
}

@media only screen and (max-width:767px){
.new-sp4-banner .newsp4bannertext {
    padding-top: 10px;
}
}
@media only screen and (min-width: 768px){
.new-sp4-banner .newsp4bannercta .c-call-to-action{
    margin-top: 40px;
   /* padding-right: 40px;*/
}
}
@media only screen and (max-width: 539px){
   .newsp4bannertext .c-heading-4,.newsp4bannertext .c-paragraph-2{
padding-top:15px;
}
.new-sp4-banner{
    text-align: center;
    padding-top: 15px;
    }
.newsp4bannercta .c-call-to-action{
    padding-right: 0px; 
}
.newsp4bannertext{
    padding-left: 0px ;
} 
} 
@media only screen and (min-width:540px) and (max-width:767px){
     .new-sp4-banner img
{
    width: 100%;
}
.newsp4bannertext .c-heading-4{
padding-top:10px;
}
 .newsp4bannertext .c-paragraph-2 {
padding-top:5px;
padding-bottom: 15px;
}  
.newsp4bannertext .newsp4bannercta{
    padding-bottom: 0px;
    padding-top: 15px;
}
.vertical-center-vp2{
    display: -ms-flexbox;
    display: flex;
    -ms-flex-pack: justify;
    justify-content: space-between;
    -ms-flex-align: center;
    align-items: center 
}
}

/*@media only screen and (min-width:540px) {
    .new-sp4-banner .mscom-link {
        float:right;
    }
}*/


@media only screen and (max-width: 1083px) and (min-width: 767px)
{
.rtl .wdg-global .m-feature.f-align-right.f-image-priority>div {
    right: 0;
}
}
.surface-pad-bottom {
    padding-bottom: 0px !important;
}
@media only screen and (min-width: 1084px) and (max-width: 1185px)
{
.wdg-pad-thin.accolade-toppadding{
    padding-top: 80px;
}
}



/*--Dial Page Pivot panel--
[data-vg='SurfaceDial_1_HeroFBPivot_VG'] a.c-glyph.surface-secondary-cta:after{
    display: none;
}
[data-vg='SurfaceDial_1_HeroFBPivot_VG'] a.c-glyph.surface-secondary-cta span{
    text-align: left;
}

[data-vg='SurfaceDial_1_HeroFBPivot_VG'] a.c-glyph.surface-secondary-cta span:after{
    font-family: MWF-MDL2;
	content: "";
    margin-left:4px;
    margin-top:1px;	
}*/
[data-vg='SurfaceDial_1_HeroFBPivot_VG'] .m-hero-item>div>div,
[data-vg='SurfaceStudioInnovation_6_HeroFullBleedPivot_VG'] .m-hero-item>div>div
{
    padding-left: 5px;
    padding-right: 0px;
}
/*
.en-au .accolodeswithbanner #surface-offer-banner .m-banner p, .en-ca .accolodeswithbanner #surface-offer-banner .m-banner p, .en-hk .accolodeswithbanner #surface-offer-banner .m-banner p, .en-ie .accolodeswithbanner #surface-offer-banner .m-banner p, .en-mo .accolodeswithbanner #surface-offer-banner .m-banner p ,.en-nz .accolodeswithbanner #surface-offer-banner .m-banner p, .en-au .accolodeswithbanner #surface-offer-banner .m-banner a, .en-ca .accolodeswithbanner #surface-offer-banner .m-banner a, .en-hk .accolodeswithbanner #surface-offer-banner .m-banner a, .en-ie .accolodeswithbanner #surface-offer-banner .m-banner a, .en-mo .accolodeswithbanner #surface-offer-banner .m-banner a ,.en-nz .accolodeswithbanner #surface-offer-banner .m-banner a {
    display: none;
    
}
.en-gb .accolodeswithbanner #surface-offer-banner,.en-au .accolodeswithbanner #surface-offer-banner, .en-ca .accolodeswithbanner #surface-offer-banner, .en-hk .accolodeswithbanner #surface-offer-banner, .en-ie .accolodeswithbanner #surface-offer-banner, .en-mo .accolodeswithbanner #surface-offer-banner , .en-nz .accolodeswithbanner #surface-offer-banner{
    padding-top:20px!important;
}
*/

.surface-hero-pivot-multi-img .c-pivot>ul>a
{
	height: 100%;
}
@media only screen and (max-width: 1350px) and (min-width: 1084px)
{
   .surface-pivot-hero-mob-margin .c-pivot>header>a 
   {
    padding-left: 0px;
    }
}


/*Where-to-buy Css start*/


.surface-wheretobuy-grid > h2 {
	margin-bottom:30px;
	padding-left:12px;
}
.surface-wheretobuy-grid.m-content-placement .surface-wheretobuy-items .m-content-placement-item {
	margin-top: 16px;
	border: 1px solid #c8c8c8;
}

.buy-surface-care
{
	display: -ms-flexbox;
    display: flex;
}
.buy-surface-care p{
	 padding-left: 8px;
	 padding-top: 0;
 }
 .surface-wheretobuy-items
 {
	padding: 0 12px;
 }
@media screen and (max-width:539px) {
  .surface-wheretobuy-grid > h2 {
		margin-bottom:2px;
	}
	.surface-wheretobuy-grid.m-content-placement .surface-wheretobuy-items .m-content-placement-item {
		margin-top:23px;
	}
}
@media only screen and (max-width: 1083px)
{
.WhereToBuy_1_HeroFB .m-hero-item .c-heading-2{
padding-top: 30px;
}

.wdg-global .WhereToBuy_1_HeroFB .c-group a.c-call-to-action.x-hidden+a.c-call-to-action{

     padding: 10px 0px 7px 0px; 
}
}
@media only screen and (max-width: 539px)
{
.surface-wheretobuy-grid .surface-wheretobuy-items .surface-secondary-cta{	
	
display: block;
}
}
.WhereToBuy_1_HeroFB .m-hero-item img
{
margin-top: 20px;	
}

.WhereToBuy_1_HeroFB .m-hero-item .buy-surface-care img
{
margin-top: 0px;	
}

@media only screen and (max-width: 1083px){
.rtl .wdg-global .m-feature.f-align-right>div {
    right: 0;
    margin-right: 0;
     margin: 0 auto;
}
}

@media only screen and (min-width: 1400px) {
.surface-wheretobuy-grid .surface-wheretobuy-items .c-group  a.c-call-to-action
{
display: inline-block;
margin-left: 10px;
margin-right: 0px;
}
}
.surface-wheretobuy-grid .surface-wheretobuy-items .c-group {	
	text-align: center;
	margin-top:0px;
	margin-bottom: 25px;
}

.surface-wheretobuy-grid .surface-wheretobuy-items .surface-secondary-cta{	
	padding-left: 20px !important;
	margin-right: 4px !important;	
	
}


.surface-wheretobuy-grid .surface-wheretobuy-items a.c-call-to-action.wdg-f-blue-button
{
padding-right: 10px;
    padding-left: 10px;
    margin-left: 0px;
    margin-right: 0px;
}

a.c-call-to-action.c-glyph.wdg-f-blue-button:hover, a.c-call-to-action.c-glyph.wdg-f-blue-button:focus {
    background: #006cc2;
    text-decoration: none;
}


a.wdg-f-blue-button span, a.c-call-to-action.wdg-f-blue-button span {
    text-decoration: none !important;
}

.wdg-f-blue-button:hover+a.c-call-to-action span {
    text-decoration: none;
}

.high-contrast-mode.hcmode-black.Firefox .c-social > a, .high-contrast-mode.hcmode-black.Firefox .c-social > ul > li > a,.high-contrast-mode.hcmode-black.Firefox .m-social > a,.high-contrast-mode.hcmode-black.Firefox .m-social > ul > li > a{
background-color: #fff!important;
}

.high-contrast-mode.hcmode-black.Firefox  .surface-fingerprint-pdp .m-multi-feature .c-logo,.high-contrast-mode.hcmode-black.Firefox .surface-fingerprint-pdp .m-multi-feature .c-logo, .high-contrast-mode.hcmode-black.Edge  .surface-fingerprint-pdp .m-multi-feature .c-logo,.high-contrast-mode.hcmode-black.Edge .surface-fingerprint-pdp .m-multi-feature .c-logo{
        outline:1px solid #fff;
    }
.high-contrast-mode.hcmode-white.Firefox .surface-fingerprint-pdp .m-multi-feature .c-logo,.high-contrast-mode.hcmode-white.Edge .surface-fingerprint-pdp .m-multi-feature .c-logo {
        outline:1px solid #000;
    }
    .high-contrast-mode.hcmode-black.Firefox  .surface-fingerprint-pdp .m-multi-feature .c-logo:focus,.high-contrast-mode.hcmode-black.Firefox .surface-fingerprint-pdp .m-multi-feature .c-logo:focus, .high-contrast-mode.hcmode-black.Edge  .surface-fingerprint-pdp .m-multi-feature .c-logo:focus,.high-contrast-mode.hcmode-black.Edge .surface-fingerprint-pdp .m-multi-feature .c-logo:focus {
        outline:3px dotted #fff;
    }
.high-contrast-mode.hcmode-white.Firefox .surface-fingerprint-pdp .m-multi-feature .c-logo:focus,.high-contrast-mode.hcmode-white.Edge .surface-fingerprint-pdp .m-multi-feature .c-logo:focus {
        outline:3px dotted #000;
    }
    .high-contrast-mode.hcmode-black.Firefox  .c-radio.swatch-color-list label.c-label input + img ,.high-contrast-mode.hcmode-black.Firefox  .c-radio.swatch-color-list label.c-label input + img + img{
        border:1px solid #fff;
    }
    .high-contrast-mode.hcmode-white.Firefox  .c-radio.swatch-color-list label.c-label input + img ,.high-contrast-mode.hcmode-white.Firefox  .c-radio.swatch-color-list label.c-label input + img + img{
        border:1px solid #000;
    }
/*Where-to-buy Css END*/
@media only screen and (min-width: 540px) and (max-width: 654px){
[data-vg='SurfaceDial_1_HeroFBPivot_VG'] .m-hero-item>div,
[data-vg='SurfaceStudioInnovation_6_HeroFullBleedPivot_VG'] .m-hero-item>div{
    width: 88%;
}
}
.surface-hero-high-contrast .m-hero-item .c-group .studio-hero-button{
    background: #0067B8 !important;
    /*background: #0078d7 !important; Changed color as per accessibility*/
    padding-right: 25px;
}



/*WDA and STC Pages CSS start*/ 

.Surface_WDA_Hero_custom a.c-call-to-action.c-glyph.surface-bg-cta-blue{    
    margin-top:24px !important;
    margin-bottom: 15px;
    margin-right: 0px !important;
}

.Surface_WDA_Hero_custom .m-feature .c-price
{
     margin-top:24px;    
}

.Surface_WDA_Hero_custom .m-feature .c-caption-2 
{    
   margin-bottom:8px;
}

.float-none
{   
    float: none !important;
}

@media only screen and (min-width: 768px){
.Surface_WDA_Hero_custom .m-feature .c-heading-2
{
    padding-top: 0px;
}
}
.ContentPlacement_youtubeVideo_2up .m-content-placement-item .c-video
{
pointer-events:auto;
}

@media only screen and (max-width:1400px) { 
.ContentPlacement_youtubeVideo_2up iframe.deviceUtubeVid{
min-height: 310px;
}
}

@media only screen and (min-width:768px) and (max-width:1083px) { 
.ContentPlacement_youtubeVideo_2up iframe.deviceUtubeVid
{
min-height: 395px; 
}
}

@media only screen and (min-width:540px) and (max-width:767px) { 
.ContentPlacement_youtubeVideo_2up iframe.deviceUtubeVid{
min-height: 314px;
}
}
@media only screen and (min-width:320px) and (max-width:540px) { 
.ContentPlacement_youtubeVideo_2up iframe.deviceUtubeVid{
min-height: 314px;
}
}

 .Surface_WDA_Hero_custom .m-multi-feature  .c-paragraph-2
{
    padding-top:18px;
}


@media only screen and (min-width: 768px){
.Surface_WDA_Hero_custom .m-multi-feature .c-heading-2
{
    padding-top: 0px;
}
}

.Surface_WDA_Hero_custom .m-multi-feature .c-price
{
     margin-top:24px;
     padding-top: 0px;
     padding-bottom: 0px; 
}

.Surface_WDA_Hero_custom .m-multi-feature .c-radio.swatch-color-list label.c-label
{
    margin-top:4px;
}

.wdg-media-gallery .c-group
{
    margin-top: 0px;
}
.m-media-gallery .c-carousel picture:after{
    
    background: rgba(0,0,0,0);
}

.m-media-gallery  .c-carousel .f-gallery li:hover picture:after{
 background: rgba(0,0,0,0);
}
.wdg-media-gallery .c-carousel .f-gallery li{
    cursor: default;
}
/*WDA Page CSS END*/ 
.accolodeswithbanner #surface-offer-banner .m-banner p,
.accolodeswithbanner #surface-offer-banner .m-banner a
{
display: none;
}
.en-us .accolodeswithbanner #surface-offer-banner .m-banner p,
.en-us .accolodeswithbanner #surface-offer-banner .m-banner a,
.en-gb .accolodeswithbanner #surface-offer-banner .m-banner p,
.en-gb .accolodeswithbanner #surface-offer-banner .m-banner a
{
display:block;
}
/*section[data-vg='Surface_Home_OfferBanner_VG']{
    padding-top: 20px;
}

.fr-be section[data-vg='Surface_Home_OfferBanner_VG'], 
.fr-lu section[data-vg='Surface_Home_OfferBanner_VG'],
 .nl-be section[data-vg='Surface_Home_OfferBanner_VG'],
 .nl-nl section[data-vg='Surface_Home_OfferBanner_VG'],
 .en-sg section[data-vg='Surface_Home_OfferBanner_VG'],
 .it-it section[data-vg='Surface_Home_OfferBanner_VG'],
 .de-lu section[data-vg='Surface_Home_OfferBanner_VG'],
 .en-my section[data-vg='Surface_Home_OfferBanner_VG'],
 .ms-my section[data-vg='Surface_Home_OfferBanner_VG']
 {
      padding-top: 48px !important;
 }*/
@media only screen and (max-width:1083px) {
.zh-cn .wdg-global .WhereToBuy_1_HeroFB .m-hero-item .c-group>.c-call-to-action+.c-call-to-action+.c-call-to-action{
    margin-left: 40px;
}
}

.zh-cn .wdg-global .WhereToBuy_1_HeroFB .m-hero-item .c-group>.c-call-to-action+.c-call-to-action+.c-call-to-action{
    margin-left: 35px;
}

@media only screen and (min-width:540px) and (max-width:1083px) {
.whereToBuy-fullStoreList .surface-wheretobuy-items
{
width: 33.3333333333%;
}
}
@media only screen and (min-width:1084px) and (max-width:1120px) {
   .surface-youtubevidplayer .c-paragraph-2.book-right-padding{     
    padding-right: 10px;
   }
}
@media only screen and (min-width:1399px) and (max-width:1401px) 
{
    .surface-youtubevidplayer .c-paragraph-2.book-right-padding{ 
        padding-bottom: 52px;
    }
}
.m-content-placement-item.cursor-pointer-none a{
    pointer-events: none !important;
    cursor: default !important;
}


/*Surface plus css */
.en-us .c-price-hide .m-content-placement-item .c-price 
{
display:none;
}
.surface-finance{display: none;}
/*Surface plus css end*/

.WhereToBuy_1_HeroFB .m-hero-item .c-heading-2{
padding-top: 12px;
}

/* COS Changes */
.surface-clear-both
{
    clear:both;
}
.surface-bold .c-heading-2
{
    font-weight:bold;
}
.surface-para-padding .c-paragraph-2 strong.surface-linebreak
{
    padding:5px;
}

.multivideosplayer{display: none;}



/*Surface Z Home page*/
.z-offer-banner{
    border: 1px solid rgba(0,0,0,.2);
}

@media only screen and (min-width: 768px) {
.z-offer-banner .newsp4bannercta{
    text-align: right;
}
}
@media only screen and (max-width: 1083px) {
    .accolodeswithbanner .accolade-paddings{
        margin-top: 0px !important;
}
}

/*Accessories CSS*/
@media only screen and (max-width:1400px) {
#surfaceAllAccessories_Browse .surface-products-category .surface-product-items .surface-secondary-cta{
    margin-left: 0px;
}
}
@media only screen and (min-width:1400px) {
#surfaceAllAccessories_Browse .surface-products-category .surface-product-items .surface-secondary-cta{
    margin-left: 10px;
}
}

/* Surface Z*/
.surface-compare-stickybar .c-price span, .surface-compare-deviceimgblock .c-price span,
.surface-compare-devicebottom .c-price span
{
    float:none;
}
@media only screen and (min-width: 768px) {
[data-vg='Surface_Z_Overview_6_SpecsBanner_VG'].surface-specsbanner .surface-indivspecs-container
{
    border-right: 2px solid #F2F2F2;
    min-height: 110px;
}
[data-vg='Surface_Z_Overview_6_SpecsBanner_VG'].surface-specsbanner .surface-indivspecs-container:last-child
{
    border-right:0px;
}
}
@media only screen and (min-width: 540px)and (max-width: 767px) {
  [data-vg='Surface_Z_Overview_6_SpecsBanner_VG'].surface-specsbanner .surface-indivspecs-container
{
    padding-top:24px;
} 
  [data-vg='Surface_Z_Overview_6_SpecsBanner_VG'].surface-specsbanner .surface-indivspecs-container:first-child
{
    padding-top:0px;
} 
}
.surfacez-custom-pivot picture,.surfacez-custom-pivot ul div
{
    display:none;
}
.surfacez-custom-pivot picture.f-active, .surfacez-custom-pivot ul div.f-active
{
    display:block;
}
  .surfacez-custom-pivot .c-image.active, .surfacez-custom-pivot .f-active .c-image.inactive
  {
      display:none
  }
  .surfacez-custom-pivot .f-active .c-image.active
  {
      display:inline-block;
      float:left;
      margin-right: 18px;
  }
.surfacez-custom-pivot .c-pivot:not(.f-disabled)>ul>li> a.f-active
{
    border:none;
}
.surfacez-custom-pivot a.c-logo
{
    display:inline-block;
    width:100%;
    margin-left: 0px;
    margin-top: 0px;
}

/*For accessibility*/
.surfacez-custom-pivot .z-pivot a.c-logo:focus{
height:inherit;
}

  .surfacez-custom-pivot .c-image.inactive
 {
     display:inline-block;
    float:left;
    margin-right: 18px;
 }
 .surfacez-custom-pivot .c-logo .c-heading-3
 {
    display:inline-block;
    /*white-space: normal;*/
 }
 .surfacez-custom-pivot ul
 {
     display:block !important;
 }
 
 .surfacez-custom-pivot .c-pivot:not(.f-disabled)>div>a.f-active:focus:not(.x-hidden-focus), 
 .surfacez-custom-pivot .c-pivot:not(.f-disabled)>ul>a.f-active:focus:not(.x-hidden-focus)
 {
     background: none;
     outline: -webkit-focus-ring-color auto 5px;
 }
 .surfacez-custom-pivot .c-logo.f-active .c-heading-3{
    font-size: 30px;
}
.surfacez-custom-pivot .c-pivot .c-heading-3{
    font-size: 20px;
}  
.surfacez-custom-pivot .c-heading-3 {
padding-top:0px;
}

@media only screen and (min-width: 1084px){
    .surface-color-white
    {
        color:#fff;
    }
}
@media only screen and (max-width: 1083px){
    .m-image-intro.f-align-top.surface-color-white>div,
    .m-image-intro.f-align-top.surface-color-black>div
    {
        position:relative;
    }
}

@media only screen and (min-width: 1084px) {
    .m-image-intro.f-align-top.surface-color-white>div,
    .m-image-intro.f-align-top.surface-color-black>div {
        width:100%;
        -webkit-transform: translateX(-50%);
        -moz-transform: translateX(-50%);
    }
}

@media only screen and (min-width: 768px){
.SurfaceAcc_V_1_SwitchpanelHero .m-feature .c-heading-2
{
padding-top:0px;
}

}
@media only screen and (max-width: 1083px){
    .surfacez-custom-pivot  .z-pivot{
        margin-left: 0px
    }
  .surfacez-custom-pivot .c-paragraph-2{
      text-align: left;
  }

}

@media only screen and (min-width: 1084px) and (max-width: 1600px) {
.surfacez-custom-pivot .m-hero-item.f-x-right>div>div
{
   max-width: 385px;
}
}
@media only screen and (max-width: 767px) {
.surfacez-custom-pivot .m-hero-item>div 
{
    width:100%;
}
}
.SurfaceAcc_V_1_SwitchpanelHero .m-feature .c-caption-1
{
padding-top:24px;
}

.SurfaceAcc_V_1_SwitchpanelHero .m-feature a.c-call-to-action.c-glyph.surface-bg-cta-blue
{
margin-top: 24px !important;
    margin-bottom: 8px;
    margin-right: 0px !important;
}

.surface-compare-stickybar .m-content-placement-item .c-badge:empty+[class*='c-heading']
{
padding-top: 43px !important;
}
.surface-compare-stickybar.surface-compare-stickybar-locale .m-content-placement-item .c-badge:empty+[class*='c-heading']
{
margin-top: 41px !important;
padding: 0!important;
margin-bottom: 15px;
}

/*Tech Specs heading Style*/
/*.headinglinebreak
{
    padding-bottom:7px;padding-top:10px;display:block;
}
*/
/*.surface-z-techspecs .m-system-requirements .c-table.f-divided tbody tr:first-child
{
   border-top: 1px solid rgba(0,0,0,.1);
}*/
.surface-z-techspecs .m-system-requirements .c-table.f-divided tbody tr:last-child
{
    border-top:0;
}
 .surface-compare-devices .specification-title td p:only-child :first-child
{
padding-top:0px;
}

@media only screen and (max-width:1083px) {
    .surfacez-custom-pivot .c-logo .c-heading-3 {
    float: left;
}}
@media only screen and (max-width:440px) {
    .surfacez-custom-pivot .c-logo.f-active .c-heading-3 {
    font-size: 24px;
}}

.price-hide{
    display: none;
}
.surface-text-transform a.mscom-link.c-call-to-action.c-glyph span
{
    text-transform: uppercase;
}
.surface-text-transform .m-banner .c-price span
{
    float:none;
}
/*Inline Video CSS----*/
/*.yt-video-inline-height iframe{min-height:33.75vw}
.c-feature.f-image-priority  iframe{min-height:32.51vw}*/
/*.m-content-placement-item.c-video{min-width:50px}*/
/*.full-grid-2-up .m-content-placement-item.c-video iframe{min-height: 24.5vw;}*/
/*@media screen and (min-width:1600px){
    .c-feature.f-image-priority.utube-video iframe{min-height: 585px;}
}*/
/*@media screen and (max-width:1083px) {
 .yt-video-inline-height iframe{min-height:56.25vw}
 .c-feature.f-image-priority iframe{min-height:56.25vw}
}*/
/*@media screen and (max-width:539px) {
 .m-content-placement-item.c-video iframe{min-height: 51.75vw;}
}*/



.c-group .x-type-center.surface-disabled-cta
{
margin-right:0px !important;
}

.adobe-offer p
{
padding-bottom: 30px;    
    
}

/*NFL Component */
.logo-wrapper .logo {
    float:left;
    width:50%;
}

.logo-image-50px img {
    height: 50px;
    margin-top: 50px;
}

@media screen and (min-width:540px) and (max-width:750px) {
    .logo-wrapper .logo {
        width:100%;
    }
}

.NFLiconimages .box{
	max-height: 180px !important;
}
.m-feature .NFLiconimages .selectMe picture img:hover {
 cursor: pointer !important;   
} 

.rules-scroll {
    max-height: 400px;
    overflow-y: scroll;
}
.wdg-pad-medium.NFL-rules {padding-top:0;}
.NFLiconimages .c-combo{
    margin-top: 0px;
    }
    .NFLiconimages .c-caption-1{
        padding-top: 24px;
        padding-bottom: 8px;
    }
    .NFLiconimages .c-heading-2 {
        padding-bottom: 0px;
    }
    .NFLiconimages .c-paragraph-2{
        padding-top: 24px !important;
        padding-bottom: 0px;
    }
    .NFLiconimages.NFL-Hero-pad .c-caption-2{
        padding-top:24px;
    }
    .nfl-clear-pad{
        clear: both;
    }
@media only screen and (min-width: 1084px) {
.NFLiconimages .box picture{
    width: 20% !important;
}
.m-highlight-feature .featurehighlight{
    width: 40%;
    display: block;
    flex-direction: none;
}
.m-highlight-feature .featurehighlight .c-heading{
     margin-top:25%;
     padding-bottom:20px;
}
.m-highlight-feature .featurehighlight .div1{
width:50%;
display: inline-block;
}
.NFLiconimages .c-drawer .accordianplus
{
width: 55%;
padding-left:0px;
padding-bottom:20px;
padding-top: 25px;
font-size:18px;
}
.NFLiconimages .c-drawer .accordianminus{
font-size:18px;
padding-left: 0px;
width: 55%;
}
.NFLiconimages .c-table td:first-child{
padding-left:0px;
}
}

.surface-readmore:empty{
    display:none;
}

@media only screen and (min-width: 540px) and (max-width:767px) {
    .m-highlight-feature .featurehighlight .div1{
        width: 50%;
        float: left;
    }
    .m-highlight-feature .featurehighlight .c-heading{
     padding-bottom:20px;
}
}
@media only screen and (min-width: 768px) and (max-width:1083px) {
    .NFLiconimages .c-drawer .accordianplus{
        width: 50%;
        left: 25%;
    }
    .NFLiconimages .c-drawer .accordianminus{
         width: 50%;
        left: 25%;
    }
}
@media only screen and (max-width: 767px) {
    .m-system-requirements .hide767{
        display: none;
    }
      .NFLiconimages .c-drawer .accordianplus{
        width: 70%;
        left: 15%;
    }
    .NFLiconimages .c-drawer .accordianminus{
          width: 70%;
        left: 15%;
}
.surface-compare-stickybar.surface-compare-stickybar-locale .m-content-placement-item .c-badge:empty+[class*='c-heading']
{
margin-bottom: 0px;
}
}
@media only screen and (max-width: 1083px) {
.NFLiconimages .c-price span{
    text-align: center;
    }
    .m-feature .NFLiconimages .selectMe picture {
        width: 20%;
        float: left;
    }
     .m-feature .NFLiconimages .selectMe span{
         text-align: left;
         padding-left: 60px;
     }
     .NFLiconimages .c-combo{
         margin: 0 auto;
     }
     .NFLiconimages .c-caption-1{
         padding-bottom: 15px;
     }
     .NFLiconimages .c-price span{
         float: none;
     }
     .NFLiconimages .c-drawer .accordianplus
{
font-size:18px;
}
.NFLiconimages .c-drawer .accordianminus{
font-size:18px;
padding-left: 10px;
}
.NFLiconimages .c-table td:first-child{
padding-left:10px;
}
}
.wdg-f-horizontal ul>li{
    float: left;
}
.NFLiconimages ul#refineDrawer{
    height: 0px; overflow: hidden;
}
.dropdownNFL .c-drawer>button[aria-expanded=false]:after,.dropdownNFL .c-drawer>button:after{content:"+"; font-size: 20px;}.dropdownNFL .c-drawer>button[aria-expanded=true]:after{content:"-";font-size: 20px;} 
.dropdownNFL .c-drawer>button:hover{
    background: none;
}
.dropdownNFL .c-drawer>button[aria-expanded=true].accordianplus:after, .dropdownNFL .NFLimages picture{
    display: none;
}
.dropdownNFL .NFLimages picture:first-child{
    display: block;
}
.m-feature .NFLiconimages .selectMe picture img
{
    height: 43px !important;
}
.surface-hero-high-contrast .m-hero-item .c-group .surface-hero-button
{
    background: #0067B8 !important;
    /*background: #0078d7 !important; Changed color as per accessibility*/
    color:#fff !important;
}
.surface-hero-high-contrast .m-hero-item .c-group .surface-hero-button:hover
{
    background: #006cc2;
}

.nfl-surface-techspecspanel .m-system-requirements .c-table.f-divided tbody tr:last-child {
    border-top: 0;
}


.nfl-surface-techspecspanel .m-system-requirements .c-table.f-divided tbody tr:first-child{
border-bottom: 1px solid rgba(0,0,0,.1);
}

.dropdownNFL .c-combo button:hover {
    color: #000;
}
[data-vg='NFL_Typecover_Feature_1_panel_VG'] .m-feature
{
z-index: -1;
}
.NFLiconimages .c-combo:focus
{    
    outline-color: inherit;
}

.c-combo input[type=text]:active, .c-combo input[type=text]:focus
{
        border-color: inherit;
}
.rules-scroll {
  padding-right: 30px;
  padding-left: 30px;
}
.m-feature .Compare-feature-pad{
    padding-top: 110px;
}
.rules-scroll .mscom-link{
    color: #006cc2;
    text-decoration: underline;
   
}

/* IE10+ specific styles for accessibility */  
@media screen and (-ms-high-contrast: active), (-ms-high-contrast: none) {  
 .surfacez-custom-pivot :not(.f-disabled).c-pivot > div > a:not(.x-hidden-focus).f-active:focus, 
.surfacez-custom-pivot :not(.f-disabled).c-pivot > ul > a:not(.x-hidden-focus).f-active:focus{
    outline: black dotted 2px; 
}
}

.Firefox .surfacez-custom-pivot :not(.f-disabled).c-pivot > div > a:not(.x-hidden-focus).f-active:focus, 
.Firefox .surfacez-custom-pivot :not(.f-disabled).c-pivot > ul > a:not(.x-hidden-focus).f-active:focus
{
        outline: black dotted 2px; 
}

.Windows.Edge .surfacez-custom-pivot :not(.f-disabled).c-pivot > div > a:not(.x-hidden-focus).f-active:focus, 
.Windows.Edge .surfacez-custom-pivot :not(.f-disabled).c-pivot > ul > a:not(.x-hidden-focus).f-active:focus{
    outline: black dotted 2px; 
}
.surface-business-twoup .m-content-placement a.mscom-link{
    border-left-width: medium;
}

#surface-Studio-Innovation section[data-vg='SurfaceStudioInnovation_6_HeroFullBleedPivot_VG'] .c-call-to-action:focus:not(.x-hidden-focus):not(.wdg-f-blue-button){
padding-left:0px;
margin-left:0px;
}
.contentPlacement_pointer .m-content-placement-item
{
        pointer-events: auto;
        cursor: pointer;
} 

@media screen and (-ms-high-contrast: active){  
[data-vg='Surface_students_1_MultiFeaturePanel_VG'] .c-pivot.surface-pivot-content div a.f-active:focus{
outline:dotted white 1px;
}
.surfacez-custom-pivot .z-pivot div{
background:black;
}
}

.high-contrast-mode.Firefox [data-vg='Surface_students_1_MultiFeaturePanel_VG'] .c-pivot.surface-pivot-content div a.f-active:focus{
outline:dotted white 1px;
}
.high-contrast-mode.Firefox .surface-business-twoup .m-content-placement a.mscom-link{
    border-left-width: medium;
}
.high-contrast-mode.Firefox .surfacez-custom-pivot .z-pivot div{
background:black;
}

/*NFL Accessibility*/
.NFLiconimages #refineDrawer .c-table .c-drawer .accordianminus:focus{
    outline: #000 dashed 1px;
    margin:1px;
}

.c-pivot:not(.f-disabled)>div>a.f-active:focus:not(.x-hidden-focus), .c-pivot:not(.f-disabled)>header>a.f-active:focus:not(.x-hidden-focus) {
background: none !important;
outline: #000 dashed 2px !important;
}

 .high-contrast-mode.hcmode-black.Firefox  .c-pivot > header{
    background: black;
} 

.high-contrast-mode .c-combo button:active, .high-contrast-mode .c-combo button:focus,.high-contrast-mode .selectMe li[role='option'] span:focus{
outline:dotted white 2px;
}  

.hcmode-black .m-hero-item>div>div{background-color:#000;}

.c-menu-item a:focus, .c-menu-item button:focus, .c-menu-item span:focus, .theme-dark .theme-light .c-menu-item a:focus, .theme-dark .theme-light .c-menu-item button:focus, .theme-dark .theme-light .c-menu-item span:focus, .theme-light .c-menu-item a:focus, .theme-light .c-menu-item button:focus, .theme-light .c-menu-item span:focus
{
outline:#000 dashed 2px !important;
}

@media screen and (-ms-high-contrast: active){  
    
    .surfacez-custom-pivot :not(.f-disabled).c-pivot > div > a:not(.x-hidden-focus).f-active:focus, .surfacez-custom-pivot :not(.f-disabled).c-pivot > header > a:not(.x-hidden-focus).f-active:focus{
      outline: 2px dotted #fff !important;
      height: inherit;  
    }
}

.high-contrast-mode.Firefox .accoladecarousel .m-banner .accoladeimage a img:focus
{
    outline: solid 2px;
}
@media screen and (-ms-high-contrast: active){  
.wdg-m-prefooter nav.c-link-navigation li a.c-hyperlink.f-image:focus img
{
         outline: 2px dashed #fff;
   
}
}

.surfacecompletebuy.surface-hero-high-contrast .c-group .mscom-link.c-call-to-action.c-glyph{
padding-right:20px;
margin-right:0px
}

.high-contrast-mode.Firefox .surface-hero-pivot-multi-img.surface-hero-high-contrast.surface_pivot_location_target .surface-caption-text div div,
.high-contrast-mode.Firefox .surface-hero-pivot-multi-img.surface-hero-high-contrast.surface_pivot_location_target .surface-caption-text div div .c-pivot header{
    background:none;
}

.high-contrast-mode.Firefox .surface-laptop-lifestyle-highcontrast [data-grid="container"] div{
    background:black;
}

@media screen and (-ms-high-contrast: white-on-black) {
    .surface-laptop-lifestyle-highcontrast [data-grid="container"] div{
    background:black;
}
}

.high-contrast-mode.Firefox button.c-action-trigger
{
    outline: none;
}

.high-contrast-mode.Firefox button.c-action-trigger:focus
{
outline: 2px dashed transparent;
}

.high-contrast-mode button.c-action-trigger
{
    outline: none;
}  

.hcmode-black.Edge .c-combo button:active, .hcmode-black.Edge .c-combo button:focus,
.hcmode-black.Edge .selectMe span:focus,.hcmode-black.Edge .selectMe span:active{border:dashed 2px #fff !important;}


/*ATL carousel*/
.atl-caro-heading {
    position: absolute;
    top:0;
    left:0;
    text-align: center;
    width:100%;
}

.c-carousel.absolute-heading-margin {
    margin-top:160px;
}

.m-multi-feature .banner-link-spacing a.c-call-to-action {
    padding: 10px 16px 7px 0;
}

@media only screen and (min-width: 768px) and (max-width: 950px)
{
    .atl-caro-heading{
    font-size: 46px;
    line-height: 56px;
    padding: 37px 0 3px;
}
}

@media only screen and (max-width: 768px){
.c-carousel.absolute-heading-margin {
    margin-top:170px;
}
}

.configpanelcarousel .cfgpanel .c-carousel .confgpanel .confgpanel-surface-IC .confgpanel-specs p.c-caption-1
{
margin-left: 20px;

}

.surface-custom-srm .m-system-requirements.f-single-column .c-table th
{
        font-weight: 700;
}

.surface-compare-c-chart tbody tr td span.surface-cmpr-heading {
    font-weight: 700;
    font-size: 18px;
    line-height: 24px;
    display: block;
    padding-bottom: 8px!important;
}

.surface-compare-c-chart tbody tr .x-screen-reader{
    width:0px !important;
}

.surface-compare-c-chart tbody tr td:not(.surface-cmpr-vsbl) .surface-cmpr-heading{
    position: relative !important;
    /*height:auto !important;*/
}

.surface-compare-devices.surface-custom-srm .m-system-requirements .c-table tr td:first-child{
    font-weight:400;
}

.surface-compare-devices.surface-custom-srm .m-system-requirements .c-table tr th{
    padding-bottom:0px;
}


.surface-compare-devices.surface-custom-srm .m-system-requirements .c-table caption.c-heading-3{
    font-size:34px;
    font-weight:100;
    line-height: 40px;
}

.surface-compare-devices.surface-custom-srm .c-table caption{
    padding-bottom:15px;
    
}

.surface-compare-devices.surface-custom-srm .c-table caption,
.surface-compare-devices.surface-custom-srm .c-table tr td, 
.surface-compare-devices.surface-custom-srm .c-table tr th{
    padding-left:24px;
}

.surface-compare-devices.surface-custom-srm .c-table tr:last-child, .surface-compare-devices.surface-custom-srm .c-table thead{
    border-bottom: none;
}

@media only screen and (min-width: 768px) {
.surface-4-col .surface-compare-c-chart .c-table tr td{
    width:25%;
}

.surface-3-col .surface-compare-c-chart .c-table tr td{
    width:33.3%;
}
}

@media only screen and (max-width: 767px) {
    
    .m-system-requirements .c-table caption.c-heading-3{
    font-size:26px;
    line-height: 32px;
    }

    .surface-compare-devices.surface-custom-srm .c-table caption,
    .surface-compare-devices.surface-custom-srm .c-table tr td, 
    .surface-compare-devices.surface-custom-srm .c-table tr th{
        padding-left:12px;
}

.surface-compare-devices tr[class*='Compare-block-'] td[class*='techspecs-block-']{
    width:50%;
    min-width: 0px !important;
}

}

@media only screen and (max-width: 539px) {
.surface-compare-devices .m-system-requirements.f-single-column .c-table.f-divided tbody>tr{
    display:table-row;
}
}

.c-table.f-divided tbody tr{
    border-bottom:1px solid rgba(0,0,0,.2);
}


.c-rating{display:inline-block;position:relative;}
.ratingPlugin.bv-stars-container{margin-top:8px;}
.totalrating{margin-left:1px;margin-right:1px;vertical-align: top;}
.c-rating a.c-glyph:before,.c-rating a.c-glyph::before{position:relative;transform: translate(0,0);width:16px;height:16px;margin-right: 3px;}
.c-rating a.c-glyph:after,.c-rating a.c-glyph::after{top:0;left:0;transform: translate(58%,0);z-index:2;width:16px;height:16px;margin-right: 3px;}
.IE11 .c-rating a.c-glyph::before{transform: translateX(50%);}
.bv-rating-stars-container .ratings-margin{
margin-top: 0px !important;
}
.surface-ratingmargin-left{
margin-left: -10px;
margin-top:15px
}
.c-rating[data-value] div{width:100px;}
.c-rating[data-value] div:after, .c-rating[data-value] div:before{font-size: 16px;}
.wdg-f-highcontrast .c-rating[data-value] div:after,.hcmode-black .c-rating[data-value] div:after,
.hcmode-white .c-rating[data-value] div:after,.high-contrast-mode .c-rating[data-value] div:after{background-color:#000;}

.surface-custom-srm .m-system-requirements.f-single-column .c-table th
{
        font-weight: 700;
}
.surface-custom-srm .m-system-requirements.f-single-column .c-table caption
{
    font-size:25px;
}

.surface-custom-srm .m-system-requirements.f-single-column .c-table caption.c-heading-3
{
    font-size:34px;
    line-height: 40px;
}

@media only screen and (max-width: 539px) {
.surface-custom-srm .m-system-requirements.f-single-column .c-table tr th:nth-of-type(2){
    border-top:1px solid rgba(0,0,0,.1);
}
.surface-compare-devices.surface-custom-srm .m-system-requirements.f-single-column .c-table tr th:nth-of-type(2){
    border-top:none;
}
}
@media only screen and (min-width: 540px) {
    .surface-custom-srm .m-system-requirements.f-single-column .c-table th,
    .surface-custom-srm .m-system-requirements.f-single-column .c-table td
    {
       padding-bottom:20px;
    }
}


.surface-pivot-hero-mob-margin .c-pivot ul li
{    
    display: inline-block;
}
.c-pivot>div>li:first-child, .c-pivot>header>li:first-child {
    margin-left: 0;
}
.surface-hero-pivot-multi-img ul li a{display: inline-block;}
.surface-pivot-hero-mob-margin .c-pivot  a .surface-blue-pivot-icon,
.surface-pivot-hero-mob-margin .c-pivot  li:first-child a .surface-grey-pivot-icon {
    display: none;
}
.surface-pivot-hero-mob-margin .c-pivot li:first-child a .surface-blue-pivot-icon {
     display: inline-block;
}


@media only screen and (max-width: 1083px){
.m-hero-item .c-pivot>ul {
    display: inline-block;
    margin-top: 20px;
    margin-bottom: 20px;
}}
.surfacez-custom-pivot ul li
{
    margin-top: 16px;
}

.surface-hero-pivot-multi-img .c-pivot>ul>li>a
{
   margin-left: 0px;
   margin-right: 0px;
}
.c-pivot>ul>li:first-child {
    margin-left: 0;
}

.high-contrast-mode.Firefox .accoladecarousel .m-banner .accoladeimage a:focus
{
   outline: 2px dashed;
}

.high-contrast-mode .z-pivot .c-pivot{
background-color: white;
}

.surface-hero-pivot-multi-img
{    
    pointer-events: none;
}
.surface-hero-pivot-multi-img a
{
    pointer-events: auto;
}

/*Configuratioin panel badges spacing*/
.configpanelcarousel .cfgpanel .confgpanel-specs .x-type-right.x-float-right.config-icon {
    margin-top: 20px;
    margin-right: 18px;
    margin-bottom: 9px;
}


@media screen and (-ms-high-contrast) { 
        #surfaceAllAccessories_Browse .surface-accessories-categories .surface-devicetype .c-menu .c-menu-item a[aria-checked=true],   #surfaceAllAccessories_Browse .surface-accessories-categories .surface-collections .c-menu .c-menu-item a[aria-checked=true],
        #surfaceAllAccessories_Browse .surface-accessories-categories .surface-devicetype .c-menu .c-menu-item a[aria-checked=false], #surfaceAllAccessories_Browse .surface-accessories-categories .surface-collections .c-menu .c-menu-item a[aria-checked=false],
         #surfaceAllAccessories_Browse .surface-accessories-categories .surface-devicetype .c-menu .c-menu-item a[aria-selected=true],
      #surfaceAllAccessories_Browse .surface-accessories-categories .surface-collections .c-menu .c-menu-item a[aria-selected=true],
      #surfaceAllAccessories_Browse .surface-accessories-categories .surface-devicetype .c-menu .c-menu-item a[aria-selected=false],
      #surfaceAllAccessories_Browse .surface-accessories-categories .surface-collections .c-menu .c-menu-item a[aria-selected=false]
{
background: rgba(0,0,0,1) !important;
}

.surface-accessoriesgrid .surface-collections .c-menu, 
.surface-accessoriesgrid .surface-devicetype .c-menu
{
border-top:1px solid #fff !important;
outline:1px solid #fff !important;
}
    
}

@media screen and (-ms-high-contrast: white-on-black){  
     #surfaceAllAccessories_Browse .surface-accessories-categories .surface-devicetype .c-menu .c-menu-item a[aria-checked=true],   #surfaceAllAccessories_Browse .surface-accessories-categories .surface-collections .c-menu .c-menu-item a[aria-checked=true],
     #surfaceAllAccessories_Browse .surface-accessories-categories .surface-devicetype .c-menu .c-menu-item a[aria-checked=false], #surfaceAllAccessories_Browse .surface-accessories-categories .surface-collections .c-menu .c-menu-item a[aria-checked=false], #surfaceAllAccessories_Browse .surface-accessories-categories .surface-devicetype .c-menu .c-menu-item a[aria-selected=true],
      #surfaceAllAccessories_Browse .surface-accessories-categories .surface-collections .c-menu .c-menu-item a[aria-selected=true],
      #surfaceAllAccessories_Browse .surface-accessories-categories .surface-devicetype .c-menu .c-menu-item a[aria-selected=false],
      #surfaceAllAccessories_Browse .surface-accessories-categories .surface-collections .c-menu .c-menu-item a[aria-selected=false]
{
background: rgba(0,0,0,1) !important;
}

.surface-accessoriesgrid .surface-collections .c-menu, 
.surface-accessoriesgrid .surface-devicetype .c-menu
{
border-top:1px solid #fff !important;
outline:1px solid #fff !important;
}
}

@media screen and (-ms-high-contrast: black-on-white){  
     #surfaceAllAccessories_Browse .surface-accessories-categories .surface-devicetype .c-menu .c-menu-item a[aria-checked=true],
      #surfaceAllAccessories_Browse .surface-accessories-categories .surface-collections .c-menu .c-menu-item a[aria-checked=true],
      #surfaceAllAccessories_Browse .surface-accessories-categories .surface-devicetype .c-menu .c-menu-item a[aria-checked=false],
      #surfaceAllAccessories_Browse .surface-accessories-categories .surface-collections .c-menu .c-menu-item a[aria-checked=false],
        #surfaceAllAccessories_Browse .surface-accessories-categories .surface-devicetype .c-menu .c-menu-item a[aria-selected=true],
      #surfaceAllAccessories_Browse .surface-accessories-categories .surface-collections .c-menu .c-menu-item a[aria-selected=true],
      #surfaceAllAccessories_Browse .surface-accessories-categories .surface-devicetype .c-menu .c-menu-item a[aria-selected=false],
      #surfaceAllAccessories_Browse .surface-accessories-categories .surface-collections .c-menu .c-menu-item a[aria-selected=false]
{
background: rgba(0,0,0,0) !important;
}

.surface-accessoriesgrid .surface-collections .c-menu, 
.surface-accessoriesgrid .surface-devicetype .c-menu
{
border-top:1px solid #000 !important;
outline:2px solid #000 !important;
}
.surfacez-custom-pivot .z-pivot div{
background:#fff;
}
}

@media only screen and (min-width: 1084px){
    .m-image-intro.f-align-top.surface-color-white .image-intro-cta {
        width: 100%;
    }
    .m-image-intro.f-align-top.surface-color-black .image-intro-cta {
        width: 100%;
    }
}



@media only screen and (min-width: 540px)
{
    .m-image-intro.f-align-top.surface-color-white .image-intro-cta,
    .m-image-intro.f-align-top.surface-color-black .image-intro-cta {
        left: 50%;
        top: 90%;
    }
    
    .m-image-intro.f-align-top.surface-color-white .image-intro-cta,
    .m-image-intro.f-align-top.surface-color-black .image-intro-cta {
        position: absolute;
        margin: 0 auto;
    }
}

.m-image-intro.f-align-top.surface-color-white .image-intro-cta,
.m-image-intro.f-align-top.surface-color-black .image-intro-cta {
    padding: 16px 12px;
    max-width: 100%;
    text-align: center;
}

@media only screen and (min-width: 540px)and (max-width:1083px)
{
    .m-image-intro.f-align-top.surface-color-white .image-intro-cta,
    .m-image-intro.f-align-top.surface-color-black .image-intro-cta {
        left: 50%;
        top: 90%;
    
    }    
    .m-image-intro.f-align-top.surface-color-white .image-intro-cta,
    .m-image-intro.f-align-top.surface-color-black .image-intro-cta{
        position: relative;
        margin: 0 auto;
    }
}

/*Remove cursor click event from Offer Hero Item and Trade in hero*/
.offer-panel .m-hero-item, .tradein-hero .m-hero-item {
    cursor: none;
    pointer-events: none;
}
.offer-panel .m-hero-item a, .tradein-hero .m-hero-item a{
    cursor: pointer;
    pointer-events: auto;
}
/*blue banner*/
.blue-offer
{
    background-color:#2F2F2F;
    /*background-color:#0067B8;*/
    /*background-color: #0078d7; Changed color as per accessibility*/
    margin-bottom: 10px;
}


.blue-offer.trade-in-banner {
    margin-bottom: 0;
}

.blue-offer .m-banner .blue-banner-cta {
    color: #fff !important ;
}
.padding-top-5px
{
    padding-top: 5px !important;
}

.padding-bottom-5px
{
    padding-bottom: 5px !important;
}

.blue-offer-home
{
   /*margin-top: 20px !important;  */
   /*158318 removed as per latest feedback */
   margin-bottom: 0px;
}
.blue-offer .m-banner .blue-banner-cta {
    padding-bottom: 0px;
    padding-top: 0px;
    margin-bottom: 0px;
    margin-top: 0px;
}

.blue-offer a:active, .blue-offer a:focus, .blue-offer a:hover
{
 text-decoration: underline;
}
/*techspecs stack below 767 
@media only screen and (max-width: 767px) {
.m-system-requirements.f-single-column .c-table.f-divided tbody tr td,
.m-system-requirements.f-single-column .c-table.f-divided tbody tr th 
{
display: block;
}
    .surface-custom-srm .m-system-requirements.f-single-column .c-table th:empty{
        display:none;  
} 
.surface-custom-srm .m-system-requirements.f-single-column .c-table th{
    padding-top:10px;
    padding-bottom: 10px;
}
.surface-custom-srm .m-system-requirements.f-single-column .c-table td{
    padding-bottom: 10px;
}
}*/

@media only screen and (min-width:1084px){
    .surfacez-custom-pivot .c-logo.f-active .c-heading-3{
        display: table;
    }
}
 .surface-compare-devices .c-table .surface-compare-tchspcs td strong:first-child
{
padding-top:0px;
}

@media screen and (-ms-high-contrast: black-on-white) {
.high-contrast-mode.hcmode-white .wdg-m-prefooter nav.c-link-navigation li a.c-hyperlink.f-image:focus img
{
outline:2px dashed #000 !important;
}
}
.questionandanswer{
    color:#00bcf2 ;
}
.m-banner.tradein-banner{
    margin-left: 0px;
    text-align: left;
}
.configpanelcarousel .surface-wmr-text
{
    clear: both;
    margin-left: 20px;
    color: #0067B8;
    border: 1px solid #0067B8;
    width: 125px;
    text-align: center;
    font-size: 13px;
    padding: 3px;
}
.surface-book2-wmr .confgpanel-specsandprice
{
    padding-bottom:20px;
}

.offer-panel .badge-border {
    padding: 10px 20px 10px 20px;
    border: 1px solid white;;
}

@media screen and (max-width:1083px) {
    .wdg-global .offer-panel .m-hero-item[class*=f-x][class*=f-y]>div>div.badge-spacing
    {
        margin-top:30px;
    }
}
    
@media only screen and (max-width:539px){   
.configpanelcarousel .surface-wmr-text
{
   width: 30%; 
}
}
.m-multi-feature.f-align-center .banner-link-spacing .wdg-f-blue-button.c-call-to-action:focus
{
    background: #006cc2 !important;
}
.m-multi-feature [role=tabpanel] .banner-link-spacing .wdg-f-blue-button.c-call-to-action:active
{
    background: #006cc2;
    color:#fff;
}

/*******hero carousel copied from windows********/
#mwf-hero-carousel-with-video.m-hero .c-carousel>.c-group{
    bottom: -40px;
}

#mwf-hero-carousel-with-video {
    margin-bottom: 40px;
}

@media (min-width: 768px) {
                #mwf-hero-carousel-with-video.m-hero .m-hero-item {
                                background: #FFFFFF;
                }
                #mwf-hero-carousel-with-video .c-hero>div,
                #mwf-hero-carousel-with-video .m-hero-item>div {
                                padding: 0 12px 12px 12px;
                                height: 300px;
                                position: relative;
                }
                .pt-pt #mwf-hero-carousel-with-video .c-hero>div,
                .pt-pt #mwf-hero-carousel-with-video .m-hero-item>div,
                .es-es #mwf-hero-carousel-with-video .c-hero>div,
                .es-es #mwf-hero-carousel-with-video .m-hero-item>div {
                                height: 400px;
                }
                #mwf-hero-carousel-with-video .c-hero>picture img, 
                #mwf-hero-carousel-with-video .m-hero-item>picture img {
                                position: absolute;
                                width: 100%;
                                left: 0;
                                top: 150px;
                                -webkit-transform: none; 
                                -ms-transform: none;
                                transform: none;
                                overflow: hidden;
                }
                
                .it-it #mwf-hero-carousel-with-video .c-hero>picture img,
                .it-it #mwf-hero-carousel-with-video .m-hero-item>picture img,
                .pt-pt #mwf-hero-carousel-with-video .c-hero>picture img,
                .pt-pt #mwf-hero-carousel-with-video .m-hero-item>picture img,
                .ar-ae #mwf-hero-carousel-with-video .c-hero>picture img,
                .ar-ae #mwf-hero-carousel-with-video .m-hero-item>picture img,
                .ar-sa #mwf-hero-carousel-with-video .c-hero>picture img,
                .ar-sa #mwf-hero-carousel-with-video .m-hero-item>picture img,
                .ar-qa #mwf-hero-carousel-with-video .c-hero>picture img,
                .ar-qa #mwf-hero-carousel-with-video .m-hero-item>picture img,
                .es-es #mwf-hero-carousel-with-video .c-hero>picture img,
                .es-es #mwf-hero-carousel-with-video .m-hero-item>picture img {
                    top:200px;
                }
                
                #mwf-hero-carousel-with-video .c-carousel li.f-animate-next .c-hero>picture img, 
                #mwf-hero-carousel-with-video .c-carousel li.f-animate-next .m-hero-item>picture img,
                #mwf-hero-carousel-with-video .c-carousel li.f-animate-previous .c-hero>picture img,
                #mwf-hero-carousel-with-video .c-carousel li.f-animate-previous .m-hero-item>picture img {
                                -webkit-animation: test cubic-bezier(.16,1,.29,.99) 667ms both;
                                animation: test cubic-bezier(.16,1,.29,.99) 667ms both;
                }
                #mwf-hero-carousel-with-video .c-hero.f-y-bottom>div>div,
                #mwf-hero-carousel-with-video .m-hero-item.f-y-bottom>div>div {
                                bottom: inherit;
                                top: 40px;
                }
}
@media screen and (max-width:767px) {
    #mwf-hero-carousel-with-video .c-hero>picture img, 
    #mwf-hero-carousel-with-video .m-hero-item>picture img
    {
        top:150px;
    }
    
    .it-it #mwf-hero-carousel-with-video .c-hero>picture img,
    .it-it #mwf-hero-carousel-with-video .m-hero-item>picture img,
    .pt-pt #mwf-hero-carousel-with-video .c-hero>picture img,
    .pt-pt #mwf-hero-carousel-with-video .m-hero-item>picture img,
    .ar-ae #mwf-hero-carousel-with-video .c-hero>picture img,
    .ar-ae #mwf-hero-carousel-with-video .m-hero-item>picture img,
    .ar-sa #mwf-hero-carousel-with-video .c-hero>picture img,
    .ar-sa #mwf-hero-carousel-with-video .m-hero-item>picture img,
    .ar-qa #mwf-hero-carousel-with-video .c-hero>picture img,
    .ar-qa #mwf-hero-carousel-with-video .m-hero-item>picture img,
    .es-es #mwf-hero-carousel-with-video .c-hero>picture img,
    .es-es #mwf-hero-carousel-with-video .m-hero-item>picture img
    {
        top:200px;
    }
}
#mwf-hero-carousel-with-video .c-hero.f-x-center>div>div,
#mwf-hero-carousel-with-video .m-hero-item.f-x-center>div>div {
                min-width: 80%;
}
@keyframes test {
                0% {
                                -webkit-transform: translate(10px,0%);
                                transform: translate(10px,0%)
                }

                100% {
                                -webkit-transform: translate(0,0%);
                                transform: translate(0,0%)
                }
}

@-webkit-keyframes test {
                0% {
                                -webkit-transform: translate(-10px,0%);
                                transform: translate(-10px,0%)
                }

                100% {
                                -webkit-transform: translate(0,0%);
                                transform: translate(0,0%)
                }
}

#mwf-hero-carousel-with-video .c-carousel li.f-animate-next>picture.c-image img {
                -webkit-animation: test cubic-bezier(.16,1,.29,.99) 667ms both;
                animation: test cubic-bezier(.16,1,.29,.99) 667ms both;
}

#mwf-hero-carousel-with-video .c-carousel li.f-animate-next>picture.c-image.f-x-center img {
                -webkit-animation-name: test;
                animation-name: test;
}

#mwf-hero-carousel-with-video .c-carousel li.f-animate-next>picture.c-image.f-y-center img {
                -webkit-animation-name: test;
                animation-name: test;
}

#mwf-hero-carousel-with-video .c-carousel li.f-animate-next>picture.c-image.f-y-center.f-x-center img {
                -webkit-animation-name: test;
                animation-name: test;
}
#mwf-hero-carousel-with-video .c-carousel li.f-animate-previous>picture.c-image.f-x-center img {
                -webkit-animation-name: test;
                animation-name: test;
}

#mwf-hero-carousel-with-video .c-carousel li.f-animate-previous>picture.c-image.f-y-center img {
                -webkit-animation-name: test;
                animation-name: test;
}

#mwf-hero-carousel-with-video .c-carousel li.f-animate-previous>picture.c-image.f-y-center.f-x-center img {
                -webkit-animation-name: test;
                animation-name: test;
}
/*
#mwf-hero-carousel-with-video #hero-slide-2 .m-hero-item > video {
                display: none;
}*/
/*#mwf-hero-carousel-with-video .c-call-to-action.c-glyph {
                background: 0 0;
    color: #0078D7;
    border-color: transparent;
    border-width: 2px;
}
#mwf-hero-carousel-with-video .c-call-to-action.c-glyph:after {
                content: "";
}*/
@media only screen and (max-width: 1083px) {
                #mwf-hero-carousel-with-video .video-slide.m-hero-item > picture {
                                display:block;
                }

                #mwf-hero-carousel-with-video .video-slide.m-hero-item > video {
                                display:none;
                }
               /* #mwf-hero-carousel-with-video h1
                {
                    width:100%;
                }*/
}
@media only screen and (min-width: 1084px) {
                                #mwf-hero-carousel-with-video .video-slide.m-hero-item > picture {
                                                display:none;
                                }
                                #mwf-hero-carousel-with-video .video-slide.m-hero-item > video {
                                                display:block;
                                                position: absolute;
                                                top: 0;
                                                width: 100%;
                                                left: 0;
                                }
                                #mwf-hero-carousel-with-video .c-hero.f-y-bottom>div>div,
                                #mwf-hero-carousel-with-video .m-hero-item.f-y-bottom>div>div {
                                                bottom: inherit;
                                                top: 20px;
                                }
}
#home-ard #home-hero .c-heading{
    padding: 50px 0 3px;
}

#mwf-hero-carousel-with-video .m-hero-item {
    padding-top: 150px;
}

.it-it #mwf-hero-carousel-with-video .m-hero-item,
.pt-pt #mwf-hero-carousel-with-video .m-hero-item,
.ar-sa #mwf-hero-carousel-with-video .m-hero-item,
.ar-ae #mwf-hero-carousel-with-video .m-hero-item,
.ar-qa #mwf-hero-carousel-with-video .m-hero-item,
.es-es #mwf-hero-carousel-with-video .m-hero-item
{
    padding-top: 200px;
}

#mwf-hero-carousel-with-video h1,
#mwf-hero-carousel-with-video .c-heading-1 {
    position:absolute;
    top:0;
    left:0;
    text-align: center;
    width:100%;
}
#mwf-hero-carousel-with-video button.c-action-toggle:hover
{
    color: #FFF;
    background: #000;
}
#mwf-hero-carousel-with-video button.c-action-toggle
{
    color: #000;
}
@media only screen and (max-width: 1083px) and (min-width: 540px)
{
   #mwf-hero-carousel-with-video .m-hero-item>div {
    width: 88%; 
} 
}
@media only screen and (min-width: 1400px)
{
#mwf-hero-carousel-with-video .c-hero.f-x-center>div>div,
#mwf-hero-carousel-with-video .m-hero-item.f-x-center>div>div {
                min-width: 100%;
}

}
/* Home page Hero carousel custom CSS end */
.laptop-surface-multiview-feature [role=tablist] li>a.c-logo.f-active .c-image.surface-greyimg
{
    display: none;
}

.laptop-surface-multiview-feature [role=tablist] li>a.c-logo.f-active .c-image.surface-blueimg
{
    display: block;
}


.swatch-color-list-new li a:focus
{
    border: #000 2px dashed;
}
@media only screen and (min-width: 768px)
{
     .surface-compare-c-chart tbody tr td:first-child .surface-cmpr-heading
     {
    width: auto!important;
    overflow: visible!important;
    }
    .surface-compare-c-chart tbody tr td:not(:first-child) .surface-cmpr-heading
    {
    position: relative !important;    
    overflow: hidden!important;
    width: 0%;
    block-size: 0 !important;
}
.surface-cmpr-heading.surface-auto_height{
    height:auto !important;
}
.Mac.Safari .surface-cmpr-heading.surface-auto_height{
    height:auto !important;
    padding-bottom: 8px!important;
}
}

.surface-compare-mac-text td
{
    width: 50%;
    
}
.surface-compare-mac-text table
{
    width: 100%;
    
}
.surface-compare-mac-text .m-compare-chart .c-heading-6{
    font-weight: 600;
    padding-top: 10px;
}
.surface-compare-mac-text td[class*=techspecs-block-]{
    padding: 0px;
    padding-bottom: 10px;
        padding-right: 6px;
    vertical-align: top;
}
.surface-compare-mac-text .c-table.f-divided tbody tr:last-child{
    border:none;
}
.surface-compare-mac-text tr[class*=Compare-block-]
{
border-bottom: 1px solid rgba(0,0,0,.2);
}
.surface-compare-mac-text tr[class*=Compare-block-]:last-child
{
border:none;
}
.surface-compare-mac-text thead{
    border-bottom: 1px solid rgba(0,0,0,.2);
}
 @media only screen and (max-width: 1083px)
 {
.surface-compare-mac-text  .c-table.f-divided{
    padding-left: 36px;
     padding-right:36px;
}
 }
 @media only screen and (max-width: 540px)
 {
.surface-compare-mac-text  .c-table.f-divided{
    padding-left: 24px;
     padding-right:24px;
}
 }
  @media only screen and (min-width: 540px) and (max-width:767px)
 {
.surface-compare-mac-text  .c-table.f-divided{
    padding-left: 24px;
     padding-right:24px;
}
 }
 
 .surface-compare-mac-text thead th{
     padding: 0px !important;
 }
 
  @media only screen and (max-width: 767px){
.wdg-global .surface-compare-imgs .m-content-placement>div>div~div .m-content-placement-item:not(.wdg-mar-pad-x-reset), .wdg-global .surface-compare-imgs .m-content-placement>div>div~div>div .m-content-placement-item:not(.wdg-mar-pad-x-reset) {
    margin-top: 0px !important;
}
 }
 @media only screen and (max-width: 539px){
 .surface-compare-imgs>div>div>div, .surface-compare-text [class*=Compare-block-]>[data-grid='col-6']{
     float:left;
 }
 }
 /*play pause button video*/
  .video-holder{
         position: relative;
         }
         video{
         width: 100%;
         }
         .video_pp_button span{
         display: inline-block;
         }
         .video_pp_button span:before{
         font-family: MWF-MDL2;
         }
         .video_pp_button.play-button span:before{
         content: "\E768";
         }
         .video_pp_button.pause-button span:before{
         content: "\E769";
         }
         .video_pp_button{
         position: absolute;	
         bottom: 15px;
         left: 15px;
         padding: 8px;
         border: none;
       
         }
         .video_pp_button:focus {
         outline: 2px dashed #fff;
         }
		 .play-tooltip,
         .pause-tooltip{
         display: none;
         }
		 .pause-button:focus + div .pause-tooltip{
			display: block !important;		
		 }
		 .play-button:focus + div .play-tooltip{
		  	display: block !important;		
		 }
         .video_pp_button:focus + div .play-pause-tooltip,
         .video_pp_button:hover + div .play-pause-tooltip{
         position: absolute;
         left : 55px;  
         bottom: 15px;
         background: #fff;
         padding: 5px;		
         }
         .play-pause-grey-white{
         background: #434343;
         color: #fff;
         }
         .play-pause-lightgrey-blue{
         background: #CCCCCC;
         color: #0078D7;
         }
         .play-pause-black-white{
         background: #000;
         color: #fff;
         }
         .video_pp_button.play-pause-grey-white {
             background-color: #434343 ;
         }
  .c-price .supText
{
    margin: 4px;
}
.blue-offer .m-banner .blue-banner-cta a.supBLink,.blue-offer .m-banner .blue-banner-cta a.supBLink span{
    color:#fff!important;
}
.blue-offer .m-banner .blue-banner-cta a.supBLink:focus{
    outline: 2px dotted #fff !important;
}

a.supBLink span.supText{
    margin-left:2px;
}
         @media only screen and (max-width:1083px) {
         .m-feature .c-video.pause-padding{
             padding-left: 0px !important;
             padding-right: 0px !important;
             padding-bottom: 0px !important;
         }
         }
         .Edge .high-contrast-mode .c-combo button:active, .Edge .c-combo button:focus
{
 color: #FFF;
    background: #000;
    border: 2px solid #fff;
}

@media only screen and (max-width:1150px)
{
    #mwf-hero-carousel-with-video h1,
    #mwf-hero-carousel-with-video .c-heading-1
    {
        padding:0px;
    }
}
@media only screen and (max-width:1150px)
{
    #mwf-hero-carousel-with-video h1,
    #mwf-hero-carousel-with-video .c-heading-1
    {
        padding-top: 37px;
        padding-bottom: 5px;
    }
}
 @media only screen and (max-width: 540px)
{
    #mwf-hero-carousel-with-video h1,
    #mwf-hero-carousel-with-video .c-heading-1
    {
        font-size: 36px;
        line-height: 46px;
    }
} 
 /*Surface Book2 Compare to Mac*/
 .surface-book2-ctomac .c-table{
     padding-left:32px;
     padding-right:32px;
 }
 
 .surface-book2-ctomac .c-heading-6{
     font-weight: 600;
     padding-top: 0px;
 }
 
  .surface-book2-ctomac .c-table td,
  .surface-book2-ctomac .c-table th{
      text-align: center;
      width:50%;
      padding-top:25px;
      padding-bottom:25px;
      display: block;
      float: left;
  }
       
      .surface-book2-ctomac .c-table thead .c-heading-3{
          font-size:34px;
          line-height:40px;
          color:rgba(0,0,0,1);
      }
      
 .surface-book2-ctomac .c-table tbody tr:nth-child(odd)
{
background:rgba(0,0,0,.2);
}

.surface-book2-ctomac .c-table tbody tr:nth-child(even)
{
background:rgba(0,0,0,.1);
}

.surface-book2-ctomac .c-table.f-divided tr,
.surface-book2-ctomac .c-table thead{
    border-bottom: none;
}
.sb2-compare .c-subheading-3{
    padding-top: 0px;
    padding-bottom: 0px;
}
.sb2-compare .c-paragraph-2{
    padding-top: 20px;
    padding-bottom: 0px;
}
.surface-book2-ctomac .sb2-compare .c-heading-3{
    padding-bottom: 44px;
}
/*.surface-book2-ctomac{
    padding-bottom: 35px;
}*/
@media screen and (max-width: 767px){
  .m-content-placement.sb2-chartpanel [data-grid~=stack-2]>[data-grid]
  {
    width: 50%;
    float: left;  
  } 
  .wdg-global .m-content-placement.sb2-chartpanel>div>div~div .m-content-placement-item:not(.wdg-mar-pad-x-reset){
      margin-top: 0px;
}
}  

.surface-locale-picker .m-content-placement-item{
    cursor: pointer;
    pointer-events: all;
}

/* ATL Caurosel en-gb */
.surfacepro-atlhero-gb .surfacepro-atl-heading
{
    top:85px;
    position: absolute;
    left: 0;
    text-align: center;
    width: 100%;
    
}
.surfacepro-atlhero-gb .c-carousel.absolute-heading-margin
{
    margin-top: 200px;
}
@media only screen and (min-width: 768px) and (max-width: 1149px)
{
   .surfacepro-atlhero-gb .atl-caro-heading{
        font-size: 46px;
        line-height: 56px;
        padding: 37px 0 3px;
    }

}

@media only screen and (min-width: 773px) and (max-width: 1149px) {

    .surfacepro-atlhero-gb .surfacepro-atl-heading
    {
        top:70px;
    }
    
}

@media screen and (max-width: 772px){
    .surfacepro-atlhero-gb .surfacepro-atl-heading
    {
        padding-top:10px;
    }
    .surfacepro-atlhero-gb .c-carousel.absolute-heading-margin
    {
        margin-top: 280px;
    }
}

@media screen and (max-width: 772px) and (min-width: 540px){
    .surfacepro-atlhero-gb .surfacepro-atl-heading
    {
        top:165px;
    }
}
@media screen and (max-width:539px) {
    .surfacepro-atlhero-gb .surfacepro-atl-heading
    {
        top:140px;
    }
}
@media screen and (max-width:400px){
    .surfacepro-atlhero-gb .surfacepro-atl-heading
    {
        top:28%;
    }
    .surfacepro-atlhero-gb .c-carousel.absolute-heading-margin
    {
        margin-top: 370px;
    }
} 

.surface-padding-bottom-48
{
    padding-bottom: 48px;
}
.surface-pro-accolade .accoladecarousel .m-banner
{
    padding-top:38px;
    padding-bottom: 50px;
}
.surface-greybanner .m-banner.wdg-grey-banner
{
    padding-top:48px;
    padding-bottom:48px;
}
.surface-pro-bestinclass .c-divider
{
    padding-top:48px;
}
.surface-hr-contentrichblock.surfacepro-contentrichblock .m-rich-content-block
{
    padding-top:64px !important;
    padding-bottom:48px !important;
}

.surface-pp-accessories .m-product-placement .c-carousel .m-product-placement-item .c-price span[itemprop='price'] a.supBLink
{
float:right;
}
.surface-pp-accessories .m-product-placement .c-carousel .m-product-placement-item .c-price span[itemprop='price'] a.supBLink span
{
    text-decoration: underline;
}
a.c-hyperlink.supBLink
{
    padding-right: 0px;
}

.sur-pad-0 
{
    padding: 0 !important; 
} 
.m-multi-hero .cos-under .c-heading{
text-decoration: underline;
}


.wdg-global .sidebyside .c-group a.c-call-to-action.x-hidden+a.c-call-to-action
{
    padding-right: 22px;
    margin-right:21px; 
}


.surface-hero-pivot-multi-img .c-pivot ul:empty, .m-hero-item .c-pivot>ul:empty{
    display: none !important;
}

@media screen and (max-width: 539px){
    section[data-vg='Surface_L_Overview_HeroWithPivot_VG'] .f-transparent-LV5-padtop66 .c-group.surface-margin-top-20px{
        margin-top:20px !important;
    }
}
@media screen and (max-width:646px) {
    .surface-hero-pivot-multi-img .c-pivot > ul > li:first-child {
        margin-left: 12px !important;
    }
    
    .c-pivot ul li{
        padding-top: 5px;
    }
}
@media only screen and (min-width:767px) and (max-width:1083px) {
#mwf-hero-carousel-with-video .m-hero-item>div{
    height: auto !important;
}
}
@media only screen and (min-width:1084px) and (max-width:1399px){
#mwf-hero-carousel-with-video .m-hero-item.f-x-center>div>div{
    min-width: 100%;
}
}
@media only screen and (min-width:1400px){
    #mwf-hero-carousel-with-video .m-hero-item>div{
        height: 360px;
    }
}
.cos-surface-para-padding .c-paragraph-2{
    padding-left: 5px;
    padding-right: 5px;
}
.wdg-global .cos-surface-para-padding .m-feature [class*=c-paragraph]{
    padding-top: 5px !important;
}
.cos-surface-para-padding .c-heading-2{
    padding-bottom: 12px;
}

.new-home-hero .m-hero-item .c-group>.c-call-to-action+.c-call-to-action {margin-left:0;}
.new-home-hero a.c-call-to-action.c-glyph.surface-bg-cta-blue {margin-right:15px;}
@media only screen and (min-width: 1084px){
   .surface-color-white-hero, .surface-color-white-hero .c-group .c-call-to-action
    {
        color:#fff !important;
    }    
}
@media only screen and (max-width: 1083px){
   .surface-color-white-hero .c-group .studio-hero-button.c-call-to-action
    {
        color:#fff !important;
    } 
}

/*********Create Change hero dimensions***********/

@media screen and (max-width:1399px) and (min-width:1084px) {
    .create-change-hero.m-hero-item:before {
        padding-bottom:62.5%;
    }
}


/*Accessibility fixes*/
.accoladecarousel .m-banner .accoladetext .c-blockquote{
    border:none;
    background:none;
    font-style:normal;
    
}
@media only screen and (min-width:1084px) and (max-width:1200px) { 
   .en-us .WhereToBuy_1_HeroFB .m-hero-item>div>div{
        margin-top:20px;
    }

    .en-us .WhereToBuy_1_HeroFB .m-hero-item{
        padding-bottom:45px;
    }
}
@media only screen and (max-width: 539px){
    .rtl .accoladecarousel .m-banner [data-grid*="col-"]{
float:right;
}
}
@media only screen and (max-width: 767px){
.rtl .accoladecarousel .m-banner .accoladetext{
padding-left:0px;
}
.rtl .accoladecarousel .m-banner .accoladetext{
padding-right:70px;
}
}
.high-contrast-mode.Firefox .wdg-global .m-product-placement-item .c-call-to-action:focus:not(.x-hidden-focus):not(.f-lightweight)
{
    outline: #fff dotted 2px;
}

.surface-dev-specs.surface-specsbanner .surface-indivspecs-container > div > p.spec-name{
    width:100%;
}
.high-contrast-mode .surfacepro-contrast .banner-link-spacing .surface-popup-video,
.hcmode-black .surfacepro-contrast .banner-link-spacing .surface-popup-video,
.hcmode-white .surfacepro-contrast .banner-link-spacing .surface-popup-video{
border:none;
}

.high-contrast-mode .surfacepro-contrast .banner-link-spacing .x-visible-inline-block a:last-child,
.hcmode-black .surfacepro-contrast .banner-link-spacing .x-visible-inline-block a:last-child,
.hcmode-white .surfacepro-contrast .banner-link-spacing .x-visible-inline-block a:last-child{
border:none;
}
.studio-border .m-hero-item.theme-dark .c-group>.c-call-to-action+.c-call-to-action:focus:not(.x-hidden-focus){
border:#000 dashed 2px
}
.blue-offer  .blue-banner-cta + .blue-offer-footnote a.c-hyperlink:active,.blue-offer  .blue-banner-cta + .blue-offer-footnote a.c-hyperlink{
    color:#ffffff !important;    
}

.surface-laptop-pivots .swatch-color
{
    margin-top: 15px !important;
}

.surface-laptop-pivots .c-pivot
{
    margin-top: 8px !important;
    padding-top: 0px;
}
.surface-expando .c-action-trigger:focus{
    border:2px dotted #000;
    background: none !important;
} 

.surface-expando .c-action-trigger{
    padding-right: 10px !important;
    padding-top: 5px;
} 
.IE11 nav.c-link-navigation li a.c-hyperlink{
    vertical-align: text-top;
}


a.c-hyperlink:not(.f-image):active,a.c-hyperlink:not(.f-image):focus,a.c-hyperlink:not(.f-image):hover
{
    background: none !important;
}

.m-multi-hero-item a:focus
{

background:none !important;
border:#fff dashed 2px;
}
.m-multi-hero-item a
{
display:inline-block;
}

.wdg-global .hero-with-2-anchors .c-group a.c-call-to-action{
margin-right:0px !important;
padding-right:24px !important;
}

.wdg-global .hero-with-2-anchors .c-group a.mul-hyperlink
{
margin-left:6px !important;
}
/*.m-content-placement-item sup a.c-hyperlink.supBLink{
    padding:0px !important;
}*/


.surface-display
{
    display: block;
}
.surface-specs-banner h2.c-heading-3
{
    line-height: 0px !important;
}
a.c-call-to-action.c-glyph.hero-background.surface-bg-cta-blue{
    background: #006cc2 !important;
}

.surface-external .c-price [itemprop='price']{
    text-transform: capitalize;
}

.surface-external .m-product-placement-item.f-size-medium>a>div{padding:2px;}
.surface-external .m-product-placement-item .c-heading{max-height: 80px;}
.IE11 .surface-external .c-group.f-active li picture{
    width:inherit;
}

.IE11.wdg-f-highcontrast .surface-external [data-value].c-rating div:after{
    background-color: transparent;
}
@media only screen and (min-width:768px){
    .surface-more-apps{
        position: absolute;
        right: 5.5%;
        padding-top: 10px;
    }
}
@media only screen and (max-width:767px){
    .surface-more-apps{
        position: absolute;
        width: 100%;
        text-align: center;        
        padding-top: 10px;
    }
}

p a.surface-WO-inline-cta{
    color:#0067B8;
}

@media only screen and (min-width:1084px) {
    .surface-WO-hero-themedark{
    color: #FFF;
    background-color: #333;
   
}

p a.surface-WO-inline-cta{
    color: #00bcf2;
}

/*WO Handoff Accessibility*/
.surface-WO-hero-themedark div p a.surface-WO-inline-cta:focus{
    outline: #fff dashed 2px !important;
}
}

/*WO Handoff Accessibility*/
.surface-welcome-promotionalpanel.new-sp4-banner .newsp4bannercta a.c-call-to-action.c-glyph:focus{
    outline: #000 dashed 2px !important;   
}
.surface-welcome-promotionalpanel.new-sp4-banner .newsp4bannercta a.c-call-to-action.c-glyph:focus span{
 text-decoration: underline !important;
}

.surfacez-custom-pivot .c-logo:hover h3{text-decoration:underline;}
.surface-WO-ctpt.m-content-placement-item sup a.c-hyperlink.supBLink:focus{
    padding: 10px 1px 10px !important;
}
@media only screen and (max-width: 790px) and (min-width: 768px)
{
.it-it .surface-richcontentimage-dialogbox .richcontentimage-content{
    width: 48%;
}
}
/* As per CR:[211089]. Remove this code when the new Sizzle video is ready... 
Lastest update - rights extended until 8/1
[data-vg='Surface_L_overview_1_video_VG']{display:none !important;} */

/*.m-content-placement-item.withcta:hover h3, .m-content-placement-item.withcta:hover a,.m-content-placement-item.withcta:hover a.c-call-to-action span{
    text-decoration: underline;
}
.m-content-placement-item.withcta a
{
pointer-events:auto;
}
.m-content-placement-item.withcta
{
cursor: default;
pointer-events:auto;
}
.m-content-placement-item
{
cursor: default;
pointer-events:none;
}
.m-content-placement-item.m-feature{
    pointer-events:auto;
}
.m-content-placement-item.withcta picture
{
cursor: pointer;
pointer-events:auto;
}*/

.m-content-placement-item
{
cursor: default;
pointer-events:none;
}

/*.m-content-placement-item > *
{
pointer-events:auto;
}*/

.m-content-placement-item a
{
pointer-events:auto;
}
.surface-hmc-back-button.surface-hmc-bg-gray:focus {
    border: #fff 2px dotted !important;
    outline: none !important; 
}

.surface-hmc-next-button.surface-hmc-bg-blue:focus
{
   border: #fff 2px dotted !important;
   outline: none !important; 
}


.surface-hmc-seeresults-button:focus
{
    border: #fff 2px dotted !important;   
    outline: none !important; 
}

/*OCID changes*/

.surface-laptop-immense-hero .c-carousel.f-multi-slide ul li .surface-laptop-pivots ul li{
    width:40px;
}

.oneplayer-video .wdg-oneplayer-inline{
    padding-bottom:56.28%;
}

.surface-laptop-immense-hero{
    margin-top:20px;
    }
    
.surface-laptop-immense-hero .c-carousel ul li[data-ocid] div{
    width: 100%;
}

.surface-laptop-immense-hero .c-carousel ul li[data-ocid] div>div {
    padding-left: 0;
    left: 5%;
    bottom: 48px;
}

@media only screen and (min-width:1084px)
{
.surface-laptop-immense-hero .c-carousel ul li[data-ocid] div{
margin:0px;
}

.surface-laptop-immense-hero{
    margin-bottom:60px;
}
}

@media only screen and (max-width:1083px)
{
.oneplayer-video .wdg-oneplayer-inline iframe{
    left:0;
}
}

.c-product-placement.surface-external>a:focus, .surface-external .m-product-placement-item>a:focus {
    outline: #000 dotted 2px !important;
}

.surfacez-custom-pivot .c-logo:focus h3
{
    text-decoration:underline;
}
.surfacez-custom-pivot .c-logo.f-active{
     text-decoration:underline;
}
/*.c-price .supText
{
    margin-bottom: 2px !important;
} */
/*pre footer latest updates*/
@media only screen and (min-width:1084px) {
.wdg-m-prefooter nav.c-link-navigation.prefooternavlist-3 ul li{
    width: 32%;
}
.wdg-m-prefooter nav.c-link-navigation.prefooternavlist-4 ul li {
    width:24%;
}
.wdg-m-prefooter nav.c-link-navigation.prefooternavlist-5 ul li {
    width:19%;
}
.wdg-m-prefooter nav.c-link-navigation.prefooternavlist-6 ul li {
    width:15%;
}
}
@media only screen and (min-width:540px) and (max-width:1083px) {
    .wdg-m-prefooter nav.c-link-navigation.prefooternavlist-3 ul li{
       width: 31%
   } 
    .wdg-m-prefooter nav.c-link-navigation.prefooternavlist-4 ul li {
        width:23%;
    }
    .wdg-m-prefooter nav.c-link-navigation.prefooternavlist-5 ul li {
        width:18%;
    }
    .wdg-m-prefooter nav.c-link-navigation.prefooternavlist-6 ul li {
        width:20%;
    }
    .center-list ul.c-list{
        text-align: left;
    }
    
    .center-list ul.c-list li{
        margin-left: 20%;
    }
}
.c-hero .c-group>.c-call-to-action+.c-call-to-action.surface-bg-cta-blue:active, .m-hero-item .c-group>.c-call-to-action+.c-call-to-action.surface-bg-cta-blue, .c-hero .c-group>.c-call-to-action+.c-call-to-action.surface-bg-cta-blue, .m-hero-item .c-group>.c-call-to-action+.c-call-to-action+.c-call-to-action.surface-bg-cta-blue {
    background-color: #0067B8 !important;
    /*background-color: #0078d7 !important; Changed color as per accessibility*/
}
.contentPlacement_pointer .m-content-placement-item:hover h3{
    text-decoration:underline;
}
@media only screen and (max-width: 767px)
{
nav.c-link-navigation li a.c-hyperlink.f-image 
{
overflow: visible
}
 .surface-compare-devices,
    .surface-compare-banner p,
    .surface-compare-banner.surface-compare-active p.surface-compare-mobview {
        display: none;
    }
}


div[data-vg='SurfacePro_Video_Panel_VG'].surface-pro-szlevid{
    display:none;
}

.ja-jp .surface-Genaric-c-heading-1
{
      font-size: 40px;   line-height: 50px;  padding: 24px 0 2px;        
}
.ja-jp .surface-Genaric-c-heading-2 
{
    font-size: 30px;     line-height: 40px;     padding: 38px 0 2px; margin-top: 25px;
}

.ja-jp .surface-book-c-paragraph-2
{
    font-size: 14px;line-height: 20px;    padding: 30px 0 0px;
}

/*Tech-specs*/


.surface-compare-devices .c-table .surface-compare-tchspcs td li:first-child
{
    padding-top: 0px;
}

.sb2-compare ul li.c-paragraph-2
{
     padding-top: 0px;
}

.sb2-compare ul
{
    padding-top: 20px;
    padding-bottom: 0px;
}
.headinglinebreak
{
    padding-bottom:7px;padding-top:10px;display:block;font-weight: 700;
}

.m-compare-chart p:empty {
   display: none;
}
.m-compare-chart p ul li{
   display: block !important;
}
 .surface-hero-pivot-multi-img .c-pivot  ul li a.f-active img:first-child,.surface-hero-pivot-multi-img .c-pivot  ul li a:not(.f-active) img+img{
     display: none!important;
 }
 .surface-hero-pivot-multi-img .c-pivot  ul li a.f-active img+img,.surface-hero-pivot-multi-img .c-pivot  ul li a:not(.f-active) img:first-child{
     display: block!important;
 }
.c-video.utube-video .f-external-player iframe {
    height: 100% !important;
}
.c-video-one-player.wdg-oneplayer-inline .InlinePlayerAPI iframe{
    position:absolute;
}
.c-video-one-player.wdg-oneplayer-inline{
display: inline-block;
margin: 0;
width: 100%;
min-width: 320px;
direction: ltr;
padding-bottom: 56.25%;
position: relative;
overflow: hidden;
height: 0;
}
.m-feature.f-image-priority>section.c-video-one-player.wdg-oneplayer-inline {
    display: inline-block;
    margin: 0;
    width: 65%;
    min-width: 320px;
    direction: ltr;
    padding-bottom: 36.50%;
    position: relative;
    overflow: hidden;
    height: 0;
}
.surface-Cos-Video{
    padding-left: 24px;
    padding-right: 24px;
}
.surface-ambient-video{
    padding-bottom: 37.50% !important;
}



/*Compare*/
.surface_specific_locale .compare_table .c-checkbox{
    padding-bottom: 5px;
    padding-top: 0px;
    text-align: center;
}


.surface_specific_locale .compare_table[data-grid~=col-4]{
        padding-left: 12px;
    padding-right: 12px;
    padding-bottom: 24px;
}

.compare_table_loadpanel.surface-compare-active .compare_table{
    padding-bottom: 0px !important;
    height:auto !important;
}
.surface_specific_locale .compare_table[data-grid~=col-4] .border_simple {
    border: 2px solid #e5e5e5;
}

 
    
   .surface-compare-devices-locale.surface-compare-devices.surface-compare-active{
       display: block;
   }
   
   /*.surface-compare-devices, .surface-compare-banner p, .surface-compare-banner.surface-compare-active p.surface-compare-mobview {
    display: none;
}*/

.surface-compare-devices-locale.surface-compare-devices,    
    .surface-compare-banner-locale.surface-compare-banner.surface-compare-active p.surface-compare-mobview {
        display: none;
    }

.surface-compare-devices-locale.surface-compare-devices.surface-compare-active td.hide[class*='techspecs-block-'], .surface-compare-devices-locale.surface-compare-devices.surface-compare-active th.hide[class*='techspecs-block-'] {
    display: none;
}

.surface_specific_locale.surface-compare-deviceimgblock .c-checkbox, .surface_specific_locale.surface-compare-deviceimgblock .m-content-placement .surface-devices-button button.c-button{
    display: block;
}

.surface_specific_locale.surface-compare-deviceimgblock .c-checkbox .c-label
{
    display: block;
}
.surface_specific_locale.surface-compare-deviceimgblock .c-checkbox .c-label
{
    margin-right: 0px !important;
    margin-top: 0px !important;
    padding-top: 21px !important;
    padding-right: 24px !important;
}


.surface-compare-banner-locale.surface-compare-banner.surface-compare-active a.surface-compare-mobview{
    display: block;
}

section.load_hide, div.load_hide{
    display: none;
}

.surface_specific_locale.surface-compare-deviceimgblock.surface-compare-active .m-content-placement .surface-devices-button button.c-button {
    display: none;
}

.surface_specific_locale.surface-compare-deviceimgblock.surface-compare-active .m-content-placement .surface-devices-button{
    display: none;
}

.fifty_width{
    width: 50%!important;
}

.quarter_width{
    width: 25%!important;
}

.thirty_width{
     width: 33.33%!important;
}

.surface-compare-stickybar-locale.surface-compare-stickybar .hide {
    display: none!important;
}

.surface-compare-stickybar.surface-compare-stickybar-locale.stick_onclick{
    display: none;
}

.surface-compare-deviceimgblock [data-grid~=col-4] [data-grid~=col-12]{
    padding-bottom: 30px;
}

.surface-devices-button button{
    margin-left: auto;
    margin-right: auto;
}

.hide_checkbox{
    display: none!important;
}

.surface-compare-deviceimgblock.surface_specific_locale .m-content-placement-item>picture{
    padding-bottom: 15px;
}

@media only screen and (max-width: 767px){
    .surface-compare-devices-locale.surface-compare-devices.tabhide_locale{
        display: none;
    }
    
    .surface-compare-banner-locale .c-paragraph-2:not(.surface-compare-mobview){
       display: none!important;
    }
}

.surface-productplacement-touts5up{
    width:20%;
    float:left;
}


.surface-compare-5up .m-content-placement-item .c-badge.f-small.f-highlight{
    margin-top:20px;
}
    @media only screen and (min-width:0px) and (max-width:1083px) {
    .m-content-placement .surface-productplacement-touts5up{
       width: 48%;
    margin-right: 1%;
    margin-left:1%;
    }
    
    .m-content-placement .surface-productplacement-touts5up:last-child{
        margin-left: 25%;
    }
}

@media only screen and (min-width:501px) and (max-width:1083px) {
    .m-content-placement .surface-productplacement-touts5up{
        min-height:330px;
    }
}

@media only screen and (max-width:500px) {
    .m-content-placement .surface-productplacement-touts5up{
        min-height:0px;
    }
}

.surface-compare-devices.surface-compare-devices-locale .surface-compare-c-chart tbody tr .first_display_visible .surface-cmpr-heading{
        width: auto!important;
    overflow: visible!important;
    
}


.surface-compare-devices.surface-compare-devices-locale .surface-compare-c-chart tbody tr .first_display .surface-cmpr-heading{
    min-height: auto;
    height:auto!important;
}


.surface-compare-devices.surface-compare-devices-locale .surface-compare-c-chart tbody tr .first_display:not(.first_display_visible) .surface-cmpr-heading{
        overflow: visible!important;
    height: auto!important;
    visibility: hidden;
    padding-bottom: 8px!important;
    opacity: 0;
    width:100%!important;
}

.m-panes-product-placement-item .c-badge+[class*='c-heading'], .m-content-placement-item .c-badge+[class*='c-heading'], .m-multi-feature .c-badge+[class*='c-heading']{
    padding-top: 0!important;
    margin-top: 5px;
    margin-bottom: 4PX;
    padding-bottom: 0!important;
}

.sample_tout_heightcalc .m-content-placement .c-price span{
    float: none;
}

.surface-devices-button button{
    margin-bottom: 80px!important;
}

/*.two_selected, .three_selected{
    display: none;
}*/

.hide{
    display: none!important;
}

/*@media only screen and (max-width:560px) {
    .surface-compare-deviceimgblock.surface_specific_locale .compare_table.fifty_width .m-content-placement-item .c-heading-4{
        height:auto!important;
        padding-bottom: 40px;
        }
        
}*/

.m-system-requirements .c-table.f-divided tbody tr:last-child{
        border-bottom: 1px solid rgba(0,0,0,.2);
}

.ordered_align .m-banner{
    width: 80%;
}

.ordered_align .m-banner .c-heading-2{
    text-align: left;
}

.ordered_align .m-banner .c-paragraph-2{
    text-align: left;
    padding-bottom: 0px;
}

.ordered_align .m-banner ol{
    list-style: disc;
    text-align: left;
    margin-left: 14px;
}

.ordered_align .m-banner ol li a{
    color: rgb(0,0,238);
    text-decoration: underline;
}

.surface-productplacement-touts5up .m-content-placement-item .c-badge:empty + [class*='c-heading']{
    padding-top:0;
    padding-bottom: 0;
    margin-top: 44px;
    margin-bottom: 4px;
}

.surface-productplacement-touts5up .m-content-placement-item .c-badge:empty + [class*='c-heading'] + [class*='c-paragraph']{
    padding-top:0;
    padding-bottom: 0;
    margin-top: 2px;
    margin-bottom: 1px;
}


.surface-compare-devices-locale.surface-compare-devices.surface-compare-active.wdg-pad-small{
    padding-top: 8px;
}

.surface-compare-devices-locale.surface-compare-devices.surface-compare-active.nextall_hide .c-table{
 padding-top: 30px;   
}

.surface-complete-fiveup .surface-productplacement-touts5up .m-content-placement-item .c-call-to-action{
    display: table;
}

.SurfaceComplete_Lg_4up_Panel_3_VG .surface-productplacement-touts4up .m-content-placement-item .c-call-to-action{
    display: table;
}

.surface-complete-fiveup .surface-productplacement-touts5up .m-content-placement-item .c-call-to-action:after, .surface-complete-fiveup .surface-productplacement-touts5up .m-content-placement-item .c-call-to-action span{
    display: table-cell;
    vertical-align: middle;
}

.SurfaceComplete_Lg_4up_Panel_3_VG .surface-productplacement-touts4up .m-content-placement-item .c-call-to-action:after, .SurfaceComplete_Lg_4up_Panel_3_VG .surface-productplacement-touts4up .m-content-placement-item .c-call-to-action span{
    display: table-cell;
    vertical-align: middle;
}

.surface-complete-fiveup .surface-productplacement-touts5up .m-content-placement-item .c-call-to-action:after{
    display:none;
}

.SurfaceComplete_Lg_4up_Panel_3_VG .surface-productplacement-touts4up .m-content-placement-item .c-call-to-action:after{
    display:none;
}

.surface-complete-fiveup .surface-productplacement-touts5up .m-content-placement-item .c-call-to-action span:after, .SurfaceComplete_Lg_4up_Panel_3_VG .surface-productplacement-touts4up .m-content-placement-item .c-call-to-action span:after{
    font-size: 11px;
    margin-top: 3px;
    margin-left: 2px;
    display: inline-block;
    position: relative;
    content: "";
    vertical-align: top;
    font-family: "MWF-MDL2";
    text-decoration: none;
}

@media only screen and (max-width:539px) {
    /*.surface-compare-deviceimgblock.surface_specific_locale .compare_table .m-content-placement-item .c-heading-4{
        height:auto!important;
        padding-bottom: 40px;
        }*/
        
        .surface-compare-deviceimgblock.surface_specific_locale .compare_table:first-child .m-content-placement-item .c-heading-4{
        padding-bottom: 4px;
        }
        
        /*.surface-compare-stickybar.surface-compare-stickybar-locale .fifty_width .c-heading-4{
            padding-bottom: 36px;
        }*/
        
        .surface-compare-stickybar.surface-compare-stickybar-locale .fifty_width:first-child .c-heading-4{
            padding-bottom: 4px;
        }
}

@media only screen and (max-width:1083px) {
.surface-productplacement-touts5up .m-content-placement-item picture img{
        width:auto;
        max-width:100%;
        transform: TranslateX(-50%);
        left:50%;
        }
        
        .surface-complete-fiveup .surface-productplacement-touts5up .m-content-placement-item .c-call-to-action.c-glyph.surface-bg-cta-blue{
    margin-left: auto;
    margin-right: auto;
}
 .c-apps-panel:not(.apps-6) .apps-wrapper li.apps{
    padding-bottom: 20px;     
    }
}
@media only screen and (max-width: 767px){
.surface-productplacement-touts5up .m-content-placement-item{
       margin-top: 0px !important;
}
} 

@media only screen and (max-width: 460px){
    .surface-compare-deviceimgblock.surface_specific_locale .compare_table .c-group .surface-bg-cta-blue{
        padding-right: 14px;
        padding-left: 14px;
    }
    
     .surface-compare-deviceimgblock.surface_specific_locale .compare_table .c-group a:not(.surface-bg-cta-blue){
        padding-right: 0px;
    }
}

@media only screen and (min-width: 1084px){
    .c-apps-panel:not(.apps-6) .apps-wrapper li.apps{
        width:10%;
       
    }
}

@media only screen and (max-width: 539px){
.surface-compare-stickybar.surface-compare-stickybar-locale .m-content-placement-item .c-heading-4{
    min-height: 64px;
}
}

/*lg_Home*/
/*Homepage Lg*/
.surface-link-nav li{
    position:relative;
    margin-left:4.5%;
}

.surface-link-nav li:first-child{    
    margin-left:0px;
}

.surface-link-nav li img{
    position:absolute;
    width:27px;
    height:21px;
   
}

.surface-link-nav li a{
   margin-left:40px !important;
}

.accoladebottomimage .accoladeimage{
    margin-top:20px;
}

.surface-lg-background{
    background: linear-gradient(#F4F4F4, #D5D5D5);
} 

.surface-laptop-background{
     background: linear-gradient(#85585B, #5C383A);
   
    color:#ffffff;
} 

.surface-laptop-background .m-banner div a:last-child{
    color:#ffffff;
    margin-left: 24px;
}

.surface-pro-background{
    background: linear-gradient(#676D78, #393D44);
    color:#ffffff;
} 

.surface-pro-background .m-banner div a:last-child{
    color:#ffffff;
    margin-left: 24px;
}

.surface-book2-background{
    background: linear-gradient(#F4F4F4, #D5D5D5);
} 

.surface-book2-background .m-banner div a:last-child,.surface-lg-background .m-banner div a:last-child,.surface-studio-background .m-banner div a:last-child {
    margin-left: 24px;
}

.surfacehome-lg-offer{
    border:1px solid #E1E1E1;
    padding-top: 2px;
    padding-bottom: 2px;
}

@media only screen and (min-width: 768px)
{
.surface-link-nav li img{
    left:0%;
}

.surface-lg-specs-banner .m-rich-content-block .surface-indivspecs-container{
border-right:2px solid #000000;
height:100px;
}

.rtl .surface-lg-specs-banner .m-rich-content-block .surface-indivspecs-container{
border-left: 2px solid #000;
    height: 100px;
} 

.surface-lg-specs-banner .m-rich-content-block .surface-indivspecs-container:last-child{
border-right:0px;
}
}

@media only screen and (max-width: 1200px) and (min-width: 768px)
{
.surface-link-nav li{
    position:relative;
    margin-left:1.3%;
}
}

@media only screen and (max-width: 767px)
{
.surface-link-nav li img{
    margin-top: 12px;
}
.surface-lg-specs-banner .m-rich-content-block .surface-indivspecs-container{
padding-top:24px;
}
}

@media only screen and (max-width: 539px)
{
.accoladebottomimage .accoladeimage {
    width:100% !important;
}
}



.surface-multifeature-pivot .m-multi-feature .surface-lg-pivot-icons [role=tablist] li img.mscom-image.c-image{
    width:51px;
    height:51px;
}

.surface-lg-pivot-icons li a img.activelogo{
    display:none;
}

.surface-lg-pivot-icons .c-logo.f-active img.activelogo{
position:absolute;
top:0;
display:block;
}

.surface-lg-pivot-icons a.c-logo{
position:relative;
}

.wdg-global .surface-lg-align a.c-call-to-action.c-glyph.surface-bg-cta-blue
{
    margin-right: 24px;
    margin-top: 10px;
    margin: 0 2px;
}
.wdg-global .surface-lg-align a.c-call-to-action
{
    margin-right: 24px;
}
.wdg-global .surface-lg-align .c-group a.c-call-to-action+a.c-call-to-action
{ 
    margin: 0 24px;
    padding-bottom: 7px;
}

.surface-laptop-background .m-banner div a:last-child:focus
{
color:#fff;
}
.surface-pro-background .m-banner div a:last-child:focus
{

color:#fff;
}
.surface-highlightFeature .m-highlight-feature>div .c-heading-3
{
 padding-top:10px;
}
.surface-highlightFeature .m-highlight-feature>div p
{
 padding-top:10px;
}
.wdg-pad-60
{
padding-top: 60px;   
}
.wdg-pad-155
{
    padding-top: 120px; 
    
}

.surface-lg-triptic .m-mosaic .c-mosaic-placement .surface-lg-triptic-copy{
padding-left:10px;
padding-right:10px;
}

@media only screen and (min-width: 768px) {
.surface-lg-triptic .c-mosaic-placement>div>div{
    height:62px !important;
}
}

.surface-link-nav .c-link-navigation ul li{
    position: relative;
}

.surface-link-nav .c-link-navigation ul li picture{
    position: absolute;
    left: 0;
    z-index: -1;
}
.rtl .surface-link-nav .c-link-navigation ul li picture{    
    right: 0;  
    left:auto; 
}
.surface-link-nav .c-link-navigation ul li a{
    margin-left: 0!important;
    padding-left: 40px;

}



@media only screen and (max-width: 550px) and (min-width: 540px)
{
.surface-lg-techspecs .m-system-requirements{
    padding-left:8px;
    padding-right:8px;
}
}

@media only screen and (min-width:768px) and (max-width:1083px) 
{
.surface-link-nav .c-link-navigation ul li
{
padding-top:20px;
}

.surface-highlightFeature .m-highlight-feature>div{
    padding-left: 12px;
    padding-right: 12px;
    width: 80%;
    text-align: center;
    margin: 0 auto;
    position: static;
    transform: none;
    box-shadow: none;
    background: transparent;
}

}
.surface_RichHeadingwithimage .new-sp4-banner .newsp4bannercta .c-call-to-action
{
    margin-right: 45px !important;
}
.Surface_Lg_Accolade .c-heading-2
{
    padding-top: 10px;
}

.Surface_Lg_Accolade .accoladecarousel .m-banner .accoladeimage a
{

margin-left:5.5%;
}

/*/home page/*/
.paddingLeft_col2{
    padding-left: 11%!important;
}

@media only screen and (max-width: 1083px) {
    .wdg-global .m-hero-item[class*=f-x][class*=f-y]>div>div {
        -webkit-transform: none;
    -ms-transform: none;
        transform: none;
    }
    
    .paddingLeft_col2{
    padding-left: 9%!important;
}
}

@media only screen and (max-width: 767px) 
{
    .paddingLeft_col2{
    padding-left: 3%!important;
}

    .surface-link-nav .c-link-navigation
    {
        width:50%;
        margin: 0% auto;
    }
     .surface-link-nav ul
     {
         text-align: left;
    }
 .surface-link-nav li:first-child
  {
margin-left: 4.5%;
}    
/*.rtl .surface-link-nav li picture, .surface-link-nav li picture img{
    position: static;   
}*/

.rtl .surface-link-nav .c-link-navigation ul li a{
    padding-left: 0px;
    padding-right: 40px;
    float: right;
}

.rtl .surface-link-nav .c-link-navigation ul{
    margin-right: 15%;
}

}
.surface-lg-panes .c-subheading
{
    padding-top: 10px !important;
}
.wdg-global .Surface_Lg_hero-panel .c-group a.c-call-to-action.x-hidden+a.c-call-to-action {
    padding-left: 21px;
}


@media only screen and (min-width:766px) and (max-width:769px) {
.Surface_Lg_hero-panel .m-hero-item:before{
    padding-bottom: 0!important;
}

.Surface_Lg_hero-panel .m-hero-item picture img{
    position:static!important;
     -webkit-transform: none!important;
    -ms-transform: none!important;
        transform: none!important;
}

.Surface_Lg_hero-panel .m-hero-item picture{
    position:static!important;
     -webkit-transform: none!important;
    -ms-transform: none!important;
        transform: none!important;
}

.Surface_Lg_hero-panel .m-hero-item[class*=f-x][class*=f-y]>div {
    position:static!important;
     -webkit-transform: none!important;
    -ms-transform: none!important;
        transform: none!important;
}

.Surface_Lg_hero-panel .m-hero-item[class*=f-x][class*=f-y]>div>div {
    position:static!important;
     -webkit-transform: none!important;
    -ms-transform: none!important;
        transform: none!important;
}
}

.IE11 .m-multi-feature.surface-lgoverview-carousel .c-carousel.f-multi-slide {
overflow:hidden;
}
 
 .surface-lg-panes .c-group{
    padding-top:0px;
    bottom: 0px;
}
 
 @media only screen and (max-width: 539px) {
     .Surface_Lg_Accolade .accoladecarousel .m-banner .accoladeimage a {
    margin-left: 0%;
}
     
 }
 
 .ordered_align ol li{
     padding-bottom: 0;
 }
 
 .surface-compare-banner .start_over_return{
     display:none;
 }
 
 .surface-complete-fiveup .m-content-placement .surface-productplacement-touts5up .m-content-placement-item .c-glyph.surface-bg-cta-blue{
margin-left:auto;
margin-right:auto;
} 

 .SurfaceComplete_Lg_4up_Panel_3_VG .m-content-placement .surface-productplacement-touts4up .m-content-placement-item .c-glyph.surface-bg-cta-blue{
margin-left:auto;
margin-right:auto;
}

.surface-compare-deviceimgblock.surface_specific_locale .surface-devices-button button{
    margin-top:0;
}

.c-apps-panel sup{
    top: -0.4em;
}
.rtl .surface-link-nav li{    
    margin-right:4.5%;
     margin-left:0%;    
}
@media only screen and (min-width:1083px) {
    .wdg-global .surface-lg-align>div
    {
        padding-bottom: 30px;
    }
    
    .m-hero-item.f-y-center.f-transparent.surface-lgovrvw-immersehero>div>div{
top: calc(70%);
transform: translateY(-30%);
}  



}
   .rtl .surface-indivspecs-container:first-child .specs-unit{
       padding-top: 0px;
   }
.surface-link-nav .m-link-navigation .c-link-navigation
{
margin-top: 10px;
}


@media only screen and (min-width:540px) and (max-width:631px) {
    .surface-lg-techspecs table tr td{
        font-size: 13px;
    }
    
     .surface-lg-techspecs .m-system-requirements table tr th{
        min-width: 0px;
        font-size: 13px;
        padding-right: 2px;
    }
    
}


.surface-productplacement-touts5up{
    padding-left: 3px;
    padding-right: 3px;
}

.c-mosaic [data-f-mosaic~=f-vp4-half]:first-child [data-f-mosaic~=f-height-medium]:nth-child(2) .c-mosaic-placement{
    background: #464646;
    color: white;
}

.surface-lg-triptic .c-mosaic-placement a, .surface-lg-triptic .c-mosaic-placement a:hover, .surface-lg-triptic .c-mosaic-placement a:focus,.surface-lg-triptic .c-mosaic-placement a:active{
    color: #fff !important;
}

@media only screen and (max-width: 540px) {  
.wdg-global .surface-lg-align .c-group
{
margin-top: 25px;
}
}

@media only screen and (min-width:768px) {
    .ar-ae .surface-link-nav ul li a.c-hyperlink.c-glyph, .ar-qa .surface-link-nav ul li a.c-hyperlink.c-glyph, .ar-sa .surface-link-nav ul li a.c-hyperlink.c-glyph{
            padding-right: 40px;
    margin-right: 0;
    margin-left: 18px!important;
    padding-left: 0;
    }
    
    .ar-ae .surface-link-nav ul li picture img, .ar-qa .surface-link-nav ul li picture img, .ar-sa .surface-link-nav ul li picture img{
        left: auto;
    right: 0;
    }
    
    .surface-productplacement-touts5up, .surface-productplacement-touts4up{
    overflow: hidden;
}
}

.wdg-global .surface-lg-align .c-group.surface-studio-pad
{
    margin-bottom: 10px;
    margin-top: 20px !important;
}
/*.zh-cn .c-uhfh #buy-now,.en-ca .c-uhfh #buy-now,.ja-jp .c-uhfh #buy-now,.fr-ca .c-uhfh #buy-now
{
    display: none;
}*/
.surface-lg-panes .c-mosaic-placement.f-height-large P
{
    padding-right: 4% !important;
    padding-left: 4% !important;
}


.msw-page #mainContent .surface-section-footnotes a.supLink{
    display:inline-block;
}


:not(.en-us) #mainContent .m-content-placement-item sup,
:not(.en-ca) #mainContent .m-content-placement-item sup,
:not(.fr-ca) #mainContent .m-content-placement-item sup,
:not(.ko-kr) #mainContent .m-content-placement-item sup,
:not(.zh-cn) #mainContent .m-content-placement-item sup,
:not(.de-de) #mainContent .compare-load .m-content-placement-item sup,
:not(.en-au) #mainContent .compare-load .m-content-placement-item sup,
:not(.en-gb) #mainContent .compare-load .m-content-placement-item sup,
:not(.es-es) #mainContent .compare-load .m-content-placement-item sup,
:not(.fr-fr) #mainContent .compare-load .m-content-placement-item sup,
:not(.it-it) #mainContent .compare-load .m-content-placement-item sup,
:not(.ja-jp) #mainContent .compare-load .m-content-placement-item sup,
:not(.nl-nl) #mainContent .compare-load .m-content-placement-item sup,
:not(.en-sg) #mainContent .compare-load .m-content-placement-item sup{
    display:inline-block!important;
    pointer-events: none!important;
}

.SurfaceComplete_Lg_4up_Panel_3_VG .surface-productplacement-touts4up a.c-call-to-action.c-glyph.surface-bg-cta-blue{
    padding-bottom: 9px;
}

.surface-productplacement-touts5up .c-paragraph-2{
    font-weight:400;
    font-size: 15px;
}

.surface-lg-panes .c-mosaic-placement .c-call-to-action{
    overflow: visible;
}

.Surface_Lg_hero-panel .m-hero-item .c-group .c-call-to-action.c-glyph{
    text-align: left;
}



.m-page-bar .c-menu-item a[aria-selected="true"]{
     background: #0067B8!important;
    /*background: #0078D7!important; Changed color as per accessibility*/
}
    
    
    .wdg-global .surface-lg-align .c-heading-2
    {
        padding-top: 20px;
    padding: 10px;
    }
    .surface-pro-background sup a
{
color: #fff;
}

.surface-lg-triptic .c-call-to-action {
    overflow: visible;
}



@media only screen and (min-width:340px) and (max-width:539px) {

.de-de .Surface_Lg_hero-panel .m-hero-item .c-group .c-call-to-action.c-glyph, .de-lu .Surface_Lg_hero-panel .m-hero-item .c-group .c-call-to-action.c-glyph, .de-at .Surface_Lg_hero-panel .m-hero-item .c-group .c-call-to-action.c-glyph,  .de-ch .Surface_Lg_hero-panel .m-hero-item .c-group .c-call-to-action.c-glyph{
    padding-left:55px!important;
}
}

.surface-complete-fiveup .surface-productplacement-touts5up .m-content-placement-item .c-call-to-action span{
    padding-top: 0;
    padding-bottom: 0;
}
.en-in .surface-laptop-background,
.en-ae .surface-laptop-background,
.ar-ae .surface-laptop-background,
.en-sa .surface-laptop-background,
.ar-sa .surface-laptop-background,
.en-qa .surface-laptop-background,
.ar-qa .surface-laptop-background,
.en-th .surface-laptop-background,
.th-th .surface-laptop-background,
.en-sg .surface-laptop-background,
.en-my .surface-laptop-background,
.ms-my .surface-laptop-background, 
.ko-kr .surface-laptop-background,
.es-es .surface-laptop-background,
.pt-pt .surface-laptop-background,
.pl-pl .surface-laptop-background,
.it-it .surface-laptop-background
{
     background: linear-gradient(#f4f4f4,#d5d5d5);   
    color:#000;
} 
.en-th .surface-pro-background,
.th-th .surface-pro-background,
.en-in .surface-pro-background,
.pl-pl .surface-pro-background,
.it-it .surface-pro-background
{
     background: linear-gradient(#f4f4f4,#d5d5d5);   
    color:#000;
} 
.en-in .surface-laptop-background .m-banner div a:last-child, 
.en-ae .surface-laptop-background .m-banner div a:last-child, 
.ar-ae .surface-laptop-background .m-banner div a:last-child,
.en-sa .surface-laptop-background .m-banner div a:last-child,
.ar-sa .surface-laptop-background .m-banner div a:last-child,
.en-qa .surface-laptop-background .m-banner div a:last-child, 
.ar-qa .surface-laptop-background .m-banner div a:last-child,
.en-th .surface-laptop-background .m-banner div a:last-child,
.th-th .surface-laptop-background .m-banner div a:last-child,
.en-sg .surface-laptop-background .m-banner div a:last-child,
.en-my .surface-laptop-background .m-banner div a:last-child,
.ms-my .surface-laptop-background .m-banner div a:last-child,
.ko-kr .surface-laptop-background .m-banner div a:last-child, 
.es-es .surface-laptop-background .m-banner div a:last-child,
.pt-pt .surface-laptop-background .m-banner div a:last-child,
.pl-pl .surface-laptop-background .m-banner div a:last-child,
.it-it .surface-laptop-background .m-banner div a:last-child
{
color: #0067B8;
}
.en-th .surface-pro-background .m-banner div a:last-child,
       
.th-th .surface-pro-background .m-banner div a:last-child,
.en-in .surface-pro-background .m-banner div a:last-child, 
.pl-pl .surface-pro-background .m-banner div a:last-child,
.it-it .surface-pro-background .m-banner div a:last-child
{
color: #0067B8;
}

.surface-complete-fiveup .surface-productplacement-touts5up .surface-disabled-cta, .surface-productplacement-touts4up .surface-disabled-cta{
    width: 100%!important;
    text-align: center!important;
}

@media only screen and (min-width:768px) and (max-width:840px) {

.SurfaceComplete_Lg_4up_Panel_3_VG .m-content-placement [data-grid~=col-12]>div:first-child div:first-child .surface-bg-cta-blue{
    padding-left:0!important;
}
}
/*@media only screen and (max-width: 1399px)
{
html[lang=fr-ca] .m-page-bar>div .context-menu .c-list.f-bare {
    display: block;
}
}*/



.en-sg .surface-complete-fiveup .surface-productplacement-touts5up:first-child .m-content-placement-item .c-call-to-action span::after, .en-sg .SurfaceComplete_Lg_4up_Panel_3_VG .surface-productplacement-touts4up:first-child .m-content-placement-item .c-call-to-action span::after{
    display: none;
}

.keyboardcovers .m-content-placement .surface-product-items:last-child .surface-swatch-colors .surface-multiview-trigger:last-child,
.surface-productfilter .m-content-placement .surface-product-items:last-child .surface-swatch-colors .surface-multiview-trigger:last-child{
    display:none;
}


@media only screen and (max-width: 1399px){
html[lang=fr-ca] .m-page-bar>div .context-menu ul.c-list {
    display: block;
}

html[lang=fr-ca] .m-page-bar>div .context-menu div.c-select-menu {
    display: none;
}

}

@media only screen and (max-width: 1083px){
html[lang=fr-ca] .m-page-bar>div .context-menu div.c-select-menu {
    display: block;
}

html[lang=fr-ca] .m-page-bar>div .context-menu ul.c-list {
    display: none;
}
.m-feature.f-image-priority>section.c-video-one-player.wdg-oneplayer-inline{
        width:100%;
    }
}




/*ja-jp**/

/*.jajpblock{
    display: none;
}

.ja-jp .jajpblock{
    display: block;
}

.nonjajp{
    display: block;
}

.ja-jp .nonjajp{
    display: none;
}

@media only screen and (min-width: 768px){
.jajpdisplay{
    display:table-cell!important;
}
.ja-jp .surface-compare-c-chart tbody tr td:not(:first-child) .surface-cmpr-heading{
    min-height: auto!important;
    width: 100%!important;
    opacity: 0!important;
}

.ja-jp .surface-compare-c-chart tbody tr .x-screen-reader{
     min-height: auto!important;
    width: 100% !important;
    opacity: 0!important;
}

.ja-jp .surface-compare-c-chart tbody tr td:first-child .surface-cmpr-heading{
    min-height: auto!important;
}
}

.ja-jp .surface-compare-c-chart tbody tr .x-screen-reader{
     min-height: auto!important;
    width: 100% !important;
    opacity: 0!important;
}


.ja-jp .surface-compare-devices .m-system-requirements:last-child{
    position: relative;
    overflow:hidden;
}*/

.configpanelcarousel a.c-call-to-action:not(.glyph-play):after, .configpanelcarousel button.c-call-to-action:not(.glyph-play):after
{
    margin-top: 6px;
}
.de-lu .Surface_Lg_hero-panel a.c-call-to-action:after{
    display: none;
}

.de-lu .Surface_Lg_hero-panel .c-call-to-action span:after{
    font-size: 11px;
    margin-top: 2px;
    margin-left: 3px;
    display: inline-block;
    position: relative;
    right: 0;
    content: "";
    vertical-align: top;
    font-family: "MWF-MDL2";
}

@media only screen and (min-width: 1400px){
.m-lifestyle-feature.surface-laptop-lifestyle-highcontrast .c-paragraph-2{
    width:90%;
}
}
.rtl .c-pivot>ul>li:first-child
{
    margin-left: 12px;
}
.rtl .c-pivot>ul>li:last-child
{
    margin-left: 0px;
}
.surface-sizzle-laptop
{
    display:none;
}
#mainContent a.c-hyperlink:not(.f-image).x-hidden-focus:not(:hover):focus, #mainContent a.c-hyperlink:not(.f-image).x-hidden-focus:focus, #mainContent a.c-hyperlink:not(.f-image):not(:hover):focus, #mainContent a.c-hyperlink:not(.f-image):focus, #mainContent p a:focus {
    outline: 2px dotted #000 !important;
}
.surface-section-footnotes .c-hyperlink.supLink:focus{
    color: #fff !important;
         background-color: #2f2f2f !important;
    outline: #4f4f4f 2px dashed !important;
   /* color: #0067b8 !important;*/
}
.IE11.wdg-f-highcontrast .surface-multifeature-pivot .surface-image-priority ul li a:focus
{
outline:#000 dashed 2px !important
}

.Edge .surface-multifeature-pivot .m-multi-feature [role=tablist] li > a.f-active.c-logo:focus
{
outline:#000 dashed 2px !important
}

.surface-lgovrvw-immersehero a.c-hyperlink
{
color:#000;
}

.surface-lgoverviewvideocn-carousel .c-carousel.f-multi-slide li.f-active{
    text-align:left;
}

.surface-lgoverviewhdng .c-heading-4{
    text-align: center;
    padding-bottom: 36px;
    
}

/*CSS updates for Holiday Launch*/
@media only screen and (min-width:1200px) and (max-width:1400px) { 
.surface-lfs-content-hero-width>div>div{
    max-width:475px;
} 
}
@media only screen and (min-width:1400px) {
    .surfacehome-lg-offer .newsp4bannertext
{
padding-left:12px
} 
}
@media only screen and (min-width:540px) and (max-width:1400px) {
    .surfacehome-lg-offer .newsp4bannertext
{
padding-left:110px
}  
}

.surface-cr-background{
    background: linear-gradient(#4A4B51, #181A1B);
    color:#ffffff;
} 

.surface-f-background{
    background: linear-gradient(#85585B, #3A1F21);
    color:#ffffff;
} 
.surface-js-background{
    background: linear-gradient(#f8f8f8,#b9bdc3);
} 

.surface-cr-background .m-banner div a:last-child{
    color:#ffffff;
   }
  .surface-cr-background .m-banner div a:first-child span{
    color:#ffffff;
   }
   
   .surface-f-background .m-banner div a:last-child{
    color:#ffffff;
   }
  .surface-f-background .m-banner div a:first-child span{
    color:#ffffff;
   }

@media only screen and (max-width:420px){
.surface_specific_locale .compare_table[data-grid~=col-4] .compare_table_inner .m-content-placement-item .c-heading-4{
    font-size:20px;
}
}
.E11 .m-content-placement-item .c-hyperlink
{
pointer-events:auto !important;
}
.surface-margin-top-60px
{
    margin-top: 60px !important;
}

@media only screen and (min-width:768px) and (max-width:1083px){
.surface-hr-contentrichblock [data-grid~=pad-6x].m-rich-content-block>[data-grid~=col-3].c-paragraph-1.f-lean{
    padding: 12px 24px;
}

.wdg-global.surfacecom .wdg-pad-bottom-medium.surface-js-background{
    padding-top: 68px;
}
}

@media only screen and (min-width:0px) and (max-width:767px){
.surface-hr-contentrichblock [data-grid~=stack-3].m-rich-content-block>[data-grid~=col-3].c-paragraph-1.f-lean{
    padding: 6px 12px;
}

/*.wdg-global.surfacecom .wdg-pad-bottom-medium.surface-js-background{
    margin-top: 48px;
}*/
}

.SurfaceHome_HL_Hero_Panel
{
    color: #fff;
}
@media only screen and (max-width:1083px) {
    .SurfaceHome_HL_Hero_Panel
{
    color: #000;
}
    
}

.m-mosaic .c-mosaic-placement .triptic-right
{
    padding-top: 22%;
}
.Surface_PCN_Techspecs_Hero_Panel .Surface_PCN-pad
{
    padding-bottom: 15%;
}
.wdg-global .surface-lg-align  .m-image .c-image
{
    padding-top: 60px;
}
@media only screen and (min-width:540px) and (max-width:768px) {
.m-mosaic .c-mosaic-placement .triptic-right
{
    padding-top: 15%;
}
}

.surface-cpr-background{
    background: linear-gradient(#100F19,#04040D);
    color:#ffffff;
} 
.en-us .surface-cpr-background a.c-call-to-action.surface-disabled-cta, .en-au .surface-cpr-background a.c-call-to-action.surface-disabled-cta, .en-ca .surface-cpr-background a.c-call-to-action.surface-disabled-cta, .fr-ca .surface-cpr-background a.c-call-to-action.surface-disabled-cta,.zh-cn .surface-cpr-background a.c-call-to-action.surface-disabled-cta,.ja-jp .surface-cpr-background a.c-call-to-action.surface-disabled-cta{
      color:#ffffff !important;
} 

.surface-bk2-background.surface-bk2-color{
    background: linear-gradient(#171c20,#cfd4d7);
    color:#ffffff;
} 
.surface-lg-new-background.surface-lg-new-color{
    background: linear-gradient(#6A757D,#A1ABB2);
    color:#ffffff;
} 

.surface-bk2-background.surface-bk2-color .m-banner div a:last-child,.surface-lg-new-background.surface-lg-new-color .m-banner div a:last-child
{ 
 color: #ffffff;   
}

.surface-cpr-background.surface-cpr-color .m-feature div a:last-child
{
    color: #ffffff !important;   
}
.triptic-right a
{
padding-top: 10px !important;    
}

.triptic-right .c-subheading
{
        padding-bottom: 5px;
}
.triptic-right .pad-top-15
{
    padding-top: 18px;
}


@media only screen and (min-width:1084px) and (max-width:1099px) {
.fr-ca .m-lifestyle-feature.f-ratio-169{
    margin-bottom: 50px;
}
}

@media only screen and (min-width:768px) and (max-width:900px) {
.surface-compare-deviceimgblock.surface-compare-5up .compare_table.shown_lables.quarter_width, .surface-compare-stickybar.surface-compare-active .quarter_width{
padding-left:0px;
padding-right:0px;
}

.surface-compare-deviceimgblock.surface-compare-5up .compare_table.shown_lables.quarter_width .compare_table_inner .c-group a.surface-bg-cta-blue, .surface-compare-stickybar.surface-compare-active .quarter_width .c-group a.surface-bg-cta-blue{
margin-right: 12px;
}

.surface-compare-deviceimgblock.surface-compare-5up .compare_table.shown_lables.quarter_width .compare_table_inner .c-group a:last-child, .surface-compare-stickybar.surface-compare-active .quarter_width .c-group a:last-child{
padding-right: 0px;
}
}


@media only screen and (max-width: 1083px){
.surface-highlightFeature.surface-highlightFeature_home .hmc-display-above-1083
{
display: none;
}
}

/*@media only screen and (max-width: 539px){
.surface-highlightFeature.surface-highlightFeature_home{
position: relative;
    margin-bottom: 50%;
}
}*/
@media only screen and (max-width: 1083px){
.surface-highlightFeature.surface-highlightFeature_home .hmc-display-above-1083
{
display: none;
}
}
@media only screen and (min-width: 1083px){
.oneplayer-video.oneplayer-video-home .display-below-1083
{
display: none;
}

.m-hero-item.f-y-center>div>div.Surface_PCN-pad{
    top: calc(60%);
    padding-left:42px;
 padding-right:12px;
}
}

.surface-highlightFeature.surface-highlightFeature_home .m-highlight-feature > div.hmc-display-below-1083 {
    margin-top:20px;
    margin-bottom:20px;
}
@media only screen and (min-width: 1084px){
.surface-highlightFeature.surface-highlightFeature_home .hmc-display-below-1083
{
display: none;
}
}
@media only screen and (max-width: 1083px){
.oneplayer-video.oneplayer-video-home .display-below-1083
{
display: none;
}
}
@media only screen and (max-width: 1083px){
.oneplayer-video.oneplayer-video-home .wdg-oneplayer-inline
{
clear: both;
}
}

@media only screen and (max-width: 767px){
.wdg-global .SurfaceHome_Lg_Banner_Panel_10.surface-lg-align

{
padding-bottom:15px;
}
}

@media only screen and (min-width:1083px) and (max-width:1199px) { 
.surface-lfs-content-hero-width>div>div h1.c-heading-1{
    font-size: 58px;
} 

.m-hero-item.surface-lfs-content-hero-width>div>div{
 padding-left:36px;
 padding-right:12px;
}
}

@media only screen and (min-width:1084px) and (max-width:1240px) { 
.surface-cr-hero-width.m-hero-item>div>div{
    padding-left: 84px;
    padding-right:0px
}

}
@media only screen and (min-width:1084px) and (max-width:1400px) { 
.surface-cr-hero-width.m-hero-item>div>div h1.c-heading-1{
    font-size: 52px;
}
}
 .wdg-global .surface-lg-align.surface-lg-new-color .m-banner .c-call-to-action+a.c-call-to-action:focus:not(.x-hidden-focus),
  .wdg-global .surface-lg-align.surface-lg-new-color .m-banner .c-call-to-action+a.c-call-to-action:hover
{
    color:#ffffff !important;
}

.wdg-global .surface-lg-align.surface-bk2-color .m-banner .c-call-to-action+a.c-call-to-action:focus:not(.x-hidden-focus),
  .wdg-global .surface-lg-align.surface-bk2-color .m-banner .c-call-to-action+a.c-call-to-action:hover
{
    color:#ffffff !important;
}
.wdg-global .surface-lg-align.surface-cpr-color .m-banner .c-call-to-action+a.c-call-to-action:focus:not(.x-hidden-focus),
  .wdg-global .surface-lg-align.surface-cpr-color .m-banner .c-call-to-action+a.c-call-to-action:hover
{
    color:#ffffff !important;
}
.wdg-global .surface-lg-align.surface-cr-background .m-banner .c-call-to-action+a.c-call-to-action:focus:not(.x-hidden-focus),
  .wdg-global .surface-lg-align.surface-cr-background .m-banner .c-call-to-action+a.c-call-to-action:hover
{
    color:#ffffff !important;
}

.wdg-global .surface-lg-align.surface-f-background .m-banner .c-call-to-action+a.c-call-to-action:focus:not(.x-hidden-focus),
  .wdg-global .surface-lg-align.surface-f-background .m-banner .c-call-to-action+a.c-call-to-action:hover
{
    color:#ffffff !important;
}

.wdg-global .surface-js-background.surface-lg-align .m-banner .c-call-to-action+a.c-call-to-action:focus:not(.x-hidden-focus),
 .wdg-global .surface-js-background.surface-lg-align .m-banner .c-call-to-action+a.c-call-to-action:hover
{
    color: #005da6 !important;
}


@media only screen and (min-width: 1399px){
.ja-jp .SurfaceHome_HL_Hero_Panel .c-hero>div>div, .m-hero-item>div>div{
    max-width:600px !important;
}} 

.m-mosaic .c-mosaic-placement .triptic-right p.c-paragraph
{
    font-weight: 200 !important;    
}
@media only screen and (min-width: 768px) {

.m-multi-feature.surface-lgoverview-carousel{
    padding-top: 84px !important;
}
}
.oneplayer-video-home .c-video-one-player.wdg-oneplayer-inline
{
padding-bottom: 56.28%;
}

.SurfaceProVideo .m-feature.f-image-priority>section.c-video-one-player.wdg-oneplayer-inline{
    width: 64.9%;
}
.m-banner .c-price sup a{
    display:inline-block;
}
.c-heading-3 sup {
    font-size: inherit;
    line-height: inherit;
} 



@media only screen and (min-width: 768px){
/*Hiding the fifth specs for non-dial markets*/
.de-lu .surface-specsbanner[data-vg='Surface_L_TechSpecs_8_ContentRichSpecsBanner_VG'] [data-grid='col-1-5']:last-child, .en-ie .surface-specsbanner[data-vg='Surface_L_TechSpecs_8_ContentRichSpecsBanner_VG'] [data-grid='col-1-5']:last-child,
.fr-be .surface-specsbanner[data-vg='Surface_L_TechSpecs_8_ContentRichSpecsBanner_VG'] [data-grid='col-1-5']:last-child, .nl-be .surface-specsbanner[data-vg='Surface_L_TechSpecs_8_ContentRichSpecsBanner_VG'] [data-grid='col-1-5']:last-child,
.fr-lu .surface-specsbanner[data-vg='Surface_L_TechSpecs_8_ContentRichSpecsBanner_VG'] [data-grid='col-1-5']:last-child, .pl-pl .surface-specsbanner[data-vg='Surface_L_TechSpecs_8_ContentRichSpecsBanner_VG'] [data-grid='col-1-5']:last-child,
.es-es .surface-specsbanner[data-vg='Surface_L_TechSpecs_8_ContentRichSpecsBanner_VG'] [data-grid='col-1-5']:last-child, .ko-kr .surface-specsbanner[data-vg='Surface_L_TechSpecs_8_ContentRichSpecsBanner_VG'] [data-grid='col-1-5']:last-child,
.it-it .surface-specsbanner[data-vg='Surface_L_TechSpecs_8_ContentRichSpecsBanner_VG'] [data-grid='col-1-5']:last-child, .pt-pt .surface-specsbanner[data-vg='Surface_L_TechSpecs_8_ContentRichSpecsBanner_VG'] [data-grid='col-1-5']:last-child,
.en-th .surface-specsbanner[data-vg='Surface_L_TechSpecs_8_ContentRichSpecsBanner_VG'] [data-grid='col-1-5']:last-child, .th-th .surface-specsbanner[data-vg='Surface_L_TechSpecs_8_ContentRichSpecsBanner_VG'] [data-grid='col-1-5']:last-child,
.en-my .surface-specsbanner[data-vg='Surface_L_TechSpecs_8_ContentRichSpecsBanner_VG'] [data-grid='col-1-5']:last-child, .ms-my .surface-specsbanner[data-vg='Surface_L_TechSpecs_8_ContentRichSpecsBanner_VG'] [data-grid='col-1-5']:last-child,
.ar-ae .surface-specsbanner[data-vg='Surface_L_TechSpecs_8_ContentRichSpecsBanner_VG'] [data-grid='col-1-5']:last-child, .ar-qa .surface-specsbanner[data-vg='Surface_L_TechSpecs_8_ContentRichSpecsBanner_VG'] [data-grid='col-1-5']:last-child,
.ar-sa .surface-specsbanner[data-vg='Surface_L_TechSpecs_8_ContentRichSpecsBanner_VG'] [data-grid='col-1-5']:last-child, .en-ae .surface-specsbanner[data-vg='Surface_L_TechSpecs_8_ContentRichSpecsBanner_VG'] [data-grid='col-1-5']:last-child,
.en-qa .surface-specsbanner[data-vg='Surface_L_TechSpecs_8_ContentRichSpecsBanner_VG'] [data-grid='col-1-5']:last-child, .en-sa .surface-specsbanner[data-vg='Surface_L_TechSpecs_8_ContentRichSpecsBanner_VG'] [data-grid='col-1-5']:last-child,
.en-in .surface-specsbanner[data-vg='Surface_L_TechSpecs_8_ContentRichSpecsBanner_VG'] [data-grid='col-1-5']:last-child{
    display: none;
}

.de-lu .surface-specsbanner[data-vg='Surface_L_TechSpecs_8_ContentRichSpecsBanner_VG'] [data-grid='col-1-5'], .en-ie .surface-specsbanner[data-vg='Surface_L_TechSpecs_8_ContentRichSpecsBanner_VG'] [data-grid='col-1-5'],
.fr-be .surface-specsbanner[data-vg='Surface_L_TechSpecs_8_ContentRichSpecsBanner_VG'] [data-grid='col-1-5'], .nl-be .surface-specsbanner[data-vg='Surface_L_TechSpecs_8_ContentRichSpecsBanner_VG'] [data-grid='col-1-5'],
.fr-lu .surface-specsbanner[data-vg='Surface_L_TechSpecs_8_ContentRichSpecsBanner_VG'] [data-grid='col-1-5'], .pl-pl .surface-specsbanner[data-vg='Surface_L_TechSpecs_8_ContentRichSpecsBanner_VG'] [data-grid='col-1-5'],
.es-es .surface-specsbanner[data-vg='Surface_L_TechSpecs_8_ContentRichSpecsBanner_VG'] [data-grid='col-1-5'], .ko-kr .surface-specsbanner[data-vg='Surface_L_TechSpecs_8_ContentRichSpecsBanner_VG'] [data-grid='col-1-5'],
.it-it .surface-specsbanner[data-vg='Surface_L_TechSpecs_8_ContentRichSpecsBanner_VG'] [data-grid='col-1-5'], .pt-pt .surface-specsbanner[data-vg='Surface_L_TechSpecs_8_ContentRichSpecsBanner_VG'] [data-grid='col-1-5'],
.en-th .surface-specsbanner[data-vg='Surface_L_TechSpecs_8_ContentRichSpecsBanner_VG'] [data-grid='col-1-5'], .th-th .surface-specsbanner[data-vg='Surface_L_TechSpecs_8_ContentRichSpecsBanner_VG'] [data-grid='col-1-5'],
.en-my .surface-specsbanner[data-vg='Surface_L_TechSpecs_8_ContentRichSpecsBanner_VG'] [data-grid='col-1-5'], .ms-my .surface-specsbanner[data-vg='Surface_L_TechSpecs_8_ContentRichSpecsBanner_VG'] [data-grid='col-1-5'],
.ar-ae .surface-specsbanner[data-vg='Surface_L_TechSpecs_8_ContentRichSpecsBanner_VG'] [data-grid='col-1-5'], .ar-qa .surface-specsbanner[data-vg='Surface_L_TechSpecs_8_ContentRichSpecsBanner_VG'] [data-grid='col-1-5'],
.ar-sa .surface-specsbanner[data-vg='Surface_L_TechSpecs_8_ContentRichSpecsBanner_VG'] [data-grid='col-1-5'], .en-ae .surface-specsbanner[data-vg='Surface_L_TechSpecs_8_ContentRichSpecsBanner_VG'] [data-grid='col-1-5'],
.en-qa .surface-specsbanner[data-vg='Surface_L_TechSpecs_8_ContentRichSpecsBanner_VG'] [data-grid='col-1-5'], .en-sa .surface-specsbanner[data-vg='Surface_L_TechSpecs_8_ContentRichSpecsBanner_VG'] [data-grid='col-1-5'],
.en-in .surface-specsbanner[data-vg='Surface_L_TechSpecs_8_ContentRichSpecsBanner_VG'] [data-grid='col-1-5']{
    width:25%;
}
}
/*.IE11 :not([data-js-href]).m-content-placement-item{
   pointer-events: auto !important; 
   cursor:pointer !important;
}*/
.c-video-one-player.wdg-oneplayer-inline .InlinePlayerAPIinline iframe{
    position:absolute
}

.surface-top-84.Surface_Home_Offer_Body_New_Banner
{
    clear:both;
    margin-top:0px !important;
    padding-top: 84px !important;
}


/*Book2 Triptic pane*/
@media only screen and (max-width:1400px) {
   .m-panes section.f-stacked:last-child>div.surface-book2-right-panes{
      justify-content: center;
   }
}
.Surface_Home_Carousel_Hero_UT .Surface_Home_Carousel_Pt-2
{   
   color: #000;
    top: 38% !important;
}
.Surface_Home_Carousel_Hero_UT .theme-light a.c-hyperlink.supBLink,
.Surface_Home_Carousel_Hero_UT .theme-dark a.c-hyperlink.supBLink {
    color: #0067B8;
}
@media only screen and (min-width: 1083px)
{
/*.en-au .Surface_Home_Carousel_Hero_UT .c-sequence-indicator button[aria-checked=true]:before, 
.en-au .Surface_Home_Carousel_Hero_UT .c-sequence-indicator button[aria-selected=true]:before,
 .en-au .Surface_Home_Carousel_Hero_UT .c-sequence-indicator button[aria-checked=true]:before,
 .en-au .Surface_Home_Carousel_Hero_UT .c-sequence-indicator button[aria-selected=true]:before
{
background: #FFF;

}

.en-au .Surface_Home_Carousel_Hero_UT .c-sequence-indicator a:before, 
.en-au .Surface_Home_Carousel_Hero_UT .c-sequence-indicator button:before,
 .en-au .Surface_Home_Carousel_Hero_UT .c-sequence-indicator a:before,
 .en-au .Surface_Home_Carousel_Hero_UT .c-sequence-indicator button:before
{
    border-color: rgba(255,255,255,.8);
}

.en-au .Surface_Home_Carousel_Hero_UT button.c-action-toggle, 
.en-au .Surface_Home_Carousel_Hero_UT button.c-action-toggle
{
    color: #FFF;
}


.en-au .Surface_Home_Carousel_Hero_UT button.c-action-toggle, 
.en-au .Surface_Home_Carousel_Hero_UT button.c-action-toggle,
.en-au .Surface_Home_Carousel_Hero_UT .theme-dark button.c-action-toggle,
.en-au .Surface_Home_Carousel_Hero_UT button.c-action-toggle
{

background: 0 0;
    text-decoration: none;
}
*/}
@media only screen and (min-width:1400px) 
{
   .wdg-global .Surface_Home_Carousel_Hero_UT .m-hero-item .Surface_Home_Carousel_Pt-2
{
  padding-left: 0px !important;
    padding-right: 0px !important;
    max-width: 500px !important;    
}
 .en-au .wdg-global .Surface_Home_Carousel_Hero_UT .m-hero-item .Surface_Home_Carousel_Pt-2
{
  padding-left: 43px !important;
    padding-right: 0px !important;
    max-width: 350px !important;    
}
}
@media only screen and (min-width:1084px) and (max-width:1400px) 
{ 

   .wdg-global .Surface_Home_Carousel_Hero_UT .m-hero-item .Surface_Home_Carousel_Pt-2
{
  padding-left: 0px !important;
    padding-right: 0px !important;
    max-width: 380px !important;    
}
 .en-au .wdg-global .Surface_Home_Carousel_Hero_UT .m-hero-item .Surface_Home_Carousel_Pt-2
{
  padding-left: 43px !important;
    padding-right: 0px !important;
    max-width: 350px !important;    
}
}

@media only screen and (min-width:1400px) {
section.f-align-middle.surface-remove-top.surface-book2-tpcpanes{
    flex:0.75;
}
section.f-align-middle.surface-remove-top.surface-book2-tpcpanes+.f-stacked{
    flex:1;
}}
.Surface_Home_Carousel_Hero_UT.black .Surface_Home_Carousel_Pt-1
{
    color: #fff;
}
@media only screen and (max-width:1083px) {
    .Surface_Home_Carousel_Hero_UT.black .Surface_Home_Carousel_Pt-1
{
    color: #000;
}
    
}
.Surface_Home_Carousel_Hero_UT.white .Surface_Home_Carousel_Pt-1
{
    color: #fff;
}
@media only screen and (max-width:1083px) {
    .Surface_Home_Carousel_Hero_UT.white .Surface_Home_Carousel_Pt-1
{
    color: #000;
}    

/*.c-sequence-indicator button[aria-checked=true]:before, .c-sequence-indicator button[aria-selected=true]:before{
    background: #000!important;
}

.c-sequence-indicator a:before, .c-sequence-indicator button:before{
    border: 1px solid rgba(0,0,0,.8)!important;
}*/
}
.wdg-global .Surface_Home_Carousel_Hero_UT .c-group a.c-call-to-action.x-hidden+a.c-call-to-action
{
padding-right: 0px;
    padding-left: 21px;
    margin-left: -24px;
}

/*.Surface_Home_Carousel_Hero_UT.blcak .c-sequence-indicator button[aria-checked=true]:before, 
.Surface_Home_Carousel_Hero_UT.blcak .c-sequence-indicator button[aria-selected=true]:before,
 .Surface_Home_Carousel_Hero_UT.blcak .c-sequence-indicator button[aria-checked=true]:before,
 .Surface_Home_Carousel_Hero_UT.blcak .c-sequence-indicator button[aria-selected=true]:before
{
background: #FFF;

}

.Surface_Home_Carousel_Hero_UT.blcak .c-sequence-indicator a:before, 
.Surface_Home_Carousel_Hero_UT.blcak .c-sequence-indicator button:before,
 .Surface_Home_Carousel_Hero_UT.blcak .c-sequence-indicator a:before,
 .Surface_Home_Carousel_Hero_UT.blcak .c-sequence-indicator button:before
{
    border-color: rgba(255,255,255,.8);
}

.Surface_Home_Carousel_Hero_UT.blcak button.c-action-toggle, 
.Surface_Home_Carousel_Hero_UT.blcak button.c-action-toggle
{
    color: #FFF;
}


.Surface_Home_Carousel_Hero_UT.blcak button.c-action-toggle, 
.Surface_Home_Carousel_Hero_UT.blcak button.c-action-toggle,
.Surface_Home_Carousel_Hero_UT.blcak  button.c-action-toggle,
.Surface_Home_Carousel_Hero_UT.blcak button.c-action-toggle
{

background: 0 0;
    text-decoration: none;
}*/

.border_change:before{
    background-color: #fff!important;
}

.border_change + button:before{
        border: 1px solid #fff;
}

.de-lu .wdg-global .Surface_Home_Carousel_Hero_UT .c-group a.c-call-to-action.x-hidden+a.c-call-to-action,.de-ch .wdg-global .Surface_Home_Carousel_Hero_UT .c-group a.c-call-to-action.x-hidden+a.c-call-to-action
{
    display:contents;
    padding-right: 0;
    padding-left: 21px;
    margin-left: -44px;
    
}
@media only screen and (min-width: 1083px) and (max-width: 1140px)
{
.rtl .wdg-global .Surface_Home_Carousel_Hero_UT .m-hero-item .Surface_Home_Carousel_Pt-2 {
    padding-left: 0 !important;
    padding-right: 0 !important;
    max-width: 355px !important;
}
}

@media only screen and (min-width: 1083px)
 {
.surface-highlightFeature.surface-highlightFeature_home a{
    padding-top: 0px;
    margin-bottom: 10px;
}
}

@media only screen and (min-width: 1083px) {
.surface-highlightFeature.surface-highlightFeature_STC a{
    padding-top: 0px;
    margin-bottom: 10px;
}
}

@media only screen and (min-width: 1083px) {
.surface-highlightFeature.surface-highlightFeature_PCN a{
    padding-top: 0px;
    margin-bottom: 10px;
}
}

@media only screen and (min-width: 1083px) {
.surface-highlightFeature.surface-highlightFeature_LFS a{
    padding-top: 0px;
    margin-bottom: 10px;
}
}

.lg-tech-head.c-subheading-2
{
    font-weight: 700;
    line-height: 20px;
}

/*Offer Carousel*/


.surface-home-offercarousel .c-carousel .c-flipper.f-previous{
    left: -5%;
}

.surface-home-offercarousel .c-carousel .c-flipper.f-next{
    right: -5%;
}
.surface-home-offercarousel .c-carousel .c-sequence-indicator{
    bottom:-35px;
    padding-bottom: 15px;
}

.surface-home-offercarousel .c-flipper{
    border-radius:50%;
    width:44px;
    height:44px;
}

.surface-home-offercarousel .c-carousel.f-multi-slide .c-flipper, .surface-home-offercarousel .c-carousel.f-multi-slide:hover .c-flipper:active{
 opacity:0.8;   
}

.surface-home-offercarousel .c-flipper:after{
    border-radius:50%;
}
.surface-home-offercarousel .c-flipper:after {
    display: block;
    position: absolute;
    top: 0;
    right: 0;
    bottom: 0;
    left: 0;
    content: '';
    border: 1px solid transparent;
}

.surface-home-offercarousel .c-flipper:hover{
    box-shadow: 0 4px 8px rgba(0,0,0,.2);
    background: rgba(255,255,255,.1);
}

.surface-home-offercarousel .c-flipper:focus{
    border:1px solid #000;  
}


@media only screen and (max-width: 1083px){
   .surface-home-offercarousel .c-carousel .c-flipper.f-next{
    right: 0%;
}
.surface-home-offercarousel .c-carousel .c-flipper.f-previous{
    left: 0%;
}
}

@media only screen and (max-width: 539px){
.surface-home-offercarousel .c-carousel .new-sp4-banner.m-banner .newsp4bannertext{
    text-align: center;
}
}

@media only screen and (min-width: 539px){
.surface-home-offercarousel .c-carousel .new-sp4-banner{
    padding-left: 0px;
    padding-right: 0px;
}
}
@media only screen and (min-width: 540px){
.surface-home-offercarousel .m-banner div:first-child{
min-height:2px; /*Safari bug*/	
}
}

.f-sticky ul li a:focus
{
     outline: 2px dotted !important;
}
    .surface-compare-banner-locale .c-paragraph-3.surface-Banner-Result-Body
    {
        display: none;
    }
    
   html:not([lang='zh-cn']) .surface-book2-hide
   {
       display: none;
   }
     .en-gb .surface-compare-5up .compare_table_hide,
.de-de .surface-compare-5up .compare_table_hide,
.ja-jp .surface-compare-5up .compare_table_hide,
.zh-cn .surface-compare-5up .compare_table_hide
{
    display: none;
}
@media only screen and (min-width: 1723px){
.de-de .compare_table .compare_table_inner .c-group a.c-call-to-action.c-glyph.surface-bg-cta-blue{
    margin-right:50px;
}}

.design-18 .hmc-buttons .see-result:focus
{
background: #005da6 !important;
margin: 10px;
}

.questions-panel .questpan-visible-container .c-radio input[type=radio]:focus+span:before
{
        outline: rgba(0,0,0,.8) dashed 2px;
}


.high-contrast-mode.hcmode-white .design-18 .surface-hmc-qa-block-item .c-checkbox input[type=checkbox]:checked+span:after
{
    outline:#000 2px dotted;
}
.surface_Z_product .m-product-placement li
{
padding-right:5px;
}


/*NFL Updates*/
@media only screen and (min-width: 1141px){
.surface-nfl-cb-margin{
    margin-bottom: 50px;
}
}

@media only screen and (min-width: 1083px) and (max-width: 1140px){
.surface-nfl-cb-margin{
    margin-bottom: 60px;
}

.c-video-one-player.wdg-oneplayer-inline.surface-nfl-cbvideo-margin{
    margin-bottom: 20px;
}

.c-video-one-player.wdg-oneplayer-inline.surface-nfl-newvid-mgnbtm{
    margin-bottom: 30px !important;
}
}


.laptop-platinum-color{
    background: linear-gradient(#F1F1F1, #CBCBCB);
    color:#000000 !important;
} 
.wdg-global .surface-lg-align.surface-f-background.laptop-platinum-color .m-banner div a:last-child
{
      color: #0067B8 !important;
}
 .wdg-global .surface-lg-align.surface-f-background.laptop-platinum-color .m-banner .c-call-to-action+a.c-call-to-action:hover
{
    color: #0067B8 !important;
}


.wdg-global .Surface_Lg_hero-panel .c-group a.c-call-to-action.x-hidden+a.c-call-to-action
{
    color: #fff;
    border: none;
}

@media only screen and (max-width:1083px) {
.wdg-global .Surface_Lg_hero-panel .c-group a.c-call-to-action.x-hidden+a.c-call-to-action
{
color: #0067B8;
}
}
.wdg-pad-37.surface-f-background.surface-lg-align.laptop-platinum-color .m-banner .c-call-to-action+a.c-call-to-action:hover
{
color: #0067b8 !important;
}


.wdg-pad-37.surface-f-background.surface-lg-align.laptop-platinum-color .m-banner .c-call-to-action+a.c-call-to-action:focus
{
color: #0067b8 !important;
}

.ja-jp .surface-compare-deviceimgblock.surface_specific_locale .compare_table .compare_table_inner .c-subheading-5{
font-size:14px;
}

@media only screen and (min-width: 480px) and (max-width: 630px) {
    .surface_Home_NFL_Contest .c-heading-2{
        font-size:30px;
    }
}

@media only screen and (min-width: 320px) and (max-width: 480px) {
    .surface_Home_NFL_Contest .c-heading-2{
        font-size:27px;
    }
}

/*.surface-lg-specs-banner .m-rich-content-block .surface-indivspecs-container:nth-last-child(2){
    border-right: none;
}*/

/*@media only screen and (min-width: 768px) {
.en-hk .surface-5specs-banner .surface-indivspecs-container[data-grid~=col-3]{
    width:20%;
}
}*/
.NFL_Style_Hero_1 sup a{
    color: #fff;
}
.NFL_Style_Hero_1 sup a:hover{
    color: #fff !important;
}

@media only screen and (min-width: 1084px) {
.surface-home-specific-ofrcrsl .new-sp4-banner [data-grid~=col-4]{
    width: 38%;
}

.surface-home-specific-ofrcrsl .newsp4bannertext[data-grid~=col-5]{
    width: 37%;
}
}
.SurfaceHome_AccoladeCarousel .accoladecarousel .m-banner .accoladeimage a:focus,
.wdg-global .new-sp4-banner .newsp4bannercta a.c-call-to-action.c-glyph:focus,
.surface-compare-deviceimgblock.surface_specific_locale .surface-devices-button button:focus
{    
        outline: 2px dotted #000 !important;
}
 .wdg-global .surface-cpr-background.surface-lg-align.surface-cpr-color a:focus
{
 outline: 2px dotted #fff !important;
}
#mainContent .surface-cpr-background a.c-hyperlink:not(.f-image).x-hidden-focus:not(:hover):focus,
 #mainContent .surface-cpr-background a.c-hyperlink:not(.f-image).x-hidden-focus:focus,
 #mainContent .surface-cpr-background a.c-hyperlink:not(.f-image):not(:hover):focus,
 #mainContent .surface-cpr-background a.c-hyperlink:not(.f-image):focus, 
#mainContent .surface-cpr-background p a:focus
{
outline: 2px dotted #fff !important;
}
.wdg-global .Surface_Home_Carousel_Hero_Outline .Surface_Home_Carousel_Pt-1 a.c-call-to-action:focus:not(.x-hidden-focus):not(.wdg-f-blue-button):focus
{
 outline: 2px dotted #fff !important;
}

.wdg-global .NFL_Style_Hero_1 .c-call-to-action:focus:not(.x-hidden-focus):not(.wdg-f-blue-button)
{
    outline: 2px dotted #fff !important;
}

/*NFL product .c-content-placement*/
.nflcarousal
{
    width: 100%;
    display: inline-block;
}
.nflcarousal .m-product-placement
{
    margin-top:60px !important;
}
.nflcarousal .m-product-placement-item
{
    width:336px;
    margin-right:12px;
}
.nflcarousal img
{
    width:330px;
}
.nflcarousal .c-flipper
{
    width: 44px;
    height: 44px;
    border-radius: 50%;
    background: #fafafa;
    border: 1px solid transparent;
}
.nflcarousal h3.c-heading
{
    font-size:20px;
    line-height:24px;
    font-weight:600;
}
.nflcarousal .m-banner h2.c-heading-3
{
    font-size:62px;
    line-height:24px;
    font-weight:300;
}
@media only screen and (max-width: 767px)
{
.nflcarousal img
    {
    width: 218px;
    margin-right: 8px;
    }
.nflcarousal .m-product-placement-item
{
    width: 224px;
    margin-right: 8px;
}
}
.zh-cn .m-banner .c-price sup a{
    display: inline !important;
}
.wdg-global .Surface_Lg_hero-panel .m-hero-item .c-group>.c-call-to-action:focus:not(.x-hidden-focus):not(.wdg-f-blue-button):focus
{
outline: #fff dashed 2px !important;
}
.design-18 .surface-hero-pivot-multi-img .c-pivot ul li[data-swatch-text="Black"] a:focus
{
     border: #000 dashed 2px;
}
.design-18 .surface-hero-pivot-multi-img .c-pivot ul li[data-swatch-text="Platinum"] a:focus
{
 outline: #000 dashed 2px !important;
}


/*accessibility*/
.m-page-bar.f-sticky .context-menu a,
.m-page-bar.f-sticky .context-menu a:active
{
    text-decoration:underline !important;
}

.surface-compare-deviceimgblock.surface_specific_locale .surface-devices-button button
{
   outline-color: none;
outline-style: none;
outline-width:0px;
}
.c-checkbox input[type="checkbox"] + span::before
{
border: 1px solid currentcolor !important;
}
/*.compare-design-en-us li.c-menu-item.active .c-checkbox input[type=checkbox]+span:before{
outline: #000 dashed 1px !important;
}*//*TODO*/
/*carousel Css*/
.m-multi-feature .c-call-to-action:focus:not(.x-hidden-focus):not(.wdg-f-blue-button){background:none !important;}

/*work your way rules stylings*/

.mb-10 {
    margin-bottom: 10px;
}

.rules-bold {
    font-weight: 700;
    margin-top:20px;
}

.rules-official {
    font-weight: 700;
}
.rules-centered {
    text-align: center;
}
.rules-underline {
    text-decoration: underline;
}
.rules-text{
    margin-top:15px;
    margin-left: 25px;
}

.rules-entryperiod, .rules-prize, .rules-prize+p, .rules-age{
    margin-left: 25px;
}

.rules-texteligibility li{
    list-style: disc;
    margin-left:65px;
}

.rules-contestwinners li{
        margin-left:65px;
        list-style: disc;
}

.rules-texteligibility, .rules-contestwinners, .rules-submit, .rules-prize{
       margin-top:20px; 
}

.rules-3prices, .surface-rules-container{
    margin-bottom: 20px;
}

a.rules-privacystmt{
    color:#0067B8;
}

@media only screen and (max-width:1083px) {
.surface-rules-container{
    padding-left:5%;
    padding-right:5%
}
}

/*Home page CSS for new carousel*/
.surfacehome_colorful_impact .wdg-theme-dark-banner a.c-call-to-action.c-glyph, 
.surfacehome_colorful_impact .wdg-theme-dark-banner a.c-call-to-action.c-glyph.surface-secondary-cta{
    color: #0067b8;
}
.wdg-global .surfacehome_colorful_impact .wdg-theme-dark-banner{
color:rgb(0,0,0);
}

.surfacehome_colorful_impact-seqind .theme-dark .theme-light .c-sequence-indicator button[aria-checked=true]:before, 
.surfacehome_colorful_impact-seqind .theme-dark .theme-light .c-sequence-indicator button[aria-selected=true]:before, 
.surfacehome_colorful_impact-seqind .theme-light .c-sequence-indicator button[aria-checked=true]:before, 
.surfacehome_colorful_impact-seqind .theme-light .c-sequence-indicator button[aria-selected=true]:before{
    background: #000;
}

.surfacehome_colorful_impact-seqind .c-sequence-indicator a:before, 
.surfacehome_colorful_impact-seqind .c-sequence-indicator button:before{
border: 1px solid rgba(0,0,0,.8);
}

.surfacehome_colorful_impact-seqind .c-sequence-indicator button[aria-checked=true]:before, 
.surfacehome_colorful_impact-seqind .c-sequence-indicator button[aria-selected=true]:before{
    background:#000;
}

.surfacehome_colorful_impact-seqind .theme-dark button.c-action-toggle, 
.surfacehome_colorful_impact-seqind .theme-light .theme-dark button.c-action-toggle{
    color: #000;
}

.surfacehome_colorful_impact .theme-dark{
    background-color: #e6e6e6
}

.surfacehome_colorful_impact-seqind .c-carousel.f-multi-slide.theme-dark .c-flipper{
    background: #FFF;
    color: #000;
}
.en-us .wdg-global .Surface_Lg_hero-panel .c-group a.c-call-to-action.x-hidden+a.c-call-to-action
{
    border: 2px solid transparent;
    padding: 9px 22px 6px 22px;
    margin-left: 0;
}
/*home page updates*/
.SurfaceHome_laptop
{
      margin-top:60px !important;
}

.surface-margin-top-60px.SurfaceHome_pro6{
  
    margin-top:0px !important;  
}
/*.en-ie .Surface_Home_Carousel_Hero_UT .hero-slide-two div, .en-gb .Surface_Home_Carousel_Hero_UT .hero-slide-two div
{
    
      color: #fff !important;  
}*/
/*.en-ie .Surface_Home_Carousel_Hero_UT .hero-slide-two div a, .en-gb .Surface_Home_Carousel_Hero_UT .hero-slide-two div a
{
    
      color: #fff !important;  
}

.en-ie .hero-slide-two .theme-light,.en-gb .hero-slide-two .theme-light
{
    background-color: #5e5e5e !important;
}*/ 

.en-ie .carousalthemedark.theme-light .Surface_Home_Carousel_2,
.en-ie .theme-dark-banner  .Surface_Home_Carousel_2 a.c-call-to-action,
.es-es .carousalthemedark.theme-light .Surface_Home_Carousel_2,
.es-es .theme-dark-banner  .Surface_Home_Carousel_2 a.c-call-to-action,
.pl-pl .carousalthemedark.theme-light .Surface_Home_Carousel_2,
.pl-pl .theme-dark-banner  .Surface_Home_Carousel_2 a.c-call-to-action,
/*.en-gb .carousalthemedark.theme-light .Surface_Home_Carousel_2*/
.theme-dark-banner  .Surface_Home_Carousel_2 a.c-call-to-action
{
color:#fff;
}
.en-ie .carousalthemedark.theme-light  button.c-action-toggle.c-glyph[aria-label],
.es-es .carousalthemedark.theme-light  button.c-action-toggle.c-glyph[aria-label],
.pl-pl .carousalthemedark.theme-light  button.c-action-toggle.c-glyph[aria-label],
.en-gb .carousalthemedark.theme-light  button.c-action-toggle.c-glyph[aria-label]
{
   color:#fff; 
}
.en-ie .carousalthemedark.theme-light.c-carousel.f-multi-slide .c-flipper,
.es-es .carousalthemedark.theme-light.c-carousel.f-multi-slide .c-flipper,
.pl-pl .carousalthemedark.theme-light.c-carousel.f-multi-slide .c-flipper
{
background: #000!important;
color:#fff!important;
}
.en-ie .carousalthemedark.theme-light .c-sequence-indicator button[aria-selected=true]:before,
.es-es .carousalthemedark.theme-light .c-sequence-indicator button[aria-selected=true]:before,
.pl-pl .carousalthemedark.theme-light .c-sequence-indicator button[aria-selected=true]:before
{
    border-color: rgba(255,255,255,.8)!important;
    background: #fff!important;
}
.en-ie .carousalthemedark.theme-light .c-sequence-indicator button.border_change:before,
.es-es .carousalthemedark.theme-light .c-sequence-indicator button.border_change:before,
.pl-pl .carousalthemedark.theme-light .c-sequence-indicator button.border_change:before
{
    border-color: rgba(255,255,255,.8)!important;
}
.en-ie .carousalthemedark.theme-light .theme-dark-banner,
.es-es .carousalthemedark.theme-light .theme-dark-banner,
.pl-pl .carousalthemedark.theme-light .theme-dark-banner
/*.en-gb .carousalthemedark.theme-light .theme-dark-banner*/
{
    background:#5e5e5e !important;
}
.en-ie .carousalthemedark.theme-light button.c-action-toggle:hover,
.es-es .carousalthemedark.theme-light button.c-action-toggle:hover,
.pl-pl .carousalthemedark.theme-light button.c-action-toggle:hover
{
color: #000 !important;
background: #FFF !important;
}
 .en-ie .wdg-global .carousalthemedark.theme-light .c-call-to-action:focus:not(.x-hidden-focus):not(.wdg-f-blue-button),
 .es-es .wdg-global .carousalthemedark.theme-light .c-call-to-action:focus:not(.x-hidden-focus):not(.wdg-f-blue-button),
 .pl-pl .wdg-global .carousalthemedark.theme-light .c-call-to-action:focus:not(.x-hidden-focus):not(.wdg-f-blue-button)
  {
      outline:#fff dashed 2px !important;
 }
 
.en-ie .wdg-global .surfacehome_colorful_impact .wdg-theme-dark-banner
/*.en-gb .wdg-global .surfacehome_colorful_impact .wdg-theme-dark-banner*/
{
color:#fff !important;
background: #5e5e5e !important;
}

.es-es .wdg-global .surfacehome_colorful_impact .wdg-theme-dark-banner, 
.pl-pl .wdg-global .surfacehome_colorful_impact .wdg-theme-dark-banner {
    color:#fff !important;
    background: #5e5e5e !important;
}

.en-ie .surfacehome_colorful_impact .wdg-theme-dark-banner a.c-call-to-action.c-glyph, 
.en-ie .surfacehome_colorful_impact .wdg-theme-dark-banner a.c-call-to-action.c-glyph.surface-secondary-cta,
.en-gb .surfacehome_colorful_impact .wdg-theme-dark-banner a.c-call-to-action.c-glyph, 
.en-gb .surfacehome_colorful_impact .wdg-theme-dark-banner a.c-call-to-action.c-glyph.surface-secondary-cta,
.es-es .surfacehome_colorful_impact .wdg-theme-dark-banner a.c-call-to-action.c-glyph,
.es-es .surfacehome_colorful_impact .wdg-theme-dark-banner a.c-call-to-action.c-glyph.surface-secondary-cta,
.pl-pl .surfacehome_colorful_impact .wdg-theme-dark-banner a.c-call-to-action.c-glyph,
.pl-pl .surfacehome_colorful_impact .wdg-theme-dark-banner a.c-call-to-action.c-glyph.surface-secondary-cta{
    color: #fff;
}

.en-gb.surfacehome_colorful_impact-seqind .theme-light .theme-dark button.c-action-toggle{
    color: #fff !important;
}

.en-ie .surfacehome_colorful_impact-seqind .c-sequence-indicator button[aria-checked=true]:before, 
.en-ie .surfacehome_colorful_impact-seqind .c-sequence-indicator button[aria-selected=true]:before,
.es-es .surfacehome_colorful_impact-seqind .c-sequence-indicator button[aria-checked=true]:before, 
.es-es .surfacehome_colorful_impact-seqind .c-sequence-indicator button[aria-selected=true]:before,
.pl-pl .surfacehome_colorful_impact-seqind .c-sequence-indicator button[aria-checked=true]:before, 
.pl-pl .surfacehome_colorful_impact-seqind .c-sequence-indicator button[aria-selected=true]:before,
.surfacehome_colorful_impact-seqind .c-sequence-indicator button[aria-checked=true]:before, 
.surfacehome_colorful_impact-seqind .c-sequence-indicator button[aria-selected=true]:before{
    background:#000 !important;
}
.en-ie .carousalthemedark.theme-dark .c-sequence-indicator button[aria-selected=true]:before,
.pl-pl .carousalthemedark.theme-dark .c-sequence-indicator button[aria-selected=true]:before,
.es-es .carousalthemedark.theme-dark .c-sequence-indicator button[aria-selected=true]:before
/*.en-gb .carousalthemedark.theme-dark .c-sequence-indicator button[aria-selected=true]:before*/
{
    border-color: rgba(255,255,255,.8)!important;
    background: #fff!important;
}

.en-ie .surfacehome_colorful_impact-seqind .c-sequence-indicator a:before, 
.en-ie .surfacehome_colorful_impact-seqind .c-sequence-indicator button:before,
.es-es .surfacehome_colorful_impact-seqind .c-sequence-indicator a:before, 
.es-es .surfacehome_colorful_impact-seqind .c-sequence-indicator button:before,
.pl-pl .surfacehome_colorful_impact-seqind .c-sequence-indicator a:before, 
.pl-pl .surfacehome_colorful_impact-seqind .c-sequence-indicator button:before,
.surfacehome_colorful_impact-seqind .c-sequence-indicator a:before, 
.surfacehome_colorful_impact-seqind .c-sequence-indicator button:before{
border: 1px solid rgba(255,255,255,.8) !important;
}
.en-ie .wdg-global .carousalthemedark.theme-dark .c-call-to-action:focus:not(.x-hidden-focus):not(.wdg-f-blue-button),
.es-es .wdg-global .carousalthemedark.theme-dark .c-call-to-action:focus:not(.x-hidden-focus):not(.wdg-f-blue-button),
.pl-pl .wdg-global .carousalthemedark.theme-dark .c-call-to-action:focus:not(.x-hidden-focus):not(.wdg-f-blue-button)
 {
    outline: #fff dashed 2px !important;
}

 .wdg-global .carousalthemedark.theme-dark .c-call-to-action:focus:not(.x-hidden-focus):not(.wdg-f-blue-button) 
{
    outline: #000 dashed 2px !important;
}
.en-ie .surfacehome_colorful_impact .theme-dark .c-call-to-action:focus:not(.x-hidden-focus):not(.wdg-f-blue-button),
.es-es .surfacehome_colorful_impact .theme-dark .c-call-to-action:focus:not(.x-hidden-focus):not(.wdg-f-blue-button),
.pl-pl .surfacehome_colorful_impact .theme-dark .c-call-to-action:focus:not(.x-hidden-focus):not(.wdg-f-blue-button),
.en-gb .surfacehome_colorful_impact .theme-dark .c-call-to-action:focus:not(.x-hidden-focus):not(.wdg-f-blue-button)
{
        background: none !important;
}

/*Home page colorful impact theme*/
@media only screen and (min-width:1084px) 
{
.wdg-global .surfacehome_colorful_impact-2 .theme-light .Surface_Home_Carousel_2,
.surfacehome_colorful_impact-2 .theme-light .Surface_Home_Carousel_2 a.c-call-to-action.c-glyph.surface-secondary-cta{
color:#ffffff;
}
.en-gb .wdg-global .carousalthemedark.theme-light .c-call-to-action:focus:not(.x-hidden-focus):not(.wdg-f-blue-button)
 {
      outline:#fff dashed 2px !important;
 }
.wdg-global .surfacehome_colorful_impact-1 .m-hero-item div,
.surfacehome_colorful_impact-1 div a.c-call-to-action.c-glyph.surface-secondary-cta{
color:#000000;
}

.wdg-global .surfacehome_colorful_impact.surfacehome_colorful_impact-1 .wdg-theme-dark-banner a.c-call-to-action.c-glyph, 
.wdg-global .surfacehome_colorful_impact.surfacehome_colorful_impact-1 .wdg-theme-dark-banner a.c-call-to-action.c-glyph.surface-secondary-cta{
    color: #0067b8;
}

/*---*/
.surfacehome_colorful_impact-seqind  .theme-light .c-sequence-indicator button:before
{
border : 1px solid #fff !important;
}
.surfacehome_colorful_impact-seqind .theme-light .c-sequence-indicator button[aria-selected=true]:before
{
background:#fff !important;
}
.surfacehome_colorful_impact-seqind .theme-light button.c-action-toggle,
.surfacehome_colorful_impact-seqind .wdg-theme-light-banner a.c-call-to-action.c-glyph.surface-secondary-cta,.surfacehome_colorful_impact-seqind .wdg-theme-light-banner
{
color:#fff !important;
}
.surfacehome_colorful_impact-seqind .theme-light button.c-action-toggle:hover
{
color: #000 !important;
background: #fff !important;
}
.surfacehome_colorful_impact-seqind .carousalthemedark.theme-dark .c-sequence-indicator button:before
{
border-color: #000 !important;   
}
.en-ie .surfacehome_colorful_impact-seqind .carousalthemedark.theme-dark .c-sequence-indicator button:before,
.es-es .surfacehome_colorful_impact-seqind .carousalthemedark.theme-dark .c-sequence-indicator button:before,
.pl-pl .surfacehome_colorful_impact-seqind .carousalthemedark.theme-dark .c-sequence-indicator button:before
{
    border-color:#fff !important;
}
.surfacehome_colorful_impact-seqind .carousalthemedark.theme-dark .c-sequence-indicator button[aria-selected=true]:before
{
border-color: #000 !important;
background: #000 !important;
}
.en-ie .surfacehome_colorful_impact-seqind .carousalthemedark.theme-dark .c-sequence-indicator button[aria-selected=true]:before,
.es-es .surfacehome_colorful_impact-seqind .carousalthemedark.theme-dark .c-sequence-indicator button[aria-selected=true]:before,
.pl-pl .surfacehome_colorful_impact-seqind .carousalthemedark.theme-dark .c-sequence-indicator button[aria-selected=true]:before
{
border-color: rgba(255,255,255,.8)!important;
background: #fff!important;
}
.surfacehome_colorful_impact-seqind .carousalthemedark.theme-dark button.c-action-toggle
{
color:#000 !important;
}
.surfacehome_colorful_impact-seqind .carousalthemedark.theme-dark button.c-action-toggle:hover
{
color: #fff !important;
background: #000 !important;
}
.surfacehome_colorful_impact-seqind .carousalthemedark.theme-dark a:focus
{
outline: #000 dashed 2px !important;
}
.en-gb .surfacehome_colorful_impact-seqind .carousalthemedark.theme-light.c-carousel.f-multi-slide .c-flipper,
.surfacehome_colorful_impact-seqind .carousalthemedark.theme-dark button:focus
{
    outline: #000 dashed 1px !important;
}

.wdg-global .surfacehome_colorful_impact-seqind .carousalthemedark.theme-light .c-call-to-action:focus:not(.x-hidden-focus):not(.wdg-f-blue-button)
{
outline: #fff dashed 2px !important;
}
.surfacehome_colorful_impact-seqind .carousalthemedark.theme-light button:focus
{
    outline: #fff dashed 1px !important;
}
.surfacehome_colorful_impact-seqind .carousalthemedark.theme-light .c-sequence-indicator button:before
{
    border-color: rgba(255,255,255,.8)!important;
}
.surfacehome_colorful_impact-seqind .carousalthemedark.theme-light .c-sequence-indicator button[aria-selected=true]:before
{
    border-color: rgba(255,255,255,.8)!important;
    background: #fff!important;
}
.surfacehome_colorful_impact-seqind .carousalthemedark.theme-light button.c-action-toggle:hover
{
color: #000 !important;
background: #FFF;
}
   
.en-gb.surfacehome_colorful_impact-seqind .theme-light .theme-dark button.c-action-toggle{
    color: #fff !important;
}
.en-ie .surfacehome_colorful_impact-seqind .theme-dark button.c-action-toggle, 
.en-ie .surfacehome_colorful_impact-seqind .theme-light .theme-dark button.c-action-toggle,
.es-es .surfacehome_colorful_impact-seqind .theme-dark button.c-action-toggle, 
.es-es .surfacehome_colorful_impact-seqind .theme-light .theme-dark button.c-action-toggle,
.pl-pl .surfacehome_colorful_impact-seqind .theme-dark button.c-action-toggle, 
.pl-pl .surfacehome_colorful_impact-seqind .theme-light .theme-dark button.c-action-toggle
{
color: #fff !important;
}
.en-ie .surfacehome_colorful_impact-seqind .c-sequence-indicator a:before, 
.en-ie .surfacehome_colorful_impact-seqind .c-sequence-indicator button:before,
.es-es .surfacehome_colorful_impact-seqind .c-sequence-indicator a:before, 
.es-es .surfacehome_colorful_impact-seqind .c-sequence-indicator button:before,
.pl-pl .surfacehome_colorful_impact-seqind .c-sequence-indicator a:before, 
.pl-pl .surfacehome_colorful_impact-seqind .c-sequence-indicator button:before
{
border: 1px solid rgba(255,255,255,.8);
border-color:#fff !important;
}
.en-ie .theme-dark .c-sequence-indicator button[aria-selected=true]:before,
.es-es .theme-dark .c-sequence-indicator button[aria-selected=true]:before,
.pl-pl .theme-dark .c-sequence-indicator button[aria-selected=true]:before
{
    background:#fff;
}
/*BTS locales css fixes*/
.surfacehome_colorful_impact-seqind .carousalthemedark.carousal-first-slide-theme-light .c-sequence-indicator button[aria-selected=true]:before
{
    border-color: #fff !important;
    background: #fff!important;
}
.surfacehome_colorful_impact-seqind .carousalthemedark.carousal-first-slide-theme-light button.c-action-toggle
{
color:#fff !important;
}

.surfacehome_colorful_impact-seqind .carousalthemedark.carousal-first-slide-theme-light button.c-action-toggle:hover
{
color: #000 !important;
    background: #fff !important;
}
.surfacehome_colorful_impact-seqind .carousalthemedark.carousal-first-slide-theme-light button:focus
{
outline:#fff dashed 1px !important;
}
.surfacehome_colorful_impact-seqind .carousalthemedark.theme-dark.carousal-first-slide-theme-light .c-sequence-indicator button:before
{
border-color:#fff !important;
}
.surfacehome_colorful_impact-seqind .carousalthemedark.theme-dark.carousal-first-slide-theme-light .c-call-to-action:focus:not(.x-hidden-focus):not(.wdg-f-blue-button)
{
outline:#fff dashed 2px !important;
}
/*BTS locales css fixes end*/
}
@media only screen and (max-width:1083px){ 
    .en-ie .surfacehome_colorful_impact-seqind .c-sequence-indicator button:before,
    .es-es .surfacehome_colorful_impact-seqind .c-sequence-indicator button:before,
    .pl-pl .surfacehome_colorful_impact-seqind .c-sequence-indicator button:before
    {
        border-color:#fff !important;
    }
    .en-ie .surfacehome_colorful_impact-seqind .carousalthemedark.theme-light .c-sequence-indicator button[aria-selected=true]:before,
    .es-es .surfacehome_colorful_impact-seqind .carousalthemedark.theme-light .c-sequence-indicator button[aria-selected=true]:before,
    .pl-pl .surfacehome_colorful_impact-seqind .carousalthemedark.theme-light .c-sequence-indicator button[aria-selected=true]:before
    {
        border-color: #fff !important;
        background: #fff !important;
    }
    .en-ie .surfacehome_colorful_impact-seqind .carousalthemedark.theme-light button.c-action-toggle, 
    .en-ie .surfacehome_colorful_impact-seqind .theme-dark button.c-action-toggle,
    .es-es .surfacehome_colorful_impact-seqind .carousalthemedark.theme-light button.c-action-toggle, 
    .es-es .surfacehome_colorful_impact-seqind .theme-dark button.c-action-toggle,
    .pl-pl .surfacehome_colorful_impact-seqind .carousalthemedark.theme-light button.c-action-toggle, 
    .pl-pl .surfacehome_colorful_impact-seqind .theme-dark button.c-action-toggle
    {
        color:#fff !important;
    }
    .en-ie .carousalthemedark.theme-light button.c-action-toggle:hover,
    .es-es .carousalthemedark.theme-light button.c-action-toggle:hover,
    .pl-pl .carousalthemedark.theme-light button.c-action-toggle:hover
    {
        color:#000 !important;
    }
    .en-ie .wdg-global .surfacehome_colorful_impact-seqind li section a,
    .es-es .wdg-global .surfacehome_colorful_impact-seqind li section a,
    .pl-pl .wdg-global .surfacehome_colorful_impact-seqind li section a
    {
        color:#fff !important;
    }
    .surfacehome_colorful_impact-seqind .carousalthemedark a:focus,
    {
    outline: #000 dashed 2px !important;
    }
    .surfacehome_colorful_impact-seqind .carousalthemedark button:focus
    {
        outline: #000 dashed 1px !important;
    }
  .en-gb .wdg-global .carousalthemedark.theme-light .c-call-to-action:focus:not(.x-hidden-focus):not(.wdg-f-blue-button)
    {
      outline:  #000 dashed 2px !important
    }
.wdg-global .surfacehome_colorful_impact-seqind .carousalthemedark li section
    {
        color: #000 !important;
        background-color:#e6e6e6 !important;
    }
   
    .wdg-global .surfacehome_colorful_impact-seqind li section a,
    .theme-dark-banner .Surface_Home_Carousel_2 a.c-call-to-action
    {
        color: #0067b8 !important;
    }
    .en-ie .theme-dark-banner .Surface_Home_Carousel_2 a.c-call-to-action,
    .es-es .theme-dark-banner .Surface_Home_Carousel_2 a.c-call-to-action,
    .pl-pl .theme-dark-banner .Surface_Home_Carousel_2 a.c-call-to-action
    {
        color:#fff !important;
    }
    .wdg-global .surfacehome_colorful_impact-seqind li section a:hover
    {
    background: transparent!important;
    }
    .surfacehome_colorful_impact-seqind .c-sequence-indicator button:before{
    border: 1px solid rgba(0,0,0,.8) !important;
    }
    
    .surfacehome_colorful_impact-seqind  .carousalthemedark .c-sequence-indicator button[aria-selected=true]:before
    {
        background:#000 !important;
    }
    .surfacehome_colorful_impact-seqind  .carousalthemedark.theme-light .c-sequence-indicator button[aria-selected=true]:before
    {
        border-color:rgba(0,0,0,.8) !important;
    }
    .surfacehome_colorful_impact-seqind .carousalthemedark.theme-light button.c-action-toggle,
    .surfacehome_colorful_impact-seqind .theme-dark button.c-action-toggle
    {
        color:#000 !important;
    }
    .carousalthemedark.theme-light button.c-action-toggle:hover,.surfacehome_colorful_impact-seqind .theme-dark button.c-action-toggle:hover{
        color:#fff !important;
        background: #000 !important;
    }
    }
    .en-ie .carousalthemedark.theme-dark button.c-action-toggle:hover,
    .es-es .carousalthemedark.theme-dark button.c-action-toggle:hover,
    .pl-pl .carousalthemedark.theme-dark button.c-action-toggle:hover
    /*.en-gb .carousalthemedark.theme-dark button.c-action-toggle:hover*/
    {
        color: #000 !important;
        background: #FFF !important;
    }
    .en-ie .surfacehome_colorful_impact-seqind .carousalthemedark button:focus,
    .en-ie .surfacehome_colorful_impact-seqind .carousalthemedark.theme-dark a:focus,
    .es-es .surfacehome_colorful_impact-seqind .carousalthemedark button:focus,
    .es-es .surfacehome_colorful_impact-seqind .carousalthemedark.theme-dark a:focus,
    .pl-pl .surfacehome_colorful_impact-seqind .carousalthemedark button:focus,
    .pl-pl .surfacehome_colorful_impact-seqind .carousalthemedark.theme-dark a:focus
    {
        transition: none;
        outline-color: #fff !important;
    }
    .surfacehome_colorful_impact-seqind .theme-dark span.c-tooltip
    {
        background: #f2f2f2;
        color: #000;
        border-color: rgba(0,0,0,.3);
    }
  
  /*Mac fixes for Hero pride*/
 .surfacehome_colorful_impact-macos-2 .wdg-theme-light-banner .c-subheading-2 a.c-hyperlink{
     color: #fff;
 }
 
 #mainContent .surfacehome_colorful_impact-macos-2 a.c-hyperlink:not(.f-image):not(:hover):focus, #mainContent .surfacehome_colorful_impact-macos-2 a.c-hyperlink:not(.f-image):focus, #mainContent p a:focus
{
    outline: 2px dotted #fff !important;
}

.surfacehome_colorful_impact-macos-2 a.c-hyperlink:not(.f-image):focus,
.surfacehome_colorful_impact-macos-2 a.c-hyperlink:not(.f-image):hover{
    color: #ffffff;
}

a .m-hero-item:hover {
    cursor: pointer;
}

@media only screen and (min-width: 1398px) and (max-width: 1650px){ 
 .Studio-hero-min1400 >div>div {
    padding-left: 13% !important;
} 
    
 }
 @media only screen and (min-width: 1241px) and (max-width: 1250px){ 
 .Studio-hero-min1400 >div>div {
    padding-left: 5% !important;
} 
    
 }

/*hero_pivot*/

div[data-module-id] {
    min-height: 1px;
}
.Surface_Hero_pivot_custom_sur .w-heropivot {

    pointer-events: none;
}
.Surface_Hero_pivot_custom_sur .m-hero-item{
    position: relative;
    overflow: hidden;
    padding: 0 5%;
    
}
.Surface_Hero_pivot_custom_sur .m-hero-item>div>div{
    position: absolute;
    z-index: 1;
    max-width: 520px;
}
.Surface_Hero_pivot_custom_sur .m-hero-item>picture {
    position: absolute;
    top: 0;
    left: 0;
    bottom: 0;
    z-index: 0;
    width: 100%;
    overflow: hidden;
    -ms-transform: scale(1.0125);
    transform: scale(1.0125);
}
 .Surface_Hero_pivot_custom_sur .w-heropivot .c-hero>div,.Surface_Hero_pivot_custom_sur  .w-heropivot .m-hero-item>div {
    height: 100%;
}
.Surface_Hero_pivot_custom_sur .m-hero-item>div,.Surface_Hero_pivot_custom_sur  .c-hero>div {
    width: 88%;
    height: 100%;
    max-width: 2048px;
    position: absolute;
    top: 0;
    bottom: 0;
    left: 0;
    right: 0;
    z-index: 1;
    margin: 0 auto;
    overflow: hidden;
}
.Surface_Hero_pivot_custom_sur .c-pivot>header, .Surface_Hero_pivot_custom_sur .c-pivot>div, .Surface_Hero_pivot_custom_sur .c-pivot>[role="tablist"] {
    display: -ms-flexbox;
    display: flex;
    overflow: hidden;
    white-space: nowrap;
    width: 100%;
}
.Surface_Hero_pivot_custom_sur .w-heropivot .c-pivot ul li {
    padding-right: 0;
    margin-right: 12px;
    margin-left: 12px;
    display: inline-block;
}
.Surface_Hero_pivot_custom_sur .w-heropivot .m-hero-item.theme-light {
    background-color: transparent !important;
}
 .Surface_Hero_pivot_custom_sur .m-hero-item.f-y-center>div>div { 
     top: 120px; 
     top: calc(50%); 
     -ms-transform: translatey(-50%); 
    transform: translatey(-50%); 
 } 
.Surface_Hero_pivot_custom_sur .m-hero-item.f-x-right>div>div{
    right: 0;
}
.Surface_Hero_pivot_custom_sur .theme-light .c-pivot:not(.f-disabled)>header>[role="tab"], 
.Surface_Hero_pivot_custom_sur .theme-light .c-pivot:not(.f-disabled)>header a,
 .Surface_Hero_pivot_custom_sur .theme-light .c-pivot:not(.f-disabled)>div>[role="tab"],
 .Surface_Hero_pivot_custom_sur  .theme-light .c-pivot:not(.f-disabled)>div a,
  .Surface_Hero_pivot_custom_sur .theme-light .c-pivot:not(.f-disabled)>[role="tablist"]>[role="tab"],
    .Surface_Hero_pivot_custom_sur .theme-light .c-pivot:not(.f-disabled)>[role="tablist"] a, 
    .Surface_Hero_pivot_custom_sur .theme-dark .theme-light .c-pivot:not(.f-disabled)>header>[role="tab"], 
    .Surface_Hero_pivot_custom_sur .theme-dark .theme-light .c-pivot:not(.f-disabled)>header a,
     .Surface_Hero_pivot_custom_sur .theme-dark .theme-light .c-pivot:not(.f-disabled)>div>[role="tab"],
      .Surface_Hero_pivot_custom_sur .theme-dark .theme-light .c-pivot:not(.f-disabled)>div a, 
      .Surface_Hero_pivot_custom_sur .theme-dark .theme-light .c-pivot:not(.f-disabled)>[role="tablist"]>[role="tab"],
       .Surface_Hero_pivot_custom_sur .theme-dark .theme-light .c-pivot:not(.f-disabled)>[role="tablist"] a {
    color: rgba(0,0,0,.6);
}
.Surface_Hero_pivot_custom_sur .w-heropivot .c-pivot ul li :first-child {
    margin-left: 0;
}
.Surface_Hero_pivot_custom_sur .w-heropivot .m-hero-item.h-immersivehero:before {
    padding-bottom: 75%;
}
.Surface_Hero_pivot_custom_sur .w-heropivot .m-hero-item:before {
    padding-bottom: 66%;
}

.Surface_Hero_pivot_custom_sur .w-heropivot .c-pivot .color_tip {
    display: none;
    position: absolute;
    border: 1px solid #000;
    background-color: #f2f2f2;
    color: #000 !important;
    padding: 6px;
}
.Surface_Hero_pivot_custom_sur span.c-tooltip {
    font-size: 13px;
    position: fixed;
    background: #f2f2f2;
    border: 1px solid rgba(0,0,0,.3);
    max-width: 340px;
    padding: 8px;
    line-height: 16px;
    z-index: 700;
font-family: Segoe UI,SegoeUI,"Helvetica Neue",Helvetica,Arial,sans-serif;
}
.Surface_Hero_pivot_custom_sur .w-heropivot .c-heading-3 {
    padding: 37px 0 3px;
    padding-top: 25px;
}
.Surface_Hero_pivot_custom_sur .c-heading-3 {
    font-size: 34px;
    line-height: 40px;
font-weight: 600;
font-family: Segoe UI,SegoeUI,"Helvetica Neue",Helvetica,Arial,sans-serif;
}
.Surface_Hero_pivot_custom_sur .w-heropivot .c-paragraph-2 {
    line-height: 28px;
padding: 4px 0 8px;
font-size: 18px;
font-weight: 200;
 
    font-family: Segoe UI,SegoeUI,"Helvetica Neue",Helvetica,Arial,sans-serif;
}
.Surface_Hero_pivot_custom_sur .c-pivot:not(.f-disabled)>header>[role="tab"].f-active, 
.Surface_Hero_pivot_custom_sur .c-pivot:not(.f-disabled)>header a.f-active, 
.Surface_Hero_pivot_custom_sur .c-pivot:not(.f-disabled)>div>[role="tab"].f-active, 
.Surface_Hero_pivot_custom_sur .c-pivot:not(.f-disabled)>div a.f-active, 
.Surface_Hero_pivot_custom_sur .c-pivot:not(.f-disabled)>[role="tablist"]>[role="tab"].f-active, 
.Surface_Hero_pivot_custom_sur .c-pivot:not(.f-disabled)>[role="tablist"] a.f-active {
    position: relative;
    color: #000;
}
.Surface_Hero_pivot_custom_sur .w-heropivot .c-pivot ul li a {
    margin-left: 0;
    margin-right: 0;
    display: inline-block;
    cursor: pointer;
    padding: 0 !important;
    pointer-events: auto;
    background-color: transparent !important;
    line-height: 0;
}
.Surface_Hero_pivot_custom_sur .c-pivot>header>[role="tab"], 
.Surface_Hero_pivot_custom_sur .c-pivot>header a, .c-pivot>div>[role="tab"], 
.Surface_Hero_pivot_custom_sur .c-pivot>div a, 
.Surface_Hero_pivot_custom_sur .c-pivot>[role="tablist"]>[role="tab"], 
.Surface_Hero_pivot_custom_sur .c-pivot>[role="tablist"] a {
    font-size: 15px;
    position: relative;
    border: 2px solid transparent;
    outline: 1px solid transparent;
    outline-offset: -3px;
    padding: 0 4px;
    margin: 0 12px;
    display: inline-block;
    color: rgba(0,0,0,.6);
    font-weight: 400;
    white-space: nowrap;
    cursor: pointer;
    box-sizing: border-box;
    transition: margin 600ms cubic-bezier(.16,1,.29,.99);
    line-height: 36px;
}
/*.Surface_Hero_pivot_custom_sur .w-heropivot .c-pivot ul li .f-active.theme-light:focus {
    border: 2px solid #b3d4fc !important;
}*/
.Surface_Hero_pivot_custom_sur .w-heropivot .c-pivot ul li .f-active {
    border: 2px solid #fff !important;
}
.Surface_Hero_pivot_custom_sur .c-pivot {
    position: relative;
    margin-top: 24px;
}
.Surface_Hero_pivot_custom_sur .m-hero-item>div>div>div {
    margin-top: 24px;
    padding: 12px 2px 0;
}

.Surface_Hero_pivot_custom_sur .m-hero-item:before, .c-hero:before {
    display: block;
    content: "";
    width: 100%;
    padding-bottom: 61.875%;
}
@media screen and (min-width: 1084px){
.Surface_Hero_pivot_custom_sur .m-hero-item:before, .Surface_Hero_pivot_custom_sur .c-hero:before {
    padding-bottom: 41.55%;
}
.Surface_Hero_pivot_custom_sur .m-hero-item:before, .Surface_Hero_pivot_custom_sur .c-hero:before {
    padding-bottom: 41.55%;
}
}
@media only screen and (max-width: 1399px){
.Surface_Hero_pivot_custom_sur .m-hero-item>div>div{
    max-width: 440px;
}
}


@media only screen and (max-width: 1083px) and (min-width: 540px){
.Surface_Hero_pivot_custom_sur .w-heropivot .c-hero>div, .Surface_Hero_pivot_custom_sur .w-heropivot .m-hero-item>div {
    width: 66.6666666667%;
}
}

@media only screen and (max-width: 1083px) and (min-width: 768px){
.Surface_Hero_pivot_custom_sur .w-heropivot .c-hero, .Surface_Hero_pivot_custom_sur .w-heropivot .m-hero-item {
    height: auto;
    padding: 0;
    text-align: center;
}
}
@media (max-width: 1083px){
.Surface_Hero_pivot_custom_sur .w-heropivot .m-hero-item {
    text-align: center;
}
.Surface_Hero_pivot_custom_sur .m-hero-item>div>div, .Surface_Hero_pivot_custom_sur .c-hero>div>div {
    max-width: 340px;
}
.Surface_Hero_pivot_custom_sur .w-heropivot>div, .Surface_Hero_pivot_custom_sur .w-heropivot .m-hero-item>div {
    padding: 12px;
    position: relative;
}

.Surface_Hero_pivot_custom_sur .w-heropivot .m-hero-item[class*=f-x][class*=f-y]>div>div {
    position: relative;
    margin: 0 auto;
    left: 0;
    top: 0;
    -ms-transform: none;
    -webkit-transform: none;
    transform: none;
    max-width: 100%;
}
.Surface_Hero_pivot_custom_sur .w-heropivot .m-hero-item .c-pivot>ul {
    display: inline-block;
    margin-top: 20px;
    margin-bottom: 20px;
    white-space: inherit;
}
}


    .Surface_Hero_pivot_custom_sur .m-hero-item.theme-dark {

        background-color: transparent !important;

    }

    .Surface_Hero_pivot_custom_sur .m-hero-item.theme-light {

        background-color: transparent !important;

    }

    .Surface_Hero_pivot_custom_sur .c-pivot {

        padding-top: 20px !important;

	}

        .Surface_Hero_pivot_custom_sur ul li {

            padding-right: 0px;

            margin-right: 12px;

            margin-left: 12px;

            display: inline-block;
		}

 

           .Surface_Hero_pivot_custom_sur  ul li:first-child {

                margin-left: 0;

            }

 

          .Surface_Hero_pivot_custom_sur  ul li a {

                margin-left: 0px;

                margin-right: 0px;

                display: inline-block;

                cursor: pointer;

                padding: 0px !important;

                pointer-events: auto;

               background-color: transparent !important;

                line-height: 0px

            }

 

           .Surface_Hero_pivot_custom_sur  ul li .f-active.theme-dark {

                border: 2px solid white !important

            }

 

            /*.f-active.theme-light {

                border: 2px solid black !important

            }*/

 

            /* Bug #223724 */

         /* .Surface_Hero_pivot_custom_sur  ul li .f-active.theme-light:focus {

                border: 2px solid #b3d4fc !important;

            }*/

 

         .Surface_Hero_pivot_custom_sur  ul li .f-active {

                border: 2px solid white !important

            }

        

 

       .Surface_Hero_pivot_custom_sur  .color_tip {

            display: none;

            position: absolute;

            border: 1px solid #000;

            background-color: #f2f2f2;

            color: #000 !important;

            padding: 6px;

        }

    /*}*/

 

    .Surface_Hero_pivot_custom_sur .f-active:after {

        border-bottom: none !important

    }

 

 

    .Surface_Hero_pivot_custom_sur .c-paragraph-2 {

        padding: 4px 0 8px;

    }

 

    .Surface_Hero_pivot_custom_sur .c-paragraph-2 {

        line-height: 28px;

    }

 

    .Surface_Hero_pivot_custom_sur .c-heading-3 {

        padding: 37px 0 3px;

        padding-top: 25px;

    }

 

    .Surface_Hero_pivot_custom_sur .c-hero > div, .m-hero-item > div {

        height: 100%;

    }

 

    .Surface_Hero_pivot_custom_sur picture {

        display: none;

    }

 

   .Surface_Hero_pivot_custom_sur  picture.f-active {

        display: block;

    }

 

 

    .Surface_Hero_pivot_custom_sur .m-hero-item:before {

        padding-bottom: 66%;

    }

        @media only screen and (min-width: 0px) and (max-width: 539px) {
.Surface_Hero_pivot_custom_sur .m-hero-item:befor{
            padding-bottom: 60%;
    }

        }

 

        @media only screen and (min-width: 540px) and (max-width: 767px) {
.Surface_Hero_pivot_custom_sur .m-hero-item:befor{
            padding-bottom: 60%;

        }
        }
 

        @media only screen and (min-width: 768px) and (max-width: 1083px) {
.Surface_Hero_pivot_custom_sur .m-hero-item:befor{
            padding-bottom: 60%;

        }
        }

    

 

    .Surface_Hero_pivot_custom_sur .m-hero-item.h-immersivehero:before {

        padding-bottom: 90%;
    }

 

        @media only screen and (min-width: 0px) and (max-width: 539px) {
           .Surface_Hero_pivot_custom_sur  .m-hero-item.h-immersivehero:before
            {
            padding-bottom: 80%;
            }

             }

 

        @media only screen and (min-width: 540px) and (max-width: 767px) {
           .Surface_Hero_pivot_custom_sur  .m-hero-item.h-immersivehero:before
            {
            padding-bottom: 80%;
                }
                }

 

        @media only screen and (min-width: 768px) and (max-width: 1083px) {
            .Surface_Hero_pivot_custom_sur .m-hero-item.h-immersivehero:before
            {
            padding-bottom: 80%;
            }

        }

    

/*}*/

 

 

.Surface_Hero_pivot_custom_sur .w-heropivot .c-pivot:not(.f-disabled) > ul > a.f-active:focus {

    background: initial;

}

 

.high-contrast-mode.Firefox .w-heropivot div div,.high-contrast-mode.Firefox .w-heropivot div div .c-pivot header {

    background: none;

}

 

@media screen and (-ms-high-contrast: white-on-black) {

    .Surface_Hero_pivot_custom_sur .w-heropivot .c-pivot > ul > li > a {

        border: 2px solid yellow !important

    }

}

 

.Surface_Hero_pivot_custom_sur .w-heropivot .c-pivot ul li a.f-active img:first-child, .w-heropivot .c-pivot ul li a:not(.f-active) img + img {

    display: none;

}

 

/*.w-heropivot .c-pivot ul li a.f-active img + img, .w-heropivot .c-pivot ul li a.f-active img:first-child {

    display: inline-block;

}*/

 

.high-contrast-mode .w-heropivot :not(.f-disabled).c-pivot > ul > a.f-active:focus {

    background: transparent;

    border: 1px solid red;

}

 

.Surface_Hero_pivot_custom_sur .w-heropivot .c-pivot ul:empty, .m-hero-item .c-pivot > ul:empty {

    display: none !important;

}

 

 

 

@media only screen and (min-width: 1400px) {

    .Surface_Hero_pivot_custom_sur .w-heropivot .m-hero-item > div > div, .c-hero > div > div {

        padding-left: 48px;

        padding-right: 48px

    }

}

 

@media (max-width: 1399px) {

    .Surface_Hero_pivot_custom_sur .w-heropivot c-heading-3 {

        line-height: 40px;

        padding: 38px 0 2px;

    }

}

 

@media only screen and (min-width: 1084px) {

    .Surface_Hero_pivot_custom_sur .sur-color-burgundy *,

    .Surface_Hero_pivot_custom_sur .sur-color-blue *,

    .Surface_Hero_pivot_custom_sur .sur-color-gold *,

    .Surface_Hero_pivot_custom_sur .sur-color-white *,

    .en-au .Surface_Hero_pivot_custom_sur .sur-color-silver * {

        color: #fff !important;

    }

}

@media (max-width: 1083px) {

       .Surface_Hero_pivot_custom_sur .w-heropivot .m-hero-item {

            text-align: center;
	   }
          .Surface_Hero_pivot_custom_sur .w-heropivot .m-hero-item  > picture img {

                top: 0;

                left: calc(50%);

                -webkit-transform: translateX(-50%);

                transform: translateX(-50%);

            }
        .Surface_Hero_pivot_custom_sur  .w-heropivot .m-hero-item .c-pivot > ul {

                display: inline-block;

                margin-top: 20px;

                margin-bottom: 20px;

                white-space: inherit;

            }

     .Surface_Hero_pivot_custom_sur .w-heropivot  .m-hero-item[class*=f-x][class*=f-y] > div > div {

            position: relative;

            margin: 0 auto;

            left: 0;

            top: 0;

            transform: none;

            max-width: 100%;

        }
      .Surface_Hero_pivot_custom_sur .w-heropivot  c-paragraph-2 {

            line-height: 24px;

        }
     .Surface_Hero_pivot_custom_sur  .w-heropivot  > div, .m-hero-item > div {

            padding: 12px;

            position: relative;

        }
}
 

@media only screen and (max-width: 1083px) and (min-width: 540px) {

    .Surface_Hero_pivot_custom_sur .w-heropivot .c-hero > div, .w-heropivot .m-hero-item > div {

        width: 66.6666666667%;

    }

 

    /*.Surface_Hero_pivot_custom_sur .w-heropivot .c-pivot > ul > li .f-active {

       
            border: 2px solid black !important

        }*/


}

 

@media only screen and (max-width: 1083px) and (min-width: 768px) {

    .Surface_Hero_pivot_custom_sur .w-heropivot .c-hero, .w-heropivot .m-hero-item {

        height: auto;

        padding: 0;

        text-align: center;

    }

      .w-heropivot .c-pivot > ul > li.f-active { 
            border: 2px solid black !important

        }

    

}

 

.Surface_Hero_pivot_custom_sur .sur-color-undefined .c-group a.c-call-to-action.c-glyph {

    margin-right: 0px;

}

 

.Surface_Hero_pivot_custom_sur .w-heropivot .c-pivot {

    padding-top: 0px;

    margin-top: 0px;

}
 @media screen and (max-width:646px) {

   .Surface_Hero_pivot_custom_sur .w-heropivot .c-pivot > ul > li:first-child {

        margin-left: 12px !important;

    }
        .Surface_Hero_pivot_custom_sur .w-heropivot .c-pivot > ul > li.f-active.theme-dark {

            border: 2px solid black !important

        }

        .Surface_Hero_pivot_custom_sur .w-heropivot .c-pivot > ul > li.f-active {

            border: 2px solid black !important

        }
    .Surface_Hero_pivot_custom_sur .c-pivot ul li {

        padding-top: 5px;

    }

}

.rtl .c-pivot > ul > li:first-child {

    margin-left: 12px;

}

 

.rtl .c-pivot > ul > li:last-child {

    margin-left: 0px;

}

 

.ar-sa .w-heropivot .c-pivot ul[role='tablist'] li {

    vertical-align: bottom;

}

 

@media screen and (-ms-high-contrast: active) {

 

    .Surface_Hero_pivot_custom_sur .w-heropivot .c-pivot .mscom-link img.mscom-image.icons:focus {

        z-index: 999;

    }

 

    /*#wdgweb-heropivot-wipvslb .c-heading-3, #wdgweb-heropivot-wipvslb .c-paragraph-2 {

        background: #000;

    }*/

}

/*--PK*/

 

/* Bug #219054 */

@media screen and (-ms-high-contrast: white-on-black) {

    #wdgweb-heropivot-wipvslb .c-heading-3, #wdgweb-heropivot-wipvslb .c-paragraph-2 {

        background: #000;

    }

}

.Surface_Hero_pivot_custom_sur .Surface_Hero_pivot_custom_hl .m-hero-item .c-logo
{
    
    margin-top: 0px !important; 
    
}
.Surface_Hero_pivot_custom_sur .Surface_Hero_pivot_custom_hl .m-hero-item .c-pivot .c-logo
{
vertical-align: initial;
}

.Surface_Hero_pivot_custom_sur .w-heropivot.Surface_Hero_pivot_custom_hl .c-pivot ul li a .c-image
{
    border-radius: 50% !important;
    
}
.Surface_Hero_pivot_custom_sur .w-heropivot.Surface_Hero_pivot_custom_hl .c-pivot ul li a
{
    border-radius: 50% !important;
    
}
.Surface_Hero_pivot_custom_sur .w-heropivot.Surface_Hero_pivot_custom_hl .color-name-hl
{
    padding-left: 20px;
}
.Surface_Hero_pivot_custom_sur .w-heropivot.Surface_Hero_pivot_custom_hl .c-pivot ul li a .c-image.inactive
{
    border-radius: 50% !important;
   /* clip-path: circle(45% at 50% 50%);*/
}
.Surface_Hero_pivot_custom_sur .w-heropivot.Surface_Hero_pivot_custom_hl .c-pivot ul li a .c-image.activelogo
{
    width: 44px;
}
/*pivot panel super script fix*/
.zh-cn .Surface_Hero_pivot_custom_sur div sup a.c-hyperlink,
.ko-kr .Surface_Hero_pivot_custom_sur div sup a.c-hyperlink
{
color:#0067B8;
font-weight:normal;
}
.zh-cn .Surface_Hero_pivot_custom_sur div sup a.c-hyperlink,
.ko-kr .Surface_Hero_pivot_custom_sur div sup a.c-hyperlink
{
    pointer-events: auto;
}
.zh-cn .Surface_Hero_pivot_custom_sur div sup a.c-hyperlink:hover,
.ko-kr .Surface_Hero_pivot_custom_sur div sup a.c-hyperlink:hover,
.zh-cn .Surface_Hero_pivot_custom_sur div sup a.c-hyperlink:focus,
.ko-kr .Surface_Hero_pivot_custom_sur div sup a.c-hyperlink:focus
{
color:#005da6 !important;
}
/*pivot panel super script fix end*/
/*.padding-bottom-carosuel
{
    padding-bottom: 50px;
}*/
.surface-section-footnotes a{
         text-decoration: underline; 
     color: #00bcf2!important; 
   
}
.rtl .surface-home-offercarousel.surface-home-offercarousel-auto .c-carousel .c-flipper.f-next
{
right:auto !important;
}

/*BTS homepage*/
@media screen and (min-width:1084px) {
/*.en-us .surfacehome_colorful_impact-seqind #hero-slide-one div,
.en-us .surfacehome_colorful_impact-seqind #hero-slide-one a,
.en-us .surfacehome_colorful_impact-seqind .carousalthemedark.theme-dark button.c-action-toggle
{
color:#fff !important;
}*/
/*.en-us .surfacehome_colorful_impact-seqind .carousalthemedark.theme-dark .c-sequence-indicator button:before,*/
.en-ca .surfacehome_colorful_impact-seqind .carousalthemedark.theme-dark .c-sequence-indicator button:before,
.fr-ca .surfacehome_colorful_impact-seqind .carousalthemedark.theme-dark .c-sequence-indicator button:before
{
border-color:#fff !important;
}
/*.en-us .surfacehome_colorful_impact-seqind .carousalthemedark.theme-dark .c-sequence-indicator button[aria-selected=true]:before,*/
.en-ca .surfacehome_colorful_impact-seqind .carousalthemedark.theme-dark .c-sequence-indicator button[aria-selected=true]:before,
.fr-ca .surfacehome_colorful_impact-seqind .carousalthemedark.theme-dark .c-sequence-indicator button[aria-selected=true]:before
{
border-color: #fff !important;
background: #fff !important;
}
/*.en-us .surfacehome_colorful_impact-seqind .carousalthemedark.theme-dark button:focus,*/
.en-ca .surfacehome_colorful_impact-seqind .carousalthemedark.theme-dark button:focus,
.fr-ca .surfacehome_colorful_impact-seqind .carousalthemedark.theme-dark button:focus
{
outline: #fff dashed 1px !important;
}
/*.en-us .surfacehome_colorful_impact-seqind #hero-slide-one a:focus,*/
.en-ca .surfacehome_colorful_impact-seqind #hero-slide-one a:focus,
.fr-ca .surfacehome_colorful_impact-seqind #hero-slide-one a:focus
{
    outline: #fff dashed 2px !important;
}
/*.en-us .surfacehome_colorful_impact-seqind .carousalthemedark.theme-dark button.c-action-toggle:hover,*/
.en-ca .surfacehome_colorful_impact-seqind .carousalthemedark.theme-dark button.c-action-toggle:hover,
.fr-ca .surfacehome_colorful_impact-seqind .carousalthemedark.theme-dark button.c-action-toggle:hover
{
color: #000 !important;
background: #fff !important;
}
/*.en-us .surfacehome_colorful_impact-seqind .carousalthemedark.theme-light button:focus,*/
.en-ca .surfacehome_colorful_impact-seqind .carousalthemedark.theme-light button:focus,
.fr-ca .surfacehome_colorful_impact-seqind .carousalthemedark.theme-light button:focus
{
outline: #000 dashed 1px !important;
}
/*.en-us .wdg-global .surfacehome_colorful_impact-seqind .carousalthemedark.theme-light .c-call-to-action:focus:not(.x-hidden-focus):not(.wdg-f-blue-button):focus{
 outline: #000 dashed 2px !important;
}*/
/*.en-us .surfacehome_colorful_impact-seqind .carousalthemedark.theme-light .c-sequence-indicator button:before,*/
.en-ca .surfacehome_colorful_impact-seqind .carousalthemedark.theme-light .c-sequence-indicator button:before,
.fr-ca .surfacehome_colorful_impact-seqind .carousalthemedark.theme-light .c-sequence-indicator button:before
{
border:1px solid #000 !important;
}
/*.en-us .surfacehome_colorful_impact-seqind .theme-light .c-sequence-indicator button[aria-selected=true]:before,*/
.en-ca .surfacehome_colorful_impact-seqind .theme-light .c-sequence-indicator button[aria-selected=true]:before,
.fr-ca .surfacehome_colorful_impact-seqind .theme-light .c-sequence-indicator button[aria-selected=true]:before
{
background: #000 !important;
}
/*.en-us .surfacehome_colorful_impact-seqind .carousalthemedark.theme-light button.c-action-toggle:hover,*/
.en-ca .surfacehome_colorful_impact-seqind .carousalthemedark.theme-light button.c-action-toggle:hover,
.fr-ca .surfacehome_colorful_impact-seqind .carousalthemedark.theme-light button.c-action-toggle:hover
{
    color: #fff !important;
    background: #000 !important;
}
/*.en-us .surfacehome_colorful_impact-seqind .Surface_Home_Carousel_2,
.en-us .surfacehome_colorful_impact-seqind .theme-light button.c-action-toggle,*/
.en-ca .surfacehome_colorful_impact-seqind .Surface_Home_Carousel_2,
.en-ca .surfacehome_colorful_impact-seqind .theme-light button.c-action-toggle,
.fr-ca .surfacehome_colorful_impact-seqind .Surface_Home_Carousel_2,
.fr-ca .surfacehome_colorful_impact-seqind .theme-light button.c-action-toggle
{
    color:#000 !important;
}
/*.en-us .surfacehome_colorful_impact-seqind .wdg-theme-light-banner a.c-call-to-action.c-glyph.surface-secondary-cta,*/
.en-ca .surfacehome_colorful_impact-seqind .wdg-theme-light-banner a.c-call-to-action.c-glyph.surface-secondary-cta,
.fr-ca .surfacehome_colorful_impact-seqind .wdg-theme-light-banner a.c-call-to-action.c-glyph.surface-secondary-cta
{
    color:#0067b8 !important;
}
}
/*BTS homepage end*/

/*Compage page icon hover*/
.mouse_hover
{
     outline:2px solid #e5e5e5;    
}
.surface-compare-deviceimgblock .compare_table
{
  cursor: pointer;  
}
/*compare page sticky nav image fix*/
.surface-compare-stickybar .c-image img{
    height:175px;
    width:175px;
    margin-left:auto;
    margin-right:auto;
}
@media only screen and (max-width:767px) {
    .surface-compare-stickybar .c-image img{
    height:120px;
    width:120px;
    }
}
/*Hero carousal issues*/
.surfacehome_colorful_impact-seqind #hero-slide-two a.mscom-link.c-call-to-action:focus,
.surfacehome_colorful_impact-seqind #hero-slide-two a.mscom-link.c-call-to-action:hover
{
    background:transparent !important;
}
@media only screen and (min-width: 1084px)
{
.en-ca .surfacehome_colorful_impact-seqind .carousalthemedark.theme-light [aria-selected="true"][aria-controls="hero-slide-two"]:focus,
.fr-ca .surfacehome_colorful_impact-seqind .carousalthemedark.theme-light [aria-selected="true"][aria-controls="hero-slide-two"]:focus
{
    outline:#000 dashed 1px !important;
}
/*.en-ca .surfacehome_colorful_impact-seqind .carousalthemedark .c-sequence-indicator button[aria-selected=true][aria-controls="hero-slide-three"]:before,*/
.fr-ca .surfacehome_colorful_impact-seqind .carousalthemedark .c-sequence-indicator button[aria-selected=true][aria-controls="hero-slide-three"]:before
{
    border-color: #fff !important;
    background: #fff !important;
}
/*.en-ca .surfacehome_colorful_impact-seqind .carousalthemedark.theme-light .c-sequence-indicator button:before, */
.fr-ca .surfacehome_colorful_impact-seqind .carousalthemedark.theme-light .c-sequence-indicator button:before
{
border:1px solid #fff !important;
border-color: rgba(255, 255, 255, 0.8) !important;
}
 /*.en-ca .surfacehome_colorful_impact-seqind .theme-light button.c-action-toggle,*/
.fr-ca .surfacehome_colorful_impact-seqind .theme-light button.c-action-toggle,
.en-ca .surfacehome_colorful_impact-seqind .Surface_Home_Carousel_3,
.fr-ca .surfacehome_colorful_impact-seqind .Surface_Home_Carousel_3,
.en-ca .surfacehome_colorful_impact#hero-slide-three .wdg-theme-dark-banner a.c-call-to-action.c-glyph.surface-secondary-cta,
.fr-ca .surfacehome_colorful_impact#hero-slide-three .wdg-theme-dark-banner a.c-call-to-action.c-glyph.surface-secondary-cta
{
color:#fff !important;
}

.fr-ca .surfacehome_colorful_impact-seqind .carousalthemedark.theme-light button.c-action-toggle:hover
{
    color: #000 !important;
    background: #fff !important;
}
}

.surface_specific_locale .surface-devices-button{
    pointer-events: none !important;
}

/*.surface_specific_locale .surface-devices-button .c-button
{
    pointer-events: auto !important;
}*/


.compare_table_inner .c-subheading-5{
    display:block !important;
}
.surface-compare-active .compare_table_inner .c-subheading-5{
    display:none !important;
}

/*CTA color issue*/
@media only screen and (max-width: 1083px) {
.en-gb .surfacehome_colorful_impact-seqind #hero-slide-one a.c-call-to-action
{
color: #0067b8 !important;
}
}
@media only screen and (min-width: 1084px) {
/*.en-ca .surfacehome_colorful_impact-seqind .carousalthemedark.theme-light .c-sequence-indicator button[aria-selected=true]:before,*/
.fr-ca .surfacehome_colorful_impact-seqind .carousalthemedark.theme-light .c-sequence-indicator button[aria-selected=true]:before
{
background: #fff !important;
}
.fr-ca .surfacehome_colorful_impact-seqind .carousalthemedark.theme-light [aria-selected="true"][aria-controls="hero-slide-two"]:focus,
.en-ca .surfacehome_colorful_impact-seqind .carousalthemedark.theme-light [aria-selected="true"][aria-controls="hero-slide-two"]:focus
{
    outline: #fff dashed 1px !important;
}
}

/*compare page hyperlink font-weight*/

.surface-compare-banner .c-hyperlink {
    font-weight:normal;
}


.hero-slide-four .theme-dark a.mscom-link.mscom-link.c-call-to-action.c-glyph.surface-secondary-cta:focus
{ 
    outline: #fff dashed 2px !important;
}

.Surface_Home_Carousel_Hero_UT_Mac .hero-slide-three .theme-dark a.mscom-link.mscom-link.c-call-to-action.c-glyph.surface-secondary-cta:focus
{
outline: #fff dashed 2px !important;
}

 .surfacehome_colorful_impact-seqind .hero-slide-four div,
 .surfacehome_colorful_impact-seqind .hero-slide-four a 
{
color: #fff !important;
}

@media only screen and (min-width: 1084px)
{
.en-ca .surfacehome_colorful_impact-seqind .carousalthemedark.theme-dark .c-sequence-indicator button[aria-selected=true]:before,
.en-ca .surfacehome_colorful_impact-seqind .carousalthemedark.theme-dark .c-sequence-indicator button:before,
.en-ca .surfacehome_colorful_impact-seqind #hero-slide-one div,
.en-ca .surfacehome_colorful_impact-seqind #hero-slide-one a,
.en-ca .surfacehome_colorful_impact-seqind .carousalthemedark.theme-dark button.c-action-toggle,
.en-ca .surfacehome_colorful_impact-seqind .carousalthemedark.theme-dark button:focus,
.fr-ca .surfacehome_colorful_impact-seqind .carousalthemedark.theme-dark .c-sequence-indicator button[aria-selected=true]:before,
.fr-ca .surfacehome_colorful_impact-seqind .carousalthemedark.theme-dark .c-sequence-indicator button:before,
.fr-ca .surfacehome_colorful_impact-seqind #hero-slide-one div,
.fr-ca .surfacehome_colorful_impact-seqind #hero-slide-one a,
.fr-ca .surfacehome_colorful_impact-seqind .carousalthemedark.theme-dark button.c-action-toggle,
.fr-ca .surfacehome_colorful_impact-seqind .carousalthemedark.theme-dark button:focus{
color:#fff !important;
}
}

@media only screen and (max-width: 1083px)
{
    .en-ca .surfacehome_colorful_impact-seqind #hero-slide-one div,
    .fr-ca .surfacehome_colorful_impact-seqind #hero-slide-one div{
        color:#000 !important;
    }
    
    .en-ca .surfacehome_colorful_impact-seqind #hero-slide-one a,
    .fr-ca .surfacehome_colorful_impact-seqind #hero-slide-one a{
        color: #0067b8 !important;
    }
    
.hero-slide-four .theme-dark a.mscom-link.mscom-link.c-call-to-action.c-glyph.surface-secondary-cta:focus
{ 
    outline: #000 dashed 2px !important;
}

.Surface_Home_Carousel_Hero_UT_Mac .hero-slide-three .theme-dark a.mscom-link.mscom-link.c-call-to-action.c-glyph.surface-secondary-cta:focus
{
outline: #000 dashed 2px !important;
}
.surfacehome_colorful_impact-seqind .hero-slide-four div 
 {    
    color: #000 !important;    
}
.surfacehome_colorful_impact-seqind .hero-slide-four a 
 {
       color: #0067b8 !important;
 }
}

.wdg-global.surfacecom .surface-compare-deviceimgblock .compare_table_inner .surface-bg-cta-blue,
.wdg-global.surfacecom .surface-compare-deviceimgblock .compare_table_inner .surface-bg-cta-blue + .mscom-link.c-call-to-action{
    display: inline-block;
}



/*custom mosaic panel*/


.black-c {
color: #000 !important;
}
.theme-green {
color: #fff;
background-color: #107c10 !important;	
}
.theme-white {
color: #000;
background-color: rgba(255, 255, 255, 1);
}
.theme-lighter {
color: #000;
background-color: rgba(238, 238, 238, 1);
}
.theme-f2 {
color: #000;
background-color: #f2f2f2 !important;
}
.theme-2f {
color: #fff;
background-color: #2f2f2f !important;
}
.theme-black {
color: #fff;
background-color: #000 !important;
}
.white-c {
color: #fff !important;
}
/*.iconBlade {
.msame_Header_name.msame_TxtTrunc {
display: none !important;
}
.msame_Header.msame_Short.msame_3row {
height: 100%;
}
.msame_Header_picframe {
margin: 0 auto;
img {
width: 100% !important;
height: 100% !important;
max-width: 100%;
}
}

.msame_Header_piccont {
padding: 0px;
}
.msame_Header.msame_Short {
msame_3row {
height: 100%;
}
}
}*/
.iconBlade .msame_Header_name.msame_TxtTrunc {
display: none !important;
}
.iconBlade .msame_Header.msame_Short.msame_3row {
height: 100%;
}
.iconBlade .msame_Header_picframe {
margin: 0 auto;
}
.iconBlade .msame_Header_picframe img {
width: 100% !important;
height: 100% !important;
max-width: 100%;
}
.iconBlade .msame_Header_piccont {
padding: 0px;
}
.iconBlade .msame_Header.msame_Short msame_3row {
height: 100%;
}

.zoomImg {
transition: background-position 0s linear !important;
-webkit-transition: background-position 0s linear !important;
transition: background-size .2s linear !important;
-webkit-transition: background-size .2s linear !important;


}
@media screen and (-ms-high-contrast: active), (-ms-high-contrast: none) {
.zoomImg{
transition: none !important;
}
}

.hp-mosaic .c-heading-2 sup {
font-size: .4em;
top: -1.5em;
}
.hp-mosaic .m-content-placement-item a.c-call-to-action {
font-weight: 700;
}

.hp-mosaic .m-content-placement-item a.c-call-to-action.f-lightweight {
background: none !important;
padding-bottom: 4px;
color: #000;
}
/*
.hp-mosaic .m-content-placement-item a.c-call-to-action:hover, 
.hp-mosaic .m-content-placement-item a.c-call-to-action:focus:not(.x-hidden-focus) {
color: rgba(0,0,0,.8);
}*/

/*.hp-mosaic .m-content-placement-item a.c-call-to-action:focus:not(.x-hidden-focus) {
color: rgba(0,0,0,.8);
}*/

.hp-mosaic .copy a.c-call-to-action.f-lightweight {
color: rgba(0,0,0,.8);
}

/*.hp-mosaic .copy a.c-call-to-action:hover, .hp-mosaic .copy a.c-call-to-action:focus:not(.x-hidden-focus) {
color: rgba(0,0,0,.8);
}

.hp-mosaic .copy a.c-call-to-action:focus:not(.x-hidden-focus) {
color: rgba(0,0,0,.8);
}*/
/*.hp-mosaic {
padding: 4px;
}*/
.hp-mosaic li {
padding: 2px;
}

.hp-mosaic li .c-call-to-action {
margin-top: 16px;
}	
.hp-mosaic li .white-c.c-call-to-action:focus {
border: 1px solid #fff !important;
}
.hp-mosaic .c-image {
max-width: 100%;
}

.hp-mosaic li.fullTile {
width: 100%;
}
.hp-mosaic .m-image-intro.f-align-bottom > div {
left: 0px;
bottom: 6%;
-ms-transform: translateX(0%);
transform: translateX(0px);
padding-left: 3.5vw;
}

.double section {
margin-top: 0px;
}
/*.icons {
text-align: center;
margin: 28px 0 35px;
}
.icons a {
display: inline-block;
margin-right: 4vw;
}

.icons a:focus {
outline: 2px dashed;
}
.icons a:nth-child(6) {
margin-right: 0px;
}
.icons a p {
color: #107c10;
}
.icons a:hover p {
text-decoration: underline;
}*/


.home-hero .c-call-to-action {
margin-top: 16px;
}

.m-hero-item .m-ambient-video video {
width: 100% !important;
}

@media screen and (-ms-high-contrast: black-on-white) {    

.theme-dark .c-heading-2 {
background-color: #fff;
}

.theme-dark .c-paragraph-1 {
background-color: #fff;
}

.theme-dark a.c-call-to-action {
background-color: #fff;
}    
}
@media (min-width: 768px) and (max-width: 1083px) {

.home-hero section {
height: 110vw;
}


.home-hero .m-hero-item > div {
overflow: visible;
}
.home-hero .m-hero-item > div > div {
top: 130% !important;
-ms-transform: none;
transform: none;
max-width: 1083px;
width: 100%;
text-align: center;
left: 0;
right: 0;
}

.home-hero .m-hero-item.f-x-center.f-y-top > div > div {
top: 20% !important;
}
}

@media screen and (max-width: 1083px) {

.home-hero .vid {
display: none;
}

.home-hero .image {
display: block;
}


.home-hero .m-hero-item> div {
height: 54.5vw;
}


/*.hp-mosaic li.double .zoom {
height: 27.74vw;
}*/


.hp-mosaic li.msctL {
clear: both;
}

.hp-mosaic li.msctR {
clear: both;
}

.hp-mosaic li:active .c-call-to-action.white-c {
border: 1px solid #fff !important;
}

.fullTile .mobImg {
display: block;
max-width: 100%;
}

.fullTile .copy {
padding: 16px 12px;
    padding-top: 16px;
    padding-right: 12px;
    padding-bottom: 24px;
    padding-left: 0px;
   
}

.double .c-paragraph-1
{
    margin-top: 10px !important;
}
.double .doublecopyclassheight {
padding-bottom: 30px !important;
}


.double .doublecopyclassheight {
padding: 40px 3.0vw;
}
.hp-mosaic .zoomImg picture.c-image img {
    width: 100% !important;
}
/*.zoom {
display: none;
}*/
}
@media only screen and (max-width:767px) {

.home-hero .m-hero-item > div > div {
top: calc(30%) !important;
}
}

@media screen and (min-width: 1084px) {
   .home-hero .vid {
display: block;
}

.home-hero .image {
display: none;
}

.home-hero section {
height: 36.7vw;
}


.fullTile section {
/*height: 25.2vw;*/
background-size: cover;
margin: 2px 0;
bottom:0;
top:0;
}

/*.fullTile .mobImg {
display: none;
}*/

.fullTile .copy {
padding-right: 5%;
max-width: 440px;
float: right;
top: 120px;
top: calc(50%);
-ms-transform: translateY(-50%);
transform: translateY(-50%);
position: relative;
}
.hp-mosaic li {
position: relative;
top: 0px;
width: 50%;
}
.hp-mosaic li .c-call-to-action {
margin-top: 12px !important;
}
.hp-mosaic li.slide {
top: 150px;
}

.hp-mosaic li.double div section {
float: left;
width: 50%;
padding: 0 7%;
}
.hp-mosaic li.double .floatR {
float: right;
width: 50%;
height: 27.74vw;
}

.hp-mosaic li.double .floatL {
float: left;
width: 50%;
height: 27.74vw;
}

.hp-mosaic li.msctL {
float: left;
}

.hp-mosaic li.msctR {
float: right;
}
.hp-mosaic ul li .zoom{
    overflow: hidden;
}
.hp-mosaic ul li .zoom img{
background-size: 100% 100% !important;
background-repeat: no-repeat !important;
background-position: center center !important;
transition: all 500ms ease !important;
transition: transform .5s ease;
}


.hp-mosaic ul li .zoom:hover img {
/*background-size: 120% 120% !important;*/
/*transform: scale(1.2);*/
/*-ms-transform: scale(1.2);*/ /* IE 9 */
  /*-webkit-transform: scale(1.2);*/ /* Safari 3-8 */
}
.hp-mosaic{
    overflow: hidden;
}

@media screen and (-ms-high-contrast: active), (-ms-high-contrast: none) {
.hp-mosaic ul li .zoom:hover {
background-size: 100% 100% !important;
}

}

.hp-mosaic ul li .zoom:hover {
background-position: center center !important;
}
.hp-mosaic .c-heading-3 {
padding: 24px 0 2px;
}

.hp-mosaic.c-paragraph-1 {
padding: 16px 0 4px;
}

/*.icons img {
max-width: 100%;
}*/
.zoomImg {
width: 50%;
height: 27.74vw;
}

#zoomImg1,
#zoomImg7,
#zoomImg8 {
float: right;
}
 #zoomImg2 {
float: left;
}

.hp-mosaic_en-us #zoomImg2 {
float: right;
}

.double > div {
height: 27.74vw;
}

.double section {
position: relative;
top: calc(50%);
-ms-transform: translateY(-50%);
transform: translateY(-50%);
}

/*.double .c-image {
display: none;
}*/
}

@media screen and (min-width: 1800px) {

.home-hero .m-hero-item > div > div {
max-width: 630px;
}
.fullTile .copy {
max-width: 630px;
}

}

@media screen and (min-width: 768px) {

.iconBlade .msame_Header_picframe {
height: 57px !important;
width: 57px !important;
}
/*.icons div {
width: 72px;
height: 56px;
}*/

}

/*@media screen and (max-width: 539px) {
.icons {
width: 294px;
margin: 0 auto 31px;
}
.icons a {
margin-right: 9.8vw;
margin-top: 32px;
}
.icons a:nth-child(3) {
margin-right: 0px;
}
}*/
/*@media screen and (max-width: 767px) {
.icons {
margin-bottom: 31px;
}
}
*/
/*@media screen and (min-width: 0px) {

.icons img {
max-width: 90%;
}

.icons div {
width: 60px;
height: 40px;
}

}*/

@media screen and (min-width: 1400px) {

.fullTile .copy {
max-width: 520px;
}

}

@media screen and (min-width: 1921px) {
.hp-mosaic {
width: 1920px;
margin: 0 auto;
float: none;

}
.hp-mosaic .m-image-intro img {
/*height: 1222px;*/
width:100%;
}

/*.hp-mosaic .fullTile section {
height: 805px;
}*/

.hp-mosaic li.double .floatR {
height: 534px;
}

.hp-mosaic li.double .floatL {
height: 534px;
}

.double > div {
height: 534px;
}
.zoomImg {
height: 534px;
}
}

@media only screen and (min-width:1084px) {
    
.fullTile section{
position: absolute; 
  /*  bottom: 20px;*/ 
}
/*.hp-mosaic .surface-lg-center .f-align-bottom > div
{
 top: 56% !important;
    transform: translateY(-45%) !important;
}*/
}

@media only screen and (min-width:767px) and (max-width:1366px) { 
/*.hp-mosaic ul li .zoom img
{
    
    height: 100% !important;
}*/
}

@media only screen and (min-width:767px){
.hp-mosaic .msctR.double a.c-call-to-action{
    text-align: left !important;
}
}


.double h2
{
    margin-top: 11px !important;
}

.single h2
{
    padding-top: 15px !important;
}

.double .c-paragraph-1
{
    padding-bottom: 10px !important;
}

.single .c-subheading-2
{
    padding-bottom: 6px !important;
    padding-top: 20px !important;
} 

li.double div
{
background-color: #E5E5E5;
}

@media screen and (min-width: 1921px)
{
.SurfaceHome_HL_HighlightFeature_Panel_19_PT {
    width: 1920px;
    margin: auto;
    float: none;
  /*  padding-top: 4px;*/
}
}
 @media only screen and (min-width:540px) and (max-width:1083px) {
        .fullTile .copy .c-heading-2
        {
            padding-top:10px !important;
        }
        .hp-mosaic li.double .c-call-to-action
        {
            margin-top: 6px !important;
        }
        .hp-mosaic  .c-badge.f-highlight {
        margin-bottom: 0px !important;
    }
            .hp-mosaic .single .c-subheading-2
        {
            margin-top: 18px !important;
            padding-top: 4px !important;
        }
        .hp-mosaic .single .c-call-to-action {
            margin-top: 12px !important;
        }
 }
 
 @media only screen and (min-width:1083px) and (max-width:1366px) { 
     
    .hp-mosaic .m-image-intro.f-align-bottom > div {
bottom: 8% !important;
}
 }
 
 @media (min-width: 540px) and (max-width: 1083px) {
     .fullTile .copy
     {
         margin-top: 32px;
     }
        .fullTile .copy .c-heading-2
     {
        margin-bottom: 10px;
     }
         
     .fullTile .copy
    {
        padding-left: 3.5vw;
    }
     .hp-mosaic .m-image-intro.f-align-bottom > div {
bottom: 84px !important;
}

.single h2.c-heading-2 {
    padding-top: 0px !important;
}

.double h2
{
    margin-top: 0px !important;
}
.double .c-paragraph-1
{
        margin-top:12px !important;
}
 }
 
 @media only screen and (min-width:768px) and (max-width:1083px) 
{
        .SurfaceHome_HL_HighlightFeature_Panel_19_PT
    {
        margin-top: 4px;
        display: block;
        
    }
    
    .hp-mosaic li
    {
        padding: 4px !important;
    }
/*.surface-highlightFeature.SurfaceHome_HL_HighlightFeature_Panel_19_PT .m-highlight-feature>div{
    padding-left: 24px ;
    	padding-right: 24px ;
    	position: absolute ;
    	margin: 0 36px ;
    	width: 316px ;
	   transform: translateY(-50%) ;
    	background: #FFF ;
    	color: #000 ;
    	box-shadow: 0 6px 6px rgba(0,0,0,.1) ;
}*/
}


 @media only screen and (max-width:539px) 
{
    .wdg-global .hp-mosaic .single .c-call-to-action:focus:not(.x-hidden-focus):not(.wdg-f-blue-button) {
    outline: #000 dashed 2px !important;
}
    .single .c-subheading-2
{
    padding-bottom: 12px !important;
    padding-top: 20px !important;
} 

    .hp-mosaic .single .m-image-intro.f-align-bottom > div
{
text-align: center !important;
}
li.double div
{
    text-align: center !important;
}

.fullTile .copy {
    text-align: center !important;
}

.hp-mosaic .single .m-image-intro.f-align-bottom > div
{
padding-bottom:56px !important;
}
li.double div .c-paragraph-1
{
    padding-top: 14px !important;
        margin-top: 0px !important; 
    
}
.double .doublecopyclassheight
{
     padding-top: 28px !important;
}
 .hp-mosaic li
    {
        padding: 0px !important;
    }
}

@media only screen and (min-width:1083px) and (max-width:1300px) 
{
    .double .c-paragraph-1
{
    font-size: 17px;
    line-height: 20px;
}

.hp-mosaic .c-heading-3
{
       font-size: 24px;
    line-height: 30px;
}
    
}
 .hp-mosaic .single .theme-dark .c-call-to-action:focus:not(.x-hidden-focus):not(.wdg-f-blue-button)
{
    background: none;
    
}

@media screen and (min-width: 540px) {
   
   .hp-mosaic 
   {
        padding-left:  8px;
        padding-right: 8px;
   }
}

.wdg-m-prefooter.prefooter-9-links
{
    clear:both;
}

@media only screen and (max-width:767px) {
.SurfaceHome_HL_HighlightFeature_Panel_19_PT .hmc-display-below-1083
{
padding-top:36px !important;
padding-bottom:36px !important;

}
}

@media only screen and (min-width: 1084px)
{
    .SurfaceHome_HL_HighlightFeature_Panel_19_PT .m-highlight-feature
{
    padding-left: 10px !important;
    padding-right: 10px !important;
}
.hp-mosaic li .c-badge.f-highlight
{
margin-bottom: 0px !important;
}
    .hp-mosaic li.single h2 {
    padding-top: 0px !important;
    }
    
    .hp-mosaic li h2.c-heading-2  
    {
        margin-top: 0px !important;
        
    }
    .hp-mosaic li.double .zoom.zoomImg
{
    float: right !important;
    
}

.hp-mosaic .m-image-intro.f-align-bottom > div 
{
bottom: 40px !important;
}
.hp-mosaic li div.c-subheading-2
{
    padding-top: 7px !important;
    padding-bottom:11px !important;
 }

.hp-mosaic li .c-call-to-action
{
    margin-top: 3px !important;
}
}


@media only screen and (min-width:540px) and (max-width:1083px) 
{
.hp-mosaic li.double div.c-subheading-2 
{
padding-top: 18px !important;
}
.hp-mosaic li.fullTile div.c-subheading-2
{
padding-top: 11px !important;
}
.hp-mosaic li.fullTile .c-call-to-action {
    margin-top: 5px;
}
}
@media only screen and (min-width:00px) and (max-width:539px) 
{
  
        
    .hp-mosaic li .c-badge:empty+[class*='c-heading-2'] {
    padding-top: 28px !important;
}

.hp-mosaic li .c-badge:empty+[class*='c-heading-2'] {
    padding-top: 28px !important;
}





   .hp-mosaic li.double h2, .hp-mosaic li.single h2 {
    padding-top: 2px !important;
}

.hp-mosaic li div.c-subheading-2 
{
 padding-top: 10px !important;
 padding-bottom: 12px !important;
}


.hp-mosaic li .c-badge
{
    margin-top: 24px !important;
}

.hp-mosaic li .c-badge.f-highlight {
    margin-bottom: 0px !important;
}
.hp-mosaic li .c-call-to-action {
    margin-top:10px !important;
}

li.fullTile .c-badge
{
    margin-top: 10px !important;
}
}



.surface-compare-stickybar11 .c-price-hide .m-content-placement-item .c-price
{
display:inline;
}


@media only screen and (max-width: 539px)
{
/*li.double div {
    background-color: #fff !important;;
}
*/

.hp-mosaic li .supBLink
{
color: #0067B8 !important;
}

.fullTile section
{
background-color:#E5E5E5 !important;
color: #000;
}


.hp-mosaic .single .m-image-intro.f-align-bottom > div
{
background-color:#E5E5E5 !important;
color: #000;

}
}

.hp-mosaic li .c-call-to-action
{
text-align: left !important;
margin-right: 0px !important;
}

.hp-mosaic .single .m-image-intro
{
color:#000 !important;
}

.hp-mosaic .single a.c-hyperlink.supBLink,
.hp-mosaic .double a.c-hyperlink.supBLink
{
color: #0067B8 !important;
}
.wdg-m-prefooter
{
    clear:both !important;
    
}


@media only screen and (min-width:1083px) and (max-width:1250px) {
   /* .hp-mosaic li.double div section
    {
        
        padding: 0 1.5vw !important; 
    }*/
    .surface-highlightFeature.SurfaceHome_HL_HighlightFeature_Panel_19_PT .m-highlight-feature div .c-heading-3
    {
                    font-size: 22px !important;    
                    line-height: 30px !important;    
    }
   .hp-mosaic li.double h2.c-heading-2
   {     
        font-size:30px !important;   
   }
 
  .hp-mosaic li.double .c-subheading-2
  {
        font-size:17px !important; 
  }
    }
    
/*    .hp-mosaic li div.c-subheading-2
{
    font-size: 20px !important;
}*/



.surface-remove-top .c-paragraph-2.block_imp a
{
font-weight: 400;
}


.surface-compare-stickybar11 .m-content-placement-item .c-badge:empty
{
   display:block !important; 
}

/*@media only screen and (max-width: 1087px)
{*/
.surface-compare-stickybar11.surface-compare-stickybar.surface-compare-stickybar-locale .m-content-placement-item .c-badge:empty+[class*='c-heading']

{
margin-top: 16px !important;
    margin-bottom: 4px !important;
}
/*}*/

@media only screen and (min-width:767px) and (max-width:795px) 
{
     .wdg-global .m-content-placement-item .c-heading-4
     {
         padding-right: 8px !important;
     }
}


@media only screen and (min-width:1084px) and (max-width:1230px) 
{
.hp-mosaic .single .m-image-intro.f-align-bottom > div {

bottom: 10px !important;
}
}

@media only screen and (min-width:540px) and (max-width:1083px) 
{
.hp-mosaic .single .m-image-intro.f-align-bottom > div {

bottom: 15px !important;
}
}
/*.hp-mosaic
{
    pointer-events: none !important;
}
.hp-mosaic a.surface-secondary-cta:not([href="#"]),.hp-mosaic a.surface-secondary-cta:not([href]),
.hp-mosaic sup a {
   pointer-events: auto !important; 
}
*/
/*.en-us .surface-highlightFeature.SurfaceHome_HL_HighlightFeature_Panel_19_PT
{
    padding-top: 28px !important;
}*/

@media only screen and (max-width:1083px) {
    .en-us .nfl-feature-video .m-feature.f-image-priority>section.c-video-one-player.wdg-oneplayer-inline,
    .en-ca .nfl-feature-video .m-feature.f-image-priority>section.c-video-one-player.wdg-oneplayer-inline,
    .fr-ca .nfl-feature-video .m-feature.f-image-priority>section.c-video-one-player.wdg-oneplayer-inline{
        
        display: inline-block;
    margin: 0;
    width: 100%;
    min-width: 320px;
    direction: ltr;
    padding-bottom: 56.25%;
    position: relative;
    overflow: hidden;
    height: 0;
    }
}

 
 @media only screen and (min-width:1083px) {
     .en-us .nfl-feature-video .m-feature.f-align-left.f-image-priority>section.c-video-one-player.wdg-oneplayer-inline,
 .en-ca .nfl-feature-video .m-feature.f-align-left.f-image-priority>section.c-video-one-player.wdg-oneplayer-inline,
 .fr-ca .nfl-feature-video .m-feature.f-align-left.f-image-priority>section.c-video-one-player.wdg-oneplayer-inline
    { float: right;}
 }
 
 
 /*start multi hero*/
 /*home multi hero*/
/*home multi hero*/
/*.m-multi-hero-item__content.m-multi-hero-item__content_left a.c-call-to-action.c-glyph.surface-secondary-cta{
   color:#fff !important;  
}*/

.Surface_Home_Multi_Hero_HL .m-multi-hero-item__content.m-multi-hero-item__content_top a.c-call-to-action.c-glyph.surface-secondary-cta:active,
.Surface_Home_Multi_Hero_HL .m-multi-hero-item__content.m-multi-hero-item__content_top a.c-call-to-action.c-glyph.surface-secondary-cta:focus,
.Surface_Home_Multi_Hero_HL .m-multi-hero-item__content.m-multi-hero-item__content_top a.c-call-to-action.c-glyph.surface-secondary-cta:hover,
.Surface_Home_Multi_Hero_HL .m-multi-hero-item__content.m-multi-hero-item__content_bottom a.c-call-to-action.c-glyph.surface-secondary-cta:active,
.Surface_Home_Multi_Hero_HL .m-multi-hero-item__content.m-multi-hero-item__content_bottom a.c-call-to-action.c-glyph.surface-secondary-cta:focus,
.Surface_Home_Multi_Hero_HL .m-multi-hero-item__content.m-multi-hero-item__content_bottom a.c-call-to-action.c-glyph.surface-secondary-cta:hover
{
background: none;
}
.Surface_Home_Multi_Hero_HL .c-sequence-indicator
{
 padding-right: 5px;   
}
@media only screen and (min-width: 1084px)
{
.Surface_Home_Multi_Hero_HL .m-multi-hero-item__content.m-multi-hero-item__content_left{
   /* color:#fff;*/
      text-align: left !important;
}
.Surface_Home_Multi_Hero_HL .m-multi-hero-item__content-wrapper.m-multi-hero-item__content-wrapper_left{
      text-align: left !important;
    top: calc(50%);
    transform: translateY(-22%);
    padding-left: 24px;
    padding-right: 24px;
}



.Surface_Home_Multi_Hero_HL .m-multi-hero .c-carousel ul li .m-multi-hero-item div div.m-multi-hero-item__content_top, 
.Surface_Home_Multi_Hero_HL .m-multi-hero .c-carousel ul li .m-multi-hero-item div div.m-multi-hero-item__content_bottom

{    
    margin-left: 0px !important;
    margin-right: 0px !important;
    padding-right: 0px !important;
    padding-left: 0px !important; 
}

.Surface_Home_Multi_Hero_HL .m-multi-hero .c-carousel ul li .m-multi-hero-item .m-multi-hero-item__content-wrapper_top,
.Surface_Home_Multi_Hero_HL .m-multi-hero .c-carousel ul li .m-multi-hero-item .m-multi-hero-item__content-wrapper_bottom
{    
    bottom: 0px;
}
}

.Surface_Home_Multi_Hero_HL .m-multi-hero li
{
pointer-events: none;
}
.Surface_Home_Multi_Hero_HL .m-multi-hero li a
{
pointer-events: auto;
}

@media only screen and (max-width: 1083px)
{
    
   .Surface_Home_Multi_Hero_HL .m-multi-hero-item>div
    {
        
           position: relative !important;
    padding-top: 30px !important;
    }
.Surface_Home_Multi_Hero_HL .m-multi-hero li a
{
    padding-left: 10px !important;
    padding-right:10px !important;
}
}

@media only screen and (max-width: 767px)
{
.Surface_Home_Multi_Hero_HL .m-multi-hero-item .c-subheading {
   display:block;
}
}

.Surface_Home_Multi_Hero_HL .m-multi-hero-item .c-heading-4 {
   font-weight: 400;
}

/*.Surface_Home_Multi_Hero_HL .m-multi-hero-item .c-subheading {
    font-weight: 200;
}*/


@media only screen and (min-width: 1083px)
{
    
     .Surface_Home_Multi_Hero_HL .m-multi-hero-item .c-sheading-5
    {
        padding-top: 43px !important;
    }
    .Surface_Home_Multi_Hero_HL .m-multi-hero-item .c-subheading-5
    {
        padding-top: 12px !important;
    }
    
    .Surface_Home_Multi_Hero_HL .m-multi-hero-item .surface-bg-cta-blue
    {
        padding-bottom: 5px !important;
        padding-top:  5px !important;
        margin-top: 25px !important;
    }
    
   .Surface_Home_Multi_Hero_HL .m-multi-hero .c-carousel ul li .m-multi-hero-item .m-multi-hero-item__content-wrapper_top a,
.Surface_Home_Multi_Hero_HL .m-multi-hero .c-carousel ul li .m-multi-hero-item .m-multi-hero-item__content-wrapper_bottom a
{
    padding-top:  13px !important;
}

    
}

@media only screen and (min-width:1084px) and (max-width:1215px) 
{
     .en-us .Surface_Home_Multi_Hero_HL .m-multi-hero .c-carousel ul li .m-multi-hero-item .m-multi-hero-item__content-wrapper_top a,
.en-us .Surface_Home_Multi_Hero_HL .m-multi-hero .c-carousel ul li .m-multi-hero-item .m-multi-hero-item__content-wrapper_bottom a
{
    padding-top:  0px !important;
}
.en-us .Surface_Home_Multi_Hero_HL .m-multi-hero .c-carousel ul li .m-multi-hero-item .m-multi-hero-item__content-wrapper_top h2,
.en-us .Surface_Home_Multi_Hero_HL .m-multi-hero .c-carousel ul li .m-multi-hero-item .m-multi-hero-item__content-wrapper_bottom h2
{
    padding-bottom:  0px !important;
}
}

@media only screen and (min-width:1084px) and (max-width:1700px) 
{
.fr-ca .Surface_Home_Multi_Hero_HL .m-multi-hero .c-carousel ul li .m-multi-hero-item div div.m-multi-hero-item__content_top h2,
 .fr-ca .Surface_Home_Multi_Hero_HL .m-multi-hero .c-carousel ul li .m-multi-hero-item div div.m-multi-hero-item__content_bottom h2,
 .en-ca .Surface_Home_Multi_Hero_HL .m-multi-hero .c-carousel ul li .m-multi-hero-item div div.m-multi-hero-item__content_top h2,
 .en-ca .Surface_Home_Multi_Hero_HL .m-multi-hero .c-carousel ul li .m-multi-hero-item div div.m-multi-hero-item__content_bottom h2
{
padding-top: 0px !important;
    padding-bottom: 0px !important;
word-break: break-all ;
}
.en-ca .Surface_Home_Multi_Hero_HL .m-multi-hero .c-carousel ul li .m-multi-hero-item div div.m-multi-hero-item__content_top h2,
 .en-ca .Surface_Home_Multi_Hero_HL .m-multi-hero .c-carousel ul li .m-multi-hero-item div div.m-multi-hero-item__content_bottom h2
{word-break: normal !important;
}
 .Surface_Home_Multi_Hero_HL .m-multi-hero .c-carousel ul li .m-multi-hero-item .m-multi-hero-item__content-wrapper_top,
.Surface_Home_Multi_Hero_HL .m-multi-hero .c-carousel ul li .m-multi-hero-item .m-multi-hero-item__content-wrapper_bottom

{
    padding-left: 0px !important;
    padding-right: 0px !important;
    bottom: -13px !important;
}

.fr-ca .Surface_Home_Multi_Hero_HL .m-multi-hero .c-carousel ul li .m-multi-hero-item div div.m-multi-hero-item__content_top a,
 .fr-ca .Surface_Home_Multi_Hero_HL .m-multi-hero .c-carousel ul li .m-multi-hero-item div div.m-multi-hero-item__content_bottom a,
 .en-ca .Surface_Home_Multi_Hero_HL .m-multi-hero .c-carousel ul li .m-multi-hero-item div div.m-multi-hero-item__content_top a,
 .en-ca .Surface_Home_Multi_Hero_HL .m-multi-hero .c-carousel ul li .m-multi-hero-item div div.m-multi-hero-item__content_bottom a
{
padding-top: 0px !important;	
}
.en-ca .Surface_Home_Multi_Hero_HL .m-multi-hero .c-carousel ul li .m-multi-hero-item .m-multi-hero-item__content-wrapper_bottom h2,
.en-ca .Surface_Home_Multi_Hero_HL .m-multi-hero .c-carousel ul li .m-multi-hero-item div div.m-multi-hero-item__content_top h2
{
    font-size: 15px !important;
}
.fr-ca .Surface_Home_Multi_Hero_HL .m-multi-hero .c-carousel ul li .m-multi-hero-item .m-multi-hero-item__content-wrapper_bottom h2,
.fr-ca .Surface_Home_Multi_Hero_HL .m-multi-hero .c-carousel ul li .m-multi-hero-item div div.m-multi-hero-item__content_top h2
{
    font-size: 15px !important;
}
}


@media only screen and (max-width: 539px)
{

 .Surface_Home_Multi_Hero_HL .m-multi-hero .c-carousel ul li .m-multi-hero-item .m-multi-hero-item__content-wrapper_bottom a,
.Surface_Home_Multi_Hero_HL .m-multi-hero .c-carousel ul li .m-multi-hero-item div div.m-multi-hero-item__content_top a
{
    
    padding-top:0px; 
}
.Surface_Home_Multi_Hero_HL .m-multi-hero .c-carousel ul li .m-multi-hero-item .m-multi-hero-item__content_left a.surface-bg-cta-blue
{
    
    margin-top: 9px;
}
/*.Surface_Home_Multi_Hero_HL .c-carousel .c-sequence-indicator
{
    bottom: 32px !important;
}*/


}
/*BUG : 97126 Wounder*/
.en-us .Surface_Home_Multi_Hero_HL #lightMutliHeroSlideOne a.mscom-link.mscom-link.c-call-to-action.c-glyph.surface-secondary-cta.surface-bg-cta-blue:focus,
.en-ca .Surface_Home_Multi_Hero_HL #lightMutliHeroSlideOne a.mscom-link.mscom-link.c-call-to-action.c-glyph.surface-bg-cta-blue:focus,
.fr-ca .Surface_Home_Multi_Hero_HL #lightMutliHeroSlideOne a.mscom-link.mscom-link.c-call-to-action.c-glyph.surface-bg-cta-blue:focus {
    background: #0067b8 !important;
}

.en-us .Surface_Home_Multi_Hero_HL #lightMutliHeroSlideOne a.c-call-to-action.c-glyph.surface-bg-cta-blue,
.en-ca .Surface_Home_Multi_Hero_HL #lightMutliHeroSlideOne a.c-call-to-action.c-glyph.surface-bg-cta-blue,
.fr-ca .Surface_Home_Multi_Hero_HL #lightMutliHeroSlideOne a.c-call-to-action.c-glyph.surface-bg-cta-blue
{
    padding-top: 11px !important;
}
/*CSS for– Increase the padding top of copy block to 60px reduce to 6 to improve mobile view port */


@media only screen and (max-width: 540px)
{
.en-us .Surface_Home_Multi_Hero_HL #lightMutliHeroSlideOne .m-multi-hero-item__content.m-multi-hero-item__content_left .c-subheading-5,
.en-ca .Surface_Home_Multi_Hero_HL #lightMutliHeroSlideOne .m-multi-hero-item__content.m-multi-hero-item__content_left .c-subheading-5,
.fr-ca .Surface_Home_Multi_Hero_HL #lightMutliHeroSlideOne .m-multi-hero-item__content.m-multi-hero-item__content_left .c-subheading-5
{

	padding-bottom: 12px !important;
    padding-top: 8px !important;
}
}
/*wave 2*/ 
 /*.en-th .hp-mosaic .fullTile,
 .th-th .hp-mosaic .fullTile,
 .en-my .hp-mosaic .fullTile,
 .ms-my .hp-mosaic .fullTile,
 .ko-kr .hp-mosaic .fullTile,
 .en-in .hp-mosaic .fullTile
{
display:none;
}*/



.hp-mosaic sup.surface-superscript-enable a{
    
    pointer-events: auto !important;
}

.Surface_LFS_Generic_ContentPlacement_3UP_ca .m-content-placement-item a
{
    margin-right: 15px;
}



.en-us .Surface_Home_Carousel_Hero_EN-US_ATL_20 a.dark-theme-cta.c-call-to-action:focus:not(.x-hidden-focus):not(.wdg-f-blue-button)
{
     outline: #fff dashed 2px !important;
}



/*LinkNavigation-Quick Link icons*/
@media only screen and (max-width: 767px) {  
.surface-link-nav .c-link-navigation {
    width: 50% !important;
    margin: 0% auto !important;
    margin-top: 30px !important;
    display: block !important;
}

.surface-link-nav .c-link-navigation ul li{
    margin-bottom: 0px !important;
    max-width: none !important;
}
}
@media only screen and (min-width: 768px) {  
.surface-link-nav .c-link-navigation ul {
	display: flex;
	flex-direction: row;
	flex-wrap: wrap;
	justify-content: space-evenly;
	max-width: 1024px;
	margin: 0 auto;
}

.surface-link-nav .c-link-navigation ul li {
	text-align: center;
	padding-top: 0 !important;
    margin-top: 20px;
}

.surface-link-nav .c-link-navigation ul li picture {
	top: 0;
	left: 50% !important;
	transform: translateX(-50%);
}

.surface-link-nav .c-link-navigation ul li img {
	position: relative;
	width: 40px;
	height: 31px;
	margin-top: 0 !important;
}

#mainContent .surface-link-nav .c-link-navigation ul li a.c-hyperlink {
	padding-left: 0;
	margin: 0 !important;
	text-decoration: none !important;
	position: relative;
	padding-top: 40px;
    display: block;
}

.wdg-global.surfacecom section.surface-home-offercarousel.SurfaceHome_OfferCarousel_VFO.padding-bottom-carosuel.surface-home-offercarousel-auto {
margin-top: 54px !important;
}

.ar-ae.rtl .surface-link-nav .c-link-navigation ul li a,
.ar-qa.rtl .surface-link-nav .c-link-navigation ul li a,
.ar-sa.rtl .surface-link-nav .c-link-navigation ul li a
{    
    top: 0;
    left: 68% !important;
    transform: translateX(-50%);
}
}

/*@media (max-width: 767px) {
	.surface-link-nav .c-link-navigation {
		width: 70% !important;
		margin: 30px auto !important;
	}
	.surface-link-nav .c-link-navigation ul li {
		flex: 1 1 50%;
		margin-bottom: 25px;
		max-width: 42%;
	}
	.surface-link-nav .c-link-navigation ul li:last-child {
		flex-basis: 100%;
		margin-bottom: 0;
		max-width: 100%;
	}
}*/

/*@media (max-width: 500px) {
	.surface-link-nav .c-link-navigation {
		width: 100% !important;
	}
}*/

@media (min-width: 1084px) {
	.surface-link-nav .c-link-navigation {
		margin-top: 20px !important;
	}
}

@media only screen and (min-width:768px) and (max-width:876px) 
{
   .de-de .surface-link-nav li:last-child,
   .es-es .surface-link-nav li:last-child,
   .fr-fr .surface-link-nav li:last-child,
   .it-it .surface-link-nav li:last-child,
   .nl-nl .surface-link-nav li:last-child
   {
   margin-left: 1.5%;
}
}

@media only screen and (min-width: 768px) {  
.IE11 .surface-link-nav .c-link-navigation ul,
.Edge .surface-link-nav .c-link-navigation ul{
    justify-content: space-around;
    }
}


.en-ca .wdg-global .Surface_Home_Carousel_Hero_UT  .wdg-theme-dark-banner.theme-dark .c-call-to-action.surface-secondary-cta:focus,
.en-ie .wdg-global .Surface_Home_Carousel_Hero_UT  .wdg-theme-dark-banner.theme-dark .c-call-to-action.surface-secondary-cta:focus,
.en-gb .wdg-global .Surface_Home_Carousel_Hero_UT  .wdg-theme-dark-banner.theme-dark .c-call-to-action.surface-secondary-cta:focus,
.en-au .wdg-global .Surface_Home_Carousel_Hero_UT  .wdg-theme-dark-banner.theme-dark .c-call-to-action.surface-secondary-cta:focus,
.en-us .wdg-global .Surface_Home_Carousel_Hero_UT  .wdg-theme-dark-banner.theme-dark .c-call-to-action.surface-secondary-cta:focus
{
outline: #fff dashed 2px !important;
}


/*Compare changes for Spring launch*/

.compare-load .c-progress {
    position: fixed;
    left: 50%;
    top: 50%;
    transform: translate(-50%);
    z-index: 10;
}
/*Compare CSS fr-ca*/
@media only screen and (min-width: 768px) and (max-width: 960px){
   .fr-ca .m-content-placement.surface-remove-cta-bg-v2 .compare_table .c-call-to-action.surface-bg-cta-blue,
   .fr-ca .m-content-placement.surface-remove-cta-bg-v2 .m-content-placement-item .c-call-to-action.surface-bg-cta-blue {
        color: #fff; 
        background : #0067b8;
        padding : 9px 22px 6px 22px;
    }
  }
 
/*Spring launch - Home*/
@media screen and (min-width: 1084px)
{
.hp-mosaic li.fullTile.fullTile-2 .copy
{
float: left;
padding-left: 5%;
}

.hp-mosaic li.fullTile.fullTile-2 .copy
{
background-color:#E5E5E5 !important;
color: #000;
}
}

/*home page tablet issue for arabic markets*/

  @media only screen and (max-width:1083px) {  
.rtl .hp-mosaic .m-image-intro.f-align-bottom>div

{
    right: 0 !important;
    transform: translateX(0) !important;
    padding-right: 3.5vw !important;

}
  }
  
  /*home page single tile issue in 1084 and 1400 px */
 /*@media only screen and (max-width:1084px) {  
  .fr-ch .hp-mosaic .single
  {
      opacity: 1;
      visibility: visible;
      top: 9px !important;
  }
 }*/
 
 /* for pro x image truncation
 @media only screen and (max-width: 1400px) and (min-width: 1084px)
{
.hp-mosaic .single .m-image-intro.f-align-bottom>div 
{
    bottom: 0px !important;

}
}
*/

/*home page right double tile issue for 1084 VP for RDA*/
 @media only screen and (min-width: 1084px) and (max-width: 1400px)
{
    .hp-mosaic .double.msctRDoubleDAR .c-heading-2
    {
        font-size: 29px !important;
    }
}

/*home page right single tile issue for 1084 to 1300 VP for G2*/
 @media only screen and (min-width: 1084px) and (max-width: 1300px)
{
    .hp-mosaic .single.msctRSingleD1 .m-image-intro.f-align-bottom .x-type-left
    {
        bottom: 0px !important;
    }
}

/*home page right single tile issue for 1084 to 1920 VP for G2*/
 @media only screen and (min-width: 1084px) and (max-width: 1920px)
{
    .es-mx .hp-mosaic .single.msctRSingleD1 .m-image-intro.f-align-bottom .x-type-left
    {
        bottom: 0px !important;
    }
}

/*Laptop white CTA for platinum and black markets in home page*/
.hp-mosaic .single .x-type-left.surface-WhiteCTAL3{
    color: #ffffff !important;
}
.hp-mosaic .single .x-type-left.surface-WhiteCTAL3 a.c-call-to-action.c-glyph.surface-secondary-cta{
    color: #ffffff !important;
}
.wdg-global .hp-mosaic .single .x-type-left.surface-WhiteCTAL3 a.c-call-to-action.c-glyph.surface-secondary-cta:focus{
    outline: #ffffff dashed 2px !important;
}

/*.en-za .hp-mosaic .single .x-type-left.surface-WhiteCTAL3,
.en-za  .hp-mosaic .single .x-type-left.surface-WhiteCTAL3 a.c-call-to-action.c-glyph.surface-secondary-cta{
    color: #ffffff !important;
}*/

/*.en-us .surface-highlightFeature.SurfaceHome_HL_HighlightFeature_Panel_19_PT,*/
.en-ca .surface-highlightFeature.SurfaceHome_HL_HighlightFeature_Panel_19_PT,
.fr-ca  .surface-highlightFeature.SurfaceHome_HL_HighlightFeature_Panel_19_PT,
.zh-cn .surface-highlightFeature.SurfaceHome_HL_HighlightFeature_Panel_19_PT,
.de-de .surface-highlightFeature.SurfaceHome_HL_HighlightFeature_Panel_19_PT,
.en-au .surface-highlightFeature.SurfaceHome_HL_HighlightFeature_Panel_19_PT,
.en-gb .surface-highlightFeature.SurfaceHome_HL_HighlightFeature_Panel_19_PT,
.es-es .surface-highlightFeature.SurfaceHome_HL_HighlightFeature_Panel_19_PT,
.fr-fr .surface-highlightFeature.SurfaceHome_HL_HighlightFeature_Panel_19_PT,
.it-it .surface-highlightFeature.SurfaceHome_HL_HighlightFeature_Panel_19_PT,
.ja-jp .surface-highlightFeature.SurfaceHome_HL_HighlightFeature_Panel_19_PT,
.nl-nl .surface-highlightFeature.SurfaceHome_HL_HighlightFeature_Panel_19_PT,
.en-sg .surface-highlightFeature.SurfaceHome_HL_HighlightFeature_Panel_19_PT
{
padding-top: 2px !important;
}
    
    
@media only screen and (max-width: 539px){
.hp-mosaic .single .x-type-left.surface-WhiteCTAL3
{
color: #000000 !important;
}

.hp-mosaic .single .x-type-left.surface-WhiteCTAL3 a.c-call-to-action.c-glyph.surface-secondary-cta{
    color: #0067b8 !important;
}

}
/*es-mx and en-za disabled CTA in 539 VP below*/
@media only screen and (max-width: 539px)
{
.es-mx .hp-mosaic .single .x-type-left.surface-WhiteCTAL3 a.c-call-to-action.c-glyph.surface-secondary-cta.surface-disabled-cta,
.en-za .hp-mosaic .single .x-type-left.surface-WhiteCTAL3 a.c-call-to-action.c-glyph.surface-secondary-cta.surface-disabled-cta
{
    text-decoration: none!important;
    color: rgba(0,0,0,.6)!important;
    background-color: transparent!important;
}
}

 @media only screen and (min-width: 1084px) and (max-width: 1300px)
{
    .hp-mosaic .single.msctRSingleD1 .m-image-intro.f-align-bottom .x-type-left
    {
        bottom: 0px !important;
    }
}

 @media only screen and (min-width: 540px) and (max-width: 630px)
{
.hp-mosaic .msctRSingleD1 .m-image-intro.f-align-bottom>div
{
padding-bottom:0px !important;
padding-top:0px !important;
bottom:0px !important;
}
}


@media only screen and (min-width:1083px) and (max-width:1300px) 
{
.hp-mosaic .msctRSingleD1 .m-image-intro.f-align-bottom>div
{
    bottom: 10px !important;
    padding-bottom: 0px !important;
    padding-top:0px !important;
}
}

@media only screen and (min-width:539px) and (max-width:577px) 
{
.hp-mosaic .msctRSingleD1 .m-image-intro.f-align-bottom > div .c-heading-2

{
font-size: 28px !important;
    line-height: 30px !important;

}
.hp-mosaic .msctRSingleD1 .m-image-intro.f-align-bottom > div .c-subheading-2
{
    margin-top: 4px !important;
}
}

/*pro 7 truncation issue in es-mx for home page*/

 @media only screen and (min-width: 1084px) and (max-width: 1120px)
{
    .es-mx .hp-mosaic .single.msctRSinglePro7 .m-image-intro.f-align-bottom .x-type-left
    {
        bottom: 0px !important;
    }
}

@media only screen and (min-width:1083px) and (max-width:1100px) 
{
.hp-mosaic .double.msctRDoubleDAR .c-heading-2
{
line-height:34px !important;
}


.hp-mosaic .msctR.double a.c-call-to-action
{
padding-top: 5px !important;
}

}

.wdg-global .Surface_Home_Carousel_Hero_EN-US_20_1 .wdg-theme-light-banner.theme-light .c-call-to-action:focus:not(.x-hidden-focus):not(.wdg-f-blue-button)
{
    outline: #000 dashed 2px !important; 
}

.wdg-global .Surface_Home_Carousel_Hero_EN-US_20_1 .wdg-theme-dark-banner.theme-dark .c-call-to-action:focus:not(.x-hidden-focus):not(.wdg-f-blue-button)
{
    outline: #fff dashed 2px !important; 
}
/*Singapore for 103476 emwa Links*/
.en-sg .wdg-global .c-group a.mscom-link.c-call-to-action.surface-emwa-cta.surface-bg-cta-blue.c-glyph {
padding-left: 22px;
}


/*************************************  Start -  Chevron Issue Fix ***************************************/
  .Chrome .compare-load a.c-call-to-action:not(.glyph-play) > span:after, 
  .Firefox .compare-load a.c-call-to-action:not(.glyph-play) > span:after, 
  .Safari .compare-load a.c-call-to-action:not(.glyph-play) > span:after, 
  .Chrome .compare-design-en-us a.c-call-to-action:not(.glyph-play) > span:after, 
  .Firefox .compare-design-en-us a.c-call-to-action:not(.glyph-play) > span:after, 
  .Safari .compare-design-en-us a.c-call-to-action:not(.glyph-play) > span:after,
  .Safari .surface-home a.c-call-to-action:not(.glyph-play) > span:after,
  .Firefox .surface-home a.c-call-to-action:not(.glyph-play) > span:after,
  .Chrome .surface-home a.c-call-to-action:not(.glyph-play) > span:after,
  .Safari .chevron-cta-fix a.c-call-to-action:not(.glyph-play) > span:after,
  .Firefox .chevron-cta-fix a.c-call-to-action:not(.glyph-play) > span:after,
  .Chrome .chevron-cta-fix a.c-call-to-action:not(.glyph-play) > span:after
  {
    content: "\00a0";
    margin-left: 3px;
    background-color: #0067B8;
    -webkit-mask-image: url('data:image/svg+xml,<svg width="1em" height="1em" fill="green" xmlns="http://www.w3.org/2000/svg" viewBox="0 0 24 24"><path d="M15.7 11.3l-6-6c-0.4-0.4-1-0.4-1.4 0s-0.4 1 0 1.4l5.3 5.3-5.3 5.3c-0.4 0.4-0.4 1 0 1.4 0.2 0.2 0.4 0.3 0.7 0.3s0.5-0.1 0.7-0.3l6-6c0.4-0.4 0.4-1     0-1.4z"></path></svg>');
    mask-image: url('data:image/svg+xml,<svg width="1em" height="1em" fill="green" xmlns="http://www.w3.org/2000/svg" viewBox="0 0 24 24"><path d="M15.7 11.3l-6-6c-0.4-0.4-1-0.4-1.4 0s-0.4 1 0 1.4l5.3 5.3-5.3 5.3c-0.4 0.4-0.4 1 0 1.4 0.2 0.2 0.4 0.3 0.7 0.3s0.5-0.1 0.7-0.3l6-6c0.4-0.4 0.4-10-1.4z"></path></svg>');
    -webkit-mask-size: 1.3em;
    mask-size: 1.3em;
    -webkit-mask-position: center;
    mask-position: center;
    -webkit-mask-repeat: no-repeat;
    mask-repeat: no-repeat;
    padding-left: 10px;
    width:auto;
    height:auto;
    font-family: MWF-MDL2;
    padding-bottom: 5px;
  }
   .Chrome .compare-load a.c-call-to-action.surface-bg-cta-blue:not(.glyph-play) > span:after,
   .Firefox .compare-load a.c-call-to-action.surface-bg-cta-blue:not(.glyph-play) > span:after,
   .Safari .compare-load a.c-call-to-action.surface-bg-cta-blue:not(.glyph-play) > span:after,
   .Chrome .compare-design-en-us a.c-call-to-action.surface-bg-cta-blue:not(.glyph-play) > span:after,
   .Firefox .compare-design-en-us a.c-call-to-action.surface-bg-cta-blue:not(.glyph-play) > span:after,
   .Safari .compare-design-en-us a.c-call-to-action.surface-bg-cta-blue:not(.glyph-play) > span:after,
   .Chrome .hp-mosaic .surface-WhiteCTAL3 a.c-call-to-action.surface-secondary-cta:not(.glyph-play) > span:after,
   .Firefox .hp-mosaic .surface-WhiteCTAL3 a.c-call-to-action.surface-secondary-cta:not(.glyph-play) > span:after,
   .Safari .hp-mosaic .surface-WhiteCTAL3 a.c-call-to-action.surface-secondary-cta:not(.glyph-play) > span:after,
   .Chrome .wdg-theme-dark-banner a.c-call-to-action:not(.glyph-play) > span:after,
   .Chrome .compare-load .wdg-theme-dark a.c-call-to-action:not(.glyph-play) > span:after,
   .Chrome .compare-design-en-us .wdg-theme-dark a.c-call-to-action:not(.glyph-play) > span:after,
   .Chrome .wdg-theme-dark-banner a.c-call-to-action.surface-secondary-cta:not(.glyph-play) > span:after, 
   .Firefox .wdg-theme-dark-banner a.c-call-to-action:not(.glyph-play) > span:after,
   .Firefox .wdg-theme-dark-banner a.c-call-to-action.surface-secondary-cta:not(.glyph-play) > span:after,   
   .Safari .wdg-theme-dark-banner a.c-call-to-action:not(.glyph-play) > span:after,
   .Safari .wdg-theme-dark-banner a.c-call-to-action.surface-secondary-cta:not(.glyph-play) > span:after ,
   .Safari .compare-load .wdg-theme-dark a.c-call-to-action:not(.glyph-play) > span:after,
   .Firefox .compare-load .wdg-theme-dark a.c-call-to-action:not(.glyph-play) > span:after,
   .Safari .compare-design-en-us .wdg-theme-dark a.c-call-to-action:not(.glyph-play) > span:after,
   .Firefox .compare-design-en-us .wdg-theme-dark a.c-call-to-action:not(.glyph-play) > span:after 
   {
       background-color: #FFFFFF;
   }
   
   @media only screen and (max-width: 539px){
    .Chrome .hp-mosaic .surface-WhiteCTAL3 a.c-call-to-action.surface-secondary-cta:not(.glyph-play) > span:after,
    .Firefox .hp-mosaic .surface-WhiteCTAL3 a.c-call-to-action.surface-secondary-cta:not(.glyph-play) > span:after,
    .Safari .hp-mosaic .surface-WhiteCTAL3 a.c-call-to-action.surface-secondary-cta:not(.glyph-play) > span:after 
    {
        background-color: #0067B8;
    }
   }
  
  
  .Chrome .compare-load a.c-call-to-action:not(.glyph-play):after,
  .Chrome .compare-design-en-us a.c-call-to-action:not(.glyph-play):after,
  .Chrome .surface-home a.c-call-to-action:not(.glyph-play):after,
  .Chrome .chevron-cta-fix a.c-call-to-action:not(.glyph-play):after,
  .Firefox .compare-load a.c-call-to-action:not(.glyph-play):after,
  .Firefox .compare-design-en-us a.c-call-to-action:not(.glyph-play):after,
  .Firefox .surface-home a.c-call-to-action:not(.glyph-play):after,
  .Firefox .chevron-cta-fix a.c-call-to-action:not(.glyph-play):after,
  .Safari .compare-load a.c-call-to-action:not(.glyph-play):after,
  .Safari .compare-design-en-us a.c-call-to-action:not(.glyph-play):after,
  .Safari .surface-home a.c-call-to-action:not(.glyph-play):after,
  .Safari .chevron-cta-fix a.c-call-to-action:not(.glyph-play):after
  {
      display: none;
  }
  
  a.c-call-to-action.surface-disabled-cta > span:after{
    content:none !important;
  }
  
  
  .IE11 .rtl .surface-home a.c-call-to-action:not(.glyph-play) > span:after,
  .IE11 .rtl .chevron-cta-fix a.c-call-to-action:not(.glyph-play) > span:after,
  .Edge .rtl .surface-home a.c-call-to-action:not(.glyph-play) > span:after,
  .Edge .rtl .chevron-cta-fix a.c-call-to-action:not(.glyph-play) > span:after
  {
    content: "\00a0";
    direction: rtl;
    text-decoration: none;
    width:auto;
    height:auto;
    font-family: MWF-MDL2;
    padding-bottom: 5px;
    font-size: 11px;
    display: inline-block;
  }
  
.IE11 .compare-load a.c-call-to-action:not(.glyph-play) > span:after,
.IE11 .compare-design-en-us a.c-call-to-action:not(.glyph-play) > span:after,
.IE11 .surface-home a.c-call-to-action:not(.glyph-play) > span:after,
.IE11 .chevron-cta-fix a.c-call-to-action:not(.glyph-play) > span:after,
.Edge .compare-load a.c-call-to-action:not(.glyph-play) > span:after,
.Edge .compare-design-en-us a.c-call-to-action:not(.glyph-play) > span:after,
.Edge .surface-home a.c-call-to-action:not(.glyph-play) > span:after,
.Edge .chevron-cta-fix a.c-call-to-action:not(.glyph-play) > span:after
  {
    content: "\00a0";
    text-decoration: none;
    width:auto;
    height:auto;
    font-family: MWF-MDL2;
    padding-bottom: 5px;
    font-size: 11px;
  }
  
.IE11 .compare-design-en-us a.headinglink.c-call-to-action:not(.glyph-play) > span:after{
 font-size: 16px;   
}
  
.IE11 .compare-load a.c-call-to-action:not(.glyph-play) > span:hover:after,
.IE11 .compare-design-en-us a.c-call-to-action:not(.glyph-play) > span:hover:after,
.IE11 .surface-home a.c-call-to-action:not(.glyph-play) > span:hover:after,
.IE11 .chevron-cta-fix a.c-call-to-action:not(.glyph-play) > span:hover:after,
.Edge .compare-load a.c-call-to-action:not(.glyph-play) > span:hover:after,
.Edge .compare-design-en-us a.c-call-to-action:not(.glyph-play) > span:hover:after,
.Edge .surface-home a.c-call-to-action:not(.glyph-play) > span:hover:after,
.Edge .chevron-cta-fix a.c-call-to-action:not(.glyph-play) > span:hover:after
  {
       text-decoration: none;
  }

.IE11 .compare-load a.c-call-to-action:not(.glyph-play):after,
.IE11 .compare-design-en-us a.c-call-to-action:not(.glyph-play):after,
.IE11 .surface-home a.c-call-to-action:not(.glyph-play):after,
.IE11 .chevron-cta-fix a.c-call-to-action:not(.glyph-play):after,
.Edge .compare-load a.c-call-to-action:not(.glyph-play):after,
.Edge .compare-design-en-us a.c-call-to-action:not(.glyph-play):after,
.Edge .surface-home a.c-call-to-action:not(.glyph-play):after,
.Edge .chevron-cta-fix a.c-call-to-action:not(.glyph-play):after
  {
      display: none;
  }    
  
.Safari .rtl .surface-home a.c-call-to-action:not(.glyph-play) > span:after,
.Safari .rtl .chevron-cta-fix a.c-call-to-action:not(.glyph-play) > span:after,
.Firefox .rtl .surface-home a.c-call-to-action:not(.glyph-play) > span:after,
.Firefox .rtl .chevron-cta-fix a.c-call-to-action:not(.glyph-play) > span:after,
.Chrome .rtl .surface-home a.c-call-to-action:not(.glyph-play) > span:after,
.Chrome .rtl .chevron-cta-fix a.c-call-to-action:not(.glyph-play) > span:after
{
    direction: rtl;
     -webkit-mask-image: url('data:image/svg+xml,<svg xmlns="http://www.w3.org/2000/svg" viewBox="0 0 192 512" width="1em" height="1em" fill="green"><path d="M4.2 247.5L151 99.5c4.7-4.7 12.3-4.7 17 0l19.8 19.8c4.7 4.7 4.7 12.3 0 17L69.3 256l118.5 119.7c4.7 4.7 4.7 12.3 0 17L168 412.5c-4.7 4.7-12.3 4.7-17 0L4.2 264.5c-4.7-4.7-4.7-12.3 0-17z" class=""></path></svg>');
     -webkit-mask-size: 1.2em;
     mask-image: url('data:image/svg+xml,<svg xmlns="http://www.w3.org/2000/svg" viewBox="0 0 192 512" width="1em" height="1em" fill="green"><path d="M4.2 247.5L151 99.5c4.7-4.7 12.3-4.7 17 0l19.8 19.8c4.7 4.7 4.7 12.3 0 17L69.3 256l118.5 119.7c4.7 4.7 4.7 12.3 0 17L168 412.5c-4.7 4.7-12.3 4.7-17 0L4.2 264.5c-4.7-4.7-4.7-12.3 0-17z" class=""></path></svg>');
     mask-size: 1.2em;
     margin-right: 5px;
}

/*Chevron fix specific to Compare en-us*/
.Chrome .compare-design-en-us a.headinglink.c-call-to-action:not(.glyph-play) > span:after,	
.Firefox .compare-design-en-us a.headinglink.c-call-to-action:not(.glyph-play) > span:after,
.Safari .compare-design-en-us a.headinglink.c-call-to-action:not(.glyph-play) > span:after{
    padding-bottom: 6px !important;
    font-size:22px;
}

.rtl a.c-call-to-action:not(.glyph-play) > span:hover:after{
 left: -2px !important;
position: relative;
}

body:not(.rtl) a.c-call-to-action:not(.glyph-play) > span:hover:after{
right: -2px;
position: relative;
}

.rtl a.c-call-to-action:not(.glyph-play):hover span, button.c-call-to-action:not(.glyph-play):hover span{
right: 0px !important;
}
/*End*/



/* End -  Chevron Issue Fix */ 

.hp-mosaic li h2.c-heading-2
{
        padding-top: 0px !important;    
}
.wdg-global .Surface_Home_Carousel_Hero_EN-US_20_1 a.c-call-to-action.c-glyph.surface-secondary-cta.carouselctaalignment 
{
text-align: left;
}

 @media only screen and (min-width: 540px) and (max-width: 600px)
{
.Edge .hp-mosaic .single .m-image-intro.f-align-bottom>div
{
bottom: 8px !important;
padding-bottom: 0px;
}
}


 @media only screen and (min-width: 540px) and (max-width: 600px)
{
.hp-mosaic .single .m-image-intro.f-align-bottom>div
{
bottom: 8px !important;
padding-bottom: 0px;
}
}

.en-us #mainContent .hp-mosaic ul li sup.surface-superscript-disable a,
.en-ca #mainContent .hp-mosaic ul li sup.surface-superscript-disable a,
.fr-ca #mainContent .hp-mosaic ul li sup.surface-superscript-disable a,
.ko-kr #mainContent .hp-mosaic ul li sup.surface-superscript-disable a,
.zh-cn #mainContent .hp-mosaic ul li sup.surface-superscript-disable a,
.de-de #mainContent .hp-mosaic ul li sup.surface-superscript-disable a,
.en-au #mainContent .hp-mosaic ul li sup.surface-superscript-disable a,
.en-gb #mainContent .hp-mosaic ul li sup.surface-superscript-disable a,
.es-es #mainContent .hp-mosaic ul li sup.surface-superscript-disable a,
.fr-fr #mainContent .hp-mosaic ul li sup.surface-superscript-disable a,
.it-it #mainContent .hp-mosaic ul li sup.surface-superscript-disable a,
.ja-jp #mainContent .hp-mosaic ul li sup.surface-superscript-disable a,
.nl-nl #mainContent .hp-mosaic ul li sup.surface-superscript-disable a,
.en-sg #mainContent .hp-mosaic ul li sup.surface-superscript-disable a {
text-decoration: none !important;
color: #000 !important;
}

@media only screen and (max-width: 539px) {
    
    .wdg-m-prefooter nav.c-link-navigation ul li
{
text-align: left !important;

}
     .wdg-m-prefooter.prefooter-9-links nav.c-link-navigation ul li
{
text-align: left !important;
}

.wdg-m-prefooter nav.c-link-navigation ul li a.c-hyperlink.f-image
{

display: inline !important;
}
.hp-mosaic ul li
{
    
   padding-bottom:5px !important; 
}
.wdg-global .hp-mosaic ul li.accpanel .c-call-to-action
{
    
        padding-left: 13px !important;
    padding-right: 5px !important;
}
.wdg-m-prefooter nav.c-link-navigation.prefooternavlist-2 ul li
{
width: 100% !important;
}
}

/*@media only screen and (min-width:1366px) {
.fullTile section{
   bottom: Calc(20%) !important;*

    }
}
@media only screen and (max-width:1366px) {
.fullTile section{
    top:0;
   bottom:0;
    }
}*/
@media only screen and (max-width:1083px) {
    
.wdg-global .Surface_Home_Carousel_Hero_EN-US_20_1 a.c-call-to-action.c-glyph.surface-secondary-cta.carouselctaalignment
{
    text-align: center !important;
}
}

@media only screen and (min-width:768px) {
 .surface-home-offercarousel .c-carousel .new-sp4-banner img
{
    position: absolute;
	top: 0;
	bottom: 0;
	left: 0;
	margin: auto;
    z-index: -1;
}
}

/*arabic locale Pre-Footer aligne*/

@media only screen and (max-width: 539px) {
    .rtl .wdg-m-prefooter button.drawer
    {
        width: 25% !important;
    }
.ar-ae .wdg-m-prefooter nav.c-link-navigation,
    .ar-sa .wdg-m-prefooter nav.c-link-navigation,
    .ar-qa .wdg-m-prefooter nav.c-link-navigation
{
    margin-right:0px !important;
}
    .ar-ae  .wdg-m-prefooter nav.c-link-navigation ul li,
    .ar-qa  .wdg-m-prefooter nav.c-link-navigation ul li,
    .ar-sa  .wdg-m-prefooter nav.c-link-navigation ul li
{
text-align: right !important;
}
}

/*arabic home moasic issue*/
.ar-ae .hp-mosaic .m-image-intro.f-align-bottom>div,
.ar-qa .hp-mosaic .m-image-intro.f-align-bottom>div,
.ar-sa .hp-mosaic .m-image-intro.f-align-bottom>div{
    right:0 ;
}


/*arabic locale back to top mobile left aligne*/

@media only screen and (max-width: 767px) 
{
.ar-ae a.c-back-to-top[aria-disabled=false],
.ar-ae a.m-back-to-top[aria-disabled=false],
.ar-sa a.c-back-to-top[aria-disabled=false],
.ar-sa a.m-back-to-top[aria-disabled=false],
.ar-qa a.c-back-to-top[aria-disabled=false],
.ar-qa a.m-back-to-top[aria-disabled=false]
{
left:24px !important;
    right: inherit !important;
}

}
.de-de .blue-offer.blue-offer-home
{
margin-top: 0px !important;
}

/*home page offer carousel padding issue in moblie viewport*/
@media only screen and (max-width:539px) {
.surface-home-offercarousel{
    padding-bottom: 13px;
}
}

/*chevron issue for studio 2*/
.wdg-global .contentPlacement_pointer .m-content-placement-item.chevron-cta-fix .mscom-link.c-call-to-action.c-glyph{
    text-align: left;
}

/*home page hero de-de overlapping issue*/
@media only screen and (min-width:1084px) and (max-width:1150px){
.de-de .wdg-global .Surface_Home_Carousel_Hero_EN-US_20_1 .Surface_Home_Carousel_Pt-1.pride-content-overlap,
.fr-ca .wdg-global .Surface_Home_Carousel_Hero_EN-US_20_1 .Surface_Home_Carousel_Pt-1.pride-content-overlap
{
    max-width: 422px;
}
}


/*home page hero Spotify*/
@media only screen and (min-width:1084px) and (max-width:1240px){
.wdg-global .Surface_Home_Carousel_Hero_EN-US_20_1 .spotify .Surface_Home_Carousel_Pt-1 
{
   padding-top: 10px;
   padding-left: 105px;
}
}


/*en-za home link nav for accessories link*/
@media only screen and (min-width: 768px) {  
#mainContent .surface-link-nav .c-link-navigation .salink.c-hyperlink:not(.f-image).x-hidden-focus:not(:hover),
#mainContent .surface-link-nav .c-link-navigation .salink.c-hyperlink:not(.f-image).x-hidden-focus,
#mainContent .surface-link-nav .c-link-navigation .salink.c-hyperlink:not(.f-image):not(:hover),
#mainContent .surface-link-nav .c-link-navigation .salink.c-hyperlink:not(.f-image),
#mainContent .surface-link-nav .c-link-navigation .salink p a:focus{
    text-decoration: none !important;
}
}

/*Home page Hero Headphones Aug update*/
@media only screen and (min-width: 1084px) and (max-width: 1170px){  
   .wdg-global .surface-home .c-carousel .surfacehome-hero-headphones .Surface_Home_Carousel_Pt-1{
        padding-left: 9%;
        padding-right: 1%;
    }
    }
    
/*@media only screen and (min-width: 1151px) and (max-width: 1250px){  
   .wdg-global .surface-home .c-carousel .surfacehome-hero-headphones .Surface_Home_Carousel_Pt-1{
        padding-left: 6%;
        padding-right: 1%;
    }
    }
    @media only screen and (min-width: 1084px){ 
.Surface_Home_Carousel_Hero_EN-US_20_1 .m-hero-item.f-x-right.f-y-center>div>div.Surface_Home_Carousel_Pt-1
{
transform: translateY(-70%);
}
.Surface_Home_Carousel_Hero_EN-US_20_1 .m-hero-item.f-x-left.f-y-center>div>div.Surface_Home_Carousel_Pt-1
{
transform: translateY(-41%);
}
    }*/
    
/*f-mask-20 hide for home hero carousel*/
.wdg-global .surface-home .c-carousel .f-mask-20.surfacehome-hero-headphones picture:after {
    background: none;
    }   


/*Home page Hero Headphones update Aug END*/



/*home page right single tile issue for 1084 to 1920 VP for G2*/
 @media only screen and (max-width: 1084px)
{
    .es-mx .hp-mosaic .single.msctRSingleD1 .m-image-intro.f-align-bottom .x-type-left
    {
        bottom: 0px !important;
    }
}

/*duo 8/12 updates start*/
 @media only screen and (min-width: 540px)
{
.en-us .hp-mosaic .x-type-left.duo-tile
{
    top: calc(6%);
    height: 30%;
}
}
/*fr-ca new tag update for */
 @media only screen and (min-width: 1084px) and (max-width: 1292px){ 

.fr-ca .hp-mosaic .m-content-placement-item.earbuds-new-text{
    padding-right: 0% !important;
    padding-left: 6% !important;
}
}


/*duo 540 VP  */
@media only screen and (max-width: 539px){ 

.en-us .hp-mosaic .duo-539-image{
   display: none;
}
.en-us .hp-mosaic .single .m-image-intro.f-align-bottom .duo-tile{
    padding-bottom: 0px !important;
}
}

/*duo 1920 VP  */
@media only screen and (min-width: 540px){ 

.en-us .hp-mosaic .duo-1920-image{
   display: none;
}
}
@media only screen and (min-width: 1084px) and (max-width: 1100px){ 
.en-us .hp-mosaic .single .m-image-intro.f-align-bottom .go-us-duo{
    bottom: 15px !important;
}
}
/*duo 8/12 updates end*/


/*home mosaic cta fix for mobile devices */
@media only screen and (max-width: 539px){
.surface-home .hp-mosaic .c-call-to-action.surface-secondary-cta{
    padding-left: 20px !important;
    text-align: center !important;
}
.surface-home .hp-mosaic .double h2{
    margin-top: 0px !important;
}
.surface-home .hp-mosaic .m-content-placement-item .c-call-to-action.surface-secondary-cta{
    padding-left: 10px !important;
    padding-right: 10px !important;
    text-align: center !important;
    
}
.surface-home .hp-mosaic .fullbook3 .c-call-to-action.surface-secondary-cta{
    padding-left: 32px !important;
}
}
/*Hom epage footnote vertical alignment issue*/
.surface-home .surface-section-footnotes ul {

padding-top: 10px;

}

/*home page en-sg mosaic fix*/

.en-sg .surface-home .hp-mosaic li.msctL.single.slide.surface-lg-center{
    clear: both;
}
.wdg-m-prefooter.wdg-pad-thin
{
    margin-top: 0px !important;
    margin-bottom: 48px;
    padding-top: 48px !important;
}

/*fr-fr accessibility bug fixes*/
.surface-home-offercarousel.SurfaceHome_OfferCarousel_VFO .c-carousel .c-sequence-indicator button:focus{
outline: #000 dashed 1px !important;
}

.design-18 .hmc-buttons button.c-button.f-lightweight.c-glyph.glyph-chevron-left.next:hover,
.design-18 .hmc-buttons button.c-button.f-lightweight.c-glyph.glyph-chevron-left.next:focus,
.design-18 .hmc-buttons button.c-button.f-lightweight.c-glyph.glyph-chevron-right.back:focus,
.design-18 .hmc-buttons button.c-button.f-lightweight.c-glyph.glyph-chevron-right.back:focus
{
outline: 1px dashed #000;
}
/*fr-fr accessibility bug fixes END*/

.surface-home-offercarousel .c-carousel.f-multi-slide .c-flipper
{
display:block !important;
}


/*home video panel padding issue need to remove when video panel removed*/
/*@media only screen and (min-width: 1084px){
.en-us .surface-highlightFeature.SurfaceHome_HL_HighlightFeature_Panel_19_PT
{
    padding-top: 43px !important;
}
}*/

@media only screen and (max-width:767px) {
.en-us .SurfaceHome_HL_HighlightFeature_Panel_19_PT .hmc-display-below-1083
{
padding-top:0px !important;
padding-bottom:0px !important;

}
}

/*commented for F21 new design*/
/*@media only screen and (min-width: 1084px){
.surface-home .oneplayer-video.oneplayer-video-home.wdg-pad-thin.VideoPanel.surface-featurevideo-text{
    padding-bottom: 46px;
}
}*/
/*commented for F21 new design end*/
@media only screen and (max-width:539px) {
.surface-home .oneplayer-video.oneplayer-video-home.wdg-pad-thin.VideoPanel.surface-featurevideo-text{
    padding-top: 0px;
}
}

@media only screen and (min-width: 1084px) and (max-width: 1400px){ 
.en-us .hp-mosaic .m-content-placement-item.earbuds-new-text .c-badge,
.en-ca .hp-mosaic .m-content-placement-item.earbuds-new-text .c-badge,
.fr-ca .hp-mosaic .m-content-placement-item.earbuds-new-text .c-badge{
   font-size:11px; 
}
}

/*Fall 20 home updates start*/
.en-us .surface-home .hp-mosaic li.msctL.single.slide.surface-lg-center{
    clear: both;
}
/*.en-us .surface-home .hp-mosaic li .duo-alignment div.x-type-left 
{
bottom: 0px !important;
}*/


@media only screen and (max-width:1366px) {
.rtl .hp-mosaic li .x-type-left.surface-slg .c-subheading-2
{
  line-height: 23px; 
    
}

.rtl .hp-mosaic li .x-type-left.surface-slg h2.c-heading-2
{
    line-height: 25px;    
}

.rtl .hp-mosaic .single .m-image-intro.f-align-bottom>div.surface-slg
{
  bottom: 0px !important;
}
}   
@media only screen and (max-width:1145px) and (min-width:1084px) { 
.hp-mosaic .single .m-image-intro.f-align-bottom>div.surface-slg
{
     bottom: 8px !important;
}
}
/*headphones 2 CTA chevron fix */
@media only screen and (max-width:1150px) and (min-width:1084px) { 
.surface-home .hp-mosaic .headphones-2-cta .c-call-to-action.surface-secondary-cta
{
     font-size: 14px !important;
}
}


/*Fall 20 home updates End*/

/* Compare Price Loader CSS*/
.compare-price-loader {
  display: inline-block;
  width: 25px;
  height: 25px;
}
.compare-price-loader:after {
  content: " ";
  display: block;
  width: 20px;
  height: 20px;
  margin: 8px;
  border-radius: 50%;
  border: 2px solid #006cc2;
  border-color: #006cc2 transparent #006cc2 transparent;
  animation: compare-price-loader 1.2s linear infinite;
}
@keyframes compare-price-loader {
  0% {
    transform: rotate(0deg);
  }
  100% {
    transform: rotate(360deg);
  }
}


/*Compare _new design css styles*/
/*.compare-design-en-us-non , .compare-design-en-us{
     display: none;
}
body:not(.en-us) .compare-design-en-us-non{
    display: block;
}*/
.compare-design-en-us{
     display: block;
}
  .sticky_compare_bar {
            /*padding-right: 36px;*/
            margin-top: 16px;
            margin-bottom: 16px;
        }
        #ResultSection .c-heading-4 {
            padding-top: 0 !important;
            margin-top: 5px;
            margin-bottom: 4PX;
            padding-bottom: 0 !important;
        }
        /*.sticky-compare-content {
            display: flex;
            flex-flow: wrap;
            float: right;
            margin-top: 10px;
        }*/

            .sticky-compare-content .compare-selected {
                display: flex;
                flex-flow: wrap;
            }

            .sticky-compare-content #numItemsSelected {
                margin-left: 10px;
            }

            .sticky-compare-content .compare-selected img {
                margin-left: 10px;
                width: 40px;
                height: 40px;
                border: 1px solid gray;
            }

            .sticky-compare-content p {
                margin-right: 20px;
            }

        .sticky_compare_bar.compare-fixed {
            position: fixed;
            width: 100%;
            max-height: 78px;
            height: 78px;
            left: 0;
            top: 0;
            /* margin-top: 0px !important; */
            z-index: 999999;
            background-color: white;
            border-bottom: 1px solid gray;
            /*padding-right: 7.5%;*/
            margin-top: 0;
            margin-bottom: 0;
        }

        #ResultSection .stickycompareImageSection.stickyFixed {
            position: fixed;
            width: 100%;
            left: 0;
            top: 0;
            /* margin-top: 0px !important; */
            z-index: 101;
            /*background-color: white;
            border-bottom: 1px solid gray;
            padding-right: 7.5%;*/
            background-color: rgb(242,242,242);
            margin: 0 auto;
            
        }

        .compareImageSection,
        .stickycompareImageSection {
            height: auto;
            display: inline-block;
        }

           

        .c-price .s1:not(:empty) {
            text-decoration: line-through;
        }
        
      .compare-design-en-us .c-price .s1:before {
            content: "Full price was: ";
            position: absolute;
            clip: rect(0 0 0 0);
        }
        
       .compare-design-en-us .c-price .s2:not(:empty):before {
            content: " Price now: ";
            position: absolute;
            clip: rect(0 0 0 0);
        }

        .compareImageSection .c-group,
        .stickycompareImageSection .c-group {
            display: block;
        }

        .compareImageSection .compare-device:not(.compare-business-panel) .m-product-placement-item picture,
        .stickycompareImageSection .m-product-placement-item picture
         {
            height: 189px;
            display: block;
            overflow: hidden;
            padding-bottom: 15px;
            position: relative;
        }
    .stickycompareImageSection .m-product-placement-item picture{height:auto;padding-top:15px;overflow: visible;}
            .compareImageSection .m-product-placement-item picture img,
             .stickycompareImageSection .m-product-placement-item picture img {
                top: auto;
                height: auto;
               
                position: relative;
            }
           .compareImageSection .m-product-placement-item picture img
            {
                 width: 100%;
            }
        .compareImageSection .learn-more-link,
        .compareImageSection .learn-more-link:hover,
        .compareImageSection .learn-more-link:focus,
        .compareImageSection .learn-more-link:active,
        .stickycompareImageSection .learn-more-link,
        .stickycompareImageSection .learn-more-link:hover,
         #compare-devices-section .learn-more-link::after{
            background-color: transparent!important;
            color: #0067B8 !important;
        }
        
       /* .compareImageSection .learn-more-link span,
        .stickycompareImageSection .learn-more-link span,
         #compare-devices-section .learn-more-link span{
            color: #0067B8 !important;
        }*/
        
        /*.compareImageSection .learn-more-link:hover span,
        .compareImageSection .learn-more-link:focus span,
        .compareImageSection .learn-more-link:active span,
        .stickycompareImageSection .learn-more-link:hover span,
         #compare-devices-section .learn-more-link:hover span{
            text-decoration: underline;
        }*/
        
        .mouse_hover .m-product-placement-item{
            background-color:rgb(247,247,247)!important;
        }
        .compareImageSection .compare-device{
            padding-left: 18px;
            padding-right: 18px;
            padding-bottom: 24px;
        }
        .stickycompareImageSection .compare-device {
            padding-left: 18px;
            padding-right: 18px;
            padding-bottom: 2px;
        }

            .compareImageSection .compare-device .m-product-placement-item ,
             .stickycompareImageSection .compare-device .m-product-placement-item {
                outline: 2px solid #e5e5e5 !important;
                margin-right: 0px;
               padding-bottom: 15px;
            }

        .compareImageSection .c-price span,
         .stickycompareImageSection .c-price span {
            float: none;
        }

        /* START :  Filter Section Styles*/
        #filterSection {
            padding-left: 36px;
            padding-right: 36px;
            padding-top: 55px;
        }

            #filterSection .c-checkbox label.c-label {
                margin-top: 10px;
                padding-left: 10px;
            }

            #filterSection .c-checkbox input[type=checkbox] + span {
                padding-top: 0;
                background: transparent;
            }

            #filterSection .c-choice-summary > .c-menu {
                width: max-content;
                width: -moz-max-content;
width: -webkit-max-content;
width: -o-max-content;
width: -ms-max-content;
            }
                   #filterSection .c-choice-summary:not(.fliterByText){
                      cursor:pointer; 
                   }
                    #filterSection  #selectionsDisplay .c-choice-summary:not(.fliterByText),.resSec #resultsCount a, #filterSection .c-choice-summary.showall{
                      cursor:auto; 
                   }
                  
                    #filterSection .c-choice-summary .c-action-trigger.c-glyph.glyph-chevron-down{
                      padding-top:12px!important;
                   }
                   #filterSection .c-choice-summary .c-action-trigger.c-glyph.glyph-chevron-down+span{
                      padding-top:12px!important;
                   }

            #filterSection .fliterByText {
                background: transparent;
                font-size: 18px;
                width: auto;
                padding-right: 0px;
            }

        .sortSection .c-group.f-wrap-items {
            float: right;
        }

        .sortSection .c-choice-summary {
            margin-right: 0px;
        }
        .sortSection .c-choice-summary.fliterByText {
            margin-right: 12px;
        }
        

        .sortSection .c-label {
            margin-top: 0px;
            padding-bottom: 0px;
        }

            .sortSection .c-label span {
                background: transparent;
            }
        /* END :  Filter Section Styles*/

        /* TechSpecs Table*/
        #TechSpecsTable {
            padding-left: 24px;
            padding-right: 24px;
        }

            #TechSpecsTable .m-system-requirements .c-table td {
                float: none;
            }

                #TechSpecsTable .m-system-requirements .c-table td:first-child {
                    font-weight: 400;
                }
        #TechSpecsTable .rowHeading {
            font-weight: 700;
            font-size: 18px;
            line-height: 24px;
            display: block;
            position:relative;
            padding-bottom: 8px !important;
            min-height:24px;
        }
        
        #TechSpecsTable tr td:not(:first-child) .rowHeading
        {
            min-height:32px;
        }
        strong.c-badge:empty {
            background: none !important;
        }
        
        #ResultSection .compareImageSection .compare-device .m-product-placement-item,
        #ResultSection .stickycompareImageSection .compare-device .m-product-placement-item
         {
            border: none !important;
            padding-bottom:0px;
            margin-right:auto;
        }
        .compare-design-en-us #TechSpecsTable  tr td,.compare-design-en-us #TechSpecsTable tr th,.compare-design-en-us #TechSpecsTable caption{
        padding-left:24px;
}
 
        @media only screen and (max-width: 767px) {
            .stickyFixed.stickycompareImageSection  .m-product-placement-item picture img {
                height: 120px;
                width: 120px;
            }
            .compare-design-en-us #TechSpecsTable  tr td,.compare-design-en-us #TechSpecsTable tr th,.compare-design-en-us #TechSpecsTable caption{
        padding-left:12px;
}
        }
        .hide{
  display:none!important;
  }
  .selectDisplays {
    padding-top: 24px;
    clear:both;
}

  ul#selectionsDisplay li span {
    padding: 10px 20px;
    font-size: 15px;
}
  .showall {
    padding-right: 10px;
    font-size: 15px;
    margin-top: 0;
    margin-bottom: 10px;
    background: transparent;
}
ul#selectionsDisplay {
    display: inline;
}
ul#selectionsDisplay li {
    margin-top: 0;
    margin-bottom: 12px;
}
.resSec {
    display: inline-block;
}
#ResultSection .stickycompareImageSection .stickyFixed .compare-device-placement{
    border:none !important;
}
        .surface-section-footnotes{ clear:both;}
        
        .sticky-compare-content {
    display: flex;
    flex-flow: wrap;
    padding: 30px;
    position: relative;
}
#compareButton {
    right: 3%;
    position: absolute;
    transform: translateY(-50%);
    top: 50%;
    margin-top: 0;
}
        .sticky-compare-content #stcikyHeading {
    width: 50%;
    padding: 0;
}
/*.c-choice-summary>#examplelist1.c-menu {
    right: 0px;
}*//*TODO*/
 .compare-design-en-us .surface-compare-banner .m-banner .c-paragraph-2{
    display: block;
}
.compare-design-en-us .surface-compare-banner .surface-Banner-Result-Body,.compare-design-en-us .surface-compare-banner.activecompare .m-banner .c-paragraph-2,.compare-design-en-us .surface-compare-banner .m-banner .c-paragraph-2.surface-compare-mobview{
    display: none;
}
.compare-design-en-us .surface-compare-banner.activecompare .surface-Banner-Result-Body{
    display: block;
}
#ResultSection .compareImageSection .compare-device .m-product-placement-item,
#ResultSection .stickycompareImageSection .compare-device .m-product-placement-item
{
    outline: none!important;
}
#TechSpecsTable+section {
    clear: both;
}
.compare-design-en-us #deviceSection li.compare-device{cursor: pointer;}
.compare-design-en-us #deviceSection #compare-devices-section{margin-bottom:56px;}

  @media only screen and (max-width: 767px) {
 .compare-design-en-us  .stickycompareImageSection.stickyFixed img ,
 .compare-design-en-us  .stickycompareImageSection.stickyFixed picture {
    display: none;
}

.fr-fr .compare-design-en-us .stickycompareImageSection.stickyFixed .compareratingimage img
{
    display: inline;
}

   #ResultSection .compareImageSection .compare-device,
   #ResultSection .stickycompareImageSection .compare-device
    {width:50% !important;float: left !important;}
   #TechSpecsTable table{display:table; }
   #TechSpecsTable td{min-width: 0px!important;width:50% !important;display: table-cell;}
   #TechSpecsTable tr{display: table-row;}
   #filterSection div[data-grid=col-9]{
       float:left;
       width:75%;
   }
   #filterSection div[data-grid=col-9] ul li{      
       width:75%;
   }
 
   .sortSection{
       float:left;
       width:25%;
   }
    .compare-design-en-us .itemsfilter, .compare-design-en-us .itemsfilter, .compare-design-en-us .itemsfilter ul, li.filterdropdown , .compare-design-en-us  .sortSection,.compare-design-en-us  .sortSection ul ,.compare-design-en-us  .sortSection li.filterdropdown {
     width:100%!important;
 }
  .compare-design-en-us   .surface-compare-banner  p.c-paragraph-2,  .compare-design-en-us .surface-compare-banner.activecompare p.surface-compare-mobview{
    display: none!important;
}
  .compare-design-en-us .surface-compare-banner p.surface-compare-mobview{
      display: block!important;
  }
 .compare-design-en-us  .surface-compare-banner.activecompare .surface-Banner-Result-Body{
    display: block!important;
}
  .compare-design-en-us #filterSection{
    padding-top:0px!important;
}
 /*.sortSection .c-choice-summary {
            margin-right: 12px;
        }*/
  }
   @media only screen and (max-width: 539px) {
      #ResultSection .compare-device .c-heading-4{
          font-size:20px;
      }
        .sticky-compare-content #stcikyHeading {
         width: 60%;
      }
  }
    @media only screen and (max-width: 815px) {
        
        #filterSection .sortSection,.sortSection .c-group.f-wrap-items {
            
            float:none!important;}
   
 .c-choice-summary>#examplelist1.c-menu {
    left: 0px;
}
        
        }
  #filterSection .c-choice-summary a.c-action-trigger.c-glyph[aria-label],
  #filterSection .c-choice-summary button.c-action-trigger.c-glyph[aria-label]{
      padding-top: 8px;
  }
.compare-design-en-us li.compare-device .c-checkbox.c-check-compare{
      pointer-events:none;
  }
  
  .compare-design-en-us .m-system-requirements .c-table caption{
border-bottom: none;
}

.compare-design-en-us #examplelist1[aria-hidden="false"]{
    border:1px solid rgb(229,229,229);
}

.compare-design-en-us #examplelist1 li{
font-size:15px;
}
.compare-design-en-us li.compare-device .headinglink:hover,.compare-design-en-us li.compare-device .headinglink:focus {text-decoration: underline;}
.compare-design-en-us li.compare-device .headinglink{
    background: transparent;
    color: #0067b8 !important;
    font-weight:400;
    padding:0px;
}
.compare-design-en-us #examplelist1 li:hover,.compare-design-en-us #examplelist1 li:focus{
    outline:2px dashed #000;
    background-color: #e6e6e6;
}

.compare-design-en-us #TechSpecsTable, .compare-design-en-us section[data-vg='SurfaceCompare_4_OfficAppsPanel_VG']{
    clear:both;
}
.compare-design-en-us .surface-compare-banner .start_over_return_new,
.compare-design-en-us .surface-compare-banner .start_over_return
{
    display: none;
}

.compare-design-en-us .surface-compare-banner.activecompare .start_over_return_new,
.compare-design-en-us .surface-compare-banner.activecompare .start_over_return{
    display: inline-block;
}
.compare-design-en-us #filterSection{
    margin-bottom: 48px;
}

.compare-design-en-us .c-chkboxfilters li.c-choice-summary span sup {display: inline-block;}
.compare-design-en-us .c-chkboxfilters li.c-choice-summary span sup .supText{padding-left:0px!important;}

.compare-design-en-us li.compare-device .headinglink:hover,.compare-design-en-us li.compare-device .headinglink:focus {text-decoration: underline;}
.compare-design-en-us li.compare-device .headinglink{
background: transparent;
    color: #0067b8;font-weight:400;
    padding:0px;
}
/*.compare-design-en-us .stickyFixed li.compare-device .headinglink{
color: #000;
 background-color: #FFF;
 pointer-events:none;
}*/
/*.compare-design-en-us .stickyFixed li.compare-device .headinglink:hover,.compare-design-en-us .stickyFixed li.compare-device .headinglink:focus{
text-decoration: none;
}*/

.compare-design-en-us li.compare-device p.c-subheading-5{ padding-top:12px;}
.compare-design-en-us .wdg-m-prefooter.wdg-pad-thin {


	margin-bottom: 48px;
	margin-top: 0px !important;
	padding-top: 48px !important;


}

.compare-design-en-us #TechSpecsTable thead{
        border-bottom: none;
}
.compare-design-en-us #TechSpecsTable thead th{
       padding-bottom: 0px;
}
.compare-design-en-us #TechSpecsTable tbody tr:last-child,.compare-design-en-us #TechSpecsTable caption{
        border-bottom: 1px solid rgba(0,0,0,.2)!important;
}
    
.compare-design-en-us #TechSpecsTable tbody tr td{padding-bottom:20px!important;}
.compare-design-en-us li.compare-device .c-badge{
    /*height:20px!important;*/
    display:inline-block;
    }
.compare-design-en-us li.filterButton {margin-top:5px;}
.compare-design-en-us .c-checkbox input[type=checkbox]:focus+span:before{
    outline: #000 dashed 1px !important;
}
/*.compare-design-en-us .c-menu .c-menu-item [aria-checked=true]:focus+span:before
{
outline: #000 dashed 1px !important;
}*/
/*.compare-design-en-us .c-menu .c-menu-item [aria-checked="true"]{
    outline: #000 dashed 1px !important;
}
.compare-design-en-us .c-checkbox input[type=checkbox][aria-checked=true]:focus + span::before {
    border: 1px solid currentcolor !important;
    border: 1px dashed;
}*/

#ResultSection .compareImageSection .compare-device {
    padding-bottom:0px;
}
#ResultSection .compareImageSection .compare-device .m-product-placement-item{
    padding-bottom:24px;
}
/* Compare Loader CSS */
.compare-loader {
  border: 16px solid #f3f3f3;
  border-radius: 50%;
  border-top: 16px solid #3498db;
  width: 120px;
  height: 120px;
  -webkit-animation: spin 2s linear infinite; /* Safari */
  animation: spin 2s linear infinite;
  margin: 0 auto;
}

/* Safari */
@-webkit-keyframes spin {
  0% { -webkit-transform: rotate(0deg); }
  100% { -webkit-transform: rotate(360deg); }
}

@keyframes spin {
  0% { transform: rotate(0deg); }
  100% { transform: rotate(360deg); }
}
.compare-design-en-us #filtercompareButton{
    position: relative;
    transform:translateX(-50%);
    left:50%;
    margin-top:0px;
    margin-bottom:13px;
    display: none;
}
@media only screen and (max-width: 767px) {
.compare-design-en-us #filtercompareButton{
     display: block;
}
}
.compare-design-en-us .stickycompareImageSection.stickyFixed{border-bottom:1px solid gray;}
/*.compare-design-en-us .stickycompareImageSection.stickyFixed .m-content-placement{padding-bottom:10px;}*/
.compare-design-en-us li.compare-device.mouse_hover{outline: none !important;}
@media only screen and (max-width:1600px) and (min-width:1084px) { 
    #filterSection div[data-grid=col-9]{
       width:73%;
   }


}
 @media only screen and (min-width: 1400px) {
.compare-design-en-us #deviceSection .sortSection .filterdropdown{margin-right:12px;}
}
 @media only screen and (min-width: 768px) {
.IE11 #filterSection .c-choice-summary > .c-menu , .Mac.Safari #filterSection .c-choice-summary #batterylife{width:250px;}
}

.Mac.Safari #TechSpecsTable .rowHeading{ display:inline-block; width:100%;height:24px; }
.Mac.Safari #TechSpecsTable .rowValue > ul{ margin-top:10px;}
.compare-design-en-us .filterspan .supText{
text-decoration:underline;
}
/*Compare _new design css styles*/


.en-sg .compare-load .compare_table .m-content-placement-item a.c-call-to-action.surface-disabled-cta:hover + a.c-call-to-action span{
    text-decoration: none !important;
}

/*.ko-kr #mainContent .hp-mosaic .single .surface-slg a.c-hyperlink.supBLink
{
color:#000 !important;
font-weight: 200;
text-decoration: none !important;
}*/

/* .msw-page.ko-kr #mainContent  .surface-section-footnotes .c-hyperlink.supLink.supLinkcolor,
 .msw-page.ko-kr #mainContent .surface-section-footnotes .c-hyperlink.supLink.supLinkcolor:hover
{
color: #fff !important;
pointer-events:none !important;
}*/

/*home hero badge edition for all locales*/
.wdg-global .surface-home .Surface_Home_Carousel_Pt-1 h1.c-heading-2.hero-badge,
.wdg-global .surface-home .Surface_Home_Carousel_Pt-1 h2.c-heading-2.hero-badge
{
    padding-top: 3px;
}

/*Overriding MWF styles for accessibility*/
.wdg-global.surfacecom .surface-go-tech sup{
    top: -0.35em;
}

.surface-360slider .surface-slidercomp .ui-widget-content{
    background: rgba(0,0,0,.6) !important;
}

.wdg-global.surfacecom .surface-go-tech .c-paragraph-2{
    line-height: 26px;
}

.wdg-global.surfacecom .surface-go-tech .m-content-placement .c-caption,
.wdg-global.surfacecom .surface-go-tech .m-system-requirements td{
    line-height: 24px;
}

.wdg-global.surfacecom .surface-go-tech .m-system-requirements sup{
    margin-left: 3px;
}

@media only screen and (max-width: 767px) {
    .wdg-global.surfacecom .surface-go-tech .surface-section-footnotes li.c-caption-2{
        line-height: 16px;
    }
}

.surface-home .hp-mosaic li .c-badge.f-highlight:empty{
display: none;
max-height: 18px;
}

/*Overriding MWF styles for accessibility*/

/*home page cr updates need to remove after this CR TD*/
@media only screen and (min-width: 1399px){
.surface-home .m-hero-item .Surface_Home_Carousel_Pt-1{
    max-width:500px !important;
}
} 

@media only screen and (max-width:1210px) and (min-width:1084px){
.surface-home .m-hero-item .Surface_Home_Carousel_Pt-1{
    max-width:380px !important;
}
}

/*Accessibility bug fixes for compare page*/
.compare-design-en-us li.compare-device .headinglink:focus{
outline: #000 dashed 2px !important;
}
span#resultsCount a:focus{
outline: #000 dashed 2px !important;
padding:3px;
}

@media screen and (-ms-high-contrast: white-on-black) {
.compare-design-en-us .filterdropdown{
    border: 1px solid white;
}
.compare-design-en-us .filterdropdown a{
    border: none;
}
}
@media screen and (-ms-high-contrast: black-on-white) {
.compare-design-en-us .filterdropdown{
    border: 1px solid black;
}
.compare-design-en-us .filterdropdown a{
    border: none;
}
}

/*.compare-design-en-us .compareImageSection .m-content-placement .compare-device .m-product-placement-item a.headinglink:not(.glyph-play):after,
.compare-design-en-us .imagesectiontable .stickycompareImageSection .stickycontainersp .compare-device .m-product-placement-item a.headinglink:not(.glyph-play):after{
content: "\E76C";
font-family: "MWF-MDL2";
display: inline-block;
font-size: 16px;
margin-left: 5px;
color: #0067b8;
font-weight: 900;

}*/
.compare-design-en-us .compareImageSection .m-content-placement .compare-device .m-product-placement-item a.headinglink,
.compare-design-en-us .imagesectiontable .stickycompareImageSection .stickycontainersp .compare-device .m-product-placement-item a.headinglink{
    text-transform: capitalize;
    font-size: 24px;
}
.compare-design-en-us .compareImageSection .m-content-placement .compare-device .m-product-placement-item a.headinglink:focus,
.compare-design-en-us .imagesectiontable .stickycompareImageSection .stickycontainersp .compare-device .m-product-placement-item a.headinglink:focus{
    background: none;
}
.compare-design-en-us .compareImageSection .m-content-placement .compare-device .m-product-placement-item a.headinglink:focus:not(.x-hidden-focus) span, .compare-design-en-us .compareImageSection .m-content-placement .compare-device .m-product-placement-item a.headinglink:hover span, .compare-design-en-us .imagesectiontable .stickycompareImageSection .stickycontainersp .compare-device .m-product-placement-item a.headinglink:focus:not(.x-hidden-focus) span, .compare-design-en-us .imagesectiontable .stickycompareImageSection .stickycontainersp .compare-device .m-product-placement-item a.headinglink:hover span{
    text-decoration: underline !important;
}
#mainContent .surface-section-footnotes a.c-hyperlink.supLink:not(.f-image).x-hidden-focus:not(:hover):focus, #mainContent .surface-section-footnotes a.c-hyperlink.supLink:not(.f-image).x-hidden-focus:focus, #mainContent .surface-section-footnotes a.c-hyperlink.supLink:not(.f-image):not(:hover):focus, #mainContent .surface-section-footnotes a.c-hyperlink.supLink:not(.f-image):focus, #mainContent .surface-section-footnotes p a.supLink:focus
{
        outline: 2px dotted #fff !important;
}
/* END*/
/*home page MAC only Hero updates*/
@media only screen and (max-width: 1083px) {
.wdg-global .surface-home .m-hero-item.f-x-left.f-mask-30 picture:after{
    background: none;
}
}
/*home disabled cta*/
.Surface_Home_Carousel_Hero_UT .Surface_Home_Carousel_Pt-1 a.surface-disabled-cta{
pointer-events: none !important;
}

/*Fr-fr Reparibilty score index.*/
.fr-fr img.mscom-image.Compare-Ratings{
    display: block;
    margin-left: 40%;
    margin-top: 18px;
}
@media only screen and (min-width: 767px) and (max-width: 1083px){
    .fr-fr img.mscom-image.Compare-Ratings{
    
    margin-left: 36%;
}
 }


/*compare en-us replica to row locales fixes*/
@media only screen and (max-width:540px){
.stickycompareImageSection li:nth-child(even).compare-device, #comparedDevices li:nth-child(even).compare-device {
padding-left:10px;
}
}

 @media only screen and (min-width: 540px) 
{
.hp-mosaic .duo-tile-position
{
    top: calc(6%);
    height: 30%;
}
}
@media only screen and (min-width: 1084px) and (max-width: 1150px)
{
.hp-mosaic .duo-tile-position
{
    top: calc(3%);
    height: 30%;
}
}
@media only screen and (min-width: 540px) and (max-width: 645px)
{
.hp-mosaic .duo-tile-position
{
    top: calc(0%);
    height: 30%;
}
}
@media only screen and (max-width: 539px){ 

.en-us .hp-mosaic .duo-539-image{
   display: none;
}
.hp-mosaic .duo-tile-position{
    padding-bottom: 0px !important;
}
.hp-mosaic li .x-type-left.surface-slg
{
    
    text-align: center!important;
}
}
@media screen and (min-width: 1084px)
{
.hp-mosaic .zoomImg {
    width: 50%;
    height: 27.74vw;
}
.hp-mosaic li.double .doublecopyclassheight
{
    
    height: 27.74vw;
}
}

@media screen and (min-width: 1921px)
{
.hp-mosaic .zoomImg {
    height: 534px;
}
.hp-mosaic li.double .doublecopyclassheight
{
     height: 534px;
    
}
}
/* END*/
.hp-mosaic ul li.surface-cee-device-disabled
{
    pointer-events: none;
    
} 

@media only screen and (min-width: 768px) {
#filterSection .fliterByText {
     display: block;
    width: 100%;
     clear: both;
}
#filterSection .fliterByText span {
     padding-bottom: 0px;
     padding-left: 0px;
}



#filterSection .sortSection .c-group{
    display: inline-block;
}
}

@media only screen and (min-width: 815px) 
{
    #filterSection .sortSection .fliterByText{
    text-align: right;
}
#filterSection .sortSection .filterdropdown{
    
    float: right;
}

}
 @media only screen and (min-width: 1400px) {
.compare-design-en-us #deviceSection .sortSection .filterdropdown
{
    margin-right:0px;
    }
}



@media only screen and (max-width: 539px)
{
.en-us .hp-mosaic .single .m-image-intro.f-align-bottom .surfaceduotitle, 
.de-de .hp-mosaic .single .m-image-intro.f-align-bottom .surfaceduotitle,
 .en-ca .hp-mosaic .single .m-image-intro.f-align-bottom .surfaceduotitle,
 .en-gb .hp-mosaic .single .m-image-intro.f-align-bottom .surfaceduotitle, 
.fr-ca .hp-mosaic .single .m-image-intro.f-align-bottom .surfaceduotitle,
 .fr-fr .hp-mosaic .single .m-image-intro.f-align-bottom .surfaceduotitle
{
padding-bottom: 0 !important;
}
}

@media only screen and (min-width:1084px) and (max-width:1245px) {

.de-de .hp-mosaic .surfaceduotitle,.fr-fr .hp-mosaic .surfaceduotitle,.fr-ca .hp-mosaic .surfaceduotitle
{
padding-top: 0px;
}

.de-de .hp-mosaic .surfaceduotitle a,.fr-fr .hp-mosaic .surfaceduotitle a,.fr-ca .hp-mosaic .surfaceduotitle a
{
padding-top: 0px;
}
}
.fr-fr .compareratingimage img
{
    width: auto !important;
    height: 44px !important;
}

.fr-fr .compareratingimage
{
    margin-top:14px;
    height: 45px;
}

.fr-fr .comparelogo{
    display: block;
    margin: 10px auto;
}

.wdg-global .compare-design-en-us .m-product-placement-item .c-price{
    display: block;
    height: auto;
}

/*@media only screen and (min-width:767px) and (max-width:1005px) {

.fr-fr .wdg-global .compare-device .m-product-placement-item .c-price
{
margin-bottom: 24px;
}
}*/


/*for business panel*/
.compare-design-en-us #deviceSection #allDeviceslist li.compare-device.compare-business-panel:not(a) {
    cursor: auto;
}
/*de-de locale font-issue*/
@media only screen and (min-width: 768px) and (max-width: 800px){  
.de-de .wdg-global .compare-design-en-us .m-product-placement-item .c-price {
    font-size: 14px;
}
.de-de .wdg-global .compare-design-en-us #deviceSection #allDeviceslist li.compare-device.compare-business-panel .c-subheading-6{
    font-size: 14px;
}
}

/*Compare New design*/

/* Removed Filterby content of comapre page from ul and adjusting the paddings as per accessiblity bug*/
#filterSection .c-chkboxfilters.c-group, #filterSection .f-wrap-items.c-group{
    margin-top: 0px !important;
}

/*CR 127225 updates start*/
.hp-mosaic #homeallDeviceslist li .c-badge.winoffer-support-copy{
    background-color:transparent;
    display:block;
    }
    @media only screen and (max-width: 539px){
    .hp-mosaic #homeallDeviceslist li .c-badge.winoffer-tag,
    .hp-mosaic #homeallDeviceslist li .c-badge.winoffer-support-copy
    {
    margin-top: 10px !important;
    }
    }
    
    @media only screen and (min-width: 1084px) and (max-width: 1400px){ 
    .hp-mosaic #homeallDeviceslist .m-image-intro.f-align-bottom > div{
        bottom:0px !important;
    }
    }
    
    #homeallDeviceslist .c-badge.f-highlight.winoffer-tag{
    white-space: normal;
    overflow:initial;
    letter-spacing: 0.05em;
    height:auto;
    }
    
    /* En-za tag 2 text visible for black background. Bug 128168*/
    @media screen and (min-width: 540px)
    {
    .en-za .hp-mosaic .single .x-type-left.surface-WhiteCTAL3 .winoffer-support-copy {
        color: #fff;
     }
    }
/*CR 127225 updates end*/




/*Surface Home Event code start */
    .home-win-offer
{
    display: flex;
    flex-direction: row;
    align-items: center;
}

.home-win-offer-text p.c-paragraph-2{
    display: inline-block;
    padding-bottom:10px;
}
/*.home-win-offer-image img.mscom-image{  
    width: 100%;
}*/

.newsp4bannercta.home-win-offer-cta a.mscom-link.c-call-to-action.c-glyph{
 margin-top: 0px;
 padding: 0px;
 display: inline-flex;
 align-items: center;
 color: #0067B8;
}
.newsp4bannercta.home-win-offer-cta .c-glyph.glyph-calendar:before{
        vertical-align: bottom;
        padding-right: 5px;
        /*padding-top: 3px;*/
}
@media only screen and (min-width: 540px) and (max-width: 940px){ 
 .home-win-offer
  {
      padding-top:15px !important;
      padding-bottom: 15px;
  }
}
@media only screen and (max-width: 539px){
     .home-win-offer
{
    flex-direction: column;
}
.newsp4bannertext.home-win-offer-text{
    padding-top: 15px;
    text-align: center !important;
}
.home-win-offer-image img.mscom-image{
    padding-bottom: 14px;
   }
.newsp4bannercta.home-win-offer-cta{
    padding-bottom: 13px;
}

}

.newsp4bannercta.home-win-offer-cta a.mscom-link.c-call-to-action.c-glyph.glyph-calendar:active{
    background: none;
}

.newsp4bannertext .newsp4bannercta.home-win-offer-cta{
    padding-top:0px;
}
/*Surface Home Event code end */

/*New design stles for filters - compare page*/
.compare-design-en-us #deviceSection #compare-devices-section {
    margin-bottom: 56px;
    float: right;
}

.compare-design-en-us .c-drawer>button.c-action-trigger, .itemsfilter .c-choice-summary{
    width: 100% !important;
    font-size: 14px;
    font-weight: 500;
    color: #000;
    position: relative;
    text-decoration: none;
    margin-top: 0;
    background: transparent !important;
    padding-left: 5px;
    padding-right: 5px;
    margin-right: 0;
}
.compare-design-en-us .itemsfilter .c-choice-summary{
    padding-left: 5px;
}
.compare-design-en-us .c-drawer-panel ul {
    padding: 0 10px 10px;
}
.compare-design-en-us .c-drawer-panel ul label.c-label {
    font-size: 12px;
}
.compare-design-en-us li.c-divider {
    border: 0;
    margin: 0;
    border-top: 1px solid rgba(0,0,0,.6);
    display: block;
    width: 100%;
}
.compare-design-en-us .c-drawer>button:hover{
    background: none;
}
.wdg-global .compare-design-en-us .c-group {
    margin-top: 0;
    /*margin-left: 5px;*/
}
#filterscreen span{
    border-bottom: 2px solid #888888;
    font-size: 16px;
    font-weight: 600;
    margin-bottom: 10px;
}

.compare-loader{
    display: none;
}
.results-out-of, .resSecLeft{
    display: inline;
}
.reults-head{
    font-size: 16px;
    font-weight: 600;
    padding-bottom: 10px;
}
.compare-design-en-us .c-menu-item .c-checkbox label.c-label{
    font-size: 15px;
    margin-top: 0;
    font-weight: 400;
    width: 100%;
}
.compare-design-en-us .c-drawer-panel li:list-child{
    padding-bottom: 10px;
}
.sortSection .c-group .c-choice-summary{
    display: block;
    width: 100%;
    margin-top: 5px;
    font-size: 16px;
    font-weight: 600;
}
.compare-design-en-us .c-action-trigger .supText{
    display: inline;
    padding: 0;
}
.sortSection{
    margin-bottom: 20px;
}
#filterSection {
    padding-left: 15px;
    padding-right: 5px;
    padding-top: 0px;
}

.compare-design-en-us .c-drawer .c-checkbox input[type=checkbox]+span:before{
    width: 15px;
    height: 15px;
}
.compare-design-en-us .c-drawer .c-checkbox span{
    line-height: 18px;
}
#filterSection{
    background-color: #FFF;
}
.compare-design-en-us .c-choice-summary{
    background: none;
}
.sortSection .c-choice-summary.filterdropdown{
    background-color: rgba(0,0,0,.1);
    cursor: pointer;
}
.c-choice-summary#sortscreen{
    background: transparent;
    /*padding-right: 0;*//*TODO*/
    margin-right: 0 !important;
    font-weight: 600;
    font-size: 16px !important;
    margin-top: 0;
}
.c-choice-summary#sortscreen span{
    padding-left: 0;
    float: right;
    padding-bottom: 2px;
    width: auto;
    min-width: auto;
    padding-right: 0;
}
.sortSection {
    margin-bottom: 20px;
    padding-left: 14px;
    /*display: flex;
    align-items: flex-end;
    justify-content: flex-end;
    flex-direction: column;
    margin-bottom: 30px;
    padding-right: 36px;*//*TODO*/
}
#sortSection .c-group.f-wrap-items[aria-labelledby="sortscreen"]{
    width: fit-content;
    margin-left: 0;
    float: none;
}
.sortSection .c-group .c-choice-summary span{
    font-size: 13px;
    font-weight: normal;
}
.sortSection .c-choice-summary > .c-menu#examplelist1{
    width: 200px;
}
#filterSection #resultsCountLeft {
    padding-right: 5px;
    border-right: 2px solid #888888;
    margin-right: 5px;
}
.compare-design-en-us .itemsfilter{
    padding-top: 15px; 
}
.compare-design-en-us .c-choice-summary a.c-action-trigger.c-glyph{
    height: auto;
}


.compare-design-en-us .c-drawer>.c-glyph.glyph-chevron-down:before{
    content: "\E710" !important;
    padding-left: 0px;
    width: auto;
    height: auto;
    font-family: MWF-MDL2;
    font-size: 9px;
    right: 0px;
    color: #000 !important;
    top: 3px;
}
.compare-design-en-us .c-drawer>.c-glyph.glyph-chevron-down.active:before{
    content: "\E738" !important;
    padding-left: 0px;
    width: auto;
    height: auto;
    font-family: MWF-MDL2;
    font-size: 9px;
    right: 0px;
    color: #000 !important;
    top: 3px;
}
#selectionsDisplay .c-choice-summary{
    background-color: rgba(0,0,0,.1);
}
#selectionsDisplay .c-choice-summary a.c-action-trigger.c-glyph{
    height: 100%;
    padding-top: 8px;
}
#compare-devices-section .selectDisplays{
    padding-left: 42px;
    padding-right: 42px;
    margin-bottom: 20px;
    padding-top: 0px;
}
#filterSection .c-choice-summary .c-action-trigger.c-glyph.glyph-chevron-down + span,
#filterSection .c-choice-summary span.filterspan
{
    padding-left: 0;
}
#filterSection .c-choice-summary .c-action-trigger.c-glyph.glyph-chevron-down {
    padding-top: 11px !important;
}
#filterSection{
    height: 430px;
}
.filter-fixed {
    position: fixed;
    top: 10px;
    width: 22.5%;
}
.filter-overflow{
    overflow: hidden;
    overflow-y: auto;
    height: 300px;
    overscroll-behavior-y : contain;
}
.filter-over-hidden{
    height: auto;
}
.filter-top{
    left: auto;
    top: 15px;
}
.noOfDevices{
    padding-left: 5px;
}
#noOfDevices {
    padding-left: 5px;
}
#filterSection .c-checkbox input[type=checkbox]:checked+span:after{
    font-size: 14px;
    line-height: 16px;
}
.compare-design-en-us .c-drawer-panel{
    display: none;
}
/*.fr-ca .compare-design-en-us .sur-taxctnt{
    display: none;
}
.fr-ca .compare-design-en-us .s2:after{
    content: "D";
}*/
/*.zh-cn .compare-design-en-us .c-badge:not(:empty) ~ .c-price
{
    visibility: hidden;
}*/
.surface-json-link{
    color: #0067b8 !important;
    font-weight: 500;
}
.surface-json-link:hover{
    text-decoration: underline;
}
@media only screen and (max-width: 480px){
    .compare-design-en-us #ResultSection a.headinglink.c-call-to-action:not(.glyph-play)>span:after{
        font-size: 14px;
    }
    .compare-design-en-us #ResultSection .m-content-placement .compare-device .m-product-placement-item a.headinglink{
        font-size: 16px;
    }
    .compare-design-en-us #ResultSection .c-badge{
        font-size: 10px;
        letter-spacing: 0;
    }
}
@media only screen and (max-width: 767px){
    li.compare-device[data-grid="col-4 pad-6x"]{
        width:100%;
    }
}

@media only screen and (max-width: 950px){    
    .compare-design-en-us #filterSection {
        padding-top: 0px !important;
        width: 100%;
        padding-left: 30px;
        padding-right: 40px;
    }
    .sortSection{
        padding-left: 30px;
        padding-right: 40px;
    }
    #filterSection{
    height: auto;
    }
    .filter-fixed{
        position: relative;
        top: 0;
        width: auto;
    }
    .filter-overflow{
    overflow: initial;
    overflow-y: initial;
    height: 300px;
    overscroll-behavior-y : none;
}
.filter-over-hidden{
    overflow: initial;
    height: auto;
}
.filter-top{
    left: auto;
    top: 0;
}
    .compare-design-en-us #filtercompareButton {
        position: relative;
        transform: translateX(-50%);
        left: 50%;
        margin-top: 0px;
        margin-bottom: 13px;
    }
    #sortSection .c-group{
        width: auto !important;
    } 
    #compare-devices-section{
        width: 100% !important;
    }
    .selectDisplaysLeft{
        padding: 15px 0 0;
        width: 100%;
        margin: 20px 0 40px;
        text-align: center !important;
    }
    .selectDisplays {
        padding-bottom: 20px;
    }
    .compare-design-en-us #filterSection{
        margin-bottom: 0;
    }
}

/*Compare New design - End*/


/* Home Page New Design */

.Surface-F21-LinkNav-Panel li:first-child {
    margin-left: 0px;
}

.Surface-F21-LinkNav-Panel li img {
    width: 40px;
    height: 40px;
    vertical-align: middle;
    float: left;
}

.Surface-F21-LinkNav-Panel li a {
    padding-top: 0px;
    margin-left: 10px;
    float: right;
}

#mainContent .Surface-F21-LinkNav-Panel .c-link-navigation ul li a.c-call-to-action {
    margin-left: 10px;
    text-align: initial;
}

#mainContent.wdg-global.surfacecom .Surface-F21-LinkNav-Panel a.c-call-to-action {
    padding: 0px;
}

@media only screen and (max-width: 768px) {
    .Surface-F21-LinkNav-Panel .c-link-navigation ul li {
        width: 50%;
        float: left;
        clear: none;
        /* top | right | bottom | left */
        padding: 10px 5px 10px 5px;
    }
    .rtl .Surface-F21-LinkNav-Panel .c-link-navigation ul li {
        width: 50%;
        float: right;
        clear: none;
        /* top | right | bottom | left */
        padding: 10px 5px 10px 5px;
    }
    .Surface-F21-LinkNav-Panel .Surface-LinkNav-Col8, .Surface-F21-LinkNav-Panel .Surface-LinkNav-Col4 {
        width: 100%
    }
    .Surface-F21-LinkNav-Panel .m-link-navigation nav.c-link-navigation {
        margin-top: 20px !important;
    }
    .rtl #mainContent.wdg-global.surfacecom .Surface-Home-Device-Family li{
         float: right;
    }
    #mainContent.wdg-global.surfacecom .Surface-Home-Device-Family li {
        width: 50%;
        padding: 5px 5px 5px 10px;
        float: left;
    }
    
    
    .Surface-F21-LinkNav-Panel .c-link-navigation ul li a {
        margin: 12px;
    }

    .Surface-Padding-12 {
        padding-left: 12px;
        padding-right: 12px;
    }
    .Surface-Home-Device-Carousel ul li .Surface-Home-Device-Carousel-sec {
        width: 350px;
    }
    .Surface-Home-Device-Carousel ul li .Surface-Home-Device-Carousel-sec img {
        width: 363px;
    }
    .Surface-Home-Device-Carousel .Surface-Home-Device-Carousel-content {
        width: 100%;
    }
}
@media only screen and (min-width: 1600px) {
    /*.Surface-F21-LinkNav-Panel .c-link-navigation ul li {
     float: left;
     width: 20%;   
    }*/
    .Surface-F21-LinkNav-Panel .c-link-navigation ul{
        display: flex;
        justify-content: space-evenly;
    }
}
@media only screen and (min-width: 1084px) and (max-width: 1599px) {
.Surface-F21-LinkNav-Panel .c-link-navigation ul li {
        width: 33.333%;      
        padding: 10px 5px 10px 5px;
        float: left;
        clear: none;
    }
    .rtl .Surface-F21-LinkNav-Panel .c-link-navigation ul li {
        width: 33.333%;      
        padding: 10px 5px 10px 5px;
        float: right;
        clear: none;
    }
}

@media only screen and (min-width: 768px) and (max-width: 1084px) {
    .Surface-F21-LinkNav-Panel .c-link-navigation ul li {
        width: 33.333%;
        /* top | right | bottom | left */
        padding: 10px 5px 10px 5px;
        float: left;
        clear: none;
    }
     .Surface-F21-LinkNav-Panel .Surface-LinkNav-Col8, .Surface-F21-LinkNav-Panel .Surface-LinkNav-Col4 {
        width: 100%
    }

    .Surface-F21-LinkNav-Panel .m-link-navigation nav.c-link-navigation {
        margin-top: 20px !important;
    }
    .Surface-LinkNav-Col4 {
        padding-left: 24px;
    }
    .Surface-Padding-24{
        padding-left: 24px !important;
        padding-right: 24px !important;
    }
    .rtl #mainContent.wdg-global.surfacecom .Surface-Home-Device-Family li{
         float: right;
    }
    #mainContent.wdg-global.surfacecom .Surface-Home-Device-Family li {
        width: 33.333%;
        padding: 5px;
        float: left;
    }
    
    .Surface-Home-Device-Carousel ul li .Surface-Home-Device-Carousel-sec,
    .Surface-Home-Device-Carousel ul li .Surface-Home-Device-Carousel-sec img {
        width: 475px;
    }
    
    .Surface-Home-Device-Carousel .Surface-Home-Device-Carousel-content {
        width: 95%;
    }
}

@media only screen and (min-width: 1084px) {

    .rtl #mainContent.wdg-global.surfacecom .Surface-Home-Device-Family li{
         float: right;
    }
    #mainContent.wdg-global.surfacecom .Surface-Home-Device-Family li {
        width: 25%;
        padding: 5px;
        float: left;
    }
  
    .Surface-Home-Device-Carousel ul li .Surface-Home-Device-Carousel-sec,
    .Surface-Home-Device-Carousel ul li .Surface-Home-Device-Carousel-sec img {
        width: 700px;
    }
     
    .Surface-Home-Device-Carousel .Surface-Home-Device-Carousel-content {
        width: 75%;
    }
    .Surface-Home-Device-Carousel ul li .Surface-Home-Device-Carousel-content #Surface-Home-iframe-button {
    /*position: absolute;*/
    margin-top: 3px;
    float: left
}
}


#mainContent.wdg-global.surfacecom .Surface-Home-Device-Family img {
   /* height: 140px;*/
    width: 100%;
}

#mainContent.wdg-global.surfacecom .Surface-Home-Device-Family h3:not(:empty) {
    padding-top: 12px;
}

#mainContent.wdg-global.surfacecom .Surface-Home-Device-Family .c-badge:empty {
    visibility: hidden;
    display: block;
    margin-bottom: 3px;
}

#mainContent.wdg-global.surfacecom .Surface-Home-Device-Family .c-badge {
    margin-top: 5px;
}
.rtl #mainContent.wdg-global.surfacecom .Surface-Home-Device-Family a.c-call-to-action{
    text-align: right;
}
.rtl #mainContent.wdg-global.surfacecom .Surface-Home-Device-Family a.c-call-to-action:focus{
    padding-right: 5px;
}
#mainContent.wdg-global.surfacecom .Surface-Home-Device-Family a.c-call-to-action {
    padding-left: 0px;
    margin-right: 0px;
    padding-right: 0px;
    text-align: left;    
    
}
  /* :not(.en-us) #mainContent.wdg-global.surfacecom .Surface-Home-Device-Family .homeallDeviceslist a.c-call-to-action.seeallcta 
   {
         display: none;
   }*/
  
#mainContent.wdg-global.surfacecom .Surface-Home-Device-Family .homeallDeviceslist:not(:nth-child(-n+4)) a.c-call-to-action.seeallcta
{
    display: none;
}
  
.msw-page:not(.en-us) #mainContent.wdg-global.surfacecom .Surface-Home-Device-Family .homeallDeviceslist a.c-call-to-action.seeallcta 
   {
         display: none;
   }
@media only screen and (max-width: 1083px) {
    #mainContent.wdg-global.surfacecom .Surface-Home-Device-Family .homeallDeviceslist:not(:nth-child(-n+3)) a.c-call-to-action.seeallcta
{
    display: none;
}
 .msw-page:not(.en-us) #mainContent.wdg-global.surfacecom .Surface-Home-Device-Family .homeallDeviceslist a.c-call-to-action.seeallcta 
   {
         display: none;
   }
}
@media only screen and (max-width: 767px) {
    #mainContent.wdg-global.surfacecom .Surface-Home-Device-Family .homeallDeviceslist:not(:nth-child(-n+2)) a.c-call-to-action.seeallcta
{
    display: none;
}
 .msw-page:not(.en-us) #mainContent.wdg-global.surfacecom .Surface-Home-Device-Family .homeallDeviceslist a.c-call-to-action.seeallcta 
   {
         display: none;
   }
}
.Surface-F21-LinkNav-Panel li {
    display: flex !important;
    align-items: center;
    /*margin-right: 10px;*/
}
.rtl .Surface-F21-LinkNav-Panel li {
    display: flex !important;
    align-items: center;
    /*justify-content: flex-end;*/
}
.Surface-Home-Device-Carousel ul li {
    padding-right: 20px;
}

.surface-home .Surface-Home-Device-Carousel .Surface-Home-Device-Carousel-sec .Surface-Home-Device-Carousel-content a.c-call-to-action:focus:not(.x-hidden-focus):not(.wdg-f-blue-button) {
    background: none;
}

.surface-home .Surface-Home-Device-Carousel {
    padding-right: 0px;
}

.Surface-Home-Device-Carousel button.f-previous {
    left: 5% !important;
    border-radius: 50%;
    width: 44px;
    height: 44px;
    /*top: 38%;
    -ms-transform: translateY(-38%);
    transform: translateY(-38%);*/
    background: #fafafa;
    border: 1px solid transparent;
}

.Surface-Home-Device-Carousel button.f-next {
    right: 5% !important;
    border-radius: 50%;
    width: 44px;
    height: 44px;
    /*top: 38%;*/
    /*-ms-transform: translateY(-38%);
    transform: translateY(-38%);*/
    background: #fafafa;
    border: 1px solid transparent;
}

.Surface-Home-Device-Carousel .Surface-Home-Device-Carousel-content a {
    padding-left: 0px !important;
}


.IE11 #mainContent.wdg-global.surfacecom .Surface-F21-LinkNav-Panel a:not(.glyph-play).c-call-to-action>span::after,
.IE11 #mainContent.wdg-global.surfacecom .Surface-Home-Device-Family a:not(.glyph-play).c-call-to-action>span::after
    {
    background-color: transparent;
    font-size: 11px;
}

.Surface-F21-LinkNav-Panel .m-content-placement>div {
    display: flex;
    align-items: center;
    flex-wrap: wrap;
}

.Surface-F21-LinkNav-Panel .m-link-navigation nav.c-link-navigation {
    margin-top: 0px;
}

.Surface-F21-Hero-Panel picture>img {
    width: 100%;
}

.Surface-F21-Hero-Panel .Hero-Panel-Image-text {
    width: 60%;
    margin: 0% auto;
    text-align: center;
    padding-bottom: 10px;
}

.Surface-Home-Device-Family #Surface-Home-Device-Family-devices li .m-channel-placement-item {
    background: #f3f3f3;
    padding-left: 12px;
    padding-right: 12px;
    padding-top: 12px;
    padding-bottom: 20px;
}

.Surface-F21-LinkNav-Panel .m-content-placement {
    padding-left: 0px;
    padding-right: 0px;
}

#mainContent.wdg-global.surfacecom .Surface-Home-Device-Family h3 {
    margin-bottom: 12px;
   /* float: left;
    padding-right: 20px;*/
}
  @media only screen and (min-width: 1083px){
.en-us #mainContent.wdg-global.surfacecom .Surface-Home-Device-Family h3.PCs
{
    float: left;
    padding-right: 20px;
}
  }
  

/*#mainContent.wdg-global.surfacecom .Surface-Home-Device-Family .homeallDeviceslist.custom-container h3
{
    float: none; 
    padding-right: 0px;
    margin-bottom: 0px;
}*/
/*.i-frame-document {
    height: 100%;
}*/

.Surface-Home-Device-Carousel ul li .Surface-Home-Device-Carousel-content #Surface-Home-iframe-button {
    /*position: absolute;*/
    margin-top: 3px;
    /*float: left*/
    display: block;
    text-align:left;
}


/*.i-frame-video-class {
    height: 100%;
    min-width: 296px;
    max-width: 1066px;
    top: 50%;
    position: absolute;
    left: 50%;
    width: 100%;
    border: 1px solid white;
    -webkit-transform: translate(-50%, calc(-50% - calc(1px/2)));
    transform: translate(-50%, -50%);
    border: 0px;
}*/


/*.i-Frame-Dialog-Box-Class {
    height: 100% !important;
    max-width: 100% !important;
    border: none !important;
    background: rgba(0, 0, 0, .9) !important;
}*/


.Surface-Home-Device-Carousel .Surface-Home-Device-Carousel-content h3, .Surface-Home-Device-Carousel .Surface-Home-Device-Carousel-content p {
    white-space: pre-wrap;
    padding: 0px;
}
/*.iframe-dialog {
    height: 100% !important;
}*/


.Home-Pop-up-c-dialog#default-lightbox-preview [role=dialog] [role=document] {
    height: 100% !important;
    overflow-y: hidden;
    padding-bottom: 0% !important;
}

.Surface-Home-Device-Family .c-badge.grey
{
background: #bab9b9;
}
.Surface-Home-Device-Carousel ul li .Surface-Home-Device-Carousel-content #Surface-Home-iframe-button:after{
    margin-top: 3px;
    color: #0067b8;
}
.Surface-Home-Device-Carousel ul li .Surface-Home-Device-Carousel-content #Surface-Home-iframe-button:hover:after{
    /*margin-left: 5px;*/
    right: -3px !important;
}

 .Surface-Home-Device-Carousel-content a:focus{
    margin-left: 1px;
}
/*New design stles for filters - compare page*/
.compare-design-en-us li.compare-device p.c-subheading-5 span{
    white-space: nowrap;
}


/*windows 11 Module*/
        .Home-Windows11-Panel
    {
        display: flex;
        flex-direction: row;
        align-items: center;
    }
    
     .Home-Windows11-Panel-text p.c-paragraph-2{
        display: inline-block;
        padding-bottom:10px;
    }
    .Home-Windows11-Panel-image img.mscom-image{  
        max-width: 100%;
    }

  .newsp4bannercta.Home-Windows11-Panel-cta a.mscom-link.c-call-to-action.c-glyph{
     margin-top: 0px;
     padding: 0px;
     /*color: #000;*/
     display: inline-flex;
     align-items: center;
    }
    .newsp4bannercta.Home-Windows11-Panel-cta .c-glyph.glyph-calendar:before{
            /*vertical-align: bottom;*/
            padding-right: 5px;
    }
    @media only screen and (min-width: 540px) and (max-width: 940px){ 
     .Home-Windows11-Panel
      {
          padding-top:15px !important;
          padding-bottom: 15px;
      }
    }
    
    @media only screen and (max-width: 539px){
       .Home-Windows11-Panel
    {
        flex-direction: column;
    }
    .newsp4bannertext.Home-Windows11-Panel-text{
        padding-top: 15px;
        text-align: center !important;
    }
    .Home-Windows11-Panel-image img.mscom-image{
        padding-bottom: 14px;
       }
    .newsp4bannercta.Home-Windows11-Panel-cta{
        padding-bottom: 13px;
    }
    .Surface-F21-Hero-Panel .Hero-Panel-Image-text{
      width:80%;
    }
    }
    
    .newsp4bannertext .newsp4bannercta.Home-Windows11-Panel-cta{
        padding-top:0px;
    }
    .newsp4bannertext .newsp4bannercta.Home-Windows11-Panel-cta a:hover{
        color: #0067b8;
    }

 @media only screen and (min-width: 1084px){
    .surface-home .home-windows-11-banner{
        padding-bottom: 48px;
    }
    }
    @media only screen and (min-width: 300px) and (max-width: 767px){
    .surface-home .home-windows-11-banner{
        padding-bottom: 60px;
        padding-top:0px;
    }
    }
    /*.Surface-Home-Device-Family a.c-call-to-action{
        text-transform: inherit;
    }*/
    @media only screen and (max-width: 767px){
    .Home-Pop-up-c-dialog [role=dialog]{
        padding: 0% !important;
    }
    }
    
    .Surface-Home-Device-Carousel button.f-next,
.Surface-Home-Device-Carousel button.f-previous{
border: 2px solid black;
}

.Surface-Home-Device-Carousel button.f-next::before,
.Surface-Home-Device-Carousel button.f-previous::before{
color: black;
}

.newsp4bannercta.Home-Windows11-Panel-cta a.mscom-link.c-call-to-action.c-glyph:focus,
.newsp4bannercta.Home-Windows11-Panel-cta a.mscom-link.c-call-to-action.c-glyph:active{
    color: #0067b8;
}
@media only screen and (min-width:768px) and (max-width:1084px) {
.rtl .Surface-F21-LinkNav-Panel li
{
    float: right !important;
}
}
/* device-family float issue 136711, 140963 Start*/
@media only screen and (max-width:767px) {
.Surface-Home-Device-Family #Surface-Home-Device-Family-devices li:nth-child(2n+1)
{
    clear: both;
}
}

@media only screen and (min-width:768px) and (max-width:1083px) {
.Surface-Home-Device-Family #Surface-Home-Device-Family-devices li:nth-child(3n+1)
{
    clear: both;
}
}

@media only screen and (min-width:1084px) {
.Surface-Home-Device-Family #Surface-Home-Device-Family-devices li:nth-child(4n+1)
{
    clear: both;
}
}
/* device-family float issue 136711, 140963 End*/

/*.surface-home .surface-section-footnotes{
    display: none;
}
.zh-cn .surface-home .surface-section-footnotes{
 display: block;   
}*/
/*Home New design - End*/

 /*Accessibility bug fix*/
@media screen and (-ms-high-contrast: active) { 
  .compare-design-en-us .itemsfilter .c-checkbox input[type=checkbox]:disabled+span{
      color:Graytext;
}    
  .compare-design-en-us .itemsfilter .c-checkbox input[type=checkbox]:disabled+span:before{
      border-color:Graytext;
}    
}   

.Surface-F21-Hero-Panel .Hero-Panel-Image-text .shop-deals{
    display: none;
}

/*Home Page windows 11 tag update*/

.Surface-Home-Device-Family #Surface-Home-Device-Family-devices li .Win_11_tag{
    display: inline-block;
    /*white-space: normal;*/
}
.Surface-Home-Device-Family #Surface-Home-Device-Family-devices li .Win_11_tag strong{
display: inline;
    white-space: normal;
}

.rtl #Surface-Home-Device-Family-devices .c-channel-placement-content .Win_11_tag .c-badge{
padding-bottom: 6px;
}

/*END Home Page windows 11 tag update*/

/*Start CR : 136099*/
 .compare-design-en-us  .stickycompareImageSection.stickyFixed img ,
 .compare-design-en-us  .stickycompareImageSection.stickyFixed picture {
    display: none;
}

.fr-fr .compare-design-en-us .stickycompareImageSection.stickyFixed .compareratingimage img
{
    display: inline;
}
.wdg-global .compare-design-en-us .m-product-placement-item .c-price,
.compare-design-en-us #deviceSection li.compare-device .c-heading-4{
    padding-top: 0px;
}
#ResultSection .imagesectiontable .m-product-placement-item .c-price{
    margin-top: 0px;
}
#ResultSection .imagesectiontable .m-product-placement-item .c-heading-4{
    margin-top: 0px;
    margin-bottom: 0PX;
}
#ResultSection .imagesectiontable #stickycomparedDevices .m-product-placement-item .c-heading-4{
    margin-top: 5px !important;
}
.compare-design-en-us li.compare-device .c-badge{
    display: inline;
    white-space:normal;
   
}
.compare-design-en-us .compare-device .windows-badge{
    display: inline-block;
    margin-top: 12px;
}
@media only screen and (max-width:539px) {
.compare-design-en-us .compareImageSection .compare-device .windows-badge{
    margin-bottom: 12px;
}

}
/*CR : 136099 code END*/
/*Accessibility bug 131980*/
.Home-Pop-up-c-dialog.c-dialog.f-lightbox{
    position: fixed;
    top: 0;
    left: 0;
    height: 100%;
    width: 100%;
    z-index: 800;
}
.Home-Pop-up-c-dialog.c-dialog.f-lightbox [role=dialog]{
    position: relative;
    left: 0%;
    top: 0%;
    -ms-transform: none;
    -webkit-transform: none;
    transform: none;
    -webkit-transform: none;
    -ms-transform: none;
    max-width: 100%;
    height: 100% !important;
    width: 100%;
    margin: 0;
    max-height: 100%;
    background: transparent;
    overflow: visible !important;
}
.Home-Pop-up-c-dialog.c-dialog.f-lightbox [role=dialog] button.c-glyph {
    z-index: 1111;
    top: 10px;
}
.Home-Pop-up-c-dialog.c-dialog.f-lightbox [role=dialog] button.c-glyph:before{
    margin:0 0 20px 0;
}
.Home-Pop-up-c-dialog.c-dialog.f-lightbox [role=dialog] button.c-glyph {
    padding: 0;
    background: 0 0;
    border: 0;
    width: 36px;
    height: 36px;
}


.Home-Pop-up-c-dialog.c-dialog.f-lightbox [role=dialog] .c-glyph {
    position: fixed;
    right: 24px;
    color: rgba(255,255,255,.6);
    font-size: 36px;
}
.Home-Pop-up-c-dialog.c-dialog.f-lightbox [role=dialog] .surface-home-player-wrapper{
    overflow: hidden;
    position: fixed;
    display: block;
    left: 50%;
    top: 50%;
    max-height: 760px;
    min-width: 296px;
    width: 100%;
    margin: 0 auto;
    max-width: 1066px;
    padding: 0;
    height: auto;
    -webkit-transform: translate(-50%,-50%);
    -ms-transform: translate(-50%,-50%);
    -webkit-transform: translate(-50%,-50%);
    transform: translate(-50%,-50%);
    -webkit-transform: translate(-50%,calc(-50% - calc(1px/2)));
}
/*End*/

#Surface-Home-Device-Family-devices .custom-container {
	width: 100% !important
}

#Surface-Home-Device-Family-devices .custom-container.showRW {
	width: 50% !important
}

.custom-container .Device-Type.c-heading-6.All-in-One {
	visibility: hidden
}
.custom-container h3{
    visibility: hidden
}
.custom-container>div {
	background-color: #f1f1f1;
	display: flex;
	justify-content: space-around;
	align-items: center;
	padding: 20px 0px;
	overflow: hidden
}

.custom-container-left {
	width: 50%
}

.custom-container-right>h1 {
	font-size: 15px;
	padding: 10px 20px 10px 0px;
	font-weight: 600
}

.custom-container-right {
	display: flex;
	flex-direction: column
}

.custom-container-right>div {
	display: flex;
	flex-direction: column
}

@media (min-width: 1084px) {
	#Surface-Home-Device-Family-devices .custom-container {
		width: 75% !important
	}
}

@media (max-width: 767.2px) {
	.custom-container-right {
		height: 100%;
		display: flex;
		justify-content: space-between
	}

	.custom-container-right>h1 {
		font-size: 15px;
		padding: 0px !important
	}

	.custom-container-right a {
		border: none
	}

	.custom-container-left {
		display: none
	}

	#Surface-Home-Device-Family-devices .custom-container {
		width: 50% !important
	}

	.custom-container>div {
		display: flex;
		flex-direction: column;
		padding: 12px 12px 20px 12px
	}
}

@media (max-width: 767.2px) and (min-width: 500px) {
	.custom-container-right>h1 {
		margin-top: 60px
	}
}

@media (max-width: 400px) {
	.custom-container-right>h1 {
		font-size: 14px !important;
		height: 50%
	}

	.custom-container-right a {
		padding: 0 !important;
		height: 50%
	}

	.custom-container-right>div {
		height: 64% !important
	}
}

@media (max-width: 320px) {
	.custom-container-right {
		align-items: flex-start;
		padding-top: 0px;
		height: 100%
	}

	.custom-container-right>div a {
		font-size: 13px;
		height: 50px !important
	}
}

@media(max-width:550px) and (min-width:499.4px) {
	.custom-container-right a {
		height: auto !important;
	}
}

@media(max-width:330px) and (min-width:320px) {
	.custom-container-right a {
		font-size: 13px !important;
	}
}

/*Home page CEE locales superscript functionality for disabled tiles */
.bg-bg .Surface-Home-Device-Family sup,
.et-ee .Surface-Home-Device-Family sup,
.hr-hr .Surface-Home-Device-Family sup,
.lt-lt .Surface-Home-Device-Family sup,
.lv-lv .Surface-Home-Device-Family sup,
.sl-si .Surface-Home-Device-Family sup{
    pointer-events: auto;
}
/*home device carousel upadtes for CR: 140147*/
.Surface-Home-Device-Carousel .c-group
{
    margin-top:0px;
}
.Surface-Home-Device-Carousel ul li .Surface-Home-Device-Carousel-content .Surface-Home-iframe-button{
    margin-top: 0px;
}
.Surface-Home-Device-Carousel ul li .Surface-Home-Device-Carousel-content .Surface-Home-iframe-button:after{
    margin-top: 3px;
    color: #0067b8;
}
.Surface-Home-Device-Carousel ul li .Surface-Home-Device-Carousel-content .Surface-Home-iframe-button:hover:after{
    /*margin-left: 5px;*/
    right: -3px !important;
}

/*CR 140929 price hiding issue start*/
/*.zh-cn #allDeviceslist .compare-device .compare-device-placement .c-price span[content='0'],
.zh-cn .compareImageSection .compare-device-placement .c-price span[content='0'],
.zh-cn .stickycompareImageSection .compare-device-placement .c-price span[content='0']
{
visibility: hidden;
}*/
/*CR 140929 price hiding issue end*/

.surface-home-devicecarouselrow .m-content-placement-item .Surface-Home-iframe-button:after{
    margin-top: 3px;
    color: #0067b8;
}
.surface-home-devicecarouselrow .m-content-placement-item .Surface-Home-iframe-button:hover:after{
    /*margin-left: 5px;*/
    right: -3px !important;
}

.surface-home-devicecarouselrow .m-content-placement-item 
{    
    pointer-events: auto;
}

.surface-home-devicecarouselrow .m-content-placement-item.f-precise-click:hover>div>.c-call-to-action span
{
    text-decoration: none ;
}
.surface-home-devicecarouselrow .m-content-placement-item  button.Surface-Home-iframe-button
{
    
    padding-bottom: 18px;
}

.surface-home-devicecarouselrow .m-content-placement-item h3.c-heading
{
    padding-top: 20px !important;
}

/*CTA fix for home video 2 up*/

.surface-home-devicecarouselrow a.surface-secondary-cta {
    padding-left: 0px !important;
}

/*Compare redesign Result Start*/
.compare-design-en-us .compare-techspec .m-system-requirements table tbody tr img{
    width:30px;
}

.compare-design-en-us .compare-techspec .m-system-requirements .c-table table tbody.table-highlights tr,
.compare-design-en-us .compare-techspec .m-system-requirements .c-table table tbody.table-performance tr,
.compare-design-en-us .compare-techspec .m-system-requirements .c-table table tbody.table-input tr,
.compare-design-en-us #TechSpecsTable.compare-techspec .m-system-requirements .c-table table tbody.table-highlights tr:last-child,
.compare-design-en-us #TechSpecsTable.compare-techspec .m-system-requirements .c-table table tbody.table-performance tr:last-child,
.compare-design-en-us #TechSpecsTable.compare-techspec .m-system-requirements .c-table table tbody.table-input tr:last-child{
    border-bottom:none !important;
}

.compare-design-en-us .compare-techspec .m-system-requirements .c-table table tbody.table-highlights tr td{
    position: relative;
}

.compare-design-en-us .compare-techspec .m-system-requirements .c-table table tbody.table-highlights tr td img{
    position: absolute;
    left:0;
    top: 50%;
  -ms-transform: translateY(-50%);
  transform: translateY(-50%);
  display: none;
} 

.compare-design-en-us .compare-techspec .m-system-requirements .c-table table tbody.table-highlights tr td span,
.compare-design-en-us .compare-techspec .m-system-requirements .c-table table tbody.table-performance tr td span,
.compare-design-en-us .compare-techspec .m-system-requirements .c-table table tbody.table-input tr td span{
    display: block;
}

.compare-design-en-us .compare-techspec .m-system-requirements .c-table table tbody.table-highlights tr td span.hgltstablerow
{
    display: inline-block;
    vertical-align: middle;
}


.compare-design-en-us .compare-techspec .m-system-requirements .c-table table tbody.table-highlights tr td span .c-hyperlink.supBLink,
.compare-design-en-us .compare-techspec .m-system-requirements .c-table table tbody.table-highlights tr td span .c-hyperlink.supBLink span,
.compare-design-en-us .compare-techspec .m-system-requirements .c-table table tbody.table-input tr td span .c-hyperlink.supBLink,
.compare-design-en-us .compare-techspec .m-system-requirements .c-table table tbody.table-input tr td span .c-hyperlink.supBLink span,
.compare-design-en-us .compare-techspec .m-system-requirements .c-table table tbody.table-performance tr td span .c-hyperlink.supBLink,
.compare-design-en-us .compare-techspec .m-system-requirements .c-table table tbody.table-performance tr td span .c-hyperlink.supBLink span{
    display: inline !important;
}

.compare-design-en-us .compare-techspec .m-system-requirements .c-table table tbody.table-highlights td,
.compare-design-en-us .compare-techspec .m-system-requirements .c-table table tbody.table-performance td,
.compare-design-en-us .compare-techspec .m-system-requirements .c-table table tbody.table-input td
{
    text-align: center;
    vertical-align: middle;
}
.compare-design-en-us .compare-techspec .m-system-requirements .c-table table tbody.table-highlights tr td .c-caption-2,
.compare-design-en-us .compare-techspec .m-system-requirements .c-table table tbody.table-performance tr td .c-caption-2,
.compare-design-en-us .compare-techspec .m-system-requirements .c-table table tbody.table-input tr td .c-caption-2
{
    font-size: 15px;
}
@media(max-width:540px){
.compare-design-en-us .hgltstablerow span.c-caption-2.hgltspara{
    line-height: 20px;
}
}
.compare-design-en-us .compare-techspec .m-system-requirements .c-table table#inputs 
{
    display: none;
}

.compare-design-en-us .compare-techspec .m-system-requirements .c-table table tbody.table-input .input1>span,
.compare-design-en-us .compare-techspec .m-system-requirements .c-table table tbody.table-input .input2>span,
.compare-design-en-us .compare-techspec .m-system-requirements .c-table table tbody.table-input .input3>span{
    display: inline-block !important;
    padding-right:15px;
}

.compare-design-en-us .rowhighlights,
.compare-design-en-us .rowperformance{
    font-weight:600;
}

.compare-design-en-us .compare-techspec .m-system-requirements .c-table table .hgltsCaption:empty,
.compare-design-en-us .compare-techspec .m-system-requirements .c-table table .prfmcCaption:empty{
visibility: hidden;
height: 16px;
}

.compare-design-en-us .compare-techspec .m-system-requirements .c-table table tbody.table-highlights tr[data-hglts='DeviceBattery'] .rowhighlights,
.compare-design-en-us .compare-techspec .m-system-requirements .c-table table tbody.table-highlights tr[data-hglts='DeviceSize'] .rowhighlights,
.compare-design-en-us .compare-techspec .m-system-requirements .c-table table tbody.table-highlights tr[data-hglts='DeviceDisplay'] .rowhighlights,
.compare-design-en-us .compare-techspec .m-system-requirements .c-table table tbody.table-highlights tr[data-hglts='DeviceWeight'] .rowhighlights,
.compare-design-en-us .compare-techspec .m-system-requirements .c-table table tbody.table-performance tr[data-prfmc='Memory'] .rowperformance,
.compare-design-en-us .compare-techspec .m-system-requirements .c-table table tbody.table-performance tr[data-prfmc='Storage'] .rowperformance{
    font-size: 36px;
}


@media(max-width:540px){
    .compare-design-en-us .compare-techspec .m-system-requirements .c-table table tbody.table-highlights tr td img,
    .compare-design-en-us .compare-techspec .m-system-requirements .c-table table tbody.table-input tr td img,
    .compare-design-en-us .compare-techspec .m-system-requirements .c-table table.surface-compare-prfmc{
        display:none !important;
    }
    
    .compare-design-en-us .compare-techspec .m-system-requirements .c-table table tbody.table-input .input1>span,
    .compare-design-en-us .compare-techspec .m-system-requirements .c-table table tbody.table-input .input2>span,
    .compare-design-en-us .compare-techspec .m-system-requirements .c-table table tbody.table-input .input3>span{
    display: block !important;
}
.compare-design-en-us .compare-techspec .m-system-requirements .c-table table tbody.table-input .c-caption-2{
        font-size: 15px !important;
        line-height: normal !important;
        font-weight:600 !important;
}
.compare-design-en-us .compare-techspec .m-system-requirements .c-table table tbody.table-highlights tr[data-hglts='DeviceBattery'] .rowhighlights,
.compare-design-en-us .compare-techspec .m-system-requirements .c-table table tbody.table-highlights tr[data-hglts='DeviceSize'] .rowhighlights,
.compare-design-en-us .compare-techspec .m-system-requirements .c-table table tbody.table-highlights tr[data-hglts='DeviceDisplay'] .rowhighlights,
.compare-design-en-us .compare-techspec .m-system-requirements .c-table table tbody.table-highlights tr[data-hglts='DeviceWeight'] .rowhighlights,
.compare-design-en-us .compare-techspec .m-system-requirements .c-table table tbody.table-performance tr[data-prfmc='Memory'] .rowperformance,
.compare-design-en-us .compare-techspec .m-system-requirements .c-table table tbody.table-performance tr[data-prfmc='Storage'] .rowperformance{
    font-size: 28px;
}
}

/*Tech specs table hide & show start*/
.compare-design-en-us #TechSpecsTable .m-system-requirements .specs-expansion .c-action-toggle
{
font-weight: 700;
font-size: 25px;
color: #171717;
padding-left: 5px;
}
.compare-design-en-us #TechSpecsTable .m-system-requirements .specs-expansion .c-action-toggle:active,
.compare-design-en-us #TechSpecsTable .m-system-requirements .specs-expansion .c-action-toggle:hover,
.compare-design-en-us #TechSpecsTable .m-system-requirements .specs-expansion .c-action-toggle:focus{
background: none;
}
.compare-design-en-us #TechSpecsTable .m-system-requirements .specs-expansion .c-action-toggle:before{
margin-left: auto !important;
margin-right: 24px;
}
.compare-design-en-us #TechSpecsTable .m-system-requirements table.specs-expansion tbody
{
    display: none;
}
/*Tech specs table hide & show end*/

/*------END Compare redesign Resul-----*/

/*------new Surface Compare filter categories-----*/
#filterSection .itemsfilter ul li.pricefilter,
#filterSection .itemsfilter ul li.pricedevider,
#filterSection .itemsfilter ul li.usecasefilter,
#filterSection .itemsfilter ul li.usecasedevider{
    display: none;
}
/*------END filter categories-----*/

/*CR: 140147 two up video pop up video text to uppercase START*/
.de-de .surface-home-devicecarouselrow .m-content-placement-item button.Surface-Home-iframe-button {
    text-transform: uppercase;
    text-align: left;
}
/*CR: 140147 two up video pop up video text to uppercase END*/



/* Compare result Drop down Sticky Start */

/*.en-us .compare-pagesticky nav.c-in-page-navigation.compare-dropdown.f-dropdown{
    visibility:visible;
    display: inline-block;
}
.en-us .compare-pagenav .compare-dropdown ul{
    margin-left: 0 !important;
}
.en-us.compare-pagesticky .compare-dropdown .compare-dropdown-menu{
    background-color: #ffffff;
}
.en-us .compare-pagesticky .compare-dropdown .compare-dropdown-menu a.compare-dropdown-link{
    font-size: 28px;
    font-weight: 600;
}
.en-us .compare-pagesticky .compare-dropdown .compare-dropdown-menu a.compare-dropdown-link:after{
    right: 0;
    padding-top: 14px;
    font-size: 18px;
}
.en-us .compare-dropdown .compare-dropdown-menu ul.compare-list{
    padding-left: 20px;
    }
.en-us .compare-dropdown .compare-dropdown-menu ul li a{
    font-size: 18px;
    font-weight: 600;
    line-height: 40px;
    }*/
    
    /* Compare result Drop down Sticky END */
    
    /*CR 144794 sup font weight & toggle button update start*/
.Surface-F21-Hero-Panel .Hero-Panel-Image-text.sustain-supscrpt .c-subheading-2 .supText {
   font-weight:400;
   }
   /*.Surface-F21-Hero-Panel .Hero-Panel-Image-text.sustain-supscrpt .videobutton.c-call-to-action.c-glyph,
   .Surface-F21-Hero-Panel .Hero-Panel-Image-text.sustain-supscrpt .videobutton.c-call-to-action.c-glyph:focus{
       border: 1px solid #ffffff;
        width: 40px;
        height: 40px;
        background: transparent;
        border-radius: 100%;
        position: absolute;
        margin: 0;
        padding: 0;
        color: #ffffff !important;
        margin-left: 4px;
        margin-top: 0px;
   }
   .Surface-F21-Hero-Panel .Hero-Panel-Image-text.sustain-supscrpt .videobutton.c-call-to-action.c-glyph.bottom-right,
   .Surface-F21-Hero-Panel .Hero-Panel-Image-text.sustain-supscrpt .videobutton.c-call-to-action.c-glyph.bottom-right:focus{
       right: auto;
       bottom: 15px;
       left: 15px;
       top: auto;
   }*/
  .Surface-F21-Hero-Panel .video-btn-sustain {
  position: absolute;
}


.Surface-F21-Hero-Panel .video-btn-sustain.top-left {
  right: 30px;
    top: 17px;
  z-index: 1;
}

@media only screen and (max-width:1084px) {
    .Surface-F21-Hero-Panel .video-btn-sustain.top-left {
         right: 21px;
      top: 17px;
       /*  z-index: 1;*/
        
    }
}
@media only screen and (max-width:767px) {
    .Surface-F21-Hero-Panel .video-btn-sustain.top-left {
       right: 17px;
    top: 17px;
       /*  z-index: 1;*/
    }
}


.Surface-F21-Hero-Panel .video-btn-sustain .videobutton.c-action-toggle.c-glyph {
  border: 2px solid #171717;
  width: 55px;
  height: 55px;
  background: transparent;
  border-radius: 50%;
  position: relative;
  margin: 0;
  padding: 0;
  overflow: initial;
}

.Surface-F21-Hero-Panel .video-btn-sustain .videobutton.c-action-toggle.c-glyph:focus {
  border: 2px dashed #171717;
  outline-color: transparent;
}

.Surface-F21-Hero-Panel .video-btn-sustain .videobutton.c-action-toggle.c-glyph:before {
  color: #171717;
  margin-left: 10px;
  margin-top: 0px;
}

.Surface-F21-Hero-Panel .video-btn-sustain .videobutton.c-action-toggle.c-glyph:after {
  border: none;
}

   /*CR 144794 sup font weight & toggle button update end*/
   
    /* compare Sticky Box functionality CSS start */
.compare-design-en-us section#fixed-bar .f-default-image.p2-image.hide {
    display: block !important;
}

.compare-design-en-us #fixed-bar {
    position: fixed;
    bottom: -1px;
    background: #2f2f2f;
    z-index: 1;
    width: 100%;
    left: 50%;
    -ms-transform: translateX(-50%);
    transform: translateX(-50%);
}

.compare-design-en-us #fixed-bar a#clear-selections span:not(.glyph-play)::after {
    display: none;
}
.compare-design-en-us #fixed-bar a#clear-selections.c-call-to-action.c-glyph:after{
    content: "\E711";
    display: inline-block;
    margin-top: 3px;
}


.compare-design-en-us #fixed-bar a#compare-button span:not(.glyph-play):after {
    color: #fff;
    display: none;
}
.compare-design-en-us #fixed-bar a#compare-button{
    border-radius: 6px;
    background-color: #0067b8;
}
.compare-design-en-us #fixed-bar .compare-items-block .compare-button-tile .compare-product-button a#compare-button.c-call-to-action:focus:not(.x-hidden-focus) span,
.compare-design-en-us #fixed-bar .compare-items-block .compare-button-tile .compare-product-button  a#compare-button.c-call-to-action:hover span,
.compare-design-en-us #fixed-bar .compare-items-block .compare-button-tile .compare-product-button a#clear-selections span{
    text-decoration: underline !important;
}
.compare-design-en-us .m-content-placement.compare-items-block {
    max-width: inherit;
}

/*.compare-product-item img {
    width: 70% !important;
    padding-top: 0;
    padding-bottom: 0;
    margin: auto;
}*/

.compare-design-en-us .closeCompareitem {
    top: 0;
    right: 0;
    position: absolute;
}

.compare-design-en-us .compare-product-button h3, .compare-product-button a {
    color: #ffffff;
}

.compare-design-en-us #fixed-bar a.c-call-to-action.wdg-f-blue-button:after {
    content: "";
}

.compare-design-en-us .m-content-placement-item.compare-product-button p.c-group #clear-selections {
    padding-left: 0;
    margin-right: 0px;
}

.compare-design-en-us #clear-selections {
    color: #ffffff;
}

.compare-design-en-us #fixed-bar .compare-button-tile[data-grid="col-3"] {
    background: none !important;
    height: auto !important;
    width: 34%;
    margin-right: 0;
}

.compare-design-en-us #fixed-bar .compare-items-block .closeCompareitem.c-glyph:before {
    content: "\E711";
    font-size: 13px;
    font-weight: 900;
}

.compare-design-en-us .cmprselcnlink {
    color: #005da6 !important;
    clear: left;
    text-transform: uppercase;
    text-decoration: underline !important;
    margin-top: 15px;
    margin-right: 20px;
}

.compare-design-en-us .cmprselcnlink:focus {
    outline: #000 dashed 1px;
}

@media screen and (min-width: 1084px) and (max-width: 1337px) {
    .compare-design-en-us .cmprselcnlink {
        padding-top:1px;
    }
}

.compare-design-en-us #fixed-bar .compare-items-block > div {
    display: flex;
    display: -webkit-flex;
}

.compare-design-en-us #fixed-bar .compare-items-block div div:last-child {
    margin-left: auto;
    order: 2;
}

.compare-design-en-us #fixed-bar .m-content-placement-item {
    margin-top: 15px;
    cursor: inherit;
}

.compare-design-en-us #fixed-bar .compare-button-tile .m-content-placement-item.compare-product-button a:hover, .pricespider.cta [data-bi-name="buy now"]:hover {
    text-decoration: underline !important;
}

.compare-design-en-us #fixed-bar [data-grid="col-3"]:hover {
    border-bottom: 4px solid #005da6;
}

.compare-design-en-us #fixed-bar .m-content-placement-item h4 {
    font-size: 18px;
    font-weight: 400;
}

.compare-design-en-us #fixed-bar .compare-button-tile[data-grid="col-3"]:hover {
    border-bottom: none;
}

.compare-design-en-us #fixed-bar a.c-call-to-action:not(.glyph-play):after {
    content: "\E711";
}

.compare-design-en-us #fixed-bar h3.c-heading-6 {
    padding-top: 25px;
}

.compare-design-en-us #fixed-bar .compare-product-item:hover .closeCompareitem.c-glyph:before {
    color: #005da6;
}

.compare-design-en-us .compare-button-tile section.m-content-placement-item {
    pointer-events: none;
}

.compare-design-en-us .compare-button-tile section.m-content-placement-item a {
    pointer-events: auto;
}

.compare-design-en-us #fixed-bar .m-content-placement.compare-items-block {
    padding-left: 24px !important;
    margin-left: 0px !important;
}

.compare-design-en-us .compare-product-item {
    text-align: center;
    position: relative;
    min-height: 120px;
    margin-bottom: 10px !important;
}

.compare-design-en-us .compare-product-item img {
    width: auto !important;
    padding-top: 0;
    padding-bottom: 0;
    margin: auto;
    max-height: 100px;
}

.compare-design-en-us #fixed-bar .compare-items-block a.c-call-to-action.wdg-f-blue-button {
    font-size: 13px;
    display: inline-block;
    max-width: 100%;
    padding: 10px 22px 10px 24px;
    overflow: hidden;
    border: 2px solid transparent;
    color: #fff;
    background: #0078d7;
    line-height: 1.3;
    text-decoration: none;
    text-align: center;
    letter-spacing: 0.075em;
    white-space: normal;
    transition: scale 0.2s ease-in-out;
    margin-right: 15px;
    margin-top: 10px;
}

.compare-design-en-us #fixed-bar .compare-items-block .disabled {
    background: #616161 !important;
    cursor: not-allowed;
    color: #fff !important;
    text-decoration: none;
    pointer-events: none;
    font-size: 13px;
    display: inline-block;
    max-width: 100%;
    padding: 10px 22px 7px 24px;
    overflow: hidden;
    border: 2px solid transparent;
    background: #0078d7;
    line-height: 1.3;
    text-align: center;
    letter-spacing: 0.075em;
    white-space: normal;
    transition: scale 0.2s ease-in-out;
    margin-right: 8px;
    margin-top: 10px;
}

.compare-design-en-us #fixed-bar [data-grid="col-3"] {
    width: 20%;
    /*height: auto !important;*/
    margin-right: 15px;
    margin: 20px 2% 20px 0px;
    background: #fff;
    border-radius: 8px;
    min-height: 212px;
}

.compare-design-en-us #fixed-bar .compare-button-tile {
    position: relative;
    float: right;
}

.compare-design-en-us .compare-items-block .compare-product-button a.c-call-to-action{
    cursor: pointer;
}
.compare-design-en-us #fixed-bar .m-content-placement-item .f-defulat-image
{
padding-top: 10px;
}
@media only screen and (max-width:1083px) {
.compare-design-en-us #fixed-bar .m-content-placement-item .f-defulat-image
{
padding-top: 50px;
}
.compare-design-en-us #fixed-bar .m-content-placement-item .f-defulat-image img
{
width:100% !important;
}
}

@media screen and (-ms-high-contrast: active) {
.compare-design-en-us #fixed-bar .compare-items-block .compare-item {
    border: 2px solid #fff;
}
}
/* compare Sticky Box functionality CSS end */

/*Removed Compare rating image in result Sticky START*/
.compare-design-en-us .stickycompareImageSection.stickyFixed .compareratingimage
{
    display: none;
}

/*Removed Compare rating image in result Sticky END*/



.surface-section-footnotes ul li:empty{
    display: none;
}
/*Bug 149238 fix start*/
@media only screen and (max-width:820px) {
.c-apps-panel .apps-wrapper .apps p {
    font-size: 13px;
}}
/*Bug 149238 fix end*/
@media only screen and (max-width:539px) {
.en-us .blue-offer-home
{
   margin-top: 0px !important;    
}
}
.new-sp4-banner.m-banner .newsp4bannertext .c-heading-3
{
    font-weight: 600;
}
/*Home event banner fall22*/
.newsp4bannertext.Home-Windows11-Panel-text p {
    padding-bottom: 15px;
}
/*Home event banner fall22*/

/*Content Request 160880: Update Compare filters to 'Control' for experiment start*/
.en-us #filterSection .itemsfilter ul li.usecasefilter, 
.en-us #filterSection .itemsfilter ul li.usecasedevider {
	display: inline-block;
}

.en-us .c-chkboxfilters .usecasefilter #usecase .c-checkbox label.c-label div.f-tooltip-icon span.f-tooltip-hover {
    visibility: hidden;
    position: absolute;
    width: 150px;
    text-align: center;
    bottom: 14px;
    padding: 20px;
    right: 6px;
    border-radius: 5px;
    line-height: 14px !important;
}
.en-us .c-chkboxfilters .usecasefilter #usecase .c-checkbox label.c-label div.f-tooltip-icon {
    color: #0067b8;
    border: none;
    width: 14px;
    height: 17px;
}
.en-us .c-chkboxfilters .usecasefilter #usecase .c-checkbox label.c-label div.f-tooltip-icon:focus {
    outline: 1.5px dotted black;
}
.en-us .c-chkboxfilters .usecasefilter #usecase .c-checkbox label.c-label div.f-tooltip-icon:hover span.f-tooltip-hover,
.en-us .c-chkboxfilters .usecasefilter #usecase .c-checkbox label.c-label div.f-tooltip-icon:focus span.f-tooltip-hover {
    visibility: visible;
    color: black;
    font-size: 11px;
    background: #f2f2f2;
    border: 1px solid rgba(0,0,0,.3);
    padding: 3px;
    z-index: 999;
}
.en-us .c-chkboxfilters .usecasefilter #usecase .c-checkbox label.c-label div.f-tooltip-icon span.f-tooltip-info {
    bottom: 10px;
    left: 10px;
    width: 135px;
}  
.en-us .c-chkboxfilters .usecasefilter #usecase .c-checkbox label.c-label div.f-tooltip-icon span.f-tooltip-info-right {
    width: 130px;
    bottom: 13px;
    left: 0px;
}
.en-us .c-chkboxfilters .usecasefilter #usecase .c-checkbox label.c-label div.f-tooltip-icon-position {
    position: relative;
    right: 8px;
}
.en-us .c-chkboxfilters .usecasefilter #usecase .c-checkbox label.c-label {
    display: -webkit-inline-box;
}
.en-us .c-checkbox label.c-label div.f-tooltip-icon .f-tooltip-hover a,
.en-us  .c-checkbox label.c-label div.f-tooltip-icon .f-tooltip-hover a span.supText {
    padding: unset;
    display: unset;
    background: transparent;
}

@media only screen and (min-width:951px) and (max-width:1200px) { 
.en-us .c-chkboxfilters .usecasefilter #usecase .c-checkbox label.c-label div.f-tooltip-icon span.f-tooltip-info {
    bottom: 13px;
    left: -25px;
    width: 95px;
}
}
@media only screen and (min-width:1201px) and (max-width:1420px) { 
.en-us .c-chkboxfilters .usecasefilter #usecase .c-checkbox label.c-label div.f-tooltip-icon span.f-tooltip-info {
    bottom: 12px;
    left: -7px;
    width: 117px;
}
}
@media only screen and (min-width:951px) and (max-width:1083px) { 
.en-us .c-chkboxfilters .usecasefilter #usecase .c-checkbox label.c-label div.f-tooltip-icon span.f-tooltip-info-right {
    bottom: 13px;
    left: -55px;
    width: 79px;
    padding: unset;
}
}
@media only screen and (min-width:1084px) and (max-width:1383px) { 
.en-us .c-chkboxfilters .usecasefilter #usecase .c-checkbox label.c-label div.f-tooltip-icon span.f-tooltip-info-right {
    bottom: 13px;
    left: -65px;
    max-width: 80px;
}
}
@media only screen and (min-width:1384px) and (max-width:1599px) { 
.en-us .c-chkboxfilters .usecasefilter #usecase .c-checkbox label.c-label div.f-tooltip-icon span.f-tooltip-info-right {
    bottom: 13px;
    left: -31px;
    width: 125px;
} 
}

/*Content Request 160880: Update Compare filters to 'Control' for experiment end*/ 


/*Fall 22 compare update*/
/*-----------------------Canada markets mangosteen device disable (2 hours delay) start-----------------------*/
/*
.compareImageSection li.compare-device[data-filterprice="1234567"] .m-product-placement-item.compare-device-placement .c-heading-4 .headinglink.mscom-link.c-call-to-action,
.stickycompareImageSection li.compare-device[data-filterprice="1234567"] .m-product-placement-item.compare-device-placement .c-heading-4 .headinglink.mscom-link.c-call-to-action{
        text-decoration: none!important;
    color: rgba(0, 0, 0, 0.6)!important;
    background-color: transparent!important;
    cursor: not-allowed;
    pointer-events: none;
}
.compareImageSection li.compare-device[data-filterprice="1234567"] .m-product-placement-item.compare-device-placement .c-heading-4 .headinglink.mscom-link.c-call-to-action span::after,
.stickycompareImageSection li.compare-device[data-filterprice="1234567"] .m-product-placement-item.compare-device-placement .c-heading-4 .headinglink.mscom-link.c-call-to-action span::after
{
    display: none;
}*/
/*-----------------------Canada markets mangosteen device disable (2 hours delay) end-----------------------*/


.surface-360slider .surface-rotatebox .surface-sliderimages{
  height: 300px;
  position: relative;
}
.surface-360slider .surface-rotatebox .surface-posterimage img,.m-feature .surface-360slider .surface-rotatebox .surface-posterimage picture{
        width:100%;
}
.surface-360slider .surface-viewportimages{
    display: none;
}

.surface-360slider .ui-slider {
	position: relative;
	text-align: left;
}
.surface-360slider .surface-slidercomp {
    position:relative;
	display: none;
}
.surface-360slider .ui-slider .ui-slider-handle {
	position: absolute;
	z-index: 2;
	/*width: 9px;
    height: 25px;
	cursor: default;*/
}
.surface-360slider .ui-slider .ui-slider-range {
	position: absolute;
	z-index: 1;
	
}
 a.ui-slider-handle:focus + span.c-tooltip[aria-hidden=true] ,a.ui-slider-handle:focus + span.c-tooltip[aria-hidden=true],  a.ui-slider-handle:hover + span.c-tooltip[aria-hidden=true] , a.ui-slider-handle:hover + span.c-tooltip[aria-hidden=true]
{
    display: inline !important;
    position: relative !important;
    width: 100% !important;
    max-width: 300px !important;
    text-align: center!important;
    top: -20px!important;
    left:0% !important;
}

/* For IE8 - See #6727 */
.surface-360slider .ui-slider.ui-state-disabled .ui-slider-handle,
.surface-360slider .ui-slider.ui-state-disabled .ui-slider-range {
	filter: inherit;
}



.surface-360slider .ui-slider-horizontal .ui-slider-handle {
	top: -10px;
	margin-left: -.5em;
}
.surface-360slider .ui-slider-horizontal .ui-slider-range {
	top: 0;
	height: 100%;
}
.surface-360slider .ui-slider-horizontal .ui-slider-range-min {
	left: 0;
}
.surface-360slider .ui-slider-horizontal .ui-slider-range-max {
	right: 0;
}

.surface-360slider .ui-slider-vertical {
	width: .8em;
	height: 100px;
}
.surface-360slider .ui-slider-vertical .ui-slider-handle {
	left: -.3em;
	margin-left: 0;
	margin-bottom: -.6em;
}
.surface-360slider .ui-slider-vertical .ui-slider-range {
	left: 0;
	width: 100%;
}
.surface-360slider .ui-slider-vertical .ui-slider-range-min {
	bottom: 0;
}
.surface-360slider .ui-slider-vertical .ui-slider-range-max {
	top: 0;
}


/* Component containers
----------------------------------*/

.surface-360slider .ui-widget-content {
	border: 1px solid #dddddd;
	background: rgba(0, 0, 0, 0.4);
	color: #333333;
}
.surface-360slider .ui-widget-content a {
	color: #333333;
}
.surface-360slider .ui-widget-header {
	border: 1px solid #e78f08;
	color: #ffffff;
	font-weight: bold;
}
.surface-360slider .ui-widget-header a {
	color: #ffffff;
}


.surface-360slider .surface-slider{
        position: relative;
    }
   .surface-360slider .ui-widget-header { border: 1px solid #aaaaaa; background: #0078d7 50% 50% repeat-x; height: 4px;}
  .surface-360slider  .ui-slider-horizontal .ui-slider-range { top: -13px; height: 100%;}
   .surface-360slider .ui-slider-horizontal .ui-slider-range-min { left: 0;width:48.45%;}
   .surface-360slider .ui-slider-horizontal .ui-slider-range-max { right: 0;}
  /* .surface-360slider .ui-slider-handle.ui-state-active,.surface-360slider .ui-slider-handle.ui-state-focus,.surface-360slider .ui-slider-handle.ui-state-hover { background: #0078d7; border:1px solid #0078d7;}
  */ .surface-360slider .ui-slider-handle {left:48.455%;}
  .surface-360slider .ui-slider-horizontal .ui-slider-handle:focus
  { 
      outline:2px dotted #000;
      }
.surface-360slider .surface-slider div {
    margin-top: 12px;
    border-radius: 6px;
}


.surface-360slider .ui-state-default{
    height: 24px;
    width: 8px;
    background: #0078D7;
    border: 0;
    padding: 0;
    border-radius: 4px;
    outline: none; 
    cursor: pointer;
	
	}
    .surface-360slider .ui-state-default.ui-state-hover{
		
		background:#000;
	}
	.surface-360slider .ui-state-default:active {
    background: #004881;
}
/*
.surface-360slider .ui-state-default:focus {
    outline: 1px dashed #000;
}
*/

	
.surface-360slider .surface-slider div span {   
    border-radius: 6px 0px 0px 6px;
}
.surface-360slider .surface-rotatebox .surface-sliderimages{
    display: none;
    
}

.surface-360slider .surface-rotatebox .surface-sliderimages,.surface-360slider  .surface-slidercomp {
    position: relative;
margin-top:12px;
}
.surface-360slider .surface-rotatebox .surface-sliderimages,.surface-360slider  .surface-slidercomp .c-slider{
		margin:0 auto;
}

.surface-360slider .surface-slider.ui-slider.ui-slider-horizontal.ui-widget.ui-widget-content.ui-corner-all {
   width:296px;
       margin-left: auto;
    margin-right: auto;
	height: 6px;
}

.surface-360slider .ui-slider-handle span {
    display: none;
    position: absolute;
    min-width: 36px;
    height: 36px;
    text-align: center;
    top: -40px;
    left: 4px;
    padding: 8px 8px 10px;
    background: #e6e6e6;
    border: 1px solid rgba(0, 0, 0, 0.3);
    -webkit-transform: translateX(-50%);
    -ms-transform: translateX(-50%);
    transform: translateX(-50%);
	border:none;
}
.surface-360slider .ui-slider-handle.ui-state-active span{display:block;}
.surface-360slider .ui-slider-horizontal .ui-slider-range-min {
     background: #0078D7;
	 background-position: 0 0;
	 height: 6px;
}
 .c-feature.f-align-right .surface-360slider, .m-feature.f-align-right .surface-360slider{
     width : 65%;
     float:left;
     max-width:100%;
 }
  .c-feature.f-align-left .surface-360slider, .m-feature.f-align-left .surface-360slider{
     width : 65%;
     float:right;
     max-width:100%;
 }
 [dir='rtl'] .c-feature.f-align-right .surface-360slider, [dir='rtl'] .m-feature.f-align-right .surface-360slider{
     float:right;
 }
  [dir='rtl'] .c-feature.f-align-left .surface-360slider,[dir='rtl'] .m-feature.f-align-left .surface-360slider{
     float:left;
 }
 .surface-360slider .ui-state-default:hover {
    cursor: pointer;
}
 @media screen and (max-width: 1083px){
     .c-feature.f-align-right .surface-360slider,.c-feature.f-align-left .surface-360slider,
     .m-feature.f-align-right .surface-360slider,.m-feature.f-align-left .surface-360slider
     {
     width : 100%;
     float:none;
     }
 
 }
@media screen and (-ms-high-contrast: active) { 
 .surface-360slider .surface-rotatebox .surface-posterimage{
     display: block!important;
 }
.surface-360slider .surface-rotatebox .surface-sliderimages, .surface-360slider .surface-slidercomp{
       display: none!important;     
  }
  }
    /*a.c-call-to-action:after
{
    position: absolute;
}*/

.blue-offer .m-banner{
    max-width:100%;
}

.wdg-global .surface-typecover-pdp .m-multi-feature {
    overflow: visible;
}
/*body .compare-load{
    visibility: hidden;
}*/
@media only screen and (min-width: 1084px){
.p-processor [data-f-mosaic~=f-height-large] {
    height :auto;
}
}
.m-panes-product-placement-item .c-badge+[class*='c-heading'],.m-content-placement-item .c-badge+[class*='c-heading'],.m-multi-feature .c-badge+[class*='c-heading']{
    padding-top: 5px;
}
.m-content-placement-item .c-price.cos-c-price {
    margin-top :24px;
}
.c-pivot>header>a[href=''] {
  cursor:default;
} 
.surface-bg-cta-blue:hover +a.c-call-to-action span{
    text-decoration: none;
}
.c-pivot>header>a img[aria-controls] { /*.c-pivot>header>a[href=''] */
  cursor:pointer;
}

.m-hero-item:hover {
    cursor: default;
}
/** CTA button css Start*****/
a.c-call-to-action.c-glyph.surface-secondary-cta {
    background: transparent;
    color: #0067B8;
    /*color: #0078d7; Changed color as per accessibility*/
    padding-left: 0px;
    /**border: none;**/
}

a.c-call-to-action.c-glyph.surface-secondary-cta span:hover {
    text-decoration: underline;
}

a.c-call-to-action.c-glyph.surface-bg-cta-blue {
    background: #0067B8;
    /*background: #0078d7; Changed color as per accessibility*/
    color: #fff;
    padding-left: 0px;
    border: 2px solid transparent;
    padding: 9px 22px 6px 22px;
    margin-left: 0px;
    margin-right: 0px;
    margin-top: 25px;
}
a.c-call-to-action.c-glyph.surface-bg-cta-blue span{
    padding:2px;
}
a.c-call-to-action.c-glyph.surface-bg-cta-blue:after{
    margin-top:5px;
    margin-left:2px;
    position: relative;/*1.22.1 MWF fix*/
}

a.c-call-to-action.c-glyph.surface-secondary-cta span:hover {
    text-decoration: underline;
}
a.c-call-to-action.c-glyph.surface-bg-cta-blue span:hover{
      text-decoration: none; 
}

.c-content-placement .c-call-to-action, 
.m-content-placement-item .c-call-to-action {  
    padding: 10px 0 7px 0;
    margin-left: 0px;
    margin-right: 24px;
}

.m-content-placement a.c-call-to-action.c-glyph.surface-bg-cta-blue, 
.c-content-placement a.c-call-to-action.c-glyph.surface-bg-cta-blue,
.c-feature a.c-call-to-action.c-glyph.surface-bg-cta-blue,
.m-feature a.c-call-to-action.c-glyph.surface-bg-cta-blue,
.m-panes-product-placement-item a.c-call-to-action.c-glyph.surface-bg-cta-blue
 {
    margin-right: 24px;
    margin-top:10px;
}


.m-content-placement-item .c-group .surface-cta-sidebyside {
    margin-left: 0px;
}

.m-content-placement .c-price, .m-content-placement .c-group, .m-banner .c-price {
    margin-top: 12px;
}

a.c-call-to-action.c-glyph.surface-bg-cta-blue:hover, 
a.c-call-to-action.c-glyph.surface-bg-cta-blue:focus {  
    background: #006cc2;
    /*border-color: rgba(0, 0, 0, 0.4);*/ 
    text-decoration: none;
}

a.mscom-link.c-call-to-action.c-glyph.surface-bg-cta-blue span:hover,
.c-content-placement a.mscom-link.c-call-to-action.c-glyph.surface-bg-cta-blue span:hover, 
.m-content-placement-item a.mscom-link.c-call-to-action.c-glyph.surface-bg-cta-blue span:hover,
.c-content-placement .c-call-to-action.surface-bg-cta-blue span:hover, 
.c-feature .c-call-to-action.surface-bg-cta-blue span:hover,
.m-content-placement-item .c-call-to-action.surface-bg-cta-blue span:hover

 {
    text-decoration: none;
}

.surface-prefooter .m-content-placement {
    padding: 0;
}

.surface-prefooter .m-content-placement-item a.c-call-to-action {
    display: inline-block;
    text-align: left;
}

.surface-prefooter .m-content-placement-item a.c-call-to-action span {
    max-width: none;
}

.surface-prefooter .m-content-placement .m-content-placement-item {
    margin-top: 0px;
}

.surface-caption-text .c-heading-3 {
    padding-top: 15px;
}
.surface-caption-text .c-heading-2 {
    padding-top: 15px;
}
.m-banner a.c-call-to-action, .m-ratings-and-reviews a.c-call-to-action {
    margin-top:10px;
}
.c-call-to-action.c-glyph,.c-action-trigger.c-glyph,.c-hyperlink,button{
    font-weight:700;
    white-space: normal;
    }
.c-uhfh .c-call-to-action.c-glyph, .c-uhfh  .c-action-trigger.c-glyph, .c-uhfh  .c-hyperlink, .c-uhfh  button,
.c-uhff .c-call-to-action.c-glyph, .c-uhff .c-action-trigger.c-glyph, .c-uhff .c-hyperlink, .c-uhff button{

    font-weight: inherit;
}
/** start of Apps css **/

.c-apps-panel {
    padding-left: 38px;
    padding-right: 38px;
}

.c-apps-panel .apps-wrapper {
    padding-top: 48px;
    text-align: center;
    float: none;
    margin: auto;
}

.c-apps-panel .apps-wrapper .apps {
    float: left;
    padding-right: 20px;
}

.c-apps-panel picture img {
    max-width: 75px;
    width: 100%;
    height: auto;
}
.c-apps-panel picture img:hover{
    cursor: default;
}
.c-apps-panel .apps p:hover{
cursor:default;
}
.c-apps-panel .apps a.c-hyperlink:hover,.c-apps-panel .apps a.c-hyperlink:visited {
text-decoration:none !important;
}
.c-apps-panel .c-divider {
    margin-top: 10px;
}

/**end of Apps css**/


.ratingPlugin.bv-stars-container .bvseo-ratingValue {
    line-height: normal;
}

/** CTA button css Start*****/

/** Banner Layout **/

#surface_bannerlayoutcta .m-banner,
.surface_banner_offer .m-banner {
    padding: 24px;
}

#surface_bannerlayoutcta .c-heading-4,
.surface_banner_offer p {
    padding: 0; 
}

.surface-compare-text .m-compare-chart .c-heading-6 {
    font-weight: 600;
    padding-top:10px;
}

.surface-compare-devices.surface-compare-active div[class*='techspecs-block-'] [data-grid*=col-] {
    width: 100%;
}

.surface-compare-devices div[class*='techspecs-block-']  [data-grid*=col-] {
    padding-right: 12px;
    width: 100%;
}

/**Banner Superscript**/

.surface-Banner-superscript {
    font-size: 0.6em;
}

.surface-banner-divider hr,
#surface_bannerlayoutcta hr {
    margin: 0px;
}

.surface-youtubevidplayer a.c-action-trigger.c-glyph:before,
.surface-youtubevidplayer button.c-action-trigger.c-glyph:before {
    margin-left: 0px;
    margin-bottom: 2px;
}

.surface-banner-divider .m-banner {
    /*padding: 33px 0 33px 0;*/
    padding-top: 33px;
    padding-bottom: 33px;
}

@media only screen and (min-width: 540px) {
    
    #surface_bannerlayoutcta .m-banner,
    .surface_banner_offer .m-banner {
        padding: 17px 24px 17px 24px;
        display: table;    
        width: auto;
    }
    
    .surface-prefooter .m-content-placement-item  a.c-call-to-action {
        max-width: none;
    }
    
    #surface_bannerlayoutcta .c-call-to-action.c-glyph,
    .surface_banner_offer .c-call-to-action.c-glyph {
        display: table-cell;
        padding-top: 5px;
    }

    #surface_bannerlayoutcta .c-heading-4,
    .surface_banner_offer p {
        display: table-cell;
        padding: 0;
    } 

}

/** Banner Layout END **/

@media only screen and (min-width: 1084px) {
    .c-feature.f-align-left.f-image-priority .surface-youtubevidplayer,
    .c-feature.f-align-right.f-image-priority .surface-youtubevidplayer {
        width: 65%;
        display: inline-block;
    } 
}

.c-feature.f-align-left.f-image-priority .surface-youtubevidplayer picture,
.c-feature.f-align-right.f-image-priority .surface-youtubevidplayer picture {
    width: 100%;
}

/** System requirements module **/

.m-system-requirements .c-list.surface-list-style li {
    list-style-type: disc;
    font-size: 15px;
    margin-left: 21px;
}

.m-system-requirements .c-table.f-divided tbody tr:last-child {
    border-bottom: 0px;
}

.m-system-requirements .c-table.surface-td-fontweight td:first-child {
    font-weight: 100;
}

.m-system-requirements.surface-techspecspanel {
    padding-top: 0px;
}

.m-system-requirements.surface-techspecspanel .c-table .c-subheading-3 {
    width: 42%;
}

/** System requirements module END **/

a.c-call-to-action.glyph-play:after {
    display: none;
} 

.c-badge.c-badge-empty.f-highlight,
.c-badge.c-badge-empty.f-lowlight {
    background-color: rgba(255,255,255,0);
}

.f-background-neutral-05 {
    background-color: #f2f2f2;    
}

/** Typography - Font overrides *****Start*****/
/**********************************************/
/**All panels Mosaic panel header 5 same font value**/

.m-mosaic .c-heading-5 {
    font-size: 20px;
    line-height: 24px;
}

/**Custom css for 1399 viewport for Hero, Immersive Hero, Area Heading, Banner **/

@media (max-width: 1399px) {
    
    /** Override of header 2 for Hero, Immersive Hero, Area Heading, Banner (as rest panel donot have header 2 not need to add component specific class) **/
    
    .c-heading-2 {
        font-size: 34px;
        line-height: 40px;
        padding: 38px 0 2px;
    }
    
    /** Override   subheader 2 only for heros and banners **/
    
    .m-hero-item .c-subheading-2,
    .m-banner .c-subheading-2 {
        font-size: 20px;
        line-height: 24px;
    }
    
    /** Override header 3 for features panel **/
    
    /*.m-feature .c-heading-3 {
        font-size: 34px;
        line-height: 40px;
    }*/

}

/**Custom css for 1083 viewport for Content Rich Block, Rich heading, Drawer & Content Placement **/

@media (max-width: 1083px) {
    
    /**Override for heading 4 in Content placement & Subheading 2 for Content Rich Block, Rich heading, Drawer **/
    
    .c-heading-4,
    .c-subheading-2 {
        font-size: 20px;
        line-height: 24px;
    }
    
    /** override for heading 3 for Content Rich Block, Rich heading, Drawer **/
    
   /* .c-heading-3 {
        font-size: 24px;
        line-height: 30px;
    } */
        .c-heading-6 {
        font-size: 18px;
    }
    .wdg-global .c-divider{margin: 0 auto;}
  
}

/**Custom css for 539 viewport for Feature,Content Rich Block, Rich heading, Drawer & Content Placement **/

@media (max-width: 539px) {
    
    /** override for heading 3 for Features, Content Rich Block, Rich heading, Drawer & header 4 of Content placement **/
    
    /*.m-feature .c-heading-3,
    .c-heading-3,*/
    .c-heading-4 {
        font-size: 26px;
        line-height: 32px;
    }
    
    /** override for heading 2 for Content Rich Block, Rich heading, Drawer **/
    
    .c-subheading-2 {
        font-size: 18px;
        line-height: 24px;
    }
 .c-feature picture img{width:100%;}  
}

.wdg-m-prefooter button.drawer#prefooterDrawer:focus{
    outline:#000 dashed 2px;
}
/** Typography - Font overrides ********************End******/
/************************************************************/
/** Hero Item - Overrides *****Start*******/
/******************************************/

@media only screen and (min-width: 768px) and (max-width: 1083px) {
    
    .c-hero,
    .m-hero-item {
        height: auto;
        padding: 0;
        text-align: center;
    }
    
    .c-hero > div,
    .m-hero-item > div {
        padding: 12px;
        position: relative;
    }
    
    .c-hero[class*=f-x][class*=f-y] > picture img,
    .m-hero-item[class*=f-x][class*=f-y] > picture img {
        top: 0;
        left: 0;
        left: calc(50%);
        -webkit-transform: translateX(-50%);
        -ms-transform: translateX(-50%);
        transform: translateX(-50%);
    }
    
    .c-hero[class*=f-x][class*=f-y] > div > div,
    .m-hero-item[class*=f-x][class*=f-y] > div > div {
        position: relative;
        margin: 0 auto;
        left: 0;
        top: 0;
        top: calc(50%);
        -webkit-transform: translateY(-50%);
        -ms-transform: translateY(-50%);
        transform: translateY(-50%);
        max-width: 100%;
    }
    
    .c-hero > div > div > div,
    .m-hero-item > div > div > div {
        -webkit-justify-content: center;
        -ms-flex-pack: center;
        justify-content: center;
    } 
      
}

@media only screen and (max-width: 1083px) {
    
    .m-hero-item .c-pivot > header {
        display: inline-block;
        margin-top: 20px;
        margin-bottom:20px;
    }
    .surface-hero-pivot-multi-img .c-pivot>header>a
    {
        display: inline-flex;
        height:auto;
    }
    .c-hero[class*=f-x][class*=f-y] > div > div,
    .m-hero-item[class*=f-x][class*=f-y] > div > div {
        transform: none;
        top: 0;
    }
    
    .c-hero[class*=f-x][class*=f-y] > div,
    .m-hero-item[class*=f-x][class*=f-y] > div {
        height: auto;
    }
    
    /*.m-hero-item > div > div .c-heading-2,
    .c-hero .m-hero-item > div > div .c-heading-2,
    .m-banner .c-heading-2 {
        padding-top: 0px;
    }*/
    
    .c-hero>div, .m-hero-item>div {
        padding-bottom:0px;
    }

}

@media only screen and (min-width: 540px) and (max-width:1083px) {
    
    .c-hero>div, .m-hero-item>div {    
        width: 66.6666666667%;
    }
    
}
@media only screen and (min-width: 1400px) {
.surface-home-ftransparent .m-hero-item.f-transparent-V5-padtop45:before
{
     padding-bottom: 45.5%;
}
 .surfacez-custom-pivot .c-hero.f-transparent-V5-padtop67:before,.surfacez-custom-pivot .m-hero-item.f-transparent-V5-padtop67:before
{
     padding-bottom: 67.5%;
} 
}

@media only screen and (min-width: 1399px) {
.m-hero-itemSP4.f-transparent-V5-padtop45:before
{
     padding-bottom: 45.5%;
}    
}
@media only screen and (min-width: 1084px) and (max-width:1399px) {
    
.c-hero.f-transparent-V5-padtop50:before, .m-hero-item.f-transparent-V5-padtop50:before
{
     padding-bottom: 50.5%;
}

.c-hero.f-transparent-V5-padtop45:before, .m-hero-item.f-transparent-V5-padtop45:before
{
     padding-bottom: 45.5%;
}
  
  .c-hero.f-transparent-V5-padtop67:before, .m-hero-item.f-transparent-V5-padtop67:before
{
     padding-bottom: 67.5%;
}  
#surface-accessories-canary .c-hero.f-transparent-V5-padtop67 .c-heading-1,
#surface-accessories-canary .m-hero-item.f-transparent-V5-padtop67 .c-heading-1{
padding-top:0px;
}

}


@media only screen and (min-width: 1084px) {
    
    .m-hero-item > div,
    .c-hero > div {
        max-width: 1600px;
    }
    
    .m-hero-item > div > div,
    .c-hero > div > div {
        padding-left: 24px;
        padding-right: 24px;
    }
     .m-hero-item.f-transparent-V6-padtop50:before
{
     padding-bottom: 50.5%;
}
    
}

@media only screen and (min-width: 1400px) {
    
    .m-hero-item > div > div,
    .c-hero > div > div {
        padding-left: 48px;
        padding-right: 48px;
    }
    
    .c-apps-panel {
        padding-left: 50px;
        padding-right: 50px;
    }
    
}

/** Hero Item - Overrides *****End*********/
/******************************************/
/** Feature Item - Overrides *****Start*******/
/*********************************************/

@media only screen and (min-width: 540px) and (max-width: 1083px) {
    
    .c-feature.f-align-left > div,
    .c-feature.f-align-right > div {
        /*width: 490px;*/
        margin: 0 auto;
        text-align: center;
        position: relative;
        top: 0;
        -webkit-transform: translateX(0);
        -ms-transform: translateX(0);
        transform: translateY(0);
        margin-top: 20px;
    }
    
    .c-feature.f-align-left>div, 
    .c-feature.f-align-right>div,
    .c-feature.f-align-center>div,.m-feature.f-align-right>div,.m-feature.f-align-left>div,.m-feature.f-align-center>div {   
        width: 66.6666666667%;
    }
    
}

@media screen and (max-width: 1083px) {
    
    /*REMOVING THE LEFT VALUE FOR LEFT AND RIGHT CONTAINERS TO MAKE IT STACKED VERTICALLY ONE BELOW OTHER */
    
    .c-feature.f-align-right > div,
    .c-feature.f-align-right.f-image-priority > div {
        left: 0;
    }
    
    .c-feature.f-align-left .c-video,
    .c-feature.f-align-left picture,
    .c-feature.f-align-right .c-video,
    .c-feature.f-align-right picture {
        display: block;
        width: 100%;
        max-width: 100%;
    }
    .c-feature.f-align-right.c-feature.f-align-right.f-image-priority .c-video
    {
        width:100%;max-width:100%;padding:0 24px 0 24px;
    }
    .c-feature.f-align-left .c-video,
    .c-feature.f-align-left picture,
    .c-feature.f-align-right .c-video,
    .c-feature.f-align-right picture {
        float: none;
    }
    
    .c-feature.f-align-right > div,
    .c-feature.f-align-right.f-image-priority > div {
        left: 0;
    }
    
    .c-feature .c-pivot > header {
        display: inline-block;
        margin-top: 20px;
    }
    
    .c-feature.f-align-left>div, 
    .c-feature.f-align-right>div {
        padding-bottom: 0px;
    }
    
}

.m-feature .c-feature .c-price {
    margin-top: 12px;
}

.m-feature .c-feature .c-price.cos-c-price {
    margin-top: 24px;
}

/** Feature Item - Overrides *****End*********/

/** Panel top Spacing - Overrides *****Start*********/

.pad-thin {
    margin-top: 48px;
}

.pad-medium {
    margin-top: 60px;
}

.pad-large {
    margin-top: 120px;
}
.wdg-pad-large
{
    padding-top: 120px;
}
@media only screen and (max-width: 1083px) {
    
    .pad-thin {
        margin-top: 36px;
    }
    
    .pad-medium {
        margin-top: 52px;
    }
    
    .pad-large {
        margin-top: 100px;
    }
    .wdg-pad-large
{
    padding-top: 84px;
}
}

@media only screen and (max-width: 539px) {
    
    .pad-thin {
        margin-top: 24px;
    }
    
    .pad-medium {
        margin-top: 40px;
    }
    
    .pad-large {
        margin-top: 80px;
    }
    .wdg-pad-large
{
    padding-top: 48px;
}
    
}

/** Panel Spacing - Overrides *****End*********/
/*********************************************/

@media screen and (min-width: 768px) {
    
    .apps-set-left[data-grid~=col-6],
    .apps-set-right[data-grid~=col-6] {
        width: auto;
    }

}
 
@media screen and (min-width: 1084px) { 
    
    .m-banner-apps-panel .m-banner {
        max-width: inherit;
        text-align: left;
    }

}

@media screen and (max-width: 1083px) {
    
    .c-apps-panel .apps-wrapper.apps-six-icons .apps {
        padding: 10px;
    } 

}

@media screen and (max-width: 1083px) {
    
    .c-apps-panel {
        padding-left: 26px;
        padding-right: 26px;
    }
    
    .c-apps-panel .apps-wrapper .apps-left-section,
    .c-apps-panel .apps-wrapper .apps-right-section {
        width: 100%;
        padding-bottom: 20px;
    }
    
    .c-apps-panel .apps-wrapper .apps-right-section {
        padding-bottom: 5px;
    }
    
    .c-apps-panel .apps-wrapper {
        width: 70%;
    }
    
    .c-apps-panel .apps-wrapper.apps-six-icons {
        width: 100%;
        float: left;
    }
    
    .c-apps-panel .apps-wrapper.apps-six-icons .apps {
        width: auto;
    }

}

@media screen and (min-width: 768px) and (max-width: 1083px) {
     .c-apps-panel .apps-wrapper {
        width: 50%;
    }
    
    .c-apps-panel {
        padding-left: 36px;
        padding-right: 36px;
    }
}

@media only screen and (max-width: 539px) {
    
    .c-apps-panel  .apps-wrapper {
        width: 100%;
        margin-left: 2.5%;
    }
 
    .c-apps-panel .apps-wrapper .apps {
        width: 20%;
    }
    
    .c-apps-panel.apps-6 .apps-wrapper .apps {
        width: 33%;
    }
    
    .surface-compare-c-chart.c-compare-chart, 
    .surface-compare-c-chart.m-compare-chart {
        padding: 0 12px;
    }
    
    .c-apps-panel {
        padding-left: 12px;
        padding-right: 12px;
    }
    
    .c-apps-panel.x-type-center {
        width: 280px;
        margin: 0 auto;
    }
    .surface-compare-text .m-compare-chart
    {
        padding-top:24px;
    }
}

@media only screen and (min-width: 540px) and (max-width: 1083px) {   
    .m-banner-apps-panel .apps-wrapper.apps-six-icons {        
        width: 256px;
        margin: 0 auto;
        float: none;
    }
}

/** CTA Spacing - Overrides **/

.c-call-to-action.c-glyph.surface-bg-cta-blue.margin-right-4px {
    margin-right: 24px;
}

.c-glyph:after, 
.c-glyph:before, 
.c-glyph:hover:after, 
.c-glyph:hover:before {
    text-decoration: none;
}

/*banner divider vertical align middle*/

.surface-banner-divider .m-banner h2 {
    padding-top:5px;
}

.surface-youtubevidplayer a.c-action-trigger.c-glyph.glyph-play:before,
.surface-youtubevidplayer a.c-action-trigger.c-glyph.glyph-play:hover:before,
a.surface-popup-video.COS-video.c-action-trigger.c-glyph.glyph-play:before,
a.surface-popup-video.COS-video.c-action-trigger.c-glyph.glyph-play:hover:before {
    text-decoration:underline !important;
}
.surface-youtubevidplayer a.c-action-trigger.c-glyph.glyph-play:before,
.surface-youtubevidplayer a.c-action-trigger.c-glyph.glyph-play:hover:before,
a.surface-popup-video.COS-video.c-action-trigger.c-glyph.glyph-play:before,
a.surface-popup-video.COS-video.c-action-trigger.c-glyph.glyph-play:hover:before{
    text-decoration:none !important;
}

/*c-feature image width fix*/
@media only screen and (min-width:1027px) and (max-width: 1083px){
.c-feature picture img, .c-carousel li>picture.c-image img{
width:100%;
}
}
#surface-Studio-techspec .surface-techspec-Popup-images .m-content-placement-item picture {
    cursor: default;   
}



@media only screen and (min-width: 1084px){
.m-mosaic.surface-mosaic-with-features{
    padding-left: 36px;
    padding-right: 36px;
}
}
@media only screen and (min-width: 1400px){
.m-mosaic.surface-mosaic-with-features{
    padding-left: 48px;
    padding-right: 48px;
}
}
/*@media (max-width: 539px) {
.c-dialog.f-lightbox [role=dialog]
{
    width: 100%;
}
}*/

/** Banner c-price caption font  **/
.m-banner .c-price .c-caption-1, .m-banner .surface-shipping.c-caption-1{
    font-size: 13px;
    color: rgb(0, 0, 0);

}
.m-banner .surface-shipping.c-caption-1
{
    padding-top: 0px;
}
/**End of Banner c-price caption font  **/

/*iframe.deviceUtubeVid{
        border-width: 0px;
}*/
   /*.m-feature picture iframe, .frameheight,iframe.deviceUtubeVid{
    min-height: 600px;
}*/
.utube-video > [aria-hidden='true']{
    display: none;
}

/*@media only screen and (min-width: 1084px) and (max-width: 1400px){ 
   .m-feature picture iframe, .frameheight,iframe.deviceUtubeVid{
    min-height: 500px;
}
}*/
/*@media only screen and (min-width: 768px) and (max-width: 1083px){
    .m-feature  picture iframe, .c-dialog iframe , .frameheight,iframe.deviceUtubeVid{
    min-height: 300px;
}
}
@media only screen and (max-width: 767px){
   .m-feature  picture iframe, .c-dialog iframe, .frameheight,iframe.deviceUtubeVid {
    min-height: 200px;
}
}*/

@media only screen and (min-width: 768px)
{
.m-mosaic .c-mosaic-placement.f-background-accent.f-height-large.f-width-large > div 
{
padding: 0 25%;
}
}

@media only screen and (min-width: 540px) and (max-width: 767px)
{
.m-mosaic .c-mosaic-placement.f-background-accent.f-height-large.f-width-large > div 
{
padding: 0 15%;
}
}
@media only screen and (max-width: 450px)
{
    .m-mosaic .c-mosaic-placement.f-background-accent.mosaic-truncate .c-heading-2
    {
        padding: 10px 0 2px;
    }
}



/* Adding white space on top to hero panel*/

.m-hero-item.hero-fullbleed-16-9-whitespace:before,
  .c-hero.hero-fullbleed-16-9-whitespace:before {
    padding-bottom: 63.2%; }


.m-hero-item.f-y-top.hero-fullbleed-16-9-whitespace> div > div,
  .c-hero.f-y-top.hero-fullbleed-16-9-whitespace> div > div {
    top: 140px; }
    @media only screen and (max-width: 1083px) {
      .m-hero-item.f-y-top.hero-fullbleed-16-9-whitespace> div > div,
      .c-hero.f-y-top.hero-fullbleed-16-9-whitespace> div > div {
        top: 0; }
         .m-hero-item.f-y-center.hero-fullbleed-16-9-whitespace> div > div,
  .c-hero.f-y-center.hero-fullbleed-16-9-whitespace> div > div {
    top: 0 !important;
    -webkit-transform: none !important;
        -ms-transform: none !important;
            transform: none !important; }
         }
  .m-hero-item.f-y-center .c-heading:first-child,
  .c-hero.f-y-center .c-heading:first-child {
    padding-top: 0; }
  .m-hero-item.f-y-center > div > div,
  .c-hero.f-y-center > div > div {
    top: 120px;
    top: calc(50%);
    -webkit-transform: translateY(-50%);
        -ms-transform: translateY(-50%);
            transform: translateY(-50%); }
  .m-hero-item.f-y-center.hero-fullbleed-16-9-whitespace> div > div,
  .c-hero.f-y-center.hero-fullbleed-16-9-whitespace> div > div {
    top: 120px;
    top: calc(55%);
    -webkit-transform: translateY(-50%);
        -ms-transform: translateY(-50%);
            transform: translateY(-50%); }



/*End of Adding white space on top to hero panel*/


.c-hero .c-group>.c-call-to-action+.c-call-to-action, .m-hero-item .c-group>.c-call-to-action+.c-call-to-action{
     margin-left: -24px;
     margin-right: -24px;
}

.c-hero .c-group>.c-call-to-action+.c-call-to-action+.c-call-to-action, .m-hero-item .c-group>.c-call-to-action+.c-call-to-action+.c-call-to-action{
     margin-left: 0px;
}


.m-content-placement-item .surface-bg-cta-blue.c-call-to-action:focus:not(.x-hidden-focus),
.c-feature>div .surface-bg-cta-blue.c-call-to-action:focus:not(.x-hidden-focus),
.m-banner a.surface-bg-cta-blue.c-call-to-action:focus:not(.x-hidden-focus),
.m-hero-item a.c-call-to-action.c-glyph.surface-bg-cta-blue:focus:not(.x-hidden-focus),
.m-panes-product-placement-item a.c-call-to-action.c-glyph.surface-bg-cta-blue:focus:not(.x-hidden-focus)
{
    color: #fff;
    /*outline: #000 solid 2px;*/
}

.m-rich-content-block .c-call-to-action:hover span,
.m-rich-content-block .c-call-to-action:focus span,
.m-product-placement-item>a:hover .c-heading-6,
.m-content-placement-item>a:first-child:hover .c-heading-4 ,.m-content-placement-item>a:first-child:hover .c-heading-5
{
    text-decoration: underline;
}

.c-feature>div .surface-bg-cta-blue.c-call-to-action:focus:not(.x-hidden-focus) span,
.c-feature>div .surface-bg-cta-blue.c-call-to-action:hover span,
.m-content-placement-item .surface-bg-cta-blue.c-call-to-action:hover span,
.m-content-placement-item .surface-bg-cta-blue.c-call-to-action:focus:not(.x-hidden-focus) span,
.m-banner a.surface-bg-cta-blue.c-call-to-action:hover span,
.m-banner a.surface-bg-cta-blue.c-call-to-action:focus:not(.x-hidden-focus) span,
.surface-bg-cta-blue:hover span,
.surface-bg-cta-blue:focus span,
.surface-image-richblock .c-call-to-action:hover span,
#surface-accessories-dial .dial-hero-panel .m-hero-item .c-group>.c-call-to-action+.surface-bg-cta-blue.c-call-to-action:hover span,
#surface-accessories-dial .dial-hero-panel .m-hero-item .c-group>.c-call-to-action+.surface-bg-cta-blue.c-call-to-action:focus:not(.x-hidden-focus) span,
.m-panes-product-placement-item .surface-bg-cta-blue.c-call-to-action:hover span,
.m-panes-product-placement-item .surface-bg-cta-blue.c-call-to-action:focus:not(.x-hidden-focus) span
{
    text-decoration: none;
}
.surface-hero-pivot-multi-img .c-pivot:not(.f-disabled)>header>a.f-active{
height:100%;
border-bottom: none;
}

.surface-hero-pivot-multi-img .c-pivot>header
{
    height: 100%;
}

.surface-hero-pivot-multi-img .c-pivot:not(.f-disabled)>header>a.f-active.x-hidden-focus
{
outline:#000 dashed 2px !important;    
}
.surface-hero-pivot-multi-img .c-pivot:not(.f-disabled)>header>a.f-active:focus {
outline:#000 dashed 2px ;
}

#surface-accessories-dial .dial-hero-panel .m-hero-item .c-group>.x-hidden+.c-call-to-action
{
    background:#0067B8;
    /*background: #0078d7; Changed color as per accessibility*/
    color: #fff;
    margin-top: 0px;
    margin-left: 0px;
}
#surface-accessories-dial .dial-hero-panel .m-hero-item .c-group>.x-hidden+.c-call-to-action:hover,
#surface-accessories-dial .dial-hero-panel .m-hero-item .c-group>.x-hidden+.c-call-to-action:focus:not(.x-hidden-focus)
{
    background:#006cc2;
}
/*a.surface-secondary-cta.c-call-to-action:focus:not(.x-hidden-focus)
{
    background: content-box rgba(0,120,215,.1);
    outline: none;
}

a.surface-secondary-cta.c-call-to-action:focus span{
    text-decoration: underline;
}*/
@media only screen and (min-width: 300px) and (max-width: 646px)
{
.surface-hero-pivot-multi-img .c-pivot>header>a {
    margin: 10px 12px;
}
}


.c-uhfh .theme-light .c-call-to-action.c-glyph {
    background-color: #0067b8!important;
    color: #fff!important;
}
.c-uhfh .theme-light .c-call-to-action.c-glyph:hover, .c-uhfh .theme-light .c-call-to-action.c-glyph:focus{
    
    background-color: #006cc2!important;
    border-color: rgba(0,0,0,0.4)!important;
    border: 2px solid transparent;
}
.c-uhff {
 margin-top: 0px;   
}
#headerArea button:focus {
    outline: 2px dashed #000 !important;
}
/*Life style comp css start*/
/*Desktop viewport 6-3*/
.m-lifestyle-feature {
  clear: both; }

.m-lifestyle-feature > div > div > div {
  margin-top: 12px; }

.m-lifestyle-feature .c-price {
  font-size: 20px;
  line-height: 24px;
  display: inline-block; }

.m-lifestyle-feature[class^='m-'] {
  padding: 0;
  position: relative; }

.m-lifestyle-feature > picture img {
  width: 100%; }

.m-lifestyle-feature > div {
  position: absolute;
  height: 100%;
  top: 0;
  bottom: 0;
  right: 0;
  left: 0; }

.m-lifestyle-feature > div > div {
  position: absolute;
  width: 34.5%; }

/*16:9 canvas with safe zone below 16.6 area*/
.m-lifestyle-feature.f-ratio-169.f-top-left > div > div {
  bottom: 66.7%;
  left: 6%; }

.m-lifestyle-feature.f-ratio-169.f-top-right > div > div {
  bottom: 66.7%;
  right: 6%; }

.m-lifestyle-feature.f-ratio-169.f-bottom-left > div > div {
  top: 66.7%;
  left: 3.5%; }

.m-lifestyle-feature.f-ratio-169.f-bottom-right > div > div {
  top: 66.7%;
  right: 6%; }

/*4:3 canvas with safe zone below 16:9 area*/
.m-lifestyle-feature.f-ratio-43.f-top-left > div > div {
  bottom: 75%;
  left: 6%; }

.m-lifestyle-feature.f-ratio-43.f-top-right > div > div {
  bottom: 75%;
  right: 6%; }

.m-lifestyle-feature.f-ratio-43.f-bottom-left > div > div {
  top: 75%;
  left: 6%; }

.m-lifestyle-feature.f-ratio-43.f-bottom-right > div > div {
  top: 75%;
  right: 6%; 
  }
  .m-lifestyle-feature.f-ratio-169.f-bottom-left > div > div {
  top: 55%;
 }
  
  @media only screen and (max-width: 1083px) {
    .m-lifestyle-feature > div {
    position: static; }

  .m-lifestyle-feature > div > div {
    text-align: center;
    position: static;
    width: 88%;
    margin: 0 auto; }
 
  .m-lifestyle-feature > div > div > div {
    -webkit-justify-content: center;
    justify-content: center; }
 }

/*Life style comp css end*/
.m-multi-feature [role=tablist] li:last-child
{
    margin-right: 0px;
}
/*CTA-Removal-bg*/
@media only screen and (min-width: 768px) and (max-width: 960px){
   .fr-ca .m-content-placement.surface-remove-cta-bg-v2  .c-call-to-action.surface-bg-cta-blue {
        border: none;background:none;margin: 0px;padding:0px;color: #0078D7;  padding: 10px 0 7px 0;
    margin-left: 0;
    margin-right: 24px;
    }

    .fr-ca  .m-content-placement.surface-remove-cta-bg-v2  .c-call-to-action.surface-bg-cta-blue span:hover{
          text-decoration: underline;
      }
  }
  
  @media only screen and (min-width: 1400px) {
.m-panes section.f-align-middle{
padding-left:0px;
}

.m-panes section.f-stacked {
       padding-right: 0px;
}
.m-panes section.f-stacked:last-child{
    flex: 2 1 100%;
}

.wdg-global .m-panes section.f-align-middle{
padding-left:0px;
}

.wdg-global .m-panes section.f-stacked {
       padding-right: 0px;
}

  }
/*********************Start wdg-Updates**********************/
.prefooter-old.surface-prefooter{
    display: none;
}
.wdg-m-prefooter {
     display: block;
 }

@media only screen and (min-width:540px) {
.wdg-m-prefooter #prefooterNav {
        display: block !important;
    }  
}

 .wdg-global.surfacecom .m-multi-feature{
    overflow: visible;
}
@media only screen and (min-width: 1084px) {
.wdg-m-prefooter nav.c-link-navigation.prefooternavlist-7 ul li
{
  width: 13%;
}

.wdg-m-prefooter nav.c-link-navigation.prefooternavlist-6 ul li
{
   width: 15%;
}
}
 /*********************END wdg-Updates**********************/
 
 
 /***********Start Rich content image Dialogbox**********/
 .surface-richcontentimage-dialogbox .m-rich-heading>picture.c-image:after{
     background:none;
 }
 .surface-dialog-custom.c-dialog [role=dialog] {
     overflow-y: scroll;
 }
.surface-dialog-custom.c-dialog .c-list li {    
    font-size: 24px;
    font-weight: 200;
} 
 @media only screen and (max-width:767px) {
     .surface-richcontentimage-dialogbox .m-rich-heading>picture.c-image{
     margin-left: -24px;
    margin-right: -24px;
    background-color: #E3E3E3;
    }
    .surface-richcontentimage-dialogbox .m-rich-heading>picture.c-image+div{
        height:auto;
    }
     .surface-richcontentimage-dialogbox .m-rich-heading>picture.c-image img{
     margin:0 auto;
    }
 .surface-richcontentimage-dialogbox .m-rich-heading>picture.c-image:before, .surface-richcontentimage-dialogbox .m-rich-heading>picture.c-image img{
    position:static; 
 }
 .surface-richcontentimage-dialogbox .m-rich-heading{
     background: none !important;
 }
  .surface-richcontentimage-dialogbox .m-rich-heading>picture.c-image:before{
     background: none;
     }
   .surface-richcontentimage-dialogbox .richcontentimage-content{
        width: 66.66667%; 
        text-align: center;
     }
    .surface-richcontentimage-dialogbox .c-group a, .surface-richcontentimage-dialogbox .richcontentimage-content{
        margin-left:auto;
        margin-right:auto;
    }
         
 }
 /***********End Rich content image Dialogbox**********/
 
 /*@media only screen and (min-width: 1084px){
.surface-typecover-pdp.wdg-pad-bottom-medium  .m-multi-feature a.c-call-to-action.c-glyph.surface-bg-cta-blue{
    margin-top: 10px !important;
}
}*/
@media only screen and (min-width: 1084px){
.surface-typecover-pdp.wdg-pad-bottom-medium  .m-multi-feature .c-paragraph-3{
padding-top:10px !important;
}
}
@media only screen and (max-width: 1399px){
 .wdg-global .m-panes section:last-child.f-stacked, .m-panes section:last-child.f-stacked
{
   -ms-flex: none;
}
}

/* multi-feature overlapping issue*/
.c-pivot>header, .m-multi-feature .c-pivot>div, .m-multi-feature .c-pivot>header, .c-pivot.comparechartmacipad>header{
    overflow: visible;
    height: 100%;
    white-space: normal;
}
.IE11 .m-multi-feature .c-pivot>div, .Edge .m-multi-feature .c-pivot>div, .Firefox .m-multi-feature .c-pivot>div
{
    height:auto;
}
.m-banner a.c-call-to-action
{
    padding: 10px 16px 15px 0;
}

@media only screen and (min-width:1400px) {
    .surface-image-hero-hybrid .m-hero-item.f-transparent:before {
        padding-bottom: 41.5%;
    }
}

@media only screen and (min-width: 1084px)
{
.c-hero:before, .m-hero-item:before
{
    padding-bottom: 41.5%;
}
.c-hero.f-transparent:before, .m-hero-item.f-transparent:before {
    padding-bottom: 60.2%;
}
}

@media only screen and (max-width: 1083px)
{
    .wdg-global .m-hero-item:before, .wdg-global .m-hero-item.wdg-f-ratio-16-9:before {
    padding-bottom: 56.25%;
    padding-top: 0px;
}
}
 
.m-hero-item>picture
{
    transform:none;
    -ms-transform:none;
    -webkit-transform: none;
}
.wdg-global .c-call-to-action.surface-bg-cta-blue:focus:not(.x-hidden-focus):not(.wdg-f-blue-button)
{
    background: #006cc2; 
}
 .wdg-global .c-group a.c-call-to-action.x-hidden+a.c-call-to-action{
     padding-left: 25px;
 }  

 /*Reverted the WDG CSS*/
  /*.wdg-global .m-content-placement-item .c-heading-4{
    padding: 36px 12px 4px 0px;
}
*/
/*.wdg-global [class^=m-]:not(.m-panes),
.wdg-global .surface-top-banner-80px [class^=m-]:not(.m-panes)
.wdg-global .surface-margin-top-15px [class^=m-]:not(.m-panes)
{
padding-top:48px;
}

.wdg-global .m-content-placement[class^=m-]:not(.m-panes){
padding-top: 0px;
margin-top: 0px;
}


.wdg-global .wdg-pad-medium.bannerimage [class^=m-]:not(.m-panes), 
{
    padding-top:0px;
}
.wdg-global .c-group{
    margin-top: 0px;
}*/

/*MWF V1.23 Overrides*/
.c-pivot>.c-flipper[aria-hidden=false]{
    display: none;
}
@media only screen and (min-width: 1084px) {
 .m-multi-feature.f-align-left>section,.m-multi-feature.f-align-right>section {
        -ms-flex-direction: row;
        flex-direction: row;
        -ms-flex-align: center;
        align-items: center
    }
}

.surfaceinnovation-pivotmosaic.m-multi-feature>section .c-pivot{
    order:1;
    -webkit-box-ordinal-group:2;
    }
.surfaceinnovation-pivotmosaic.m-multi-feature>section .c-carousel{
    order:2;
    -webkit-box-ordinal-group:3;
    }

.c-call-to-action:focus:not(.x-hidden-focus):not(.wdg-f-blue-button),.c-feature>div .c-call-to-action:focus:not(.x-hidden-focus):not(.wdg-f-blue-button), .m-feature>div .c-call-to-action:focus:not(.x-hidden-focus):not(.wdg-f-blue-button),.c-hero-item .c-group>.c-call-to-action:focus:not(.x-hidden-focus):not(.wdg-f-blue-button),.m-hero-item .c-group>.c-call-to-action:focus:not(.x-hidden-focus):not(.wdg-f-blue-button),a.surface-popup-video:focus:not(.wdg-f-blue-button),a.surface-popup-video.x-hidden-focus:focus:not(.wdg-f-blue-button) {
    background: none;
    outline: #000 dashed 2px;
}
.c-call-to-action.surface-outline-white:focus:not(.x-hidden-focus):not(.wdg-f-blue-button),.c-feature>div .c-call-to-action.surface-outline-white:focus:not(.x-hidden-focus):not(.wdg-f-blue-button), .m-feature>div .c-call-to-action.surface-outline-white:focus:not(.x-hidden-focus):not(.wdg-f-blue-button),.c-hero-item .c-group>.c-call-to-action.surface-outline-white:focus:not(.x-hidden-focus):not(.wdg-f-blue-button),.m-hero-item .c-group>.c-call-to-action.surface-outline-white:focus:not(.x-hidden-focus):not(.wdg-f-blue-button) {
    outline: #fff dashed 2px;
}

.m-multi-feature .c-call-to-action:focus:not(.x-hidden-focus):not(.wdg-f-blue-button),.c-call-to-action:focus:not(.x-hidden-focus):not(.wdg-f-blue-button).surface-bg-cta-blue,.m-feature>div .c-call-to-action:focus:not(.x-hidden-focus):not(.wdg-f-blue-button).surface-bg-cta-blue,.c-feature>div .c-call-to-action:focus:not(.x-hidden-focus):not(.wdg-f-blue-button).surface-bg-cta-blue,.m-content-placement .surface-product-items  .c-call-to-action:focus:not(.wdg-f-blue-button):not(.surface-secondary-cta){
  background: #005da6;
}
a.surface-popup-video:focus:not(.wdg-f-blue-button),a.surface-popup-video.x-hidden-focus:focus:not(.wdg-f-blue-button){
    background: none!important;
    border: #000 dashed 2px;
}
.m-product-placement-item .c-call-to-action:focus:not(.x-hidden-focus):not(.f-lightweight) {
    background: #005da6;
    outline: #000 solid 2px;
}

.theme-light .c-call-to-action:focus:not(.x-hidden-focus):not(.wdg-f-blue-button){
    background: #lalala;
    outline: #fff solid 2px;
}
.theme-dark .c-call-to-action:focus:not(.x-hidden-focus):not(.wdg-f-blue-button){
    background: #e6e6e6;
    outline: #000 solid 2px;
}
.wdg-global .c-group a.c-call-to-action+a.c-call-to-action
{
    padding-left: 0px;

     /*margin-left:0px;*/
}
.wdg-pad-70 {
    padding-top:68px;
}
.wdg-pad-small {
    padding-top: 36px;
}
.wdg-pad-bottom-small{
    padding-bottom: 25px;
}

.wdg-pad-left-16px
{
    padding-left: 16px !important;
}
@media only screen and (max-width: 1083px)
{
.wdg-pad-small {
    padding-top: 24px;
}
}

@media only screen and (max-width: 539px)
{
.wdg-pad-small {
    padding-top: 12px;
} 
}

.surface-compare-stickybar .m-content-placement-item [class^='c-heading'] {
    padding-top: 40px;
}
.surface-compare-stickybar .m-content-placement-item .c-badge+[class^='c-heading'] {
    padding-top: 5px;
}
.m-content-placement-item .c-badge:empty{display:none;}

@media only screen and (max-width: 767px){
    .wdg-global .surface-compare-active .m-content-placement>div>div~div .m-content-placement-item, .wdg-global .surface-compare-active .m-content-placement>div>div~div>div .m-content-placement-item {
    margin-top: 0;
}
}
.wdg-global .m-lifestyle-feature.f-ratio-169.f-bottom-left>div>div
{
    top:55%;
}


@media only screen and (min-width: 1399px)
{
.c-hero.f-transparent-55:before, .m-hero-item.f-transparent-55:before {
    padding-bottom: 55%;
}
}
@media only screen and (min-width: 1084px) and (max-width: 1400px){ 
  .c-hero.f-transparent-55:before, .m-hero-item.f-transparent-55:before {
    padding-bottom: 36%;
}
}
.wdg-global .sj-overview .m-feature .c-group a.c-call-to-action+a.c-call-to-action
{
    padding-left:25px;
}
@media only screen and (max-width: 960px) and (min-width: 768px)
{
.fr-ca .wdg-global .c-call-to-action.surface-bg-cta-blue:focus:not(.x-hidden-focus):not(.wdg-f-blue-button)
{
background: none;
}
}

.m-page-bar .c-call-to-action:focus:not(.x-hidden-focus)
{
    background: #005da6;
}
@media only screen and (min-width: 540px) and (max-width: 1084px){ 		
  .c-hero.f-transparent-55:before, .m-hero-item.f-transparent-55:before {		
    padding-bottom:41.55%;		
}		
}		
.rtl .surface-hero-pivot-multi-img.rtl-images-customRL .c-hero.f-x-right>div>div,		
.rtl .surface-hero-pivot-multi-img.rtl-images-customRL .m-hero-item.f-x-right>div>div{		
left:0;		
right:initial;		
}		
.ar-ae.rtl .surface-hero-pivot-multi-img.rtl-images-customRL .c-pivot>header>a:first-child,		
.ar-sa.rtl .surface-hero-pivot-multi-img.rtl-images-customRL .c-pivot>header>a:first-child		
{		
    margin-right: 0px;		
}

.c-feature>div .c-call-to-action.surface-bg-cta-blue:focus:not(.x-hidden-focus), 
.c-feature>div .c-call-to-action.surface-bg-cta-blue:hover, 
.m-feature>div .c-call-to-action.surface-bg-cta-blue:focus:not(.x-hidden-focus), 
.m-feature>div .c-call-to-action.surface-bg-cta-blue:hover
{
    color: #fff;
}

.wdg-float-none
{
    float: none !important;
}
.wdg-margin-right-zero
{
    margin-right: 0 !important;
}

.wdg-margin-right-zero-calltoaction .c-call-to-action
{
    margin-right: 0 !important;
}
.wdg-pad-top10px
{
    padding-top: 10px;
}

@media only screen and (max-width: 1083px) and (min-width: 540px)
{
[data-vg='SurfaceDial_1_BannerAppsPanel_VG'].m-banner-apps-panel .apps-wrapper.apps-six-icons {
width: 100%;
}
}

@media only screen and (max-width: 539px)
{
[data-vg='SurfaceDial_1_BannerAppsPanel_VG'].m-banner-apps-panel .apps-wrapper.apps-six-icons {
width: 256px;
}
}
@media only screen and (min-width: 1084px){
[data-vg='SurfaceDial_1_HeroFBPivot_VG'] .m-hero-item, [data-vg='SurfaceDial_1_HeroFBPivot_VG'] .m-hero-item>picture,
[data-vg='SurfaceStudioInnovation_6_HeroFullBleedPivot_VG'] .m-hero-item, [data-vg='SurfaceStudioInnovation_6_HeroFullBleedPivot_VG'] .m-hero-item>picture
{
    overflow: visible;
}
}
@media only screen and (max-width: 1084px){
.specs-bootom-padding.surface-specsbanner .m-rich-content-block
{
    padding-bottom: 0px;
}
}
@media only screen and  (min-width: 540px)and (max-width: 767px){
.specs-bootom-padding.surface-specsbanner .m-rich-content-block
{
    padding-top: 36px;
}
[class*='de-'] .wdg-m-prefooter nav.c-link-navigation ul li a.c-hyperlink p,.da-dk .wdg-m-prefooter nav.c-link-navigation ul li a.c-hyperlink p
{
    font-size:8px;
}
} 
   @media only screen and (max-width: 539px)
   {
    .wdg-global .m-hero-item .c-paragraph, .m-hero-item .c-price, .m-hero-item .c-rating {
    display: block
    }
   }

.c-feature.f-align-center .m-ambient-video,.m-feature.f-align-center .m-ambient-video
{    
   text-align: left;
}


 .IE11 .c-video-player.yt-video-inline-height{
height: 100vh;
      }

/*zap css*/

 .surface-compare-devices .specification-title td p:only-child :first-child
{
padding-top:0px;
}

@media only screen and (max-width:1083px) {
    
    .surfacez-custom-pivot .c-logo .c-heading-3 {
    
    float: left;
}


}
.price-hide{
    display: none;
}
.wdg-global .WhereToBuy_1_HeroFB .c-group a.c-call-to-action+a.c-call-to-action
{
    margin-left: -24px;
}
.surface-multiview-feature .m-multi-feature [role=tablist] li > a.f-active.c-logo:focus,
.sur-pivot-custom-color.surface-hero-pivot-multi-img .c-pivot:not(.f-disabled)>header>a.f-active.x-hidden-focus
{
    outline:none !important;
}
.surface-multiview-feature.laptop-surface-multiview-feature .m-multi-feature [role=tablist] li > a.f-active.c-logo:focus,.swatch-color-list-new li a:focus{
    border:none!important;
}
.surface-multiview-feature.laptop-surface-multiview-feature .m-multi-feature [role=tablist] li > a.c-logo.pivotfocus:focus{
        outline:#000 3px solid !important;
        border:none;
}
.surface-multiview-feature.laptop-surface-multiview-feature .m-multi-feature [role=tablist].view-thumbs  li > a.c-logo.pivotfocus:focus{
        outline:#000 2px solid !important;
        border:none;
}

@media only screen and (min-width:540px){
  .Edge .wdg-global .m-image-intro.f-align-top>div,.IE11 .wdg-global .m-image-intro.f-align-top>div {
    left: 0;   
    -ms-transform: translateX(0);
    transform: translateX(0);
  }
}
.fulllivearea-video.c-video.utube-video button.c-glyph.glyph-play:focus
{
    outline:2px dashed #fff;
}

#mainContent a.c-hyperlink:not(.f-image).x-hidden-focus:not(:hover),#mainContent a.c-hyperlink:not(.f-image).x-hidden-focus,#mainContent a.c-hyperlink:not(.f-image):not(:hover),#mainContent a.c-hyperlink:not(.f-image),#mainContent p a{
    text-decoration: underline !important;
}
#mainContent a.c-hyperlink:not(.f-image).x-hidden-focus:not(:hover):focus,#mainContent a.c-hyperlink:not(.f-image).x-hidden-focus:focus,#mainContent a.c-hyperlink:not(.f-image):not(:hover):focus,#mainContent a.c-hyperlink:not(.f-image):focus,#mainContent p a:focus{
   outline: 2px dotted #000;
}
.m-multi-feature.f-align-center .banner-link-spacing .c-call-to-action:focus
{
    background: none !important;
}

/***start-safari issue fix- multi feature panel***/
/***Remove this css after MWF version V1.26.0 migration***/

@media only screen and (min-width: 1400px) {
.m-multi-feature.f-align-left > section > div, .m-multi-feature.f-align-right > section > div {
-webkit-box-ordinal-group: 3;
}

.m-multi-feature.f-align-left > section > div.c-carousel, .m-multi-feature.f-align-right > section > div.c-carousel {
 -webkit-box-ordinal-group: 2;
}
}
@media only screen and (min-width: 1084px) {
.m-multi-feature.f-align-left > section, .m-multi-feature.f-align-right > section {
 -webkit-box-orient: horizontal;
 -webkit-box-direction: normal;
 -webkit-box-align: center;
}

.m-multi-feature > section {
display: -webkit-box;
-webkit-box-orient: vertical;
-webkit-box-direction: normal;
}

.m-multi-feature.f-align-left > section > div {
-webkit-box-ordinal-group: 3;
}

.m-multi-feature.f-align-left > section > div.c-carousel, .m-multi-feature.f-align-right > section > div {
-webkit-box-ordinal-group: 2;
}

.m-multi-feature.f-align-right > section > div.c-carousel {
-webkit-box-ordinal-group: 3;
}
}

  .m-multi-feature > section .c-pivot, .m-multi-feature > section > ul {
     -webkit-box-ordinal-group: 3;
 }

.m-multi-feature > section .c-carousel {
     -webkit-box-ordinal-group: 2;
}

.m-multi-feature > section > .c-sequence-indicator {
    -webkit-box-ordinal-group: 4;
}

/***end -safari issue fix- multi feature panel***/


.wdg-m-prefooter nav.c-link-navigation ul li a.c-hyperlink span{
    padding: 0;
    font-weight: 700;
    font-size: 13px;
    text-transform: uppercase;
    max-height: none;
    text-decoration: underline;
}
.wdg-m-prefooter nav.c-link-navigation ul li a.c-hyperlink:focus span{
    outline: transparent;
    background: content-box rgba(0,103,184,.1);
}
@media only screen and (min-width: 768px) and (max-width: 1399px)
{
[data-vg='Surface_J_Overview_3_HighlightFeature_VG'] .m-highlight-feature.f-align-left>div {
    padding-left: 12px;
    padding-right: 12px;
	width: 320px;
    height: 350px;
}
}
/*overriding 1px to 2px */
.wdg-global .c-call-to-action:focus:not(.x-hidden-focus):not(.wdg-f-blue-button){
outline: #000 dashed 2px !important;
}
@media only screen and (min-width: 1084px) {
    
    .hero-panel-padding{
        padding-left: 61px !important;
        }
    }
    .surface-highlightFeature .m-highlight-feature>div
{
 height: auto;
}
.surface-link-nav li
{
    padding-top: 20px;
}

/*Need to remove for footnotes implete for all locales*/

.msw-page #mainContent .surface-section-footnotes a.supLink
{
    pointer-events: none !important;
    text-decoration: none !important;
    font-size:8px;
    top:-5px;
    position:relative;
}

.en-us #mainContent .surface-section-footnotes a.supLink,
.en-ca #mainContent .surface-section-footnotes a.supLink,
.fr-ca #mainContent .surface-section-footnotes a.supLink,
.zh-cn #mainContent .surface-section-footnotes a.supLink,
.fr-fr #mainContent .surface-section-footnotes a.supLink,
.msw-page #mainContent .surface-home .surface-section-footnotes a.supLink,
#mainContent .compare-load .surface-section-footnotes a.supLink,
#mainContent .compare-design-en-us .surface-section-footnotes a.supLink
{
    pointer-events:auto !important;
    text-decoration: underline !important;
    font-size:8px;
}
/*.surface-lg-align .m-image
{
padding-bottom:100px
}*/
/*.surface-lg-panes .c-heading
{
    line-height: 35px !important;
}
.surface-lg-panes .c-mosaic-placement.f-height-large .c-group a
{
display:initial;
}
 */
 .surface-lg-panes .c-mosaic-placement.f-height-large .c-group a
{
display:inline !important;
}
 
 .wdg-global .c-group a.c-call-to-action+a.c-call-to-action.surface-in-book2{
     padding-left: 16px !important;
 } 
 
a.c-call-to-action:not(.glyph-play):after, button.c-call-to-action:not(.glyph-play):after{
     margin-top:2px;
 }
.configpanelcarousel a.surface-secondary-cta.c-call-to-action:not(.glyph-play):after{
     top:-3px;
 }
 .Surface_Lg_hero-panel .m-hero-item .c-group>.c-call-to-action+.c-call-to-action
 {
         padding-right: 0px;
 }
 @media only screen and (min-width: 1083px){
 .rtl .Surface_Lg_hero-panel .m-hero-item>div>div
{
padding-right: 150px;
}
 }

.de-de .wdg-global .Surface_Lg_hero-panel .c-group a.c-call-to-action.x-hidden+a.c-call-to-action
{
min-width: 331px;
}

.rtl .wdg-global .Surface_Lg_hero-panel .c-group a.c-call-to-action
{
    
    padding-right: 16px !important;
}
.c-social>a:focus, .c-social>ul>li>a:focus, .m-social>a:focus, .m-social>ul>li>a:focus {
    outline: 2px dashed #000 !important;
} 

@media only screen and (max-width: 1399px) and (min-width: 860px)
{
  .c-uhfh.c-sgl-stck .c-uhf-menu ul:not(.f-multi-column) {
    width: 190px !important;
}
}



@media only screen and (min-width: 1084px)
{
 .SurfaceHome_HL_Hero_Panel_en-in .m-hero-item:before
{
    padding-bottom: 60.2% !important;
}
}


@media only screen and (max-width: 1083px)
{
    .wdg-global .Surface_Hero_pivot_custom_sur .m-hero-item:before, .wdg-global .Surface_Hero_pivot_custom_sur .m-hero-item.wdg-f-ratio-16-9:before {
    padding-bottom: 75% !important;
    padding-top: 0px;
}
}.reduced-animation-toggle {
	 width: 100%;
	 display: flex;
	 flex-flow: row-reverse;
	 padding: 10px;
	 background-color: #f2f2f2;
	 height: 40px;
	 padding-right: 150px;
}
 @media screen and (max-width: 1920px) {
	 .reduced-animation-toggle {
		 padding-right: 70px;
	}
}
 @media screen and (max-width: 1400px) {
	 .reduced-animation-toggle {
		 padding-right: 56px;
	}
}
 @media screen and (max-width: 1083px) {
	 .reduced-animation-toggle {
		 padding-right: 12px;
	}
}
 .reduced-animation-toggle div.c-toggle > label + button {
	 clear: none;
}
 .reduced-animation-toggle div.c-toggle {
	 display: flex;
	 align-items: center;
}
 .reduced-animation-toggle div.c-toggle button {
	 margin-top: 0;
}
 .reduced-animation-toggle div.c-toggle span {
	 font-weight: 400;
	 font-size: 15px;
	 line-height: 20px;
   pointer-events: none;
}
 .reduced-animation-toggle div.c-toggle .c-label {
	 margin-top: 0;
	 padding-bottom: 0;
	 font-weight: 600;
	 font-size: 13px;
	 line-height: 16px;
	 text-align: center;
}
 .reduced-animation-toggle div.c-toggle .toggle-seperator {
	 width: 15px;
	 height: 0;
	 border: 1px solid #d5d5d5;
	 -ms-transform: rotate(90deg);
	 -webkit-transform: rotate(90deg);
	 transform: rotate(90deg);
	 margin-right: 15px;
	 margin-left: 15px;
}


/* START -  Image Animation */

.surface-laptop-family .main-image-stack {
    position: relative;
    right: 0;
    top: 0;
    width: 100%;
    display: flex;
    flex-direction: row-reverse;
    overflow: inherit;
        padding-bottom: 140px;
}

.surface-laptop-family .main-image-stack.rightAlign {
            flex-direction: column;
    }
 
.surface-laptop-family .image-stack-leftbottom .image-stack-item-2.parallax_scroll {
    position: absolute;
    top: 28%;
    left: 0;
    z-index:1;
}

.surface-laptop-family .main-image-stack.rightAlign .image-stack-item-2.parallax_scroll  {
    right: 0;
    left: auto;
    border-radius: 10px;
    top:22%;
}

.surface-laptop-family .main-image-stack.rightAlign .image-stack-item-2.parallax_scroll video,
.surface-laptop-family .main-image-stack .image-stack-item-2.imgposition.parallax_scroll video
{
    border-radius: 10px;
}
.surface-laptop-family .image-stack-lefttop .image-stack-item-1,
.surface-laptop-family .image-stack-leftbottom .image-stack-item-1 {
    position: relative;
    top: 0;
    right: 0;
    border-radius: 10px;
}
.surface-laptop-family .image-stack-item-1 img, .image-stack-item-2 img {
    width: 100%;
    height: auto;
    border-radius:10px;
}


.surface-laptop-family .image-stack-rightmiddle .image-stack-item-1 {
    position: relative;
    top: 0;
    right: 0;
}

.surface-laptop-family .image-stack-rightmiddle .image-stack-item-2 {
    position: absolute;
    top: 28%;
    bottom:28%;
    left: 0;
    z-index: 1;
}


@media only screen and (min-width:1084px) {
.surface-laptop-family .image-stack-rightmiddle .image-stack-item-2.parallax_scroll,
.surface-laptop-family .main-image-stack.rightAlign .image-stack-item-2.parallax_scroll,
.surface-laptop-family .image-stack-leftbottom .image-stack-item-2.parallax_scroll
{
width: 50%;
}
.surface-laptop-family .image-stack-lefttop .image-stack-item-1,
 .surface-laptop-family .image-stack-leftbottom .image-stack-item-1,
.surface-laptop-family .image-stack-rightmiddle .image-stack-item-1
{
width: 55%;
}
}

@media only screen and (max-width:1083px) {
    .surface-laptop-family .surface-FamilyDevices .m-banner .c-heading-1
    {
      font-size: 48px;
    }
    .surface-laptop-family .main-image-stack,.surface-laptop-family .main-image-stack.rightAlign {
            flex-direction: column-reverse;
    }

   .surface-laptop-family .main-image-stack .image-stack-item-1 {
        margin-left: 18%;
    }
    
    .surface-laptop-family .main-image-stack.rightAlign .image-stack-item-1 {
          margin-right: 18%;
           margin-left: 0;
    }
    
    
   .surface-laptop-family .main-image-stack .image-stack-item-2 {
        margin-right: 22%;
        margin-top: -5%;
        margin-left: 5%;
        z-index: 1;
        position: relative;
        transform: translateY(200px);
        opacity: 0;
        transition: 2s all ease;
    }
    
     
    .surface-laptop-family .main-image-stack .image-stack-item-2.active {
         transform: translateY(0);
         opacity: 1;
    }
    
    .surface-laptop-family .main-image-stack.rightAlign .image-stack-item-2 {
           margin-left: 22%;
            margin-right: 5%;
    }   
   
    
       .surface-laptop-family .main-image-stack .image-stack-item-2  {
           clip-path: inset(0% 0% 0% 0% round 10px);
       }
    
}

@media only screen and (max-width:539px) {
        .surface-laptop-family .main-image-stack .image-stack-item-2,
        .surface-laptop-family .main-image-stack.rightAlign .image-stack-item-2  {
            margin: auto 10%;
            margin-top: -5%;
        }
        .surface-laptop-family .main-image-stack .image-stack-item-1,
        .surface-laptop-family .main-image-stack.rightAlign .image-stack-item-1 {
            margin: auto 5%;
        }
}


/* END - Image Animation */


/*spring launch 2022 css start*/


/*Lifestylevideo */
.surface-laptop-family #family-lifestyle {
    background-color: #000000;
    color: #ffffff;
}

.surface-laptop-family .wdg-lifestyle-video {
  position: relative;
}

.surface-laptop-family .wdg-lifestyle-video .lifestyle-video {
  position: -webkit-sticky;
  position: sticky;
}



.surface-laptop-family .wdg-lifestyle-video .lifestyle-video.margin-top {
  top: -48px;
}
/*hero image truncation and black space below video on animatin off*/
@media (prefers-reduced-motion: reduce){
 
    .surface-laptop-family .wdg-lifestyle-video .lifestyle-video.margin-top 
  {
    top: 0;
  }
  
   }


.surface-laptop-family .wdg-lifestyle-video .lifestyle-video .lifestylevideoautoplay {
  -o-object-fit: initial;
     object-fit: initial;
}

.surface-laptop-family .wdg-lifestyle-video .lifestyle-video .btn-div {
  position: absolute;
}

.surface-laptop-family .wdg-lifestyle-video .lifestyle-video .btn-div.top-right {
  z-index: 1;
  right: 32px;
  top: 100px;
}



@media screen and (max-width: 767px) {
  .surface-laptop-family .wdg-lifestyle-video .lifestyle-video .btn-div.top-right {
    right: 32px;
    top: 112px;
  }
}

.surface-laptop-family .wdg-lifestyle-video .lifestyle-video .btn-div.top-left {
  left: 32px;
  top: 32px;
  z-index: 1;
}

.surface-laptop-family .wdg-lifestyle-video .lifestyle-video .btn-div .videobutton.c-call-to-action.c-glyph {
  border: 2px solid #FFFFFF;
  width: 50px;
  height: 50px;
  background: transparent;
  border-radius: 50%;
  position: relative;
  margin: 0;
  padding: 0;
  overflow: initial;
}

.surface-laptop-family .wdg-lifestyle-video .lifestyle-video .btn-div .videobutton.c-call-to-action.c-glyph:focus {
  border: 2px dashed #FFFFFF;
  outline-color: transparent;
}

.surface-laptop-family .wdg-lifestyle-video .lifestyle-video .btn-div .videobutton.c-call-to-action.c-glyph:before {
  color: #FFFFFF;
  margin-left: 0px;
  margin-top: 2px;
}

.surface-laptop-family .wdg-lifestyle-video .lifestyle-video .btn-div .videobutton.c-call-to-action.c-glyph:after {
  border: none;
  content: initial;
}

.surface-laptop-family .wdg-lifestyle-video .lifestyle-video .masker {
  position: absolute;
  top: 0;
  height: 100%;
  width: 100%;
}

@media screen and (min-width: 768px) and (max-width: 1083px) {
  .surface-laptop-family .wdg-lifestyle-video .lifestyle-video .btn-div.top-right {
    right: 20px;
    top: 56px;
  }
  /*.surface-laptop-family .wdg-lifestyle-video .lifestyle-video .masker
  {
    top:0;
    height: 100%
  }*/
}

.surface-laptop-family .wdg-lifestyle-video .lifestyle-video picture img {
  width: 100%;
}

@media only screen and (max-width: 800px) {
  .surface-laptop-family .wdg-lifestyle-video .lifestyle-video picture.desktop {
    display: none;
  }
  .surface-laptop-family .wdg-lifestyle-video .lifestyle-video picture.mobile {
    display: block;
  }
}

.surface-laptop-family .wdg-lifestyle-video .lifestyle-video picture.mobile {
  display: none;
}

.surface-laptop-family .wdg-lifestyle-video .lifestyle-video-content {
  color: #FFFFFF;
}


.surface-laptop-family .wdg-lifestyle-video .lifestyle-video-content .lifestyle-video-main-content {
  padding: 30px;
}

.surface-laptop-family .wdg-lifestyle-video .lifestyle-video-content .lifestyle-video-main-content .c-heading-2,
.surface-laptop-family .wdg-lifestyle-video .lifestyle-video-content .lifestyle-video-main-content .c-paragraph {
  padding: 0 0 30px 0;
}

.surface-laptop-family .wdg-lifestyle-video .lifestyle-video-content .lifestyle-video-main-content .lifestyle-video-cta .c-call-to-action {
  padding: 8px 57px;
  background-color: transparent;
  border: 2px solid #fff;
  border-radius: 5px;
  color: #fff;
}

.surface-laptop-family .wdg-lifestyle-video .lifestyle-video-content .lifestyle-video-main-content .lifestyle-video-cta .c-call-to-action span {
  position: relative;
  top: 3px;
}

.surface-laptop-family .wdg-lifestyle-video .lifestyle-video-content .lifestyle-video-main-content .lifestyle-video-cta .c-call-to-action span:focus {
  color: #000;
}

.surface-laptop-family .wdg-lifestyle-video .lifestyle-video-content .lifestyle-video-main-content .lifestyle-video-cta .c-call-to-action:before {
  content: "";
}

.surface-laptop-family .wdg-lifestyle-video .lifestyle-video-content .lifestyle-video-main-content .lifestyle-video-cta .c-call-to-action:active {
  background-color: #ffffff;
  border-color: transparent;
  color: #000;
}

.surface-laptop-family .wdg-lifestyle-video .lifestyle-video-content .lifestyle-video-main-content .lifestyle-video-cta .c-call-to-action:hover {
  background-color: #ffffff;
  border-color: transparent;
  color: #000 !important;
  text-decoration: none !important;
}

.surface-laptop-family .wdg-lifestyle-video .lifestyle-video-content .lifestyle-video-main-content .lifestyle-video-cta .c-call-to-action:focus {
  background-color: #ffffff;
  border-color: transparent;
  text-decoration: none !important;
  color: #000 !important;
}

.surface-laptop-family .wdg-lifestyle-video .lifestyle-video-content .lifestyle-video-main-content .lifestyle-video-cta .c-call-to-action::after {
  font-family: "mwf-mdl2";
  content: "\e768";
  display: inline-block;
  margin: 3px 0 0 5px;
  vertical-align: middle;
  padding: 0px 2px;
  border-radius: 50%;
  background-color: #ffffff;
  color: #000;
}

.surface-laptop-family .wdg-lifestyle-video .lifestyle-video-box-content {
  width: 50%;
  padding: 30px 176px;
}

@media screen and (max-width: 1400px) {
  .surface-laptop-family .wdg-lifestyle-video .lifestyle-video-box-content {
    padding: 30px 150px;
  }
}

@media screen and (max-width: 1400px) and (prefers-reduced-motion: reduce) {
  .surface-laptop-family .wdg-lifestyle-video .lifestyle-video-box-content {
    padding: 0 150px !important;
  }
 
}

@media screen and (max-width: 1083px) {
  .surface-laptop-family .wdg-lifestyle-video .lifestyle-video-box-content {
    padding: 30px 100px;
    width: 80%;
  }
}

@media screen and (max-width: 1083px) and (prefers-reduced-motion: reduce) {
  .surface-laptop-family .wdg-lifestyle-video .lifestyle-video-box-content {
    padding: 0 100px;
  }
}

@media screen and (max-width: 767px) {
  .surface-laptop-family .wdg-lifestyle-video .lifestyle-video-box-content {
    padding: 30px 72px;
  }
}

@media screen and (max-width: 767px) and (prefers-reduced-motion: reduce) {
  .surface-laptop-family .wdg-lifestyle-video .lifestyle-video-box-content {
    padding: 0 72px;
  }
}

@media screen and (max-width: 540px){
  .surface-laptop-family .wdg-lifestyle-video .lifestyle-video-box-content {
    padding: 0 0 0 5%;
  }
}
@media screen and (max-width: 540px) and (prefers-reduced-motion: reduce){
  .surface-laptop-family .wdg-lifestyle-video .lifestyle-video-box-content {
    padding: 0 0 0 5% !important;
  }
}
.surface-laptop-family .wdg-lifestyle-video .lifestyle-video-box-content .lifestyle-video-main-content {
  padding: 0;
}

.surface-laptop-family .wdg-lifestyle-video .lifestyle-video-box-content .lifestyle-video-main-content .c-heading-2 {
  padding: 0;
  font-size: 164px;
  line-height: 174px;
  margin-left: -6px;
}

@media screen and (max-width: 1400px) {
  .surface-laptop-family .wdg-lifestyle-video .lifestyle-video-box-content .lifestyle-video-main-content .c-heading-2 {
    font-size: 126px;
    line-height: 136px;
  }
}

@media screen and (max-width: 1400px) and (prefers-reduced-motion: reduce) {
  .surface-laptop-family .wdg-lifestyle-video .lifestyle-video-box-content .lifestyle-video-main-content .c-heading-2 {
    font-size: 38px;
    line-height: 48px;
  }
}

@media screen and (max-width: 1083px) {
  .surface-laptop-family .wdg-lifestyle-video .lifestyle-video-box-content .lifestyle-video-main-content .c-heading-2 {
    font-size: 90px;
    line-height: 100px;
  }
}

@media screen and (max-width: 1083px) and (prefers-reduced-motion: reduce) {
  .surface-laptop-family .wdg-lifestyle-video .lifestyle-video-box-content .lifestyle-video-main-content .c-heading-2 {
    font-size: 27px;
    line-height: 37px;
  }
}

@media screen and (max-width: 767px) {
  .surface-laptop-family .wdg-lifestyle-video .lifestyle-video-box-content .lifestyle-video-main-content .c-heading-2 {
    font-size: 92px;
    line-height: 102px;
  }
}

@media screen and (max-width: 767px) and (prefers-reduced-motion: reduce) {
  .surface-laptop-family .wdg-lifestyle-video .lifestyle-video-box-content .lifestyle-video-main-content .c-heading-2 {
    font-size: 27px;
    line-height: 37px;
  }
}

@media screen and (max-width: 540px) {
  .surface-laptop-family .wdg-lifestyle-video .lifestyle-video-box-content .lifestyle-video-main-content .c-heading-2 {
    font-size: 85px;
    line-height: 95px;
    font-weight: 400;
  }
}
@media screen and (max-width: 430px) {
  .surface-laptop-family .wdg-lifestyle-video .lifestyle-video-box-content .lifestyle-video-main-content .c-heading-2 {
    font-size: 75px;
    line-height: 85px;
    font-weight: 400;
  }
}

@media screen and (max-width: 540px) and (prefers-reduced-motion: reduce) {
  .surface-laptop-family .wdg-lifestyle-video .lifestyle-video-box-content .lifestyle-video-main-content .c-heading-2 {
    font-size: 25px;
    line-height: 35px;
  }
}

.surface-laptop-family .wdg-lifestyle-video .lifestyle-video-box-content .lifestyle-video-main-content .c-paragraph {
  padding: 98px 0 0 0;
  font-size: 26px;
  width: 50%;
}

@media screen and (max-width: 1400px) {
  .surface-laptop-family .wdg-lifestyle-video .lifestyle-video-box-content .lifestyle-video-main-content .c-paragraph {
    font-size: 20px;
    width: 60%;
  }
}

@media screen and (max-width: 1400px) and (prefers-reduced-motion: reduce) {
  .surface-laptop-family .wdg-lifestyle-video .lifestyle-video-box-content .lifestyle-video-main-content .c-paragraph {
    font-size: 16px;
  }
}

@media screen and (max-width: 1083px) {
  .surface-laptop-family .wdg-lifestyle-video .lifestyle-video-box-content .lifestyle-video-main-content .c-paragraph {
    font-size: 16px;
    padding: 50px 0 0 0;
    width: 60%;
  }
}

@media screen and (max-width: 1083px) and (prefers-reduced-motion: reduce) {
  .surface-laptop-family .wdg-lifestyle-video .lifestyle-video-box-content .lifestyle-video-main-content .c-paragraph {
    padding: 15px 0 0 0;
  }
}

@media screen and (max-width: 767px) {
  .surface-laptop-family .wdg-lifestyle-video .lifestyle-video-box-content .lifestyle-video-main-content .c-paragraph {
    font-size: 24px;
    padding: 125px 0 0 0;
    width: 100%;
  }
}

@media screen and (max-width: 767px) and (prefers-reduced-motion: reduce) {
  .surface-laptop-family .wdg-lifestyle-video .lifestyle-video-box-content .lifestyle-video-main-content .c-paragraph {
    font-size: 18px;
    padding: 38px 0 0 0;
  }
}

.surface-laptop-family .wdg-lifestyle-video .lifestyle-video-box-content .lifestyle-video-main-content .lifestyle-video-cta {
  padding: 93px 0 0 0;
}

@media screen and (max-width: 1083px) {
  .surface-laptop-family .wdg-lifestyle-video .lifestyle-video-box-content .lifestyle-video-main-content .lifestyle-video-cta {
    padding: 53px 0 0 0;
  }
}

@media screen and (max-width: 1083px) and (prefers-reduced-motion: reduce) {
  .surface-laptop-family .wdg-lifestyle-video .lifestyle-video-box-content .lifestyle-video-main-content .lifestyle-video-cta {
    padding: 16px 0 0 0;
  }
}

@media screen and (max-width: 767px) {
  .surface-laptop-family .wdg-lifestyle-video .lifestyle-video-box-content .lifestyle-video-main-content .lifestyle-video-cta {
    padding: 95px 0 0 0;
  }
}

@media screen and (max-width: 767px) and (prefers-reduced-motion: reduce) {
  .surface-laptop-family .wdg-lifestyle-video .lifestyle-video-box-content .lifestyle-video-main-content .lifestyle-video-cta {
    padding: 28px 0 0 0;
  }
}

.surface-laptop-family div[id*="LifestyleVideo"].c-dialog div[role="dialog"] {
  background-color: #000000;
}

.surface-laptop-family div.c-dialog.x-lightbox-video[id^="wdgweb-LifestyleVideo"] {
  z-index: 1000;
}

@keyframes obd-content {
  0% {
    opacity: 0;
  }
  100% {
    opacity: 1;
  }
}

[lang^="ar-"] .surface-laptop-family .wdg-lifestyle-video {
  direction: ltr;
}

[lang^="ar-"] .surface-laptop-family .wdg-lifestyle-video .lifestyle-video-content .lifestyle-video-main-content {
  direction: rtl;
}

 .surface-home-player-wrapper .c-video-player{
    display: inline-block;
    margin: 0;
    width: 100%;
    min-width: 320px;
    direction: ltr;
    padding-bottom: 56.25%;
    position: relative;
    overflow: hidden;
}
/*lifestylevideo end*/


/* interactive card */

@charset "UTF-8";
.surface-laptop-family .wdg-device-highlight-tile {
  position: relative;
}

@media screen and (min-width: 768px) and (prefers-reduced-motion: reduce) {
  .surface-laptop-family .wdg-device-highlight-tile {
    min-height: 100vh;   
  }
}

.surface-laptop-family .wdg-device-highlight-tile.business-style .wdg-device-highlight-tile-content {
  padding: 0 0 80px 148px;
}

@media screen and (max-width: 1600px) and (prefers-reduced-motion: reduce) {
  .surface-laptop-family .wdg-device-highlight-tile.business-style .wdg-device-highlight-tile-content {
    padding: 0 0 0 36px;
  }
}

@media screen and (max-width: 1400px) {
  .surface-laptop-family .wdg-device-highlight-tile.business-style .wdg-device-highlight-tile-content {
    padding: 0 0 80px 52px;
  }
}

@media screen and (max-width: 1400px) and (prefers-reduced-motion: reduce) {
  .surface-laptop-family .wdg-device-highlight-tile.business-style .wdg-device-highlight-tile-content {
    padding: 0 0 0 36px;
  }
}

@media screen and (max-width: 1083px) {
  .surface-laptop-family .wdg-device-highlight-tile.business-style .wdg-device-highlight-tile-content {
    padding: 0 56px 68px 56px;
  }
}

@media screen and (max-width: 1083px) and (prefers-reduced-motion: reduce) {
  .surface-laptop-family .wdg-device-highlight-tile.business-style .wdg-device-highlight-tile-content {
    padding: 0 39px 0 39px;
  }
}

@media screen and (max-width: 767px) {
  .surface-laptop-family .wdg-device-highlight-tile.business-style .wdg-device-highlight-tile-content {
    padding: 84px 48px 68px 48px;
  }
}

.surface-laptop-family .wdg-device-highlight-tile.business-style .wdg-device-highlight-tile-content .wdg-device-content .c-heading-2 {
  font-size: 48px;
  line-height: 58px;
  padding: 0;
}

@media screen and (max-width: 1600px) and (prefers-reduced-motion: reduce) {
  .surface-laptop-family .wdg-device-highlight-tile.business-style .wdg-device-highlight-tile-content .wdg-device-content .c-heading-2 {
    font-size: 28px;
    line-height: 38px;
  }
}

@media screen and (max-width: 767px) {
  .surface-laptop-family .wdg-device-highlight-tile.business-style .wdg-device-highlight-tile-content .wdg-device-content .c-heading-2 {
    font-size: 46px;
    line-height: 56px;
  }
}

.surface-laptop-family .wdg-device-highlight-tile.business-style .wdg-device-highlight-tile-content .wdg-device-content .c-paragraph-2 {
  font-size: 24px;
  line-height: 34px;
  padding: 36px 0 0 0;
}

@media screen and (min-width: 768px) and (max-width: 1083px) {
  .surface-laptop-family .wdg-device-highlight-tile.business-style .wdg-device-highlight-tile-content .wdg-device-content .c-paragraph-2 {
    font-size: 30px;
    line-height: 40px;
    padding: 24px 0 0 0;
  }
}

@media screen and (min-width: 768px) and (max-width: 1083px) and (prefers-reduced-motion: reduce) {
  .surface-laptop-family .wdg-device-highlight-tile.business-style .wdg-device-highlight-tile-content .wdg-device-content .c-paragraph-2 {
    font-size: 21px;
    line-height: 30px;
    padding: 16px 0 0 0;
  }
}

@media screen and (max-width: 767px) {
  .surface-laptop-family .wdg-device-highlight-tile.business-style .wdg-device-highlight-tile-content .wdg-device-content .c-paragraph-2 {
    padding: 23px 0 0 0;
  }
}

.surface-laptop-family .wdg-device-highlight-tile.business-style .wdg-device-highlight-tile-content .wdg-device-specs-grid {
  padding: 66px 0 65px 0;
}

.surface-laptop-family .wdg-device-highlight-tile.business-style .wdg-device-highlight-tile-content .wdg-device-specs-grid .wdg-device-specs-flex .wdg-device-category-content .wdg-device-spec-content {
  background-color: #505050;
  height: 100%;
  padding: 56px 48px 33px 48px;
  cursor: initial;
}

@media screen and (max-width: 1600px) and (prefers-reduced-motion: reduce) {
  .surface-laptop-family .wdg-device-highlight-tile.business-style .wdg-device-highlight-tile-content .wdg-device-specs-grid .wdg-device-specs-flex .wdg-device-category-content .wdg-device-spec-content {
    padding: 19px 36px 12px 36px;
  }
}

@media screen and (max-width: 1083px) {
  .surface-laptop-family .wdg-device-highlight-tile.business-style .wdg-device-highlight-tile-content .wdg-device-specs-grid .wdg-device-specs-flex .wdg-device-category-content .wdg-device-spec-content {
    padding: 27px 52px 17px 52px;
  }
}

@media screen and (max-width: 1083px) and (prefers-reduced-motion: reduce) {
  .surface-laptop-family .wdg-device-highlight-tile.business-style .wdg-device-highlight-tile-content .wdg-device-specs-grid .wdg-device-specs-flex .wdg-device-category-content .wdg-device-spec-content {
    padding: 19px 36px 12px 36px;
  }
}

@media screen and (max-width: 767px) {
  .surface-laptop-family .wdg-device-highlight-tile.business-style .wdg-device-highlight-tile-content .wdg-device-specs-grid .wdg-device-specs-flex .wdg-device-category-content .wdg-device-spec-content {
    padding: 64px 52px 37px 52px;
  }
}

.surface-laptop-family .wdg-device-highlight-tile.business-style .wdg-device-highlight-tile-content .wdg-device-specs-grid .wdg-device-specs-flex .wdg-device-category-content .wdg-device-spec-content .c-heading-3 {
  padding: 0;
  color: #FFFFFF;
  font-size: 30px;
  line-height: 40px;
}

@media screen and (max-width: 1600px) and (prefers-reduced-motion: reduce) {
  .surface-laptop-family .wdg-device-highlight-tile.business-style .wdg-device-highlight-tile-content .wdg-device-specs-grid .wdg-device-specs-flex .wdg-device-category-content .wdg-device-spec-content .c-heading-3 {
    font-size: 18px;
    line-height: 28px;
  }
}

@media screen and (max-width: 1083px) {
  .surface-laptop-family .wdg-device-highlight-tile.business-style .wdg-device-highlight-tile-content .wdg-device-specs-grid .wdg-device-specs-flex .wdg-device-category-content .wdg-device-spec-content .c-heading-3 {
    font-size: 48px;
    line-height: 58px;
  }
}

@media screen and (max-width: 1083px) and (prefers-reduced-motion: reduce) {
  .surface-laptop-family .wdg-device-highlight-tile.business-style .wdg-device-highlight-tile-content .wdg-device-specs-grid .wdg-device-specs-flex .wdg-device-category-content .wdg-device-spec-content .c-heading-3 {
    font-size: 28px;
    line-height: 38px;
  }
}

@media screen and (max-width: 767px) {
  .surface-laptop-family .wdg-device-highlight-tile.business-style .wdg-device-highlight-tile-content .wdg-device-specs-grid .wdg-device-specs-flex .wdg-device-category-content .wdg-device-spec-content .c-heading-3 {
    font-size: 36px;
    line-height: 46px;
  }
}

.surface-laptop-family .wdg-device-highlight-tile.business-style .wdg-device-highlight-tile-content .wdg-device-specs-grid .wdg-device-specs-flex .wdg-device-category-content .wdg-device-spec-content .c-paragraph-3 {
  color: #FFFFFF;
  font-size: 18px;
  line-height: 28px;
  padding: 31px 0 10px 0;
}

@media screen and (max-width: 1600px) and (prefers-reduced-motion: reduce) {
  .surface-laptop-family .wdg-device-highlight-tile.business-style .wdg-device-highlight-tile-content .wdg-device-specs-grid .wdg-device-specs-flex .wdg-device-category-content .wdg-device-spec-content .c-paragraph-3 {
    font-size: 16px;
    line-height: 20px;
  }
}

@media screen and (max-width: 1083px) {
  .surface-laptop-family .wdg-device-highlight-tile.business-style .wdg-device-highlight-tile-content .wdg-device-specs-grid .wdg-device-specs-flex .wdg-device-category-content .wdg-device-spec-content .c-paragraph-3 {
    font-size: 30px;
    line-height: 40px;
    padding: 25px 0 16px 0;
  }
}

@media screen and (max-width: 1083px) and (prefers-reduced-motion: reduce) {
  .surface-laptop-family .wdg-device-highlight-tile.business-style .wdg-device-highlight-tile-content .wdg-device-specs-grid .wdg-device-specs-flex .wdg-device-category-content .wdg-device-spec-content .c-paragraph-3 {
    font-size: 18px;
    line-height: 28px;
    padding: 17px 0 11px 0;
  }
}

@media screen and (max-width: 767px) {
  .surface-laptop-family .wdg-device-highlight-tile.business-style .wdg-device-highlight-tile-content .wdg-device-specs-grid .wdg-device-specs-flex .wdg-device-category-content .wdg-device-spec-content .c-paragraph-3 {
    font-size: 24px;
    line-height: 34px;
    padding: 29px 0 27px 0;
  }
}

.surface-laptop-family .wdg-device-highlight-tile.business-style .wdg-device-highlight-tile-content .wdg-device-specs-grid .wdg-device-specs-flex .wdg-device-category-content .wdg-device-spec-content .c-group .c-call-to-action {
  color: #FFFFFF;
  white-space: normal;
  padding: 0;
  margin: 10px 5px 10px 0;
  text-align: left;
  padding-right: 15px;
}

.surface-laptop-family .wdg-device-highlight-tile.business-style .wdg-device-highlight-tile-content .wdg-device-specs-grid .wdg-device-specs-flex .wdg-device-category-content .wdg-device-spec-content .c-group .c-call-to-action:after {
  content: "";
}

.surface-laptop-family .wdg-device-highlight-tile.business-style .wdg-device-highlight-tile-content .wdg-device-specs-grid .wdg-device-specs-flex .wdg-device-category-content .wdg-device-spec-content .c-group .c-call-to-action:hover {
  text-decoration: none;
}

.surface-laptop-family .wdg-device-highlight-tile.business-style .wdg-device-highlight-tile-content .wdg-device-specs-grid .wdg-device-specs-flex .wdg-device-category-content .wdg-device-spec-content .c-group .c-call-to-action:hover span {
  -webkit-box-shadow: none;
          box-shadow: none;
}

.surface-laptop-family .wdg-device-highlight-tile.business-style .wdg-device-highlight-tile-content .wdg-device-specs-grid .wdg-device-specs-flex .wdg-device-category-content .wdg-device-spec-content .c-group .c-call-to-action:hover span::after {
  left: 12px;
}

.surface-laptop-family .wdg-device-highlight-tile.business-style .wdg-device-highlight-tile-content .wdg-device-specs-grid .wdg-device-specs-flex .wdg-device-category-content .wdg-device-spec-content .c-group .c-call-to-action:hover span:hover {
  -webkit-text-decoration: underline 2.8px;
          text-decoration: underline 2.8px;
}

.surface-laptop-family .wdg-device-highlight-tile.business-style .wdg-device-highlight-tile-content .wdg-device-specs-grid .wdg-device-specs-flex .wdg-device-category-content .wdg-device-spec-content .c-group .c-call-to-action:hover span:focus {
  -webkit-text-decoration: underline 2.8px;
          text-decoration: underline 2.8px;
}

.surface-laptop-family .wdg-device-highlight-tile.business-style .wdg-device-highlight-tile-content .wdg-device-specs-grid .wdg-device-specs-flex .wdg-device-category-content .wdg-device-spec-content .c-group .c-call-to-action:focus {
  text-decoration: none;
}

.surface-laptop-family .wdg-device-highlight-tile.business-style .wdg-device-highlight-tile-content .wdg-device-specs-grid .wdg-device-specs-flex .wdg-device-category-content .wdg-device-spec-content .c-group .c-call-to-action span {
  line-height: 20px;
  padding-right: 20px;
}

.surface-laptop-family .wdg-device-highlight-tile.business-style .wdg-device-highlight-tile-content .wdg-device-specs-grid .wdg-device-specs-flex .wdg-device-category-content .wdg-device-spec-content .c-group .c-call-to-action span::after {
  content: "\E76C";
  font-family: "MWF-MDL2";
  position: relative;
  top: 2px;
  left: 8px;
  text-decoration: none;
}

.surface-laptop-family .wdg-device-highlight-tile.business-style .wdg-device-highlight-tile-content .wdg-device-specs-grid .wdg-device-specs-flex .wdg-device-category-content .wdg-device-spec-content:hover {
  background-color: #FFFFFF;
}

.surface-laptop-family .wdg-device-highlight-tile.business-style .wdg-device-highlight-tile-content .wdg-device-specs-grid .wdg-device-specs-flex .wdg-device-category-content .wdg-device-spec-content:hover .c-heading-3 {
  color: #000000;
}

.surface-laptop-family .wdg-device-highlight-tile.business-style .wdg-device-highlight-tile-content .wdg-device-specs-grid .wdg-device-specs-flex .wdg-device-category-content .wdg-device-spec-content:hover .c-paragraph-3 {
  color: #000000;
}

.surface-laptop-family .wdg-device-highlight-tile.business-style .wdg-device-highlight-tile-content .wdg-device-specs-grid .wdg-device-specs-flex .wdg-device-category-content .wdg-device-spec-content:hover .c-group .c-call-to-action {
  color: #000000;
}

.surface-laptop-family .wdg-device-highlight-tile.bgcolor1 {
  background-color: #0078d4;
}

.surface-laptop-family .wdg-device-highlight-tile.bgcolor2 {
  background-color: #2f2f2f;
}

.surface-laptop-family .wdg-device-highlight-tile.bgcolor3 {
  background-color: #e6e6e6;
}

.surface-laptop-family .wdg-device-highlight-tile.bgcolor4 {
  background-color: #737373;
}

.surface-laptop-family .wdg-device-highlight-tile.bgcolor5 {
  background-color: #ffffff;
}

.surface-laptop-family .wdg-device-highlight-tile.bgcolor6 {
  background-color: #243a5e;
}

.surface-laptop-family .wdg-device-highlight-tile.bgcolor7 {
  background-color: #f9e9df;
}

.surface-laptop-family .wdg-device-highlight-tile.bgcolor8 {
  background-color: #f0eff4;
}

.surface-laptop-family .wdg-device-highlight-tile .wdg-device-m-image {
  position: -webkit-sticky;
  position: sticky;
  top: 0;
  /*z-index: -1;*/
  padding: 0;
}

@media screen and (max-width: 767px) {
  .surface-laptop-family .wdg-device-highlight-tile .wdg-device-m-image {
    position: initial;
  }
}

.surface-laptop-family .wdg-device-highlight-tile .wdg-device-m-image .wdg-device-m-picture img {
  width: 100%;
}

.surface-laptop-family .wdg-device-highlight-tile .wdg-device-highlight-tile-content {
  width: 50%;
  padding: 0 0 162px 144px;
}

@media screen and (max-width: 1400px) {
  .surface-laptop-family .wdg-device-highlight-tile .wdg-device-highlight-tile-content {
    width: 60%;
    padding: 0 0 162px 52px;
  }
}

@media screen and (max-width: 1400px) and (prefers-reduced-motion: reduce) {
  .surface-laptop-family .wdg-device-highlight-tile .wdg-device-highlight-tile-content {
    padding: 0 0 0 36px;
  }
}

@media screen and (max-width: 1083px) {
  .surface-laptop-family .wdg-device-highlight-tile .wdg-device-highlight-tile-content {
    width: 100%;
    padding: 0 136px 215px 136px;
  }
}

@media screen and (max-width: 1083px) and (prefers-reduced-motion: reduce) {
  .surface-laptop-family .wdg-device-highlight-tile .wdg-device-highlight-tile-content {
    padding: 0 95px 0 95px;
  }
}

@media screen and (max-width: 767px) {
  .surface-laptop-family .wdg-device-highlight-tile .wdg-device-highlight-tile-content {
    position: initial;
    -webkit-transform: initial;
            transform: initial;
    width: 100%;
    padding: 0 52px 146px 52px;
  }
}

.surface-laptop-family .wdg-device-highlight-tile .wdg-device-highlight-tile-content.content-z-index {
  position: relative;
  z-index: 1;
}

.surface-laptop-family .wdg-device-highlight-tile .wdg-device-highlight-tile-content .wdg-device-content {
  padding: 0 0 0 16px;
  position: relative;
}

@media screen and (min-width: 768px) {
  .surface-laptop-family .wdg-device-highlight-tile .wdg-device-highlight-tile-content .wdg-device-content {
    width: 70%;
  }
}

@media screen and (max-width: 767px) {
  .surface-laptop-family .wdg-device-highlight-tile .wdg-device-highlight-tile-content .wdg-device-content {
    padding: 0;
  }
}

.surface-laptop-family .wdg-device-highlight-tile .wdg-device-highlight-tile-content .wdg-device-content .c-heading-2 {
  font-size: 90px;
  line-height: 100px;
}

@media screen and (min-width: 1084px) and (max-width: 1400px) {
  .surface-laptop-family .wdg-device-highlight-tile .wdg-device-highlight-tile-content .wdg-device-content .c-heading-2 {
    font-size: 70px;
    line-height: 80px;
  }
}

@media screen and (min-width: 1084px) and (max-width: 1400px) and (prefers-reduced-motion: reduce) {
  .surface-laptop-family .wdg-device-highlight-tile .wdg-device-highlight-tile-content .wdg-device-content .c-heading-2 {
    font-size: 34px;
    line-height: 44px;
  }
}

@media screen and (max-width: 767px) {
  .surface-laptop-family .wdg-device-highlight-tile .wdg-device-highlight-tile-content .wdg-device-content .c-heading-2 {
    font-size: 66px;
    line-height: 76px;
  }
}

.surface-laptop-family .wdg-device-highlight-tile .wdg-device-highlight-tile-content .wdg-device-content .c-paragraph-2 {
  font-size: 26px;
  padding: 48px 0 0 0;
  line-height: 36px;
}

@media screen and (min-width: 1084px) and (max-width: 1400px) {
  .surface-laptop-family .wdg-device-highlight-tile .wdg-device-highlight-tile-content .wdg-device-content .c-paragraph-2 {
    font-size: 20px;
    line-height: 28px;
  }
}

@media screen and (min-width: 1084px) and (max-width: 1400px) and (prefers-reduced-motion: reduce) {
  .surface-laptop-family .wdg-device-highlight-tile .wdg-device-highlight-tile-content .wdg-device-content .c-paragraph-2 {
    font-size: 16px;
    line-height: 20px;
  }
}

@media screen and (max-width: 767px) {
  .surface-laptop-family .wdg-device-highlight-tile .wdg-device-highlight-tile-content .wdg-device-content .c-paragraph-2 {
    padding: 27px 0 0 0;
    font-size: 20px;
    line-height: 26px;
  }
}

.surface-laptop-family .wdg-device-highlight-tile .wdg-device-highlight-tile-content .wdg-device-content .c-call-to-action {
  background: transparent;
  color: #000000;
  font-weight: 700;
  margin-top: 48px;
}

.surface-laptop-family .wdg-device-highlight-tile .wdg-device-highlight-tile-content .wdg-device-content .c-call-to-action:focus {
  background: transparent;
  color: #000000;
  font-weight: 700;
}

.surface-laptop-family .wdg-device-highlight-tile .wdg-device-highlight-tile-content .wdg-device-content .c-call-to-action:hover {
  background: transparent;
  color: #000000;
  font-weight: 700;
}

.surface-laptop-family .wdg-device-highlight-tile .wdg-device-highlight-tile-content .wdg-device-content .c-call-to-action::after {
  font-weight: 700;
}

.surface-laptop-family .wdg-device-highlight-tile .wdg-device-highlight-tile-content .wdg-device-specs-grid {
  position: relative;
  padding: 169px 0 65px 0;
}

@media screen and (max-width: 767px) {
  .surface-laptop-family .wdg-device-highlight-tile .wdg-device-highlight-tile-content .wdg-device-specs-grid {
    padding: 66px 0 80px 0;
  }
}

.surface-laptop-family .wdg-device-highlight-tile .wdg-device-highlight-tile-content .wdg-device-specs-grid .wdg-device-specs-flex {
  display: -webkit-box;
  display: -ms-flexbox;
  display: flex;
  -ms-flex-wrap: wrap;
      flex-wrap: wrap;
}

.surface-laptop-family .wdg-device-highlight-tile .wdg-device-highlight-tile-content .wdg-device-specs-grid .wdg-device-specs-flex .wdg-device-category-content {
  width: 50%;
  padding: 16px;
  opacity: 0;
}

.surface-laptop-family .wdg-device-highlight-tile .wdg-device-highlight-tile-content .wdg-device-specs-grid .wdg-device-specs-flex .wdg-device-category-content.is-scrollDown {
  -webkit-animation: cards-fade 2s ease-in-out forwards;
          animation: cards-fade 2s ease-in-out forwards;
}

.surface-laptop-family .wdg-device-highlight-tile .wdg-device-highlight-tile-content .wdg-device-specs-grid .wdg-device-specs-flex .wdg-device-category-content.is-scrollTop {
  -webkit-animation: cards-fade 2s ease-in-out forwards;
          animation: cards-fade 2s ease-in-out forwards;
}

@media screen and (max-width: 767px) {
  .surface-laptop-family .wdg-device-highlight-tile .wdg-device-highlight-tile-content .wdg-device-specs-grid .wdg-device-specs-flex .wdg-device-category-content {
    width: 100%;
    padding: 52px 0 0 0;
  }
}

.surface-laptop-family .wdg-device-highlight-tile .wdg-device-highlight-tile-content .wdg-device-specs-grid .wdg-device-specs-flex .wdg-device-category-content .wdg-device-spec-content {
  position: relative;
  background-color: rgba(250, 250, 250, 0.8);
  color: #000000;
  border-radius: 10px;
  padding: 40px 40px 31px 40px;
  height: 100%;
  cursor: pointer;
}

.surface-laptop-family .wdg-device-highlight-tile .wdg-device-highlight-tile-content .wdg-device-specs-grid .wdg-device-specs-flex .wdg-device-category-content .wdg-device-spec-content:hover {
  background-color: #ffffff;
}

@media screen and (max-width: 767px) {
  .surface-laptop-family .wdg-device-highlight-tile .wdg-device-highlight-tile-content .wdg-device-specs-grid .wdg-device-specs-flex .wdg-device-category-content .wdg-device-spec-content {
    padding: 52px 52px 42px 52px;
  }
}

.surface-laptop-family .wdg-device-highlight-tile .wdg-device-highlight-tile-content .wdg-device-specs-grid .wdg-device-specs-flex .wdg-device-category-content .wdg-device-spec-content .wdg-device-tile-expand {
  position: absolute;
  width: 40px;
  height: 40px;
  background-color: transparent;
  border: 2px solid #000000;
  border-radius: 50%;
  top: 32px;
  right: 32px;
}

.surface-laptop-family .wdg-device-highlight-tile .wdg-device-highlight-tile-content .wdg-device-specs-grid .wdg-device-specs-flex .wdg-device-category-content .wdg-device-spec-content .wdg-device-tile-expand:focus-visible {
  outline: none;
}

.surface-laptop-family .wdg-device-highlight-tile .wdg-device-highlight-tile-content .wdg-device-specs-grid .wdg-device-specs-flex .wdg-device-category-content .wdg-device-spec-content .wdg-device-tile-expand:focus {
  border: 2px dashed #000000;
}

@media screen and (max-width: 767px) {
  .surface-laptop-family .wdg-device-highlight-tile .wdg-device-highlight-tile-content .wdg-device-specs-grid .wdg-device-specs-flex .wdg-device-category-content .wdg-device-spec-content .wdg-device-tile-expand {
    width: 45px;
    height: 45px;
    top: 36px;
    right: 36px;
  }
}

.surface-laptop-family .wdg-device-highlight-tile .wdg-device-highlight-tile-content .wdg-device-specs-grid .wdg-device-specs-flex .wdg-device-category-content .wdg-device-spec-content .wdg-device-tile-expand::before {
  font-family: "MWF-MDL2";
  font-size: 25px;
  display: inline-block;
  vertical-align: middle;
  color: #000000;
  content: "";
  font-weight: 700;
}

@supports (-webkit-touch-callout: none) 
{
  .surface-laptop-family .wdg-device-highlight-tile .wdg-device-highlight-tile-content .wdg-device-specs-grid .wdg-device-specs-flex .wdg-device-category-content .wdg-device-spec-content .wdg-device-tile-expand::before {
    margin-left: -7px;
  }
}

.surface-laptop-family .wdg-device-highlight-tile .wdg-device-highlight-tile-content .wdg-device-specs-grid .wdg-device-specs-flex .wdg-device-category-content .wdg-device-spec-content .popup-image {
  display: none;
}

.surface-laptop-family .wdg-device-highlight-tile .wdg-device-highlight-tile-content .wdg-device-specs-grid .wdg-device-specs-flex .wdg-device-category-content .wdg-device-spec-content .wdg-device-tile-logo img {
  padding: 40px 0 0 0;
}

.surface-laptop-family .wdg-device-highlight-tile .wdg-device-highlight-tile-content .wdg-device-specs-grid .wdg-device-specs-flex .wdg-device-category-content .wdg-device-spec-content .c-paragraph-2 {
  font-size: 26px;
  font-weight: 600;
  padding: 28px 0 0 0;
  line-height: 36px;
}

@media screen and (min-width: 1084px) and (max-width: 1400px) {
  .surface-laptop-family .wdg-device-highlight-tile .wdg-device-highlight-tile-content .wdg-device-specs-grid .wdg-device-specs-flex .wdg-device-category-content .wdg-device-spec-content .c-paragraph-2 {
    font-size: 20px;
    line-height: 30px;
  }
}

@media screen and (min-width: 1084px) and (max-width: 1400px) and (prefers-reduced-motion: reduce) {
  .surface-laptop-family .wdg-device-highlight-tile .wdg-device-highlight-tile-content .wdg-device-specs-grid .wdg-device-specs-flex .wdg-device-category-content .wdg-device-spec-content .c-paragraph-2 {
    font-size: 16px;
    line-height: 20px;
  }
}

@media screen and (max-width: 767px) {
  .surface-laptop-family .wdg-device-highlight-tile .wdg-device-highlight-tile-content .wdg-device-specs-grid .wdg-device-specs-flex .wdg-device-category-content .wdg-device-spec-content .c-paragraph-2 {
    font-size: 30px;
    line-height: 40px;
  }
}

.surface-laptop-family .wdg-device-highlight-tile .wdg-device-highlight-tile-content .wdg-device-specs-grid .wdg-device-model {
  position: absolute;
  top: 192px;
  width: 95%;
  color: #ffffff;
  background-color: #000000;
  display: none;
  padding: 32px 0;
  border-radius: 10px;
}


@media screen and (max-width: 767px) {
  .surface-laptop-family .wdg-device-highlight-tile .wdg-device-highlight-tile-content .wdg-device-specs-grid .wdg-device-model {
    padding: 36px 0;
    width: 100%;
  }
}

.surface-laptop-family .wdg-device-highlight-tile .wdg-device-highlight-tile-content .wdg-device-specs-grid .wdg-device-model.foldIn {
  width: 40%;
  -webkit-animation: unfoldIn 1s cubic-bezier(0.165, 0.84, 0.44, 1) forwards;
          animation: unfoldIn 1s cubic-bezier(0.165, 0.84, 0.44, 1) forwards;
}

@media screen and (max-width: 767px) {
  .surface-laptop-family .wdg-device-highlight-tile .wdg-device-highlight-tile-content .wdg-device-specs-grid .wdg-device-model.foldIn {
    -webkit-animation: unfoldInmobile 1s cubic-bezier(0.165, 0.84, 0.44, 1) forwards;
            animation: unfoldInmobile 1s cubic-bezier(0.165, 0.84, 0.44, 1) forwards;
  }
}

.surface-laptop-family .wdg-device-highlight-tile .wdg-device-highlight-tile-content .wdg-device-specs-grid .wdg-device-model.foldIn.foldout {
  -webkit-animation: unfoldOut 1s cubic-bezier(0.165, 0.84, 0.44, 1) forwards;
          animation: unfoldOut 1s cubic-bezier(0.165, 0.84, 0.44, 1) forwards;
}

.surface-laptop-family .wdg-device-highlight-tile .wdg-device-highlight-tile-content .wdg-device-specs-grid .wdg-device-model .wdg-device-cross {
  /*float: right;*/
  position: absolute;
  top: 32px;
  right: 32px;
  z-index: 1;
  width: 40px;
  height: 40px;
  background-color: transparent;
  border: 2px solid #FFFFFF;
  border-radius: 50%;
}

.surface-laptop-family .wdg-device-highlight-tile .wdg-device-highlight-tile-content .wdg-device-specs-grid .wdg-device-model .wdg-device-cross:focus-visible {
  outline: none;
}

.wdg-device-highlight-tile .wdg-device-highlight-tile-content .wdg-device-specs-grid .wdg-device-model .wdg-device-cross:focus {
  border: 2px dashed #FFFFFF;
}

.surface-laptop-family .wdg-device-highlight-tile .wdg-device-highlight-tile-content .wdg-device-specs-grid .wdg-device-model .wdg-device-cross::before {
  font-family: "MWF-MDL2";
  font-size: 25px;
  display: inline-block;
  vertical-align: middle;
  color: #FFFFFF;
  content: "";
  font-weight: 700;
}

@supports (-webkit-touch-callout: none) {
  .surface-laptop-family .wdg-device-highlight-tile .wdg-device-highlight-tile-content .wdg-device-specs-grid .wdg-device-model .wdg-device-cross::before {
    margin-left: -7px;
  }
}

.surface-laptop-family .wdg-device-highlight-tile .wdg-device-highlight-tile-content .wdg-device-specs-grid .wdg-device-model .modal-content {
  display: -ms-grid;
  display: grid;
  place-content: center;
  padding: 40px;
}

@media screen and (min-width: 768px) {
  .surface-laptop-family .wdg-device-highlight-tile .wdg-device-highlight-tile-content .wdg-device-specs-grid .wdg-device-model .modal-content {
    position: relative;
    top: 50%;
    -webkit-transform: translateY(-50%);
            transform: translateY(-50%);
  }
}

.surface-laptop-family .wdg-device-highlight-tile .wdg-device-highlight-tile-content .wdg-device-specs-grid .wdg-device-model .modal-content .c-image {
  display: none;
  border-radius: 10px;
}
.surface-laptop-family .wdg-device-highlight-tile .wdg-device-highlight-tile-content .wdg-device-specs-grid .wdg-device-model .modal-content video{
    border-radius: 10px;
}
.surface-laptop-family .wdg-device-highlight-tile .wdg-device-highlight-tile-content .wdg-device-specs-grid .wdg-device-model .modal-content .m-ambient-video {
  padding: 40px 0 0 0;
  display: none;
  /*min-width: 100%;*/
  /*@media (prefers-reduced-motion: reduce) {
                        padding: 28px 5px 28px 28px;
                    }*/
}

@media screen and (min-width: 2000px) {
  .surface-laptop-family .wdg-device-highlight-tile .wdg-device-highlight-tile-content .wdg-device-specs-grid .wdg-device-model .modal-content .m-ambient-video {
    max-width: 660px;
  }
}

@media screen and (max-width: 767px) {
 .surface-laptop-family .wdg-device-highlight-tile .wdg-device-highlight-tile-content .wdg-device-specs-grid .wdg-device-model .modal-content .m-ambient-video {
    padding: 52px 0;
  }
  .surface-laptop-family .wdg-device-highlight-tile .wdg-device-highlight-tile-content .wdg-device-specs-grid .wdg-device-model .modal-content .c-image
  {
      margin: 52px 0px;
  }
}

.surface-laptop-family .wdg-device-highlight-tile .wdg-device-highlight-tile-content .wdg-device-specs-grid .wdg-device-model .modal-content .m-ambient-video .tilevideo {
  height: auto;
}

.surface-laptop-family .wdg-device-highlight-tile .wdg-device-highlight-tile-content .wdg-device-specs-grid .wdg-device-model .modal-content .m-ambient-video .refresh-btn {
  position: absolute;
  bottom: 20px;
  right: 20px;
  width: 40px;
  height: 40px;
  background-color: transparent;
  border: 2px solid #FFFFFF;
  border-radius: 50%;
  border: none;
}

.surface-laptop-family .wdg-device-highlight-tile .wdg-device-highlight-tile-content .wdg-device-specs-grid .wdg-device-model .modal-content .m-ambient-video .refresh-btn:focus-visible {
  outline: none;
}

.surface-laptop-family .wdg-device-highlight-tile .wdg-device-highlight-tile-content .wdg-device-specs-grid .wdg-device-model .modal-content .m-ambient-video .refresh-btn:focus {
  border: 2px dashed #FFFFFF;
}

.surface-laptop-family .wdg-device-highlight-tile .wdg-device-highlight-tile-content .wdg-device-specs-grid .wdg-device-model .modal-content .m-ambient-video .refresh-btn::before {
  font-family: "MWF-MDL2";
  font-size: 25px;
  display: inline-block;
  vertical-align: middle;
  color: #FFFFFF;
  content: "";
  font-weight: 700;
  -webkit-transform: rotate(75deg);
          transform: rotate(75deg);
}

.surface-laptop-family .wdg-device-highlight-tile .wdg-device-highlight-tile-content .wdg-device-specs-grid .wdg-device-model .modal-content .c-paragraph-2 {
  padding: 40px 8px 0 0;
  /*position: relative;*/
}

@media screen and (max-width: 767px) {
  .surface-laptop-family .wdg-device-highlight-tile .wdg-device-highlight-tile-content .wdg-device-specs-grid .wdg-device-model .modal-content .c-paragraph-2 {
    /*position: initial;*/
    font-size: 20px;
    line-height: 26px;
  }
}

.surface-laptop-family .wdg-device-highlight-tile .wdg-device-highlight-tile-content .wdg-device-specs-grid .wdg-device-model .focus-jump-close {
  opacity: 0;
  position: absolute;
}

[lang^="ar-"] .surface-laptop-family .wdg-device-highlight-tile {
  direction: ltr;
}

[lang^="ar-"] .surface-laptop-family .wdg-device-highlight-tile .wdg-device-highlight-tile-content {
  direction: rtl;
}

[lang^="ar-"] .surface-laptop-family .wdg-device-highlight-tile .wdg-device-highlight-tile-content .wdg-device-specs-grid .wdg-device-specs-flex .wdg-device-category-content .wdg-device-spec-content .c-group .c-call-to-action {
  direction: ltr;
}

@-webkit-keyframes cards-fade {
  0% {
    opacity: 0;
  }
  100% {
    opacity: 1;
  }
}

@keyframes cards-fade {
  0% {
    opacity: 0;
  }
  100% {
    opacity: 1;
  }
}

@-webkit-keyframes unfoldIn {
  0% {
    width: 40%;
    height: 0;
    opacity: 0;
  }
  100% {
    width: 95%;
    height: auto;
    opacity: 1;
  }
}

@keyframes unfoldIn {
  0% {
    width: 40%;
    height: 0;
    opacity: 0;
  }
  100% {
    width: 95%;
    height: auto;
    opacity: 1;
  }
}

@-webkit-keyframes unfoldInmobile {
  0% {
    width: 40%;
    height: 0;
    opacity: 0;
  }
  100% {
    width: 100%;
    height: auto;
    opacity: 1;
  }
}

@keyframes unfoldInmobile {
  0% {
    width: 40%;
    height: 0;
    opacity: 0;
  }
  100% {
    width: 100%;
    height: auto;
    opacity: 1;
  }
}

@-webkit-keyframes unfoldOut {
  0% {
    width: 100%;
    height: auto;
    opacity: 1;
  }
  /*50% {
        opacity: 0.3;
    }
    75%{
        opacity: 0;
    }*/
  100% {
    width: 50%;
    opacity: 0;
  }
}

@keyframes unfoldOut {
  0% {
    width: 100%;
    height: auto;
    opacity: 1;
  }
  /*50% {
        opacity: 0.3;
    }
    75%{
        opacity: 0;
    }*/
  100% {
    width: 50%;
    opacity: 0;
  }
}

@media screen and (min-width: 768px) {
    .surface-laptop-family .wdg-device-highlight-tile .wdg-device-highlight-tile-content .wdg-device-specs-grid .wdg-device-model .modal-content .c-image
  {
     margin: 40px 0 0 0;
  }
  .surface-laptop-family .wdg-device-highlight-tile .desktop-img {
    display: block;
  }
 .surface-laptop-family .mobile-img {
    display: none;
  }
}

@media screen and (max-width: 767px) {
  /*.surface-laptop-family .desktop-img {
    display: none;
  }*/
  .surface-laptop-family .mobile-img {
    display: block;
  }
}
/*# sourceMappingURL=style.css.map */

/*interactive cards end*/


/*START Feature360*/

.surface-laptop-family .feature_summary_360 {
    background-color: #2f2f2f;
    color: #ffffff;
}

.surface-laptop-family .feature_summary_360 .family-feature-360 {
    overflow: visible;
    /*padding: 0px;*/
}

.surface-laptop-family .feature_summary_360 .family-feature-360>div {
    position: relative;
    padding-left: 0px;
}

.surface-laptop-family .feature_summary_360 .feature_summary_360_left .feature_summary_360_animation .feature_summary_360_content h2.c-heading {
    font-size: 90px;
    line-height: 120px;
    font-weight: 600;
    padding: 24px 0 50px;
    margin-top: 0px;
}

.surface-laptop-family .feature_summary_360 .feature_summary_360_left .feature_summary_360_animation .feature_summary_360_content p.c-paragraph {
    font-size: 26px;
    line-height: 36px;
    font-weight: 600;
}

@media screen and (min-width: 1084px) {
    .surface-laptop-family .feature_summary_360 .feature_summary_360_left {
        display: flex;
    }
    .surface-laptop-family .feature_summary_360 .feature_summary_360_left .feature_summary_360_animation .feature_summary_360_content {
        width: 90%;
    }
    .surface-laptop-family .feature_summary_360 .feature_summary_360_left .feature_summary_360_image {
        width: 50%;
    }
    .surface-laptop-family .feature_summary_360 .family-feature-360>div {
        flex-direction: row;
        align-items: center;
    }
      .surface-laptop-family .feature_summary_360 .family-feature-360>div {
        -webkit-box-orient: horizontal;
        -webkit-box-direction: normal;
        -webkit-box-align: center;
    }
}


.surface-laptop-family .feature_summary_360 .feature_summary_360_left .feature_summary_360_animation {
    transform: none;
    position: relative;
    padding-left: 0px;
    
}

.surface-laptop-family .feature_summary_360 .feature_summary_360_left .feature_summary_360_animation a {
    border-radius: 10px;
    color: #2f2f2f;
    background-color: #ffffff;
    font-size: 20px;
    font-weight: 600;
    margin-top: 60px;
}

.surface-laptop-family .feature_summary_360 .feature_summary_360_left .feature_summary_360_animation a.c-button:focus:not(.x-hidden-focus),
.surface-laptop-family .feature_summary_360 .feature_summary_360_left .feature_summary_360_animation a.c-button:hover {
    background-color: #ffffff;
    text-decoration: underline;
}
.surface-laptop-family .feature_summary_360 .feature_summary_360_left .feature_summary_360_animation a.c-button:active{
    background-color: #ffffff;
}
.surface-laptop-family .feature_summary_360 .feature_summary_360_left .feature_summary_360_animation.is-scrollDown,
.surface-laptop-family .feature_summary_360 .feature_summary_360_left .feature_summary_360_animation.is-scrollTop,
.surface-laptop-family .m-multi-feature .feature-swatch .feature-swatch-content .swatch-content-animation.is-scrollDown,
.surface-laptop-family .m-multi-feature .feature-swatch .feature-swatch-content .swatch-content-animation.is-scrollTop,
.surface-laptop-family .family-color-picker .family-color-picker-container .family-color-picker-content.is-scrollTop,
.surface-laptop-family .family-color-picker .family-color-picker-container .family-color-picker-content.is-scrollDown {
    -webkit-animation: animation360 2s forwards;
    animation: animation360 2s forwards;
}

@-webkit-keyframes animation360 {
    0% {
        opacity: 0;
    }
    100% {
        opacity: 1;
    }
}

@keyframes animation360 {
    0% {
        opacity: 0;
    }
    100% {
        opacity: 1;
    }
}

.surface-laptop-family .feature_summary_360 .feature_summary_360_left .feature_summary_360_image .feature360-viewportimages {
    display: none;
}

.surface-laptop-family .feature_summary_360 .feature_summary_360_left .feature_summary_360_image img {
    width: 100%;
}

.surface-laptop-family .feature_summary_360 .feature_summary_360_left .feature_summary_360_image .featureimage360-sprite {
    position: relative;
    width: 100%;
    height: 0;
    background-size: 100%;
    padding-bottom: 58.5%;
    background-position-y: 0%;
    cursor: default;
}

.surface-laptop-family .feature_summary_360 .feature_summary_360_left .feature_summary_360_image .featureimage360-center input.thinSlider {
    cursor: pointer;
    pointer-events: auto;
    background: transparent;
    width: 70%;
}

.surface-laptop-family .feature_summary_360 .feature_summary_360_left .feature_summary_360_image .featureimage360-center input.thinSlider::-webkit-slider-thumb{
  -webkit-appearance: none;
  margin-top: -2.5px;
    height: 6.5px;
    width: 130px;
    border: none;
    border-radius: 3px;
    background: #f2f2f2;
    cursor: pointer;
}
.surface-laptop-family .feature_summary_360 .feature_summary_360_left .feature_summary_360_image .featureimage360-center input.thinSlider::-moz-range-thumb {
    margin-top: -2.5px;
    height: 6.5px;
    width: 130px;
    border: none;
    border-radius: 3px;
    background: #f2f2f2;
    cursor: pointer;
}
@media screen and (-ms-high-contrast: active) {
.surface-laptop-family .feature_summary_360 .feature_summary_360_left .feature_summary_360_image .featureimage360-center input.featureimage360-slider::-webkit-slider-thumb{
  border: 3px solid #fff;
}
.surface-laptop-family .feature_summary_360 .feature_summary_360_left .feature_summary_360_image .featureimage360-center input.featureimage360-slider::-moz-range-thumb{
    border: 3px solid #fff;
}
.surface-laptop-family .feature_summary_360 .feature_summary_360_left .feature_summary_360_image .featureimage360-center input.thinSlider::-webkit-slider-runnable-track{
  border: 1px solid #959595;
}
.surface-laptop-family .feature_summary_360 .feature_summary_360_left .feature_summary_360_image .featureimage360-center input.thinSlider::-moz-range-track {
    border: 1px solid #959595;
}
}
.surface-laptop-family .feature_summary_360 .feature_summary_360_left .feature_summary_360_image .featureimage360-center input.thinSlider::-webkit-slider-runnable-track{
  width: 100%;
    height: 2.5px;
    cursor: pointer;
    background: #959595;
}
.surface-laptop-family .feature_summary_360 .feature_summary_360_left .feature_summary_360_image .featureimage360-center input.thinSlider::-moz-range-track {
    width: 100%;
    height: 2.5px;
    cursor: pointer;
    background: #959595;
}

.surface-laptop-family .feature_summary_360 .feature-iconpanel-360 {
    padding: 180px 30px 30px 30px;
    width: 60%;
}

@media screen and (max-width: 1083px) {
    .surface-laptop-family .feature_summary_360 .feature-iconpanel-360 {
        width: 100%;
    }
    .surface-laptop-family .feature_summary_360 .feature-iconpanel-360 ul {
        flex-direction: column;
        flex-wrap: nowrap;
    }
    .surface-laptop-family .feature_summary_360 .feature-iconpanel-360 li {
        width: 100%;
    }
}

.surface-laptop-family .feature_summary_360 .feature-iconpanel-360 ul {
    display: flex;
    flex-direction: row;
    flex-wrap: wrap;
    -webkit-box-orient: horizontal;
    -webkit-box-direction: normal;
    /*height: 450px;*/
    align-content: flex-start;
}

.surface-laptop-family .feature_summary_360 .feature-iconpanel-360 ul li {
    width: 50%;
    display: -webkit-box;
    display: -ms-flexbox;
    display: flex;
    align-items: center;
    justify-content: flex-start;
    padding-bottom: 60px;
    -webkit-box-align: center;
    -ms-flex-align: center;
    -webkit-box-pack: start;
    -ms-flex-pack: start;
}

.surface-laptop-family .feature_summary_360 .feature-iconpanel-360 ul li img {
    width: auto;
}

.surface-laptop-family .feature_summary_360 .feature-iconpanel-360 ul li .c-paragraph-3 {
    font-size: 30px;
    line-height: 42px;
    font-weight: 600;
    padding-top: 0;
    padding-left: 15px;
}

@media screen and (max-width: 540px) {
.surface-laptop-family .feature_summary_360 .feature-iconpanel-360 li {
        width: 100%;
    }
}
@media screen and (max-width: 767px) {
  .surface-laptop-family .feature_summary_360 .family-feature-360
  {
    padding-left: 24px;
    padding-right: 24px;
  }
  .surface-laptop-family .feature_summary_360 .family-feature-360>div
  {
    padding-left: 20px;
  }
.surface-laptop-family .feature_summary_360 .feature-iconpanel-360 ul li {
        width: 100%;
    }
     .surface-laptop-family .feature_summary_360 .feature_summary_360_left .feature_summary_360_animation
    {
        text-align: left;
        margin-left: 0px;
    }
}
@media only screen and (min-width: 768px) and (max-width: 1083px) 
{
    .surface-laptop-family .feature_summary_360 .feature-iconpanel-360
    {
        padding: 140px 30px 4px 30px;
    }
    .surface-laptop-family .feature_summary_360 .feature_summary_360_left .feature_summary_360_animation
    {
        text-align: left;
        width: 90%;
        padding-bottom: 128px;
    }
    .surface-laptop-family .feature_summary_360 .feature_summary_360_left .feature_summary_360_animation .feature_summary_360_content h2.c-heading
    {
            padding: 24px 0 20px;
    }
   .surface-laptop-family .surface-laptop-family .feature_summary_360 .family-feature-360
   {
           padding-left: 50px;
   }
   .surface-laptop-family .feature_summary_360 .family-feature-360>div{
         padding-left: 5%;
         padding-right: 5%;
   }
}
/*------------END Feature360----------*/


/*devicefamily start*/
.surface-laptop-family .surface-FamilyDevices .m-banner .c-heading-1 {
    font-size: 90px;
    line-height: 120px;
    font-weight: 600;    
    color: #2f2f2f;    
    
}

.surface-laptop-family .surface-FamilyDevices.scrollablePrevious .m-channel-placement {
    padding-right: 8%;
}

@media only screen and (max-width: 1083px) {
    .surface-laptop-family .surface-FamilyDevices.scrollablePrevious .m-channel-placement {
        padding-right: 32px;
    }
     .surface-laptop-family .surface-FamilyDevices .m-banner {
        width: 50%;
        padding-top: 84px;
        padding-left: 92px;
    }
     .surface-laptop-family .surface-FamilyDevices .m-channel-placement {
        padding-left: 0;
        padding-right: 0;
        padding-top: 55px !important;
    }
     .surface-laptop-family .surface-FamilyDevices .m-channel-placement .c-carousel {
        padding-left: 32px;
    }
    .surface-laptop-family .surface-FamilyDevices .m-channel-placement .c-carousel.f-scrollable-previous {
        padding-left: 0;
    }
    .surface-laptop-family .surface-FamilyDevices .m-channel-placement .c-carousel ul>li {
        padding-right: 13px;
    }
    .surface-laptop-family .surface-FamilyDevices .m-channel-placement .c-carousel .c-flipper.f-previous:before {
        font-size: 25px;
    }
     .surface-laptop-family .surface-FamilyDevices .m-channel-placement .c-carousel .c-flipper.f-previous {
        left: 160px;
        width: 55px;
        height: 55px;
    }
     .surface-laptop-family .surface-FamilyDevices .m-channel-placement .c-carousel .c-flipper.f-next:before {
        font-size: 25px;
    }
     .surface-laptop-family .surface-FamilyDevices .m-channel-placement .c-carousel .c-flipper.f-next {
        right: 160px;
        width: 55px;
        height: 55px;
    }
     .surface-laptop-family .surface-FamilyDevices .m-channel-placement-item.f-wide .family-device-content {
        padding-left: 44px;
        padding-right: 44px;
    }
    .surface-laptop-family .surface-FamilyDevices .m-channel-placement-item.f-wide .c-channel-placement-content .c-heading-4 {
        font-size: 36px;
        line-height: 36px;
    }
    .surface-laptop-family .surface-FamilyDevices .m-channel-placement-item.f-wide .c-channel-placement-content .c-paragraph-2 {
        font-size: 22px;
        line-height: 24px;
    }
 .surface-laptop-family .surface-FamilyDevices .m-channel-placement-item.f-wide .FamilyDevices-specification-list li div.text .c-paragraph {
        font-size: 18px;
        line-height: 24px;
    }
     .surface-laptop-family .surface-FamilyDevices .m-channel-placement-item.f-wide .FamilyDevices-action .c-call-to-action {
        padding: 10px 0;
    }
     .surface-laptop-family .surface-FamilyDevices .m-channel-placement-item.f-wide {
        width: 400px;
    }
     .surface-laptop-family .surface-FamilyDevices .m-channel-placement-item.f-wide {
        width: 370px;
    }
}

@media only screen and (max-width: 540px) {
    .surface-laptop-family .surface-FamilyDevices.scrollablePrevious .m-channel-placement {
        padding-right: 20px;
    }
     .surface-FamilyDevices .m-banner {
        width: 75%;
    }
     .surface-laptop-family .surface-FamilyDevices .m-channel-placement .c-flipper.f-previousbtn {
        left: 5px;
    }
     .surface-laptop-family .surface-FamilyDevices .m-channel-placement .c-flipper.f-nextbtn {
        right: 5px;
        display: block;
        visibility: visible;
    }
     .surface-laptop-family .surface-FamilyDevices .m-channel-placement:hover .c-flipper.f-nextbtn {
        display: block;
        visibility: visible;
    }
      .surface-laptop-family .surface-FamilyDevices .m-channel-placement .c-carousel {
        padding-left: 20px;
    }
    .surface-laptop-family .surface-FamilyDevices .m-channel-placement .c-carousel.f-scrollable-previous {
        padding-left: 5px;
    }
     .surface-laptop-family .surface-FamilyDevices .m-channel-placement .c-carousel ul>li {
        padding-left: 5px;
        padding-right: 10px;
    }
    .surface-laptop-family .surface-FamilyDevices .m-channel-placement .c-carousel .device-family-maindiv .c-sequence-indicator {
        display: block;
    }
    /*BUG: 146956*/
    /*.surface-laptop-family .surface-FamilyDevices .m-channel-placement .c-carousel .c-flipper.f-previous {
        display: none;
    }
    .surface-laptop-family .surface-FamilyDevices .m-channel-placement .c-carousel .c-flipper.f-next {
        display: none;
    }*/
    .surface-laptop-family .surface-FamilyDevices .m-channel-placement-item.f-wide .c-channel-placement-content .c-paragraph-2 {
        padding: 40px 0 12px;
    }  
 .surface-laptop-family .surface-FamilyDevices .m-channel-placement-item.f-wide .FamilyDevices-specification-list li div.text .c-paragraph {
        font-size: 20px;
        line-height: 30px;
    }
    .surface-laptop-family .surface-laptop-family .surface-FamilyDevices .m-channel-placement-item.f-wide .FamilyDevices-action .c-call-to-action {
        padding: 6px 0;
    }    
     .surface-laptop-family .surface-FamilyDevices .m-channel-placement-item.f-wide {
        width: 300px;
    }
}

@media only screen and (max-width: 475px) {
    .surface-laptop-family .surface-FamilyDevices.scrollablePrevious .m-channel-placement {
        padding-left: 10px;
        padding-right: 10px;
    }
      .surface-laptop-family .surface-FamilyDevices .m-channel-placement .c-carousel {
        padding-left: 10px;
        padding-right: 5px;
    }
    .surface-laptop-family .surface-FamilyDevices .m-channel-placement .c-carousel.f-scrollable-previous {
        padding-left: 5px;
    }
    .surface-laptop-family .surface-FamilyDevices .m-channel-placement-item.f-wide {
        width: 280px;
    }
}

.surface-laptop-family .surface-FamilyDevices .m-banner {
    width: 50%;
    padding-top: 96px;
    text-align: left;
    margin: 0;
    padding-left: 8%;
}


@media only screen and (max-width: 767px) {
    .surface-laptop-family .surface-FamilyDevices .m-banner {
        width: 65%;
        padding-top: 84px;
        padding-left: 20px;
    }
      .surface-laptop-family .surface-FamilyDevices .m-banner .c-heading-1 {
        font-size: 46px;
        line-height: 46px;
    }
     .surface-laptop-family .surface-FamilyDevices .m-banner .c-paragraph-2 {
        font-size: 20px;
        line-height: 24px;
    }
    .surface-laptop-family .surface-FamilyDevices .m-channel-placement {
        padding-left: 0px;
        padding-top: 34px;
    }
    .surface-laptop-family .surface-FamilyDevices .m-channel-placement .c-carousel .device-family-maindiv {
        padding-bottom: 40px;
    }
      .surface-laptop-family .surface-FamilyDevices .m-channel-placement .c-carousel .c-flipper.f-previous {
        left: 85px;
    }
     .surface-laptop-family .surface-FamilyDevices .m-channel-placement .c-carousel .c-flipper.f-next {
        right: 85px;
    }
     .surface-laptop-family .surface-FamilyDevices .m-channel-placement-item.f-wide .family-device-content {
        padding-left: 20px;
        padding-right: 20px;
    }
     .surface-laptop-family .surface-FamilyDevices .m-channel-placement-item.f-wide {
        margin-right: 4px;
    }
    .surface-laptop-family .surface-laptop-family .surface-FamilyDevices .m-channel-placement-item.f-wide .c-channel-placement-content .c-heading-4 {
        font-size: 32px;
        line-height: 32px;
    }
    .surface-laptop-family .surface-FamilyDevices .m-channel-placement-item.f-wide .c-channel-placement-content .c-paragraph-2 {
        padding: 26px 0 0px;
    }
}
@media only screen and (max-width: 425px) {
    .surface-laptop-family .surface-FamilyDevices .m-banner {
        width: 95%;
    }
}



.surface-laptop-family .surface-FamilyDevices .m-banner .c-paragraph-2 {
    padding: 25px 0 23px;
    color: #2f2f2f;
    font-size: 26px;
    line-height: 40px;
}
.surface-laptop-family .surface-FamilyDevices .m-channel-placement {
    padding-top: 36px;
    max-width: 100%;
}
.surface-laptop-family .surface-FamilyDevices .m-channel-placement .c-flipper.f-previousbtn {
    opacity: 1;
    box-shadow: 0 4px 8px #222;
    width: 55px;
    height: 55px;
    display: none;
}

.surface-laptop-family .surface-FamilyDevices .m-channel-placement .c-flipper.f-previousbtn:before {
    font-size: 25px;
    content: "\E76B";
    margin-right: 2px;
    font-family: "MWF-MDL2";
}
.surface-laptop-family .surface-FamilyDevices .m-channel-placement .c-flipper.f-nextbtn {
    opacity: 1;
    box-shadow: 0 4px 8px #222;
    width: 55px;
    height: 55px;
    display: none;
}

.surface-laptop-family .surface-FamilyDevices .m-channel-placement .c-flipper.f-nextbtn:before {
    font-size: 25px;
    content: "\E76C";
    margin-left: 2px;
    font-family: "MWF-MDL2";
}

.surface-laptop-family .surface-FamilyDevices .m-channel-placement .c-carousel {
    padding-left: 8%;
}

.surface-laptop-family .surface-FamilyDevices .m-channel-placement .c-carousel.f-scrollable-previous {
    padding-left: 0;
}
.surface-laptop-family .surface-FamilyDevices .m-channel-placement .c-carousel ul {
    margin-top: 0;
    white-space: inherit;
}

.surface-laptop-family .surface-FamilyDevices .m-channel-placement .c-carousel ul>li {
    padding-right: 16px;
    padding-top: 10px;
    vertical-align: top;
    padding-bottom: 10px;
}

.surface-laptop-family .surface-FamilyDevices .m-channel-placement .c-carousel ul>li:nth-child(1) {
    padding-left: 5px;
}
.surface-laptop-family .surface-FamilyDevices .m-channel-placement .c-carousel ul>li:last-child {
    padding-right: 5px;
}

.surface-laptop-family .surface-FamilyDevices .m-channel-placement .c-carousel ul>li:last-child .m-channel-placement-item {
    margin-right: 0;
}
.surface-laptop-family .surface-FamilyDevices .m-channel-placement .c-carousel .device-family-maindiv .c-sequence-indicator {
    display: none;
}
.surface-laptop-family .surface-FamilyDevices .m-channel-placement .c-carousel .device-family-maindiv .c-sequence-indicator button {
    width: 20px;
    height: 18px;
}

.surface-laptop-family .surface-FamilyDevices .m-channel-placement .c-carousel .c-flipper.f-previous {
    left: 70px;
    opacity: 1;
    box-shadow: 0 4px 8px #222;
    width: 75px;
    height: 75px;
}

.surface-laptop-family .surface-FamilyDevices .m-channel-placement .c-carousel .c-flipper.f-previous:before {
    font-size: 35px;
}
@media only screen and (min-width: 1800px) {
    .surface-laptop-family .surface-FamilyDevices .m-channel-placement .c-carousel .c-flipper.f-previous {
        left: 150px;
    }
}

@media only screen and (min-width: 1920px) {
    .surface-laptop-family .surface-FamilyDevices .m-channel-placement .c-carousel .c-flipper.f-previous {
        left: 110px;
        width: 75px;
        height: 75px;
    }
}

@media only screen and (min-width: 2200px) {
    .surface-laptop-family .surface-FamilyDevices .m-channel-placement .c-carousel .c-flipper.f-previous {
        left: 250px;
        width: 75px;
        height: 75px;
    }
}
@media only screen and (max-width: 992px) {
    .surface-laptop-family .surface-FamilyDevices .m-channel-placement .c-carousel .c-flipper.f-previous {
        left: 140px;
    }
}

@media only screen and (max-width: 700px) {
    .surface-laptop-family .surface-FamilyDevices .m-channel-placement .c-carousel .c-flipper.f-previous {
        left: 10px;
    }
}
.surface-laptop-family .surface-FamilyDevices .m-channel-placement .c-carousel .c-flipper.f-next {
    right: 70px;
    opacity: 1;
    box-shadow: 0 4px 8px #222;
    width: 75px;
    height: 75px;
}

.surface-laptop-family .surface-FamilyDevices .m-channel-placement .c-carousel .c-flipper.f-next:before {
    font-size: 35px;
}
@media only screen and (min-width: 1800px) {
    .surface-laptop-family .surface-FamilyDevices .m-channel-placement .c-carousel .c-flipper.f-next {
        right: 150px;
    }
}

@media only screen and (min-width: 1920px) {
    .surface-laptop-family .surface-FamilyDevices .m-channel-placement .c-carousel .c-flipper.f-next {
        right: 110px;
        width: 75px;
        height: 75px;
    }
}

@media only screen and (min-width: 2200px) {
    .surface-laptop-family .surface-FamilyDevices .m-channel-placement .c-carousel .c-flipper.f-next {
        right: 250px;
        width: 75px;
        height: 75px;
    }
}
@media only screen and (max-width: 992px) {
    .surface-laptop-family .surface-FamilyDevices .m-channel-placement .c-carousel .c-flipper.f-next {
        right: 140px;
    }
}
@media only screen and (max-width: 700px) {
    .surface-laptop-family .surface-FamilyDevices .m-channel-placement .c-carousel .c-flipper.f-next {
        right: 10px;
    }
}
.surface-laptop-family .surface-FamilyDevices .m-channel-placement-item.f-wide {
    background-color: #f0f0f0;
    height: 100%;
    width: 350px;
    border-radius: 8px;
    padding-top: 5px !important;
    padding-bottom: 22px;
    margin-right: 16px;
    margin-bottom: 0;
    position: relative;
}

@media (min-width: 1084px) {
    .surface-laptop-family .surface-FamilyDevices .m-channel-placement-item.f-wide .family-device-content {
        padding-left: 56px;
        padding-right: 56px;
    }
}
.surface-laptop-family .surface-FamilyDevices .m-channel-placement-item.f-wide .c-channel-placement-image {
    text-align: center;
    margin-bottom: 2px;
    margin-top: 28px;
}

.surface-laptop-family .surface-FamilyDevices .m-channel-placement-item.f-wide .c-channel-placement-image picture {
    max-height: 100% !important;
    max-width: 100%;
}

.surface-laptop-family .surface-FamilyDevices .m-channel-placement-item.f-wide .c-channel-placement-content {
    height: auto;
    padding: 0;
}

.surface-laptop-family .surface-FamilyDevices .m-channel-placement-item.f-wide .c-channel-placement-content .badgeDiv {
    min-height: 25px;
}

.surface-laptop-family .surface-FamilyDevices .m-channel-placement-item.f-wide .c-channel-placement-content .c-heading-4 {
    font-size: 40px;
    line-height: 40px;
    color: #2f2f2f;
    padding-top: 10px;
}
.surface-laptop-family .surface-FamilyDevices .m-channel-placement-item.f-wide .c-channel-placement-content .c-paragraph-2 {
    padding: 25px 0 0px;
    color: #2f2f2f;
    font-size: 24px;
    font-style: italic;
    line-height: 30px;
}


.surface-laptop-family .surface-FamilyDevices .m-channel-placement-item.f-wide .c-channel-placement-content .c-channel-placement-price {
    position: relative;
    padding: 10px 0;
}

.surface-laptop-family .surface-FamilyDevices .m-channel-placement-item.f-wide .c-channel-placement-content .c-channel-placement-price .c-price {
    font-style: italic;
}

.surface-laptop-family .surface-FamilyDevices .m-channel-placement-item.f-wide .c-channel-placement-description {
    height: auto;
    min-height: 60px;
    padding: 5px 0px 45px;
    color: #2f2f2f;
}

.surface-laptop-family .surface-FamilyDevices .m-channel-placement-item.f-wide .c-logo.color-swatch img {
    height: auto;
    max-width: 100%;
}

.surface-laptop-family .surface-FamilyDevices .m-channel-placement-item.f-wide .m-color-picker {
    padding-top: 10px;
    bottom: 0;
    margin: 0 5px;
    display: block;
    height: auto;
}

.surface-laptop-family .surface-laptop-family.surface-FamilyDevices .m-channel-placement-item.f-wide .m-color-picker li {
    text-align: center;
}

.surface-laptop-family .surface-FamilyDevices .m-channel-placement-item.f-wide .FamilyDevices-specification-list {
    list-style-type: none;
    display: flex;
    flex-direction: column;
    height: auto;
    padding: 40px 0px 15px;
}

.surface-laptop-family .surface-FamilyDevices .m-channel-placement-item.f-wide .FamilyDevices-specification-list li {
    display: flex;
    align-items: center;
    padding: 0px 0 40px;
    min-height: 45px;
}

.surface-laptop-family .surface-FamilyDevices .m-channel-placement-item.f-wide .FamilyDevices-specification-list li:nth-child(1) {
    padding-left: 0px;
}

.surface-laptop-family .surface-FamilyDevices .m-channel-placement-item.f-wide .FamilyDevices-specification-list li div.text {
    padding-left: 10px;
}

.surface-laptop-family .surface-FamilyDevices .m-channel-placement-item.f-wide .FamilyDevices-specification-list li div.text .c-paragraph {
    font-size: 20px;
    color: #2f2f2f;
}
.surface-laptop-family .surface-FamilyDevices .m-channel-placement-item.f-wide .FamilyDevices-specification-list li div.text .c-paragraph p {
    margin: 0 !important;
}

.surface-laptop-family .surface-FamilyDevices .m-channel-placement-item.f-wide .FamilyDevices-specification-list li span {
    padding-left: 8px;
}
.surface-laptop-family .surface-FamilyDevices .m-channel-placement-item.f-wide .FamilyDevices-specification-list li a.supBLink span {
    padding-left: 0px;
}
.surface-laptop-family .surface-FamilyDevices .m-channel-placement-item.f-wide .FamilyDevices-action {
    text-align: center;
    width: 100%;
    padding-bottom: 24px;
}

.surface-laptop-family .surface-FamilyDevices .m-channel-placement-item.f-wide .FamilyDevices-action .c-call-to-action {
    background-color: #0c0c0d;
    border-radius: 10px;
    width: 100%;
    padding: 15px 0;
    white-space: normal;
    text-align: center;
}
.surface-laptop-family .surface-FamilyDevices .m-channel-placement-item.f-wide .FamilyDevices-action .c-call-to-action:after {
    display: none;
}

.surface-laptop-family .surface-FamilyDevices .m-channel-placement-item.f-wide .FamilyDevices-action .c-call-to-action:hover {
    outline: none;
    box-shadow: none;
}

.surface-laptop-family .surface-FamilyDevices .m-channel-placement-item.f-wide .FamilyDevices-action .c-call-to-action:hover span {
    left: 0px;
}

.surface-laptop-family .surface-FamilyDevices .m-channel-placement-item.f-wide .FamilyDevices-action .c-call-to-action:focus {
    outline: none;
    box-shadow: none;
    outline: 0.1875rem dotted;
    outline-offset: -0.375rem;
}

@media only screen and (min-width: 786px) {
    .surface-laptop-family .surface-FamilyDevices .m-channel-placement-item.f-wide .m-channel-placement-item.f-wide .c-channel-placement-image {
        height: 204px;
    }
}

@media only screen and (min-width: 1420px) {
    .surface-laptop-family .surface-FamilyDevices .m-channel-placement-item.f-wide {
        width: 400px;
    }
}

@media only screen and (min-width: 1620px) {
    .surface-laptop-family .surface-FamilyDevices .m-channel-placement-item.f-wide {
        width: 460px;
    }
}

@media only screen and (min-width: 1900px) {
    .surface-laptop-family .surface-FamilyDevices .m-channel-placement-item.f-wide {
        width: 510px;
    }
}

@media only screen and (min-width: 2000px) {
    .surface-laptop-family .surface-FamilyDevices .m-channel-placement-item.f-wide {
        width: 550px;
    }
}

@media only screen and (min-width: 2400px) {
    .surface-laptop-family .surface-FamilyDevices .m-channel-placement-item.f-wide {
        width: 620px;
    }
}

@media only screen and (min-width: 2600px) {
    .surface-laptop-family .surface-FamilyDevices .m-channel-placement-item.f-wide {
        width: 700px;
    }
}

@media only screen and (max-width: 1281px) {
    .surface-laptop-family .surface-FamilyDevices .m-channel-placement-item.f-wide {
        width: 320px;
    }
}

@media only screen and (max-width: 1200px) {
    .surface-laptop-family .surface-FamilyDevices .m-channel-placement-item.f-wide {
        width: 280px;
    }
}


@media only screen and (max-width: 940px) {
    .surface-laptop-family .surface-FamilyDevices .m-channel-placement-item.f-wide {
        width: 380px;
    }
}

@media only screen and (max-width: 880px) {
    .surface-laptop-family .surface-FamilyDevices .m-channel-placement-item.f-wide {
        width: 310px;
    }
}

@media only screen and (max-width: 840px) {
    .surface-laptop-family .surface-FamilyDevices .m-channel-placement-item.f-wide {
        width: 280px;
    }
}

@media only screen and (max-width: 720px) {
    .surface-laptop-family .surface-FamilyDevices .m-channel-placement-item.f-wide {
        width: 260px;
    }
}
@media only screen and (max-width: 424px) {
    .surface-laptop-family .surface-FamilyDevices .m-channel-placement-item.f-wide {
        width: 250px;
    }
}

.surface-laptop-family .surface-FamilyDevices .device-family-maindiv .family-device-cta a {
    background-color: #0c0c0d;
    border-radius: 10px;
    color: #ffffff;
    font-size: 20px;
    font-weight: 600;
    width: 100%;
    max-width: 100%;
    white-space: normal;
}

.surface-laptop-family .surface-FamilyDevices .device-family-maindiv .family-device-cta a.c-button:focus:not(.x-hidden-focus),
.surface-laptop-family .surface-FamilyDevices .device-family-maindiv .family-device-cta a.c-button:hover {
    background-color: #0c0c0d;
    color: #ffffff;
    border-radius: 10px;
    text-decoration: underline;
}


/*devicefamily end*/


/*//feature swatch start//*/

@media only screen and (min-width: 1083px) {
    .surface-laptop-family .multi-swatch-selector .m-multi-feature .feature-swatch .feature-swatch-content {
        max-width: none;
        display: -webkit-box;
        display: -ms-flexbox;
        display: flex;
        /* flex-direction: column;*/
        padding-left: 0px;
    }
    
  
   
}
@media only screen and (min-width:1084px) and (max-width:1270px) {

.surface-laptop-family .multi-swatch-selector .m-multi-feature .feature-swatch .feature-swatch-content
{
  
  margin-right: 35px;
}
}
@media only screen and (max-width: 767px) {
    .surface-laptop-family .multi-swatch-selector .m-multi-feature.f-align-right>section>div.feature-swatch-content
   {
        -webkit-box-ordinal-group: 1;
        -ms-flex-order: 0;
        order: 0;
        text-align: left;
    }
   
}

/*.surface-laptop-family .animated-hero .m-ambient-video
{
min-height: 625px;
}*/
.surface-laptop-family .surface-laptop-family-hero
{
background-color: #f2f2f2;
}
/*.surface-laptop-family .multi-swatch-selector .feature-swatch-content.is-animated {
    opacity: 1;
    -webkit-animation-name: animation360;
    animation-name: animation360;
    -webkit-animation-duration: 5s;
    animation-duration: 5s;
    -webkit-transform: none;
    transform: none;
    position: relative;
}*/


/*@media only screen and (min-width:767px) and (max-width:1366px) {
  
.wdg-global.surfacecom .surface-laptop-family .multi-swatch-selector .m-multi-feature
{
padding-left: 5%;
    padding-right: 5%;
}
}*/

@media only screen and (min-width: 768px)
{
.surface-laptop-family .multi-swatch-selector .m-multi-feature .feature-swatch .c-carousel.f-multi-slide {
 
    width: 100%;
}

/*sleek slight ui design change --<ul> to <div>*/
.surface-laptop-family .m-multi-feature.f-align-right>section>div.feature-swatch-content{
  text-align: left;
}
}

.surface-laptop-family .multi-swatch-selector .swatch-content-animation .c-call-to-action {
    padding: 10px 15px !important;
}

.surface-laptop-family .multi-swatch-selector .swatch-content-animation .c-call-to-action.c-glyph.f-primary {
    border-radius: 6px;
    background: transparent !important;
    color: #fff !important;
    background-color: #171717 !important;
    max-width: none !important;
}

.surface-laptop-family .multi-swatch-selector .swatch-selector .swatch-list {   
    padding-top: 50px !important;
    align-items: center;
}

.surface-laptop-family .multi-swatch-selector .swatch-selector .swatch-list a.c-logo {
    background: none !important;
}
.surface-laptop-family .multi-swatch-selector .swatch-selector .swatch-list a.c-logo:after {
    outline-color: transparent !important;
}

.surface-laptop-family .multi-swatch-selector .c-carousel.f-multi-slide .swatch-selector .swatch-list li {
    width: auto;
    padding: 0 13px;
}

.surface-laptop-family .multi-swatch-selector .swatch-selector .swatch-list a.c-logo:hover {
    border-radius: 50%;
    /*border: 1px solid #000;*/
}

.surface-laptop-family .multi-swatch-selector .swatch-selector .swatch-list a.c-logo.active.f-active {
    background: none !important;
    border-radius: 50%;
    border: 2px solid #000000;
    padding: 4px;
    outline-color: #000000;
}

.surface-laptop-family .multi-swatch-selector .swatch-selector .swatch-list a.c-logo.active.swatch0 {
    background-color: #d0e4db;
}

.surface-laptop-family .multi-swatch-selector .swatch-selector .swatch-list a.c-logo.active.swatch1 {
    background-color: #f9e9df;
}

.surface-laptop-family .multi-swatch-selector .swatch-selector .swatch-list a.c-logo.active.swatch2 {
    background-color: #d4e7f6;
}

.surface-laptop-family .multi-swatch-selector .swatch-selector .swatch-list a.c-logo.active.swatch3 {
    background-color: #f9e9df;
}
.surface-laptop-family .multi-swatch-selector .swatch-selector .swatch-list a.c-logo.f-active span.tick_mark {
    clip: unset !important;
    height: 0px !important;
    width: 5px !important;
    -webkit-transform: scaleX(-1) rotate(-40deg);
    transform: scaleX(-1) rotate(-40deg);
    font-size: 25px;
    top: 28%;
    left: 72%;
    overflow: inherit !important;
}

.surface-laptop-family .multi-swatch-selector .swatch-selector .swatch-list a.c-logo.f-active.tdark span.tick_mark {
    color: #000000;
}
.surface-laptop-family .multi-swatch-selector.family-color-picker-panel-2 .swatch-selector.swatch4 .swatch-list a.c-logo.f-active.tdark span.tick_mark{
    color: #ffffff;
}

.surface-laptop-family .multi-swatch-selector .swatch-selector .swatch-list .swatch_tip {
    position: absolute;
    display: none;
    white-space: normal;
    left: 0;
}
.surface-laptop-family .multi-swatch-selector.family-color-picker-panel-2 .swatch-selector .swatch-list .swatch_tip{
    left: -30px;
}

.surface-laptop-family .multi-swatch-selector .swatch-selector .swatch-list .swatch_tip.active {
    display: block;
    font-size: 30px;
    padding-top: 15px;
}

.surface-laptop-family .multi-swatch-selector .swatch-selector.swatch0 {
    background-color: #d0e4db;
}

.surface-laptop-family .multi-swatch-selector .swatch-selector.swatch1 {
    background-color: #e8e8e8;
}

.surface-laptop-family .multi-swatch-selector .swatch-selector.swatch2 {
    background-color: #d4e7f6;
}

.surface-laptop-family .multi-swatch-selector .swatch-selector.swatch3 {
    background-color: #f9e9df;
}
.surface-laptop-family .multi-swatch-selector.swatch0 {
    background-color: #d0e4db;
}

.surface-laptop-family .multi-swatch-selector.swatch1 {
    background-color: #e8e8e8;
}

.surface-laptop-family .multi-swatch-selector.swatch2 {
    background-color: #d4e7f6;
}

.surface-laptop-family .multi-swatch-selector.swatch3 {
    background-color: #f9e9df;
}
/*Family color picker panel 2 swatch colors START*/
.surface-laptop-family .multi-swatch-selector.family-color-picker-panel-2 .swatch-selector .swatch-list a.c-logo.active.swatch0 {
    background-color: #e8e8e8;
}

.surface-laptop-family .multi-swatch-selector.family-color-picker-panel-2 .swatch-selector .swatch-list a.c-logo.active.swatch1 {
    background-color: #d4e7f6;
}

.surface-laptop-family .multi-swatch-selector.family-color-picker-panel-2 .swatch-selector .swatch-list a.c-logo.active.swatch2 {
    background-color: #f9e9df;
}

.surface-laptop-family .multi-swatch-selector.family-color-picker-panel-2 .swatch-selector .swatch-list a.c-logo.active.swatch3 {
    background-color: #e8e8e8;
}

.surface-laptop-family .multi-swatch-selector.family-color-picker-panel-2 .swatch-selector .swatch-list a.c-logo.active.swatch4 {
    background-color: #ffffff;
}
.surface-laptop-family .multi-swatch-selector.family-color-picker-panel-2 .swatch-selector.swatch0 {
    background-color: #e8e8e8;
}

.surface-laptop-family .multi-swatch-selector.family-color-picker-panel-2 .swatch-selector.swatch1 {
    background-color: #d4e7f6;
}

.surface-laptop-family .multi-swatch-selector.family-color-picker-panel-2 .swatch-selector.swatch2 {
    background-color: #f9e9df;
}

.surface-laptop-family .multi-swatch-selector.family-color-picker-panel-2 .swatch-selector.swatch3 {
    background-color: #e8e8e8;
}

.surface-laptop-family .multi-swatch-selector.family-color-picker-panel-2 .swatch-selector.swatch4 {
    background-color: #ffffff;
}

.surface-laptop-family .multi-swatch-selector.family-color-picker-panel-2.swatch0 {
    background-color: #e8e8e8;
}

.surface-laptop-family .multi-swatch-selector.family-color-picker-panel-2.swatch1 {
    background-color: #d4e7f6;
}
.surface-laptop-family .multi-swatch-selector.family-color-picker-panel-2.swatch2 {
    background-color: #f9e9df;
}
.surface-laptop-family .multi-swatch-selector.family-color-picker-panel-2.swatch3 {
    background-color: #e8e8e8;
}

.surface-laptop-family .multi-swatch-selector.family-color-picker-panel-2.swatch4 {
    background-color: #ffffff;
}
/*Family color picker panel 2 swatch colors END*/

.surface-laptop-family .multi-swatch-selector .iconpanel-swatch {
    width: 60%;
    padding: 190px 12px 10px 12px;
}

@media screen and (min-width: 768px) and (max-width: 1083px) {
     .surface-laptop-family .m-multi-feature.f-align-right>section.feature-swatch
    {
          display: flex;
        flex-direction: column;
    }
    .surface-laptop-family .surface-FamilyDevices .m-channel-placement-item.f-wide .FamilyDevices-specification-list
    {
      padding-bottom: 32px;
    }
    .surface-laptop-family .surface-FamilyDevices .m-channel-placement-item.f-wide .FamilyDevices-specification-list li
    {
      padding-bottom: 11px;
    }
    .surface-laptop-family .surface-FamilyDevices .m-channel-placement-item.f-wide .c-channel-placement-description .c-paragraph-2
    {
      padding-top: 0px;
    }
    .surface-laptop-family .surface-FamilyDevices .m-channel-placement-item.f-wide .c-channel-placement-description
    {
      padding-bottom: 8px;
    }
    .surface-laptop-family .surface-FamilyDevices .m-banner .c-paragraph-2 {
      
      padding-top: 15px;
      }
      /*BUG:146959 issue 2*/
     .surface-laptop-family .multi-swatch-selector .m-multi-feature .feature-swatch .feature-swatch-content
     {
         width: 90%;
     }
     .surface-laptop-family .multi-swatch-selector .iconpanel-swatch {
    width: 100%;
    padding-left: 5%;
    padding-right: 5%;
     }
     .surface-laptop-family .multi-swatch-selector .iconpanel-swatch ul li
{
    width: 45%;
}
}

@media only screen and (max-width: 767px) {
    .surface-laptop-family .multi-swatch-selector .iconpanel-swatch {
        display: -webkit-box;
        display: -ms-flexbox;
        display: flex;
        width: 100%;
        -webkit-box-orient: vertical;
        -webkit-box-direction: normal;
        -ms-flex-direction: column;
        flex-direction: column;
    }
}

.surface-laptop-family .multi-swatch-selector .iconpanel-swatch.iconpanel-swatch-bottom-immersive ul,
.surface-laptop-family .feature-iconpanel-360 ul.feature-iconlist-360, .iconpanel-swatch .iconlist-swatch

{
     height: 475px;
}

.surface-laptop-family .multi-swatch-selector .iconpanel-swatch ul {
    display: -webkit-box;
    display: -ms-flexbox;
    display: flex;
    -webkit-box-orient: horizontal;
    -webkit-box-direction: normal;
    -ms-flex-direction: row;
    flex-direction: row;
    -ms-flex-wrap: wrap;
    flex-wrap: wrap;
    /*height: 450px;*/
    -ms-flex-line-pack: start;
    align-content: flex-start;
}

.surface-laptop-family .multi-swatch-selector .iconpanel-swatch ul li img {
    width: auto;
}

@media screen and (max-width: 767px) {
    .surface-laptop-family .multi-swatch-selector .iconpanel-swatch ul {
        -webkit-box-orient: vertical;
        -webkit-box-direction: normal;
        -ms-flex-direction: column;
        flex-direction: column;
        -ms-flex-wrap: nowrap;
        flex-wrap: nowrap;
    }
}

.surface-laptop-family .multi-swatch-selector .iconpanel-swatch ul li {
    width: 50%;
    display: -webkit-box;
    display: -ms-flexbox;
    display: flex;
    -webkit-box-align: center;
    -ms-flex-align: center;
    align-items: center;
    -webkit-box-pack: start;
    -ms-flex-pack: start;
    justify-content: flex-start;
    padding-bottom: 60px;
    align-items: center;
}
.surface-laptop-family .multi-swatch-selector .iconpanel-swatch ul li .c-paragraph-3 {
    font-size: 30px;
    line-height: 42px;
    font-weight: 600;
    padding-top: 0px;
    padding-left: 15px;
}
.surface-laptop-family .multi-swatch-selector .feature-swatch-content ul li .c-badge
{
   margin-top: 40px;
    font-size: 20px;
   padding: 0px 7px 1px 7px;
   border-radius: 10px;
}
/*Sleek slight color pcker ui Change--UL to Div*/
.surface-laptop-family .multi-swatch-selector .feature-swatch-content div .c-badge
{
   margin-top: 40px;
    font-size: 20px;
   padding: 0px 7px 1px 7px;
   border-radius: 10px;
}
.surface-laptop-family .multi-swatch-selector.light-color .feature-swatch-content ul li  .supBLink
{
background-color: inherit;
color: #0067b8;
}
.surface-laptop-family .multi-swatch-selector.light-color .feature-swatch-content ul li .supBLink span
{
color: #0067b8;
}
/*Sleek slight color pcker ui Change--UL to Div*/
.surface-laptop-family .multi-swatch-selector.light-color .feature-swatch-content div  .supBLink
{
background-color: inherit;
color: #0067b8;
}
/*Sleek slight color pcker ui Change--UL to Div*/
.surface-laptop-family .multi-swatch-selector.light-color .feature-swatch-content div .supBLink span
{
color: #0067b8;
}
.surface-laptop-family .feature_summary_360.dark-color .family-feature-360 .supBLink
{
background-color: inherit;
color: #fff;
}
#mainContent .surface-laptop-family .feature_summary_360.dark-color .family-feature-360 a.supBLink:focus
{
        outline: 2px dotted #fff !important;
}

.surface-laptop-family .feature_summary_360.dark-color .family-feature-360 .supBLink span,
.surface-laptop-family .feature_summary_360.dark-color .family-feature-360 a.supBLink:not(.f-image):focus:not(.x-hidden-focus)
{
color:  #fff;
}

 .surface-laptop-family .multi-swatch-selector .feature-swatch-content ul li a.c-hyperlink.supBLink
{
border-radius: 0px;
}

.surface-laptop-family .multi-swatch-selector .feature-swatch-content ul li a
{
     background-color: #000000;
    border-radius: 10px;
    color: #ffffff;
    font-size: 20px;
    font-weight: 600;
    margin-top: 25px;
}
/*Sleek slight color pcker ui Change--UL to Div*/
 .surface-laptop-family .multi-swatch-selector .feature-swatch-content div a.c-hyperlink.supBLink
{
border-radius: 0px;
}
/*Sleek slight color pcker ui Change--UL to Div*/
.surface-laptop-family .multi-swatch-selector .feature-swatch-content div a
{
     background-color: #000000;
    border-radius: 10px;
    color: #ffffff;
    font-size: 20px;
    font-weight: 600;
    margin-top: 25px;
}
.surface-laptop-family .multi-swatch-selector.family-color-picker-panel-2 .feature-swatch-content ul li a
{
  margin-top: 60px;
}
.surface-laptop-family .multi-swatch-selector .feature-swatch-content ul li a.c-button:focus:not(.x-hidden-focus),
.surface-laptop-family .multi-swatch-selector .feature-swatch-content ul li a.c-button:hover {
    background-color: #000000;
    border-radius: 10px;
    text-decoration: underline;
}
/*Sleek slight color pcker ui Change--UL to Div*/
.surface-laptop-family .multi-swatch-selector .feature-swatch-content div a.c-button:focus:not(.x-hidden-focus),
.surface-laptop-family .multi-swatch-selector .feature-swatch-content div a.c-button:hover {
    background-color: #000000;
    border-radius: 10px;
    text-decoration: underline;
}
@-webkit-keyframes animation360 {
    0% {
        opacity: 0;
    }
    25% {
        opacity: 0.25;
    }
    50% {
        opacity: 0.5;
    }
    75% {
        opacity: 0.75;
    }
    100% {
        opacity: 1;
    }
}

@keyframes animation360 {
    0% {
        opacity: 0;
    }
    25% {
        opacity: 0.25;
    }
    50% {
        opacity: 0.5;
    }
    75% {
        opacity: 0.75;
    }
    100% {
        opacity: 1;
    }
}
.surface-laptop-family .multi-swatch-selector .feature-swatch .feature-swatch-content .swatch-content-animation .f-active .c-heading {
    font-size: 90px;
    line-height: 120px;
    font-weight: 600;
    padding: 24px 0px 45px;
}

.surface-laptop-family .multi-swatch-selector .feature-swatch .feature-swatch-content .swatch-content-animation .f-active .c-paragraph {
    /*text-align: justify;*/
    font-size: 26px;
    line-height: 36px;
    font-weight: 600;
}

.surface-laptop-family .multi-swatch-selector .feature-swatch .feature-swatch-content .c-group .c-glyph {
    margin: 30px 0px 50px;
}
@media screen and (max-width :539px) {
    .surface-laptop-family .multi-swatch-selector .iconpanel-swatch .iconlist-swatch {
        margin: auto;
        /*height: 300px !important*/
    }
}

@media screen and (max-width: 767px) {
  .surface-laptop-family .multi-swatch-selector .iconpanel-swatch ul li .c-paragraph-3
  {
    font-size: 24px;
  }
  .surface-laptop-family .multi-swatch-selector .feature-swatch .feature-swatch-content .swatch-content-animation .f-active .c-heading
  {
    padding-bottom: 30px;
  }
    .surface-laptop-family .multi-swatch-selector .iconpanel-swatch ul li {
        width: 100%;
    }
    .surface-laptop-family .multi-swatch-selector .feature-swatch .feature-swatch-content .swatch-content-animation .f-active .c-heading {
    font-size: 64px;
     line-height: 78px;
    }
    .surface-laptop-family .feature_summary_360 .feature_summary_360_left .feature_summary_360_animation .feature_summary_360_content h2.c-heading
    {
         font-size: 64px;
     line-height: 78px;
    }
}
@media screen  and (max-width: 767px) {
     .surface-laptop-family .m-multi-feature.f-align-right>section.feature-swatch
    {
          display: flex;
    flex-direction: column;
    }
    .surface-laptop-family .multi-swatch-selector .feature-swatch
    {
        padding-right: 0px;
    }
    .surface-laptop-family .multi-swatch-selector .f-align-right
    {
        padding: 0 10px;
    }
    .surface-laptop-family .multi-swatch-selector .c-carousel.f-multi-slide .swatch-selector .swatch-list li
    {
        padding: 0px 0px 0px 10px;
    }
    .surface-laptop-family .multi-swatch-selector .swatch-selector .swatch-list .swatch_tip.active
    {
        font-size: 12px;
    padding-top: 12px;
    }
    .surface-laptop-family .multi-swatch-selector.family-color-picker-panel-2 .swatch-selector .swatch-list .swatch_tip {
    left: -23px;
}
.surface-laptop-family .multi-swatch-selector .swatch-selector .swatch-list a.c-logo.f-active span.tick_mark
{
    top: 30%;
    left: 73%;
}
}
.surface-laptop-family .multi-swatch-selector.light-color
{
padding-top: 90px;
} 
.surface-laptop-family .multi-swatch-selector.light-color .Immersive_Content
{
padding-bottom: 140px;
}
.surface-laptop-family .multi-swatch-selector.family-color-picker-panel-2
{
padding-top: 90px;
} 
.surface-laptop-family .multi-swatch-selector.family-color-picker-panel-2 .Immersive_Content
{
padding-bottom: 140px;
}
.surface-laptop-family .multi-swatch-selector .m-multi-feature .feature-swatch .c-carousel li.f-animate-next>picture.c-image img,.surface-laptop-family .multi-swatch-selector .m-multi-feature .feature-swatch .c-carousel li.f-animate-previous>picture.c-image img
{
animation:none;
}

.surface-laptop-family .feature_summary_360.dark-color
{
padding-top: 40px;
}
.surface-laptop-family .feature_summary_360.dark-color .Immersive_Content
{
padding-bottom: 140px;
}
/*//feature swatch end//*/


/*Animated Hero start*/

@keyframes moveInCopy {
    from {
        opacity: 0;
    }
    to {
        opacity: 1;
    }
}
.surface-laptop-family .animated-hero video.animated-hero-media {
object-fit: cover;
}
.surface-laptop-family .animated-hero .animated-hero-main-content {
    display: flex;
    justify-content: center;
    align-items: center; 
    padding-top: 30px;
    padding-bottom: 10px;
}
/*.surface-laptop-family .animated-hero .animated-hero-main-content a span:after
{
    padding-bottom: 12px !important;
}*/
.surface-laptop-family .animated-hero .animated-hero-main-content .hero-content {
  /* position: absolute;*/
    top: 52px;
   /* left: 50%;*/
  /*  display: none;
    -ms-transform: translateX(-50%);
    transform: translateX(-50%);*/
    text-align: center;
    width: 80%;
}
.surface-laptop-family .surface-laptop-family-hero .animated-hero .animated-hero-main-content .chevron-cta-fix a.c-call-to-action:not(.glyph-play) > span:after{
  display: inline-block;
  position: relative;
  vertical-align: middle;
  padding-bottom: 0;
}

@media screen and (min-width: 1084px) and (max-width: 1400px) {
    .surface-laptop-family .animated-hero .animated-hero-main-content .hero-content {
        top: 40px;
    }
}

@media screen and (min-width: 768px) and (max-width: 1083px) {
    .surface-laptop-family .animated-hero .animated-hero-main-content .hero-content {
        top: 22px;
    }
    .surface-laptop-family .multi-swatch-selector .feature-swatch .feature-swatch-content .swatch-content-animation .f-active .c-heading
    {
      padding-bottom: 15px;
    }
}

@media screen and (max-width: 539px) {
    .surface-laptop-family .animated-hero .animated-hero-main-content .hero-content {
        top: 30px;
        width: 100%;
        padding: 0 5% 24px;
    }
}

/*.surface-laptop-family .animated-hero .animated-hero-main-content .hero-content.slide-in-m-banner {
    animation-name: moveInCopy;
    animation-duration: 2s;
    animation-fill-mode: both;
}*/

.surface-laptop-family .animated-hero .animated-hero-main-content .hero-content .c-badge {
    background-color: #52e4ff;
    color: #000;
    border-radius: 10px;
}

.surface-laptop-family .animated-hero .animated-hero-main-content .hero-content .c-heading-3 {
    font-size: 75px;
    color: #000;
    padding: 4px 0 0 0;
    line-height: 76px;
    font-weight: 600;
}
.surface-laptop-family .animated-hero .animated-hero-main-content .hero-content .c-subheading-2{
font-size: 29px;
    line-height: 35px;
    padding-top: 7px;
}
.surface-laptop-family .animated-hero .animated-hero-main-content .hero-content a.c-call-to-action {
   font-size: 18px;
        margin-top: 0px;
    line-height: 18px;
    padding-bottom:3px;
}

.surface-laptop-family .animated-hero .animated-hero-main-content a span {
   padding-bottom: 5px;
}

.surface-laptop-family .animated-hero .animated-hero-main-content a.c-call-to-action.f-lightweight:hover span
{
    box-shadow: none;
}
/*.surface-laptop-family .animated-hero .animated-hero-main-content .hero-content a.c-call-to-action:not(.glyph-play):after {
  font-size: 17px;
    margin-top: -5px;
}*/

@media screen and (min-width: 1084px) and (max-width: 1400px) {
    .surface-laptop-family .animated-hero .animated-hero-main-content .hero-content a.c-call-to-action
  {
        font-size: 24px;
    margin-top: 0px;
    padding: 10px 3px 7px 0;
  }
  .surface-laptop-family .animated-hero .animated-hero-main-content .hero-content .c-heading-3 {
        font-size: 45px;
    line-height: 53px;
    padding: 5px 0 0 0;
    }
    .surface-laptop-family .animated-hero .animated-hero-main-content .hero-content .c-subheading-2{
    font-size: 24px;
    line-height: 29px;
    padding: 6px 0 0 0;
    }
}

@media screen and (min-width: 768px) and (max-width: 1083px) {
    .surface-laptop-family .animated-hero .animated-hero-main-content .hero-content .c-heading-3 {
        font-size: 40px;
        line-height: 50px;
        padding: 4px 0 0 0;
    }
    .surface-laptop-family .animated-hero .animated-hero-main-content .hero-content .c-subheading-2{
      font-size: 21px;
    line-height: 31px;
    padding: 4px 0 0 0;
    }
    
}

@media screen and (min-width: 540px) and (max-width: 767px) {
    .surface-laptop-family .animated-hero .animated-hero-main-content .hero-content .c-heading-3 {
        font-size: 56px;
        line-height: 66px;
    }
    .surface-laptop-family .animated-hero .animated-hero-main-content .hero-content .c-subheading-2{
      font-size: 30px;
    line-height: 40px;
    padding: 12px 0 0 0;
    }
}

@media screen and (max-width: 539px) {
    .surface-laptop-family .animated-hero .animated-hero-main-content .hero-content .c-heading-3 {
        font-weight: 600;
        font-size: 46px;
        line-height: 56px;
        padding: 15px 0 0 0;
    }
    .surface-laptop-family .animated-hero .animated-hero-main-content .hero-content .c-subheading-2{
       font-size: 30px;
    line-height: 40px;
    padding: 12px 0 0 0;
    }
   
}

.surface-laptop-family .animated-hero .animated-hero-main-content .hero-content .c-paragraph-2 {
  font-size: 18px;
    color: #2f2f2f;
    padding: 0;
    font-weight: 600;
    line-height: 26px;
}

@media screen and (min-width: 1084px) and (max-width: 1400px) {
    .surface-laptop-family .animated-hero .animated-hero-main-content .hero-content .c-paragraph-2 {
       font-size: 16px;
    padding: 5px 0 0 0;
    }
    .surface-laptop-family .animated-hero .animated-hero-main-content
    {
          padding-top: 15px;
    }
}

@media screen and (min-width: 768px) and (max-width: 1083px) {
    .surface-laptop-family .animated-hero .animated-hero-main-content .hero-content .c-paragraph-2 {
        font-size: 16px;
        padding: 0px;
    }
}

@media screen and (max-width: 767px) {
    .surface-laptop-family .animated-hero .animated-hero-main-content .hero-content .c-paragraph-2 {
        font-size: 20px;
        padding: 10px 0 0 0;
    }
}

@media screen and (max-width: 539px) {
    .surface-laptop-family .animated-hero .animated-hero-main-content .hero-content .c-paragraph-2 {
        font-weight: 400;
         padding: 20px 0 0 0;
    }
}

.surface-laptop-family .animated-hero picture.animated-hero-media img {
    width: 100%;
}

@media only screen and (max-width: 768px) {
    .surface-laptop-family .animated-hero picture.animated-hero-media.desktop {
        display: none;
    }
}

.surface-laptop-family .animated-hero picture.animated-hero-media.mobile {
    display: none;
}

@media only screen and (max-width: 768px) {
  .surface-laptop-family .animated-hero picture.animated-hero-media.mobile {
        display: block;
    }
}
.surface-laptop-family .animated-hero .m-ambient-video
{
  display: flex;
  flex-direction: column-reverse;
}
/*Hero animated video related post publish video replacement START*/
@media screen and (min-width: 1084px) {
.surface-laptop-family .animated-hero .m-ambient-video .animated-hero-media.desktop-video {
    display: block;
}
.surface-laptop-family .animated-hero .m-ambient-video .animated-hero-media.tablet-video {
        display: none;
    }
.surface-laptop-family .animated-hero .m-ambient-video .animated-hero-media.mobile-video {
            display: none;
        }
    .surface-laptop-family .animated-hero .m-ambient-video .animated-hero-media.mobile-2-video{
        display: none;
    }

}
@media screen and (min-width: 768px) and (max-width: 1083px) {
 .surface-laptop-family .animated-hero .m-ambient-video .animated-hero-media.tablet-video {
    display: block;
}
.surface-laptop-family .animated-hero .m-ambient-video .animated-hero-media.desktop-video {
    display: none;
}

.surface-laptop-family .animated-hero .m-ambient-video .animated-hero-media.mobile-video {
        display: none;
    }
    .surface-laptop-family .animated-hero .m-ambient-video .animated-hero-media.mobile-2-video{
        display: none;
    }
}

  @media screen and (min-width: 540px) and (max-width: 767px) {
    .surface-laptop-family .animated-hero .m-ambient-video .animated-hero-media.mobile-video {
            display: block;
        }
      .surface-laptop-family .animated-hero .m-ambient-video .animated-hero-media.desktop-video {
        display: none;
    }  
    .surface-laptop-family .animated-hero .m-ambient-video .animated-hero-media.tablet-video {
            display: none;
        }
        .surface-laptop-family .animated-hero .m-ambient-video .animated-hero-media.mobile-2-video{
            display: none;
        }
    }
    @media screen and (max-width: 539px) {
        .surface-laptop-family .animated-hero .m-ambient-video .animated-hero-media.mobile-2-video{
            display: block;
        }
        .surface-laptop-family .animated-hero .m-ambient-video .animated-hero-media.mobile-video {
                display: none;
            }
          .surface-laptop-family .animated-hero .m-ambient-video .animated-hero-media.desktop-video {
            display: none;
        }  
        .surface-laptop-family .animated-hero .m-ambient-video .animated-hero-media.tablet-video {
                display: none;
            }
        }
/*Hero animated video related post publish video replacement END*/
/*@media only screen and (max-width: 767px) {
    .surface-laptop-family .animated-hero video.desktop-video {
        display: none;
    }
    .surface-laptop-family .animated-hero video.mobile-video {
        display: inline;
    }
}

@media only screen and (min-width: 768px) {
    .surface-laptop-family .animated-hero video.desktop-video {
        display: inline;
    }
    .surface-laptop-family .animated-hero video.mobile-video {
        display: none;
    }
}*/
/*animated hero end*/


/*family hero*/

.surface-laptop-family .surface-family-hero .content
{
    width: 37%;
}
.surface-laptop-family .surface-family-hero .content .c-heading-2 {
    margin: 0 0 42px 0px;
   /* width: 25%;*/
    font-size: 90px;
    font-weight: 600;
    line-height: 120px;
}

.surface-laptop-family .surface-family-hero .mask {
    position: relative;
}


.surface-laptop-family .surface-family-hero .cta a.c-button.f-flex{
    font-size: 20px;
    width: 388px;
   
}
@media only screen and (min-width: 768px) and (max-width: 1083px)
{
    .surface-laptop-family .surface-family-hero .content a.c-button.cta1, .surface-family-hero .content .cta2 {
    margin-bottom: 26px;
}
.surface-laptop-family .surface-family-hero .content .c-group.cta {
    display: flex;
    flex-direction: column;
    margin-bottom: 64px;
}
.surface-laptop-family .surface-family-hero .content {
    width: 67%;
}
.surface-laptop-family .surface-family-hero .content {
    padding-left: 88px;
}
}

.surface-laptop-family .surface-family-hero .mask:after {
    content: '';
    position: absolute;
    left: 0;
    top: 0;
    width: 100%;
    height: 100%;
    display: inline-block;
    background: linear-gradient(to top, transparent, #e6e6e6);
}

@media only screen and (max-width: 767px) {
    .surface-laptop-family .surface-family-hero .content .c-heading-2
    {
        font-size: 62px;
        line-height: 70px;
    }
    .surface-laptop-family .surface-family-hero .content
    {
        width: 100%;
        text-align: center;
    }
    .surface-laptop-family .surface-family-hero .content .cta {
           display: flex;
    flex-direction: column;
    align-content: space-around;
    flex-wrap: wrap;
  
    margin: 0px 48px 92px 48px;
    }
    .surface-laptop-family .surface-family-hero .content .cta div {
        padding: 5px;
    }
     .surface-laptop-family .surface-family-hero .content .cta2
     {
         margin-top: 20px;
     }
}



@media only screen and (min-width: 768px) {
    .surface-laptop-family .surface-family-hero .content .cta {
        display: flex;
    }
    .surface-laptop-family .surface-family-hero .content .cta div {
        padding: 5px;
    }
}

.surface-laptop-family .surface-family-hero .content a.c-button.cta1,
.surface-laptop-family .surface-family-hero .content .cta2 {
    border-radius: 10px;
    font-weight: 600;
       
}

.surface-laptop-family .surface-family-hero .content a.c-button.cta1 {
    background-color: #171717;
    color: #fff;
}

.surface-laptop-family .surface-family-hero .content a.c-button.cta2,
.surface-laptop-family .surface-family-hero .content a.c-button.cta2:hover,
.surface-laptop-family .surface-family-hero .content a.c-button.cta2:active,
.surface-laptop-family .surface-family-hero .content a.c-button.cta2:focus {
    background-color: #fff;
    color: #171717;
    border-color: #000;
}

.surface-laptop-family .surface-family-hero .c-image img
{
    width: 100%
}
.surface-laptop-family .surface-family-hero
{
    background: #f2f2f2;
background-image: linear-gradient(to bottom, #f2f2f2, #f5f5f5, #f8f8f8, #fcfcfc, #ffffff);
}

/*family hero*/


/*spring launch 2022 css end*/

.surface-laptop-family .surface-family-devices-left {
    position: relative;
    opacity: 1;
    transform: translateX(-25px) rotateX(360deg);
    transition: transform 1s 0.25s cubic-bezier(0, 1, 0.3, 1), opacity 1s 1s ease-out;
    will-change: transform, opacity;
}

.surface-laptop-family .surface-family-devices-left.surface-family-animate {
    opacity: 1;
    transform: rotateX(0deg);
}

.surface-laptop-family .surface-family-devices-left div {
    width: 100%;
}

.surface-laptop-family .surface-family-devices-left div ul.device-family-flex {
    display: flex;
    flex-direction: row;
    flex-wrap: wrap;
    align-items: center;
    justify-content: space-between;
    padding-top: 40px;
}

.surface-laptop-family .surface-family-devices-left div ul.device-family-flex li {
    width: 50%;
    padding: 5px;
}

.surface-laptop-family .surface-family-devices-left .m-ambient-video.surface-family-devices-left-video {
    padding-top: 10px;
}

.surface-laptop-family .surface-family-devices-left .m-ambient-video.surface-family-devices-left-video h3 {
    text-align: left;
}

.surface-laptop-family .surface-family-devices-left .m-ambient-video.surface-family-devices-left-video h3:not(:empty) {
    padding-top: 5px;
}

.surface-laptop-family .surface-family-devices-left .surface-border-radius {
    border-radius: 10px;
    -o-object-fit: fill;
    object-fit: fill;
}

.surface-laptop-family .surface-family-devices-left .videobutton.c-call-to-action.c-glyph,
.surface-laptop-family .surface-family-devices-left .videobutton.c-call-to-action.c-glyph:focus {
    border: 1px solid #ffffff;
}

.surface-laptop-family .surface-family-devices-left .videobutton.c-call-to-action.c-glyph.bottom-right,
.surface-laptop-family .surface-family-devices-left .videobutton.c-call-to-action.c-glyph.bottom-right:focus {
    right: auto;
    bottom: 15px;
    left: 15px;
    top: auto;
}

.surface-laptop-family .surface-family-devices-left .videobutton.c-call-to-action.c-glyph,
.surface-laptop-family .surface-family-devices-left .videobutton.c-call-to-action.c-glyph:focus {
    width: 40px;
    height: 40px;
    background: transparent;
    border-radius: 100%;
    position: absolute;
    margin: 0;
    padding: 0;
}

.surface-laptop-family .surface-family-devices-left .videobutton.c-call-to-action.c-glyph:before {
    color: #ffffff !important;
}

.surface-laptop-family .surface-family-devices-left .videobutton.c-call-to-action.c-glyph:before {
    margin-left: 4px;
    margin-top: 0px;
}

.surface-laptop-family .surface-family-devices-left .videobutton.glyph-pause:after,
.surface-laptop-family .surface-family-devices-left .videobutton.glyph-play:after {
    content: "" !important;
}

.surface-laptop-family .surface-family-devices-left .m-channel-placement-item {
    box-shadow: 1px 2px 2px 1px #b6b0b0;
    border-radius: 10px;
}

@media (min-width: 540px) {
    .surface-laptop-family .surface-family-devices-left {
        display: flex;
        flex-direction: row;
    }
    .surface-laptop-family .surface-family-devices-left .mobile-family-devices {
        display: none;
    }
}

@media (max-width: 539px) {
    .surface-laptop-family .surface-family-devices-left .desktop-family-devivces {
        display: none;
    }
}

.surface-laptop-family .surface-family-hero .mask .c-image img {
    width: 100%;
}

.surface-laptop-family .mobile-family-devices {
    border-radius: 10px;
    display: block;
}

.surface-laptop-family .mobile-family-devices.m-multi-hero--v2 .c-carousel .c-flipper {
    top: 50%;
}

.surface-laptop-family .mobile-family-devices.m-multi-hero--v2 .c-carousel .c-sequence-indicator {
    bottom: 0px;
}

.surface-laptop-family .mobile-family-devices a.c-call-to-action.c-glyph {
    padding-top: 2px;
    padding-bottom: 15px;
}


.surface-laptop-family .family-pagenav .family-stickynav .family-pagesticky nav.family-dropdown{
z-index: 501;  
}

.surface-laptop-family .family-dropdown-menu ul {
    margin-left: 16 !important;
}

.surface-laptop-family .family-pagenav .family-stickynav nav.c-in-page-navigation {
    border-bottom: none;
}

.surface-laptop-family .family-dropdown .family-dropdown-menu a {
    font-size: 28px;
    font-weight: 600;
}
@media only screen and (min-width: 768px) {
   .surface-laptop-family .family-dropdown .family-dropdown-menu a {
    font-size: 28px;
    font-weight: 600;
}
}
.surface-laptop-family .family-stickynav nav.c-in-page-navigation.family-dropdown .family-dropdown-menu>a:after {
    right: 0px;
    padding-top: 14px;
    font-size: 18px;
  
}

.surface-laptop-family .family-pagenav .m-in-page-navigation.family-stickynav.f-sticky .family-pagesticky nav.c-in-page-navigation.f-dropdown.family-dropdown.f-sticky .f-dropdown-menu .c-menu {
    position: relative;
    top: 0;
}
.surface-laptop-family .family-dropdown .family-dropdown-menu ul li a {
    font-size: 18px;
    font-weight: 600;
    line-height: 40px;
    color: #000;
}

.surface-laptop-family .family-dropdown .family-dropdown-menu ul li a.c-call-to-action.f-lightweight {
    text-align: left;
}

.surface-laptop-family .family-dropdown .family-dropdown-menu ul.family-list {
    border: none;
}

.surface-laptop-family .family-dropdown .family-dropdown-menu ul li a.c-call-to-action:not(.glyph-play):after {
    vertical-align: middle;
}
.surface-laptop-family .m-in-page-navigation.family-stickynav.f-sticky .family-pagesticky nav.c-in-page-navigation.f-dropdown.family-dropdown .family-dropdown-menu.f-dropdown-menu>a
{
 margin: 0 6px;
}
.surface-laptop-family nav.c-in-page-navigation.family-dropdown .family-dropdown-menu>a {
    border: none;
    margin: 0;
    
}
.surface-laptop-family .family-pagenav .family-stickynav .family-pagesticky .family-dropdown .family-dropdown-menu ul{
    background-color: #ffffff;
}

/*Family Stickey dropdown END*/

/*.surface-laptop-family #family-interactivecards {
    background-color: #f9e9df;
}*/
.wdg-lifestyle-video .lifestyle-video .videobutton.c-call-to-action.c-glyph:after {
    content: "" !important;
}
/*Laptop Family Price START*/

.surface-laptop-family .surface-FamilyDevices .family-device-price {
    font-size: 24px;
    padding-top: 16px;
    padding-bottom: 0px;
    font-style: italic;
    line-height: 30px;
}


/*Laptop Family Price END*/

.surface-laptop-family .m-in-page-navigation.family-stickynav {
    position: absolute;
    top: 0;
    width: 100%;
    left: 0;
}

.surface-laptop-family .m-in-page-navigation.family-stickynav {
    display: none;
}
.surface-laptop-family .family-stickynav nav.c-in-page-navigation.family-dropdown.blcak-color .family-dropdown-menu > a:after {
    right: 0px;
    padding-top: 14px;
    font-size: 18px;
    color: #fff;
}

.surface-laptop-family .wdg-sp-margin-top
{
    padding-top: 190px;
}

.surface-laptop-family .m-channel-placement-item.f-wide .c-channel-placement-image
{
background-color: #fff !important;
}

.surface-laptop-family .surface-FamilyDevices .m-channel-placement-item.f-wide
{
background-color: #fff !important;
}
.surface-laptop-family .surface-FamilyDevices
{
background-color: #f2f2f2;
padding-bottom: 150px;
padding-top: 80px;
}

.surface-laptop-family .multi-swatch-selector .Immersive_Content,.feature_summary_360 .Immersive_Content
{
    padding-bottom: 236px
}
.surface-laptop-family .surface-FamilyDevices .m-channel-placement .c-flipper.f-previousbtn{
    display: none;
}
@media only screen and (max-width: 539px) {
    .surface-laptop-family .surface-FamilyDevices .m-channel-placement .c-carousel .c-flipper.f-previous, .surface-FamilyDevices .m-channel-placement .c-carousel .c-flipper.f-next{
        display: none;
    }
}
@media only screen and (max-width: 767px) {
    .surface-laptop-family .surface-FamilyDevices
{
padding-bottom: 40px;
}
    .surface-laptop-family .multi-swatch-selector .iconpanel-swatch.iconpanel-swatch-bottom-immersive ul, 
    .surface-laptop-family .feature-iconpanel-360 ul.feature-iconlist-360, .iconpanel-swatch .iconlist-swatch{
        height: 600px;
    }
    .surface-laptop-family .multi-swatch-selector .iconpanel-swatch{
        padding: 80px 30px 10px 30px;
    }
}
@media only screen and (max-width: 767px) {
    .surface-laptop-family .multi-swatch-selector .Immersive_Content{
        padding-bottom: 100px;
    }
    .surface-laptop-family .multi-swatch-selector .feature-swatch .feature-swatch-content .swatch-content-animation .f-active .c-heading{
        font-size: 50px;
            line-height: 60px;
    }
    
}
@media only screen and (max-width: 475px) {
    .surface-laptop-family .multi-swatch-selector .iconpanel-swatch.iconpanel-swatch-bottom-immersive ul, 
    .surface-laptop-family .feature-iconpanel-360 ul.feature-iconlist-360, .iconpanel-swatch .iconlist-swatch{
        height: 710px;
    }
}
@media (prefers-reduced-motion: reduce) {
 .surface-laptop-family .feature_summary_360 .feature_summary_360_left .feature_summary_360_animation.is-scrollDown,
.surface-laptop-family .feature_summary_360 .feature_summary_360_left .feature_summary_360_animation.is-scrollTop,
.surface-laptop-family .m-multi-feature .feature-swatch .feature-swatch-content .swatch-content-animation.is-scrollDown,
.surface-laptop-family .m-multi-feature .feature-swatch .feature-swatch-content .swatch-content-animation.is-scrollTop,
.surface-laptop-family .family-color-picker .family-color-picker-container .family-color-picker-content.is-scrollTop,
.surface-laptop-family .family-color-picker .family-color-picker-container .family-color-picker-content.is-scrollDown,
.surface-laptop-family .family-color-picker .family-color-picker-container .family-color-picker-content.is-scrollTop,
.surface-laptop-family .family-color-picker .family-color-picker-container .family-color-picker-content.is-scrollDown,
.surface-laptop-family .animated-hero .animated-hero-main-content .hero-content.slide-in-m-banner,
.surface-laptop-family .wdg-device-highlight-tile .wdg-device-highlight-tile-content .wdg-device-specs-grid .wdg-device-specs-flex .wdg-device-category-content.is-scrollDown,
.surface-laptop-family .wdg-device-highlight-tile .wdg-device-highlight-tile-content .wdg-device-specs-grid .wdg-device-specs-flex .wdg-device-category-content.is-scrollTop,
.surface-laptop-family .wdg-device-highlight-tile .wdg-device-highlight-tile-content .wdg-device-specs-grid .wdg-device-model.foldIn.foldout {
     -webkit-animation: none;
    animation: none;
  }
  .surface-laptop-family .wdg-lifestyle-video .lifestyle-video {
    position: relative;
  }
  .surface-laptop-family .wdg-lifestyle-video .lifestyle-video .masker {
    background-color: rgba(0, 0, 0, 0.6);
    top:0;
    height: 100%;
  }
  .surface-laptop-family .wdg-lifestyle-video .lifestyle-video-content {
    position: absolute;
    top: 50%;
    -webkit-transform: translateY(-50%);
            transform: translateY(-50%);
  }
  .surface-laptop-family .wdg-lifestyle-video .lifestyle-video-content .lifestyle-video-main-content {
    opacity: 1;
  }
  .surface-laptop-family .wdg-lifestyle-video .lifestyle-video-box-content {
    padding: 0 176px;
  }
  .surface-laptop-family .wdg-lifestyle-video .lifestyle-video-box-content .lifestyle-video-main-content .c-heading-2 {
    font-size: 50px;
    line-height: 60px;
  }
  .surface-laptop-family .wdg-lifestyle-video .lifestyle-video-box-content .lifestyle-video-main-content .c-paragraph {
    font-size: 20px;
    padding: 30px 0 0 0;
  }
  .surface-laptop-family .wdg-lifestyle-video .lifestyle-video-box-content .lifestyle-video-main-content .lifestyle-video-cta {
    padding: 28px 0 0 0;
  }
  .surface-laptop-family .wdg-device-highlight-tile.business-style .wdg-device-highlight-tile-content {
    padding: 0 0 0 103px;
  }
  .surface-laptop-family .wdg-device-highlight-tile.business-style .wdg-device-highlight-tile-content .wdg-device-content .c-heading-2 {
    font-size: 34px;
    line-height: 44px;
  }
  .surface-laptop-family .wdg-device-highlight-tile.business-style .wdg-device-highlight-tile-content .wdg-device-content .c-paragraph-2 {
    font-size: 17px;
    line-height: 25px;
    padding: 25px 0 0 0;
  }
  .surface-laptop-family .wdg-device-highlight-tile.business-style .wdg-device-highlight-tile-content .wdg-device-specs-grid {
    padding: 46px 0 0 0;
  }
  .surface-laptop-family .wdg-device-highlight-tile.business-style .wdg-device-highlight-tile-content .wdg-device-specs-grid .wdg-device-specs-flex .wdg-device-category-content .wdg-device-spec-content {
    padding: 39px 33px 23px 33px;
  }
  .surface-laptop-family .wdg-device-highlight-tile.business-style .wdg-device-highlight-tile-content .wdg-device-specs-grid .wdg-device-specs-flex .wdg-device-category-content .wdg-device-spec-content .c-heading-3 {
    font-size: 21px;
    line-height: 30px;
  }
  .surface-laptop-family .wdg-device-highlight-tile.business-style .wdg-device-highlight-tile-content .wdg-device-specs-grid .wdg-device-specs-flex .wdg-device-category-content .wdg-device-spec-content .c-paragraph-3 {
    padding: 22px 0 7px 0;
  }
  .surface-laptop-family .wdg-device-highlight-tile .wdg-device-m-image {
    position: relative;
    /*display: none;*/
  }
  .surface-laptop-family .wdg-device-highlight-tile .wdg-device-highlight-tile-content {
    position: absolute;
    top: 50%;
    -webkit-transform: translateY(-50%);
            transform: translateY(-50%);
    padding: 0 0 0 100px;
  }
  .surface-laptop-family .wdg-device-highlight-tile .wdg-device-highlight-tile-content.content-z-index {
        position: absolute;
    }
    .surface-laptop-family .wdg-device-highlight-tile .wdg-device-highlight-tile-content .wdg-device-content .c-heading-2 {
    font-size: 34px;
    line-height: 44px;
    padding: 0;
  }
  .surface-laptop-family .wdg-device-highlight-tile .wdg-device-highlight-tile-content .wdg-device-content .c-paragraph-2 {
    font-size: 18px;
    line-height: 28px;
    padding: 20px 0 0 0;
  }
  .surface-laptop-family .wdg-device-highlight-tile .wdg-device-highlight-tile-content .wdg-device-content .c-call-to-action {
    margin-top: 0;
  }
  .surface-laptop-family .wdg-device-highlight-tile .wdg-device-highlight-tile-content .wdg-device-specs-grid {
    padding: 30px 0 0 0;
  }
  .surface-laptop-family .wdg-device-highlight-tile .wdg-device-highlight-tile-content .wdg-device-specs-grid .wdg-device-specs-flex .wdg-device-category-content {
    opacity: 1;
    padding: 11px;
  }
   .surface-laptop-family .wdg-device-highlight-tile .wdg-device-highlight-tile-content .wdg-device-specs-grid .wdg-device-specs-flex .wdg-device-category-content .wdg-device-spec-content {
    padding: 28px 28px 22px 28px;
  }
  .surface-laptop-family .wdg-device-highlight-tile .wdg-device-highlight-tile-content .wdg-device-specs-grid .wdg-device-specs-flex .wdg-device-category-content .wdg-device-spec-content .c-paragraph-2 {
    font-size: 20px;
    line-height: 30px;
    padding: 20px 0 0 0;
  }
  .surface-laptop-family .wdg-device-highlight-tile .wdg-device-highlight-tile-content .wdg-device-specs-grid .wdg-device-model {
    padding: 22px 0;
    top: 42px;
  }
  .surface-laptop-family .wdg-device-highlight-tile .wdg-device-highlight-tile-content .wdg-device-specs-grid .wdg-device-model.foldIn {
    -webkit-animation: none;
            animation: none;
    width: 95%;
  }
  .surface-laptop-family .wdg-device-highlight-tile .wdg-device-highlight-tile-content .wdg-device-specs-grid .wdg-device-model .modal-content .c-paragraph-2 {
    padding: 28px 5px 0 0;
  }
}

/*accessibility*/
.surface-laptop-family .multi-swatch-selector .m-multi-feature .feature-swatch-content a.dark-cta:focus,
.surface-laptop-family .surface-FamilyDevices .device-family-maindiv .FamilyDevices-action a.dark-cta:focus,
.surface-laptop-family .surface-family-hero .surface-hero-family-content a.dark-cta:focus{
    border-color: #ffffff;
}

.surface-laptop-family .animation-on a.c-call-to-action.f-lightweight:focus:not(.x-hidden-focus) span, 
.surface-laptop-family .animation-on a.c-call-to-action:focus:not(.x-hidden-focus) span,
.surface-laptop-family .surface-family-hero .surface-hero-family-content a.c-button:focus:not(.x-hidden-focus),
.surface-laptop-family .surface-family-hero .surface-hero-family-content a.c-button:hover,
.surface-laptop-family .animation-on a.c-hyperlink.supBLink:not(.f-image):focus:not(.x-hidden-focus){
    text-decoration: underline;
} 

.surface-laptop-family .multi-swatch-selector .m-multi-feature .feature-swatch .swatch-selector ul li a.c-logo:after{
    outline: none;
}

@media screen and (-ms-high-contrast: active) {
.surface-laptop-family .surface-FamilyDevices .device-family-maindiv ul li div.m-channel-placement-item {
    border: 2px solid #fff;
}
}
 /*accessibility end*/

/*obd video*/
@media screen and (min-width: 1400px) {
.surface-laptop-family .wdg-lifestyle-video .lifestyle-video-box-content {
width:60%;
}
}
@media only screen and (min-width: 1200px) {
.surface-laptop-family .lifestylevideoautoplay.mobilevideo{
  display: none;
}
}
@media only screen and (max-width: 1199px) {
.surface-laptop-family .lifestylevideoautoplay.desktopvideo{
  display: none;
}
}
/*OBD video CTA underline issue*/

.surface-laptop-family .lifestyle-video-main-content .lifestyle-video-cta a.c-call-to-action.c-glyph.glyph-play.f-lightweight span {
text-decoration: none;
}

/*400% zoom accessibility issues*/
@media only screen and (max-width: 320px) {
.surface-laptop-family .family-pagenav .family-stickynav nav.c-in-page-navigation{
  display: none;
}
}
/*400% zoom accessibility issues End*/

/*High Contrast issues*/
@media screen and (-ms-high-contrast: white-on-black) {
 .surface-laptop-family .wdg-device-highlight-tile .wdg-device-highlight-tile-content .wdg-device-specs-flex .wdg-device-category-content .wdg-device-spec-content .wdg-device-tile-logo img,
 .surface-laptop-family .multi-swatch-selector .m-multi-feature .iconpanel-swatch .iconlist-swatch li .c-logo img,
 .device-family-maindiv .c-group .tileslist .m-channel-placement-item .family-device-content .FamilyDevices-specification-list li .img img,
 .device-family-maindiv .c-group .tileslist .m-channel-placement-item .family-device-content .color-swatch img{
   background-color: WindowText;
 }
 
 .surface-laptop-family a.c-call-to-action.f-lightweight{
   border:none !important;
   outline: none !important;
 }
}

@media screen and (-ms-high-contrast: black-on-white) {
  .surface-laptop-family .dark-color.feature_summary_360 .feature-iconpanel-360 ul li img,
  .device-family-maindiv .c-group .tileslist .m-channel-placement-item .family-device-content .color-swatch img{
   background-color: WindowText;
 }
 
  .surface-laptop-family a.c-call-to-action.f-lightweight{
   border:none !important;
   outline: none !important;
 }
}
/*High Contrast issues - end*/

/*360 panel specs paddings*/

/*Hero 420 to 370 VP fixes*/
@media screen and (min-width: 370px) and (max-width: 415px) {
  .surface-laptop-family .animated-hero .animated-hero-main-content .hero-content a.c-call-to-action {
    font-size: 19px;
    margin-top: 0px;
    line-height: 20px;
}
.surface-laptop-family .animated-hero .animated-hero-main-content .hero-content .c-paragraph-2{
  font-size: 16px;
  font-weight: 400;
    padding: 15px 0 0 0;
}
.surface-laptop-family .animated-hero .animated-hero-main-content .hero-content .c-subheading-2 {
    font-size: 26px;
    line-height: 36px;
    padding: 12px 0 0 0;
}
}

/* Logo icons visible in Contrast modes in chrome for light background*/

/*@media screen and (forced-colors: active) and (prefers-color-scheme: light) {
background-color: snow;
}*/
/* Logo icons visible in Contrast modes in chrome for dark background*/
/*@media screen and (forced-colors: active) and (prefers-color-scheme: dark) {
background-color: WindowsText;
}*/
/*Back to top link in dark theme contrast ratio issues*/
a.m-back-to-top,a.c-back-to-top {
outline: 1px #ffffff dotted;
}
/*Superscript link color contrast ratio issue in sage background*/
.surface-laptop-family #family-color-Picker1.swatch0 .feature-swatch-content div .supBLink 
{
background-color: inherit;
color: #003EA3;
}
.surface-laptop-family #family-color-Picker1.swatch0 .feature-swatch-content div .supBLink span
{
color: #003EA3;
}
/*Interactive cards refresh button mobile VP fix*/
@media screen and (max-width: 767px){
.surface-laptop-family .wdg-device-highlight-tile .wdg-device-highlight-tile-content .wdg-device-specs-grid .wdg-device-model .modal-content .m-ambient-video .refresh-btn{
bottom: 60px;
right: 15px;
}
}
/*360 panel horizontal scroll bar issue*/
@media only screen and (min-width: 540px) and (max-width: 550px){
.feature_summary_360_left.m-feature.f-align-left>div{
    width: 478px;
}
}
/*CSS fixes on animation effects off */
@media screen and (max-width: 767px) and (prefers-reduced-motion: reduce) {

/*Life style vide content is comming in single line in tablet and mobile vp */
 .surface-laptop-family .wdg-lifestyle-video .lifestyle-video-box-content {
       
           padding: 0 72px;
    
 }
 /*interactive cards text cominng on video and on image*/
 .surface-laptop-family .wdg-device-highlight-tile .wdg-device-m-image {
       position: initial;
   }
   
   .surface-laptop-family .wdg-device-highlight-tile .wdg-device-highlight-tile-content {
    position: initial;
    -ms-transform: initial;
    -webkit-transform: initial;
    transform: initial;
    width: 100%;
    padding: 0 52px 146px 52px;
}
 

}
/*Transition of 2 sec is applied in below 1083*/
@media screen and (max-width: 1083px) and (prefers-reduced-motion: reduce) {
  
  .surface-laptop-family .main-image-stack .image-stack-item-2 {
    transition-property: none;
  }
}
/*BUG:147007 1, 2 issues*/
@media only screen and (min-width: 370px) and (max-width: 405px){
.surface-laptop-family .multi-swatch-selector .c-carousel.f-multi-slide .swatch-selector .swatch-list li
    {
        padding: 0px 0px 0px 5px;
        margin-right: 5px;
    }
}
@media only screen and (min-width: 1084px) and (max-width: 1130px){
.surface-laptop-family .multi-swatch-selector .c-carousel.f-multi-slide .swatch-selector .swatch-list li
    {
        padding: 0px 0px 0px 10px;
    }
}
/*this needs to be comment if landscape sticky not requries*/
@media screen and (min-width: 665px) and (max-width: 920px) and (orientation: landscape){
.surface-laptop-family .family-dropdown .family-dropdown-menu ul li a{
  line-height: 22px;
}
}
/*@media screen and (min-width: 910px) and (max-width: 920px) and (orientation: landscape){
.surface-laptop-family .family-dropdown .family-dropdown-menu ul li a{
  line-height: 26px;
}
}*/
/*Hero desktop and mobile CTA's*/
@media only screen and (min-width: 768px){
.surface-laptop-family .animated-hero .animated-hero-main-content .hero-content a.c-call-to-action.family-hero-mobile-cta{
  display: none;
}
}
@media only screen and (max-width: 767px){
.surface-laptop-family .animated-hero .animated-hero-main-content .hero-content a.c-call-to-action.family-hero-desktop-cta{
  display: none;
}
}
/*BUG 147703 3rd issue*/
@media only screen and (min-width: 370px) and (max-width: 390px){
.surface-laptop-family .feature_summary_360 .feature-iconpanel-360 ul li .c-paragraph-3{
  line-height: 38px;
}
}
/*Laptop family disabled CTA*/
.surface-laptop-family a.mscom-link.c-button.f-primary.surafce-laptop-family-disabled-cta{
cursor: not-allowed;
border-color: transparent;
background: #cce1f1;
color: #59626a;
pointer-events: none;
}
.surface-laptop-family a.mscom-link.c-button.f-primary.surafce-laptop-family-disabled-cta:active{
  transform: none;
}
.surface-laptop-family a.mscom-link.c-button.f-primary.surafce-laptop-family-disabled-cta:hover,
.surface-laptop-family a.mscom-link.c-button.f-primary.surafce-laptop-family-disabled-cta:focus:not(.x-hidden-focus),
.surface-laptop-family a.mscom-link.c-button.f-primary.surafce-laptop-family-disabled-cta:focus{
  background-color: #cce1f1;
 border-color: transparent;
    text-decoration: none;
}
.surface-laptop-family a.mscom-link.c-button.f-primary.surafce-laptop-family-disabled-cta:not(.x-hidden-focus):not(.f-lightweight):not([disabled]), 
.surface-laptop-family a.mscom-link.c-button.f-primary.surafce-laptop-family-disabled-cta:hover:not(.f-lightweight):not([disabled]){
  box-shadow: none;
}
.surface-laptop-family .surface-FamilyDevices .device-family-maindiv .family-device-cta a.c-button.surafce-laptop-family-disabled-cta:focus:not(.x-hidden-focus), 
.surface-laptop-family .surface-FamilyDevices .device-family-maindiv .family-device-cta a.c-button.surafce-laptop-family-disabled-cta:hover{
  color: #59626a;
}
/*Hero panel disable CTA*/
.surface-laptop-family a.mscom-link.c-call-to-action.c-glyph.f-lightweight.surface-disabled-cta{
  cursor: not-allowed;
  pointer-events: none;
}
.surface-laptop-family a.mscom-link.c-call-to-action.c-glyph.f-lightweight.surface-disabled-cta:active{
  text-decoration: none !important;
}
.surface-laptop-family a.mscom-link.c-call-to-action.c-glyph.f-lightweight.surface-disabled-cta:focus:not(.x-hidden-focus):not(.wdg-f-blue-button){
  outline: none !important;
}

/*dark mode swatches fix start*/
@media screen and (-ms-high-contrast: white-on-black) {
#family-color-Picker2 .m-multi-feature .feature-swatch .c-carousel.f-multi-slide .swatch-selector .swatch-list .c-glyph.swatch-list-item .c-logo.swatch-list-item-link.tdark img {
    border: 2px dotted white;
}
}

/*.Home-Pop-up-c-dialog.c-dialog.f-lightbox [role=dialog] .surface-home-player-wrapper
{
  height: 100%
}*/
/*home hero fixes 370 to 480*/
@media only screen and (min-width: 370px) and (max-width: 480px){
    .surface-laptop-family .animated-hero-main-content .c-badge
    {
        display: none;
    }
   .surface-laptop-family .animated-hero .animated-hero-main-content .hero-content .c-heading-3
    {
              font-weight: 600;
    font-size: 40px;
    line-height: 45px;
    padding: 10px 0 0 0;
    }
    .surface-laptop-family .animated-hero .animated-hero-main-content .hero-content .c-paragraph-2
    {
        font-size: 12px;
        padding: 5px 0 0 0;
    }
}

/* All anchor elements having an outline in contrast modes*/
@media screen and (prefers-contrast: more) {
.surface-laptop-family a.c-call-to-action,
.surface-laptop-family a.c-hyperlink:not(.supBlink){
border:none !important;
outline: none !important;
}
.surface-laptop-family a.c-button:focus:not(.x-hidden-focus){
  outline: 2px #ffffff dashed;
}
}
/* All anchor elements having an outline in contrast modes*/
@media screen and (prefers-contrast: less) {
.surface-laptop-family a.c-call-to-action ,
.surface-laptop-family a.c-hyperlink:not(.supBlink) {
border:none !important;
outline: none !important;
}
.surface-laptop-family a.c-button:focus:not(.x-hidden-focus){
 outline: 2px #ffffff dashed;
}
}
 /* Logo icons visible in Contrast modes in chrome for nightskymode black-contrast*/
@media screen and (forced-colors: active) and (prefers-color-scheme: dark) {
  
.surface-laptop-family .multi-swatch-selector .m-multi-feature .iconpanel-swatch .iconlist-swatch li .c-logo img{
   background-color: WindowText;
 }
}
/* Logo icons visible in Contrast modes in chrome for desert mode white contrast*/
@media screen and (forced-colors: active) and (prefers-color-scheme: light) {
.surface-laptop-family .dark-color.feature_summary_360 .feature-iconpanel-360 ul li img{
   background-color: WindowText;
 }
}
/*back to top Color contrast issue*/
 a.m-back-to-top,a.c-back-to-top {

background-color: #D9D9D9 !important;
}

/*400% zoom accessibility issues*/
@media only screen and (max-width: 369px) {

.surface-laptop-family .animated-hero .animated-hero-main-content .hero-content strong.c-badge:empty {
    display: none;
}
.surface-laptop-family .animated-hero .animated-hero-main-content .hero-content .c-heading-3
{
  font-size: 36px;
  padding-top:0;
}
.surface-laptop-family .animated-hero .animated-hero-main-content .hero-content .c-subheading-2{
    font-size: 21px;
  padding-top:0;
}
.surface-laptop-family .animated-hero .animated-hero-main-content .hero-content .c-paragraph-2 {
    font-size: 16px;
  padding-top:0;
  line-height: 20px; 
}
.en-us .surface-laptop-family .animated-hero .animated-hero-main-content a.c-call-to-action.f-lightweight {
    font-size: 10px;
  padding-top:0;
   padding-bottom: 0;
  
}
.en-us .surface-laptop-family .animated-hero .animated-hero-main-content a.c-call-to-action.f-lightweight span{
    font-size: 10px;
  padding-top:0;
  padding-bottom: 0;
  
}
.surface-laptop-family .animated-hero .animated-hero-main-content .hero-content a.c-call-to-action span:after{
  font-size: 10px;
  padding-bottom: 5px !important;
}
.surface-laptop-family .wdg-lifestyle-video .lifestyle-video-box-content .lifestyle-video-main-content .c-heading-2 {
    font-size: 50px;
  
}
.surface-laptop-family .wdg-device-highlight-tile .wdg-device-highlight-tile-content .wdg-device-content .c-heading-2{
  font-size: 46px;
}
.surface-laptop-family .wdg-device-highlight-tile .wdg-device-highlight-tile-content .wdg-device-specs-grid .wdg-device-specs-flex .wdg-device-category-content .wdg-device-spec-content .c-paragraph-2{
  font-size: 26px;
}
.surface-laptop-family .feature_summary_360 .feature_summary_360_left .feature_summary_360_animation .feature_summary_360_content h2.c-heading{
   font-size: 56px;
}
.surface-laptop-family .feature_summary_360 .feature_summary_360_left .feature_summary_360_animation a{
   font-size: 15px;
}
.surface-laptop-family .feature_summary_360 .feature-iconpanel-360 ul li .c-paragraph-3{
  font-size: 24px;
}
.surface-laptop-family .family-feature-360 .main-image-stack .image-stack-item-1, .surface-laptop-family .main-image-stack.rightAlign .image-stack-item-1{
  margin-top: 5%;
}
}

/*400% zoom accessibility issues End*/
/*200% iframe issue*/
@media only screen and (min-width: 634px) and (max-width: 970px){

 .surface-home-player-wrapper .c-video-player iframe
{
height: 82% !important;
    width: 100% !important;
    margin-top: 38px !important;
  }
}


/*color swatch new design update*/

.surface-laptop-family .family-color-picker {
  background-color: #e1e4ef;
}

.surface-laptop-family .family-color-picker .family-color-picker-container {
  display: -webkit-box;
  display: -ms-flexbox;
  display: flex;
 
}

@media only screen and (max-width: 1083px) {
  .surface-laptop-family .family-color-picker .family-color-picker-container {
    -webkit-box-orient: vertical;
    -webkit-box-direction: normal;
        -ms-flex-direction: column;
            flex-direction: column;
  }
}

.surface-laptop-family .family-color-picker .family-color-picker-container .family-color-picker-content {
  width: 40%;
}
/*Superscript link color contrast ratio issue in sage background*/
.surface-laptop-family #family-color-Picker1 .family-color-picker-content .supBLink 
{
background-color: inherit;
color: #003EA3;
}
.surface-laptop-family #family-color-Picker1 .family-color-picker-content .supBLink span
{
color: #003EA3;
}

@media only screen and (min-width: 1084px) and (max-width: 1320px) {
  .surface-laptop-family .family-color-picker .family-color-picker-container .family-color-picker-content {
    width: 50%;
  }
}

@media screen and (min-width: 768px) and (max-width: 1083px) {
 .surface-laptop-family .family-color-picker .family-color-picker-container .family-color-picker-content {
    width: 90%;
    padding: 0 36px;
  }
}
@media only screen and (max-width: 767px){
   .surface-laptop-family .family-color-picker .family-color-picker-container .family-color-picker-content {
     padding: 0 24px;
     width: 100%;
   }
}
.surface-laptop-family .family-color-picker .family-color-picker-container .family-color-picker-content .c-heading {
  font-size: 90px;
  line-height: 120px;
  font-weight: 600;
  padding: 24px 0px 45px;
}
@media screen and (max-width: 767px){
  .surface-laptop-family .family-color-picker .family-color-picker-container .family-color-picker-content .c-heading {
      font-size: 50px;
    line-height: 60px;
}
}
.surface-laptop-family .family-color-picker .family-color-picker-container .family-color-picker-content .c-paragraph {
  font-size: 26px;
  line-height: 36px;
  font-weight: 600;
}

.surface-laptop-family .family-color-picker .family-color-picker-container .family-color-picker-content .c-badge {
  margin-top: 40px;
  font-size: 20px;
  padding: 0px 7px 1px 7px;
  border-radius: 10px;
}

.surface-laptop-family .family-color-picker .family-color-picker-container .family-color-picker-content .family-color-picker-cta {
  padding-bottom: 10px;
}

.surface-laptop-family .family-color-picker .family-color-picker-container .family-color-picker-content .family-color-picker-cta a {
  background-color: #000000;
  border-radius: 10px;
  color: #ffffff;
  font-size: 20px;
  font-weight: 600;
  margin-top: 25px;
}
.surface-laptop-family .family-color-picker .family-color-picker-container .family-color-picker-content .family-color-picker-cta a:hover,
.surface-laptop-family .family-color-picker .family-color-picker-container .family-color-picker-content .family-color-picker-cta a:focus{
   background-color: #000000;
   text-decoration: underline;
   
}
.surface-laptop-family .family-color-picker .family-color-picker-container .family-color-picker-content .family-color-picker-cta a:active{
   background-color: #000000;
}
.surface-laptop-family .family-color-picker .family-color-picker-container .family-color-picker-content .family-color-picker-cta a:focus{
  border-color: #fff;
}
.surface-laptop-family .family-color-picker .family-color-picker-container .family-color-picker-swatches-container {
  width: 60%;
  display: -webkit-box;
  display: -ms-flexbox;
  display: flex;
  -webkit-box-orient: vertical;
  -webkit-box-direction: reverse;
      -ms-flex-direction: column-reverse;
          flex-direction: column-reverse;
}
@media only screen and (min-width: 1084px) and (max-width: 1320px) {
.surface-laptop-family .family-color-picker .family-color-picker-container .family-color-picker-swatches-container {
   width: 50%;
   padding-bottom: 115px;
   }
}
  
@media only screen and (max-width: 1083px) {
  .surface-laptop-family .family-color-picker .family-color-picker-container .family-color-picker-swatches-container {
    width: 100%;
  }
}

.surface-laptop-family .family-color-picker .family-color-picker-container .family-color-picker-swatches-container .actions-section .family-color-picker-swatches .family-color-section {
  display: -webkit-box;
  display: -ms-flexbox;
  display: flex;
  -webkit-box-pack: center;
      -ms-flex-pack: center;
          justify-content: center;
  -webkit-box-align: center;
      -ms-flex-align: center;
          align-items: center;
  padding-top: 50px;
}

.surface-laptop-family .family-color-picker .family-color-picker-container .family-color-picker-swatches-container .actions-section .family-color-picker-swatches .family-color-section .color-picker {
  position: relative;
  white-space: nowrap;
}

.surface-laptop-family .family-color-picker .family-color-picker-container .family-color-picker-swatches-container .actions-section .family-color-picker-swatches .family-color-section .color-picker .color-picker-dot-light {
  position: relative;
  padding: 0 13px
}

.surface-laptop-family .family-color-picker .family-color-picker-container .family-color-picker-swatches-container .actions-section .family-color-picker-swatches .family-color-section .color-picker .color-picker-dot-light input {
  position: absolute;
  z-index: -1;
  opacity: 0;
}

.surface-laptop-family .family-color-picker .family-color-picker-container .family-color-picker-swatches-container .actions-section .family-color-picker-swatches .family-color-section .color-picker .color-picker-dot-light input:checked + .color-picker-dot {
  -webkit-transform: scale(1.15);
          transform: scale(1.15);
  border-color: transparent;
  outline-style: solid;
  outline-width: 2px;
}


.surface-laptop-family .family-color-picker .family-color-picker-container .family-color-picker-swatches-container .actions-section .family-color-picker-swatches .family-color-section .color-picker .color-picker-dot-light input:checked + .color-picker-dot::before {
  content: "";
  position: absolute;
  border-radius: 50%;
  -webkit-box-shadow: inset 0 0 0 2px #000000;
          box-shadow: inset 0 0 0 2px #000000;
  width: 100%;
  height: 100%;
  z-index: 1;
}

.surface-laptop-family .family-color-picker .family-color-picker-container .family-color-picker-swatches-container .actions-section .family-color-picker-swatches .family-color-section .color-picker .color-picker-dot-light input:checked + .color-picker-dot::after {
  font-family: "MWF-MDL2";
  content: "\E8FB";
  color: #000000;
  position: absolute;
  line-height: 1;
  font-size: 25px;
  font-weight: 700;
  text-align: center;
  left: 50%;
  top: 50%;
  margin-left: -.5em;
  margin-top: -.5em;
}
@media screen and (max-width: 540px){
.surface-laptop-family .family-color-picker .family-color-picker-container .family-color-picker-swatches-container .actions-section .family-color-picker-swatches .family-color-section .color-picker .color-picker-dot-light input:checked + .color-picker-dot::after{
   font-size: 18px;
}
}
.surface-laptop-family .family-color-picker .family-color-picker-container .family-color-picker-swatches-container .actions-section .family-color-picker-swatches .family-color-section .color-picker .color-picker-dot-light input:checked + .color-picker-dot.swatch-color-1::after {
  color: #ffffff;
}

.surface-laptop-family .family-color-picker .family-color-picker-container .family-color-picker-swatches-container .actions-section .family-color-picker-swatches .family-color-section .color-picker .color-picker-dot-light input:checked + .color-picker-dot + .color-picker-label {
  display: block;
  position: absolute;

  left: 0;
  white-space: normal;
  font-size: 30px;
}
/*.surface-laptop-family .family-color-picker .family-color-picker-container .family-color-picker-swatches-container .actions-section .family-color-picker-swatches .family-color-section .color-picker .color-picker-dot-light input:checked + .color-picker-dot + .color-picker-label.swatch-tip{
  white-space: normal;
   bottom: -2.3em;
}*/
@media screen and (max-width: 767px){
.surface-laptop-family .family-color-picker .family-color-picker-container .family-color-picker-swatches-container .actions-section .family-color-picker-swatches .family-color-section .color-picker .color-picker-dot-light input:checked + .color-picker-dot + .color-picker-label{
  font-size: 12px;
  padding-top: 5px;
  padding-left: 10px;
}
}
.surface-laptop-family .family-color-picker .family-color-picker-container .family-color-picker-swatches-container .actions-section .family-color-picker-swatches .family-color-section .color-picker .color-picker-dot-light .color-picker-dot {
  height: 60px;
  width: 60px;
  display: inline-block;
  border-radius: 50%;
  border: 3.5px solid currentColor;
  margin-right: .83rem;
  margin-bottom: .25rem;
  margin: 1em 0.83em 1em 0;
  -webkit-transition: -webkit-transform .15s;
  transition: -webkit-transform .15s;
  transition: transform .15s;
  transition: transform .15s, -webkit-transform .15s;
  will-change: transform;
  position: relative;
  cursor: pointer;
}
@media only screen and (max-width: 320px) {
.surface-laptop-family .family-color-picker .family-color-picker-container .family-color-picker-swatches-container .actions-section .family-color-picker-swatches .family-color-section .color-picker .color-picker-dot-light .color-picker-dot{
   height: 40px;
  width: 40px;
 
}
}
@media only screen and (min-width: 321px) and (max-width: 540px) {
.surface-laptop-family .family-color-picker .family-color-picker-container .family-color-picker-swatches-container .actions-section .family-color-picker-swatches .family-color-section .color-picker .color-picker-dot-light .color-picker-dot{
   height: 48px;
  width: 48px;
   margin: 0px;
}
}

.surface-laptop-family .family-color-picker .family-color-picker-container .family-color-picker-swatches-container .actions-section .family-color-picker-swatches .family-color-section .color-picker .color-picker-dot-light input:focus + .color-picker-dot{
  border: 1px solid;
  outline: 2px solid;
}
.surface-laptop-family .family-color-picker .family-color-picker-container .family-color-picker-swatches-container .actions-section .family-color-picker-swatches .family-color-section .color-picker .color-picker-dot-light .color-picker-dot.swatch0{
  background: #9ca29f;
}
.surface-laptop-family .family-color-picker .family-color-picker-container .family-color-picker-swatches-container .actions-section .family-color-picker-swatches .family-color-section .color-picker .color-picker-dot-light .color-picker-dot.swatch1{
  background: #86888a;
}
.surface-laptop-family .family-color-picker .family-color-picker-container .family-color-picker-swatches-container .actions-section .family-color-picker-swatches .family-color-section .color-picker .color-picker-dot-light .color-picker-dot.swatch2{
  background: #6c788c;
}
.surface-laptop-family .family-color-picker .family-color-picker-container .family-color-picker-swatches-container .actions-section .family-color-picker-swatches .family-color-section .color-picker .color-picker-dot-light .color-picker-dot.swatch3{
  background: #cab1a0;
}

.surface-laptop-family .family-color-picker .family-color-picker-container .family-color-picker-swatches-container .actions-section .family-color-picker-swatches .family-color-section .color-picker .color-picker-dot-light .color-picker-dot.swatch-color-0{
  background: #d3d4d5;
}
.surface-laptop-family .family-color-picker .family-color-picker-container .family-color-picker-swatches-container .actions-section .family-color-picker-swatches .family-color-section .color-picker .color-picker-dot-light .color-picker-dot.swatch-color-1{
  background: #353637;
}
.surface-laptop-family .family-color-picker .family-color-picker-container .family-color-picker-swatches-container .actions-section .family-color-picker-swatches .family-color-section .color-picker .color-picker-dot-light .color-picker-dot.swatch-color-2{
  background: #8a9792;
}
.surface-laptop-family .family-color-picker .family-color-picker-container .family-color-picker-swatches-container .actions-section .family-color-picker-swatches .family-color-section .color-picker .color-picker-dot-light .color-picker-dot.swatch-color-3{
  background: #e9cdb8;
}
.surface-laptop-family .family-color-picker .family-color-picker-container .family-color-picker-swatches-container .actions-section .family-color-picker-swatches .family-color-section .color-picker .color-picker-dot-light .color-picker-dot.swatch-color-4{
  background: #d3d4d5;
}

.surface-laptop-family .family-color-picker .family-color-picker-container .family-color-picker-swatches-container .actions-section .family-color-picker-swatches .family-color-section .color-picker .color-picker-dot-light .color-picker-dot:hover {
  -webkit-transform: scale(1.15);
          transform: scale(1.15);
  border-color: transparent;
  outline-style: solid;
  outline-width: 1px;
}
/*.surface-laptop-family .family-color-picker .family-color-picker-container .family-color-picker-swatches-container .actions-section .family-color-picker-swatches .family-color-section .color-picker .color-picker-dot-light .color-picker-dot.swatch-color-1:hover{
  color: white;
}*/
.surface-laptop-family .family-color-picker .family-color-picker-container .family-color-picker-swatches-container .actions-section .family-color-picker-swatches .family-color-section .color-picker .color-picker-dot-light .color-picker-dot.swatch-color-1:hover{
  color: #ffffff;
}
.surface-laptop-family .family-color-picker .family-color-picker-container .family-color-picker-swatches-container .actions-section .family-color-picker-swatches .family-color-section .color-picker .color-picker-dot-light .color-picker-dot:active{
   border-color: transparent;
  outline-style: solid;
  outline-width: 2px;
}

.surface-laptop-family .family-color-picker .family-color-picker-container .family-color-picker-swatches-container .actions-section .family-color-picker-swatches .family-color-section .color-picker .color-picker-dot-light .color-picker-dot:hover::before {
  content: " ";
  position: absolute;
  border-radius: 50%;
  /*-webkit-box-shadow: inset 0 0 0 2px #000000;
          box-shadow: inset 0 0 0 2px #000000;*/
  width: 100%;
  height: 100%;
  z-index: 1;
}

.surface-laptop-family .family-color-picker .family-color-picker-container .family-color-picker-swatches-container .actions-section .family-color-picker-swatches .family-color-section .color-picker .color-picker-dot-light .color-picker-label {
  display: none;
}

.surface-laptop-family .family-color-picker .family-color-picker-container .family-color-picker-swatches-container .family-color-images .swatch-image {
  display: none;
}

.surface-laptop-family .family-color-picker .family-color-picker-container .family-color-picker-swatches-container .family-color-images .swatch-image.active {
  display: block;
}

.surface-laptop-family .family-color-picker .family-color-picker-container .family-color-picker-swatches-container .family-color-images .swatch-image img {
  width: 100%;
}

.surface-laptop-family .family-color-picker .iconpanel-swatch {
  width: 60%;
    padding: 190px 12px 10px 12px;
}
@media screen and (min-width: 768px) and (max-width: 1083px) {
   .surface-laptop-family .family-color-picker .iconpanel-swatch {
    width: 100%;
    padding-left: 5%;
    padding-right: 5%;
  }
}
@media screen and (max-width: 767px) {
   .surface-laptop-family .family-color-picker .iconpanel-swatch {
    width: 100%;
    padding: 80px 30px 10px 30px;
    }
    }
 .surface-laptop-family .family-color-picker .iconpanel-swatch ul {
  display: flex;
  flex-direction: row;
  flex-wrap: wrap;
  align-content: flex-start;
}
@media screen and (max-width: 767px) {
   .surface-laptop-family .family-color-picker .iconpanel-swatch ul {
    flex-direction: column;
    flex-wrap: nowrap;
    height: 910px;
  }
}
@media screen and (max-width: 320px) {
.surface-laptop-family .family-color-picker .iconpanel-swatch ul{
    height: 1070px;
}
}
 .surface-laptop-family .family-color-picker .iconpanel-swatch li {
  width: 50%;
  display: flex;
  justify-content: flex-start;
  padding-bottom: 60px;
  align-items: center;
}
@media screen and (max-width: 767px) {
 .surface-laptop-family .family-color-picker .iconpanel-swatch li {
    width: 100%;
    padding: 80px 30px 10px 30px;
  }
}
 
 @media screen and (forced-colors: active) and (prefers-color-scheme: dark) {
    .surface-laptop-family .family-color-picker .iconlist-swatch .c-logo img {
      background-color: WindowText;
    }
    .surface-laptop-family .family-color-picker .family-color-picker-container .family-color-picker-swatches-container .actions-section .family-color-picker-swatches .family-color-section .color-picker .color-picker-dot-light .color-picker-dot.swatch-color-0,
    .surface-laptop-family .family-color-picker .family-color-picker-container .family-color-picker-swatches-container .actions-section .family-color-picker-swatches .family-color-section .color-picker .color-picker-dot-light .color-picker-dot.swatch-color-1,
    .surface-laptop-family .family-color-picker .family-color-picker-container .family-color-picker-swatches-container .actions-section .family-color-picker-swatches .family-color-section .color-picker .color-picker-dot-light .color-picker-dot.swatch-color-2,
    .surface-laptop-family .family-color-picker .family-color-picker-container .family-color-picker-swatches-container .actions-section .family-color-picker-swatches .family-color-section .color-picker .color-picker-dot-light .color-picker-dot.swatch-color-3,
    .surface-laptop-family .family-color-picker .family-color-picker-container .family-color-picker-swatches-container .actions-section .family-color-picker-swatches .family-color-section .color-picker .color-picker-dot-light .color-picker-dot.swatch-color-4,
    .surface-laptop-family .family-color-picker .family-color-picker-container .family-color-picker-swatches-container .actions-section .family-color-picker-swatches .family-color-section .color-picker .color-picker-dot-light .color-picker-dot.swatch0,
    .surface-laptop-family .family-color-picker .family-color-picker-container .family-color-picker-swatches-container .actions-section .family-color-picker-swatches .family-color-section .color-picker .color-picker-dot-light .color-picker-dot.swatch1,
    .surface-laptop-family .family-color-picker .family-color-picker-container .family-color-picker-swatches-container .actions-section .family-color-picker-swatches .family-color-section .color-picker .color-picker-dot-light .color-picker-dot.swatch2,
    .surface-laptop-family .family-color-picker .family-color-picker-container .family-color-picker-swatches-container .actions-section .family-color-picker-swatches .family-color-section .color-picker .color-picker-dot-light .color-picker-dot.swatch3{
      forced-color-adjust: none;
      /*forced-color-adjust: preserve-parent-color;*/
    }
 }
 @media screen and (forced-colors: active) and (prefers-color-scheme: light) {
   .surface-laptop-family .family-color-picker .family-color-picker-container .family-color-picker-swatches-container .actions-section .family-color-picker-swatches .family-color-section .color-picker .color-picker-dot-light .color-picker-dot.swatch-color-0,
    .surface-laptop-family .family-color-picker .family-color-picker-container .family-color-picker-swatches-container .actions-section .family-color-picker-swatches .family-color-section .color-picker .color-picker-dot-light .color-picker-dot.swatch-color-1,
    .surface-laptop-family .family-color-picker .family-color-picker-container .family-color-picker-swatches-container .actions-section .family-color-picker-swatches .family-color-section .color-picker .color-picker-dot-light .color-picker-dot.swatch-color-2,
    .surface-laptop-family .family-color-picker .family-color-picker-container .family-color-picker-swatches-container .actions-section .family-color-picker-swatches .family-color-section .color-picker .color-picker-dot-light .color-picker-dot.swatch-color-3,
    .surface-laptop-family .family-color-picker .family-color-picker-container .family-color-picker-swatches-container .actions-section .family-color-picker-swatches .family-color-section .color-picker .color-picker-dot-light .color-picker-dot.swatch-color-4,
    .surface-laptop-family .family-color-picker .family-color-picker-container .family-color-picker-swatches-container .actions-section .family-color-picker-swatches .family-color-section .color-picker .color-picker-dot-light .color-picker-dot.swatch0,
    .surface-laptop-family .family-color-picker .family-color-picker-container .family-color-picker-swatches-container .actions-section .family-color-picker-swatches .family-color-section .color-picker .color-picker-dot-light .color-picker-dot.swatch1,
    .surface-laptop-family .family-color-picker .family-color-picker-container .family-color-picker-swatches-container .actions-section .family-color-picker-swatches .family-color-section .color-picker .color-picker-dot-light .color-picker-dot.swatch2,
    .surface-laptop-family .family-color-picker .family-color-picker-container .family-color-picker-swatches-container .actions-section .family-color-picker-swatches .family-color-section .color-picker .color-picker-dot-light .color-picker-dot.swatch3{
      forced-color-adjust: none;
      /*forced-color-adjust: preserve-parent-color;*/
    }
 }
 /*@media screen and (forced-colors: active) and (prefers-color-scheme: light) {
     .surface-laptop-family .family-color-picker .iconlist-swatch .c-logo img {
      background-color: WindowText;
    }
 }*/
 .surface-laptop-family .family-color-picker .iconpanel-swatch li .c-paragraph-3 {
    font-size: 30px;
    line-height: 42px;
    font-weight: 600;
    padding-top: 0px !important;
    padding-left: 15px;
 }
 @media screen and (max-width: 767px) {
   .surface-laptop-family .family-color-picker .iconpanel-swatch li .c-paragraph-3 {
   font-size: 24px;
  }
   }
/*# sourceMappingURL=style.css.map */

/*FALL 22 updates Start*/
/*User story Banner start*/
.surface-laptop-family  .m-banner.surface-lf-banner{
    text-align: left;
    padding-left: 0;
    margin-bottom: 15px;
    float: left;
    
}
@media screen and (min-width: 768px) and (max-width: 1083px) {
    
    /*.surface-laptop-family .surface-lf-innovation{
        margin-top: 70px;
    }*/
   .surface-laptop-family .m-banner.surface-lf-banner {
    padding-left: 10%;
}
}

@media screen and (max-width: 767px) {
   .surface-laptop-family .m-banner.surface-lf-banner {
    padding-left: 48px;
}
}
/*.surface-laptop-family  .m-banner.surface-lf-banner h2.c-heading-2{
padding: 5px 0 2px 0;
}*/
.surface-laptop-family  .m-banner.surface-lf-banner p.c-paragraph-3{
padding: 10px 0 15px 0;
}
/*User story Banner End*/

.surface-laptop-family .surface-FamilyDevices .m-banner a.c-call-to-action.f-lightweight:hover span,
.surface-laptop-family .surface-laptopfamily-mte .m-feature a.c-call-to-action.f-lightweight:hover span{
  box-shadow: none;
}

.surface-laptop-family .surface-laptopfamily-mte,
.surface-laptop-family #family-interactivecards {
  background-color: #ffffff;
}
/*.surface-laptop-family .reduced-animation-toggle .c-label{
    margin-top: 0;
    padding-right: 20px;
    padding-bottom: 0px;
    float: left;
    }*/
.surface-laptop-family .surface-laptopfamily-mte a.mscom-link.c-call-to-action.c-glyph.f-lightweight{
  padding-right: 20px;
}
.surface-laptop-family .surface-laptopfamily-mte .c-call-to-action:not(.f-primary):not(.f-secondary):focus:not(.x-hidden-focus){
  background: none;
}
.surface-laptop-family .surface-laptopfamily-mte .m-feature .c-call-to-action:not(.f-primary):not(.f-secondary):focus{
      border-color: #ffffff;
}
    
/*Fall 22 Video button start*/
.video-btn-laptop-family {
  position: absolute;
}


.video-btn-laptop-family.top-left {
  right: 47%;
    bottom: 48%;
  z-index: 1;
}

/*@media only screen and (max-width:1084px) {
    .video-btn-laptop-family.top-left {
         right: 21px;
      top: 17px;
       
        
    }
}
@media only screen and (max-width:767px) {
    .video-btn-laptop-family.top-left {
       right: 17px;
    top: 17px;
       
    }
}*/


.video-btn-laptop-family .videobutton.c-action-toggle.c-glyph {
  /*border: 2px solid #171717;*/
  width: 45px;
  height: 45px;
  /*background: transparent;*/
  background: #E8E8E8;
  border-radius: 50%;
  position: relative;
  margin: 0;
  padding: 0;
  overflow: initial;
}

/*.video-btn-laptop-family .videobutton.c-action-toggle.c-glyph:focus {
  border: 2px dashed #171717;
  outline-color: transparent;
}*/

.video-btn-laptop-family .videobutton.c-action-toggle.c-glyph:before {
  color: #0067B8;
  margin-left: 10px;
  margin-top: 0px;
}

.video-btn-laptop-family .videobutton.c-action-toggle.c-glyph:after {
  border: none;
}
.video-btn-laptop-family button.videobutton.c-action-toggle:focus {
     border-color: transparent; 
}
/*Fall 22 Video button end*/
/*Fall22 Banner Start*/
/*.fallCustomBanner {
  margin: 0 auto;
  clear: both;
}
.fallCustomBanner .m-banner {
  padding-bottom: 24px;
  width: 60%;
}
@media only screen and (max-width: 1399px) {
  .fallCustomBanner .m-banner {
    width: 80%;
  }
}
@media only screen and (max-width: 1083px) {
  .fallCustomBanner .m-banner {
    width: 80%;
  }
}
@media only screen and (max-width: 767px) {
  .fallCustomBanner .m-banner {
    width: 80%;
  }
}
@media only screen and (max-width: 539px) {
  .fallCustomBanner .m-banner {
    width: 90%;
  }
}
.fallCustomBanner .m-banner.f-align-left {
  margin: initial;
}
.fallCustomBanner .m-banner h2 {
  font-size: 62px;
  line-height: 72px;
}
@media only screen and (min-width: 768px) {
  .fallCustomBanner .m-banner h2 {
    display: flex;
    flex-direction: column;
  }
}
@media only screen and (max-width: 1083px) {
  .fallCustomBanner .m-banner h2 {
    font-size: 46px;
    line-height: 56px;
  }
}
@media only screen and (max-width: 767px) {
  .fallCustomBanner .m-banner h2 {
    font-size: 34px;
    line-height: 40px;
  }
}
@media only screen and (max-width: 539px) {
  .fallCustomBanner .m-banner h2 {
    font-size: 34px;
    line-height: 40px;
  }
}
.fallCustomBanner .m-banner p {
  font-weight: 400;
  font-size: 15px;
  line-height: 20px;
}*/
/*Fall22 Banner End*/

/*user story fixes*/
/*@media only screen and (min-width: 768px){
    .surface-laptop-family .surface-lf-userstory .c-feature.f-align-right,
    .surface-laptop-family .surface-lf-userstory .c-feature.f-align-left{
    min-height: 279px;
}
.surface-laptop-family .surface-lf-userstory .c-feature.f-align-right.f-image-priority picture,
.surface-laptop-family .surface-lf-userstory .c-feature.f-align-left.f-image-priority picture,
.surface-laptop-family .surface-lf-userstory .c-feature.f-align-left.f-image-priority video,
.surface-laptop-family .surface-lf-userstory .c-feature.f-align-right.f-image-priority video{
  width: 65%;
}
.surface-laptop-family .surface-lf-userstory .c-feature.f-align-right.f-image-priority>div{
  left: 65%;
}

.surface-laptop-family .surface-lf-userstory .c-feature.f-align-left.f-image-priority>div{
  right: 65%;
}
.surface-laptop-family .surface-lf-userstory .c-feature.f-align-right.f-image-priority>div,
.surface-laptop-family .surface-lf-userstory .c-feature.f-align-left.f-image-priority>div{
  width: 65%;
}
.surface-laptop-family .surface-lf-userstory .c-feature.f-align-left picture,
.surface-laptop-family .surface-lf-userstory .c-feature.f-align-left video{
  float: right;
}

}*/
@media only screen and (min-width: 768px) and (max-width: 1083px) {
    .surface-laptop-family .surface-lf-userstory .c-feature.f-align-left picture,
    .surface-laptop-family .surface-lf-userstory .c-feature.f-align-right picture,
    .surface-laptop-family .surface-lf-userstory .c-feature.f-align-left video,
    .surface-laptop-family .surface-lf-userstory .c-feature.f-align-right video {
        width:50%;
    }

    .surface-laptop-family .surface-lf-userstory .c-feature.f-align-left picture img,
    .surface-laptop-family .surface-lf-userstory .c-feature.f-align-right picture img,
    .surface-laptop-family .surface-lf-userstory .c-feature.f-align-left video,
    .surface-laptop-family .surface-lf-userstory .c-feature.f-align-right video{
        right: 0;
    }
    .surface-laptop-family .surface-lf-userstory .c-feature.f-align-left>div,
    .surface-laptop-family .surface-lf-userstory .c-feature.f-align-right>div{
        padding-left: 36px;
        padding-right: 36px;
        padding-bottom: 0;
        position: absolute;
        top: calc(50%);
        -ms-transform: translateY(-50%);
        transform: translateY(-50%);
        width: 50%;
        text-align: left
    }
    .surface-laptop-family .surface-lf-userstory .c-feature.f-align-left>div.m-ambient-video,
    .surface-laptop-family .surface-lf-userstory .c-feature.f-align-right>div.m-ambient-video {
        margin: 0
    }

    .surface-laptop-family .surface-lf-userstory .c-feature.f-align-left>div .c-heading,
    .surface-laptop-family .surface-lf-userstory .c-feature.f-align-right>div .c-heading{
        padding-top: 0
    }
    .surface-laptop-family .surface-lf-userstory .c-feature.f-align-left>div {
        left: 0
    }

    .surface-laptop-family .surface-lf-userstory .c-feature.f-align-left picture,
    .surface-laptop-family .surface-lf-userstory .c-feature.f-align-left .m-ambient-video {
        float: right;
        left: 50%
    }
    .surface-laptop-family .surface-lf-userstory .c-feature.f-align-right>div {
        left: 50%
    }

    .surface-laptop-family .surface-lf-userstory .c-feature.f-align-right picture,
    .surface-laptop-family .surface-lf-userstory .c-feature.f-align-right .m-ambient-video
     {
        float: left;
        left: 0
    }

    
    .surface-laptop-family .surface-lf-userstory .c-feature.f-align-right{
        min-height: 213px
    }

    /*.surface-laptop-family .surface-lf-userstory .c-feature.f-align-right.f-image-priority>div{
        left: 50%;
    }*/

    .surface-laptop-family .surface-lf-userstory .c-feature.f-align-left{
        min-height: 213px
    }
    .surface-laptop-family .surface-lf-userstory .m-feature>div{
      width: 100%
    }   
}


       .surface-laptop-family .lf-userstory-4{
       padding-bottom: 48px;
   }
   
/*@media only screen and (min-width: 1084px){
.surface-laptop-family .surface-lf-userstory .c-feature.f-align-left>div, 
.surface-laptop-family .surface-lf-userstory .c-feature.f-align-right>div {
  width: 40%
}
.surface-laptop-family .surface-lf-userstory .c-feature.f-align-left picture, 
.surface-laptop-family .surface-lf-userstory .c-feature.f-align-right picture, 
.surface-laptop-family .surface-lf-userstory .c-feature.f-align-left video, 
.surface-laptop-family .surface-lf-userstory .c-feature.f-align-right video {
    width: 60%;
}
.surface-laptop-family .surface-lf-userstory .c-feature.f-align-right.f-image-priority>div{
    left: 65% ;
}

}*/
/*.surface-laptop-family .surface-lf-userstory .c-feature{
    display: block;
    width: 100%;
    float: left;
    clear: both;
    position: relative;
    height: auto
}

.surface-laptop-family .surface-lf-userstory .c-feature:before,
.surface-laptop-family .surface-lf-userstory .c-feature:after{
    content: " ";
    display: table
}

.surface-laptop-family .surface-lf-userstory .c-feature:after{
    clear: both
}
.surface-laptop-family .surface-lf-userstory .c-feature>div{
    text-align: center;
    margin: 0 auto
}

.surface-laptop-family .surface-lf-userstory .c-feature>div .c-heading{
    font-size: 20px;
    line-height: 24px;
    padding: 35px 0 5px;
    font-weight: 600;
    font-weight: 600;
    opacity: .95;
    padding-top: 24px;
    margin-top: 20px
}
.surface-laptop-family .surface-lf-userstory .c-feature>div .c-paragraph{
    font-size: 15px;
    line-height: 20px;
    padding: 12px 0 0;
    font-weight: 400
}

.surface-laptop-family .surface-lf-userstory .c-feature picture,
.surface-laptop-family .surface-lf-userstory .c-feature .m-ambient-video {
    display: block;
    width: 100%;
    max-width: 100%
}

.surface-laptop-family .surface-lf-userstory .c-feature picture img {
    max-width: 100%;
    min-height: 213px;
    height: auto
}
.surface-laptop-family .surface-lf-userstory .c-feature.f-align-left>div,
.surface-laptop-family .surface-lf-userstory .c-feature.f-align-right>div{
    width: 100%;
    position: relative;
    padding: 0 24px 24px
}

.surface-laptop-family .surface-lf-userstory .c-feature.f-align-left>div.m-ambient-video,
.surface-laptop-family .surface-lf-userstory .c-feature.f-align-right>div.m-ambient-video{
    padding: 0
}
@media only screen and (min-width: 540px) {
    .surface-laptop-family .surface-lf-userstory .c-feature.f-align-left,
    .surface-laptop-family .surface-lf-userstory .c-feature.f-align-right {
        min-height: 211px
    }

    .surface-laptop-family .surface-lf-userstory .c-feature.f-align-left>div,
    .surface-laptop-family .surface-lf-userstory .c-feature.f-align-right>div{
        width: 490px;
        margin: 0 auto;
        text-align: center
    }
}
@media only screen and (min-width: 1084px) {
    .surface-laptop-family .surface-lf-userstory .c-feature>div .c-heading {
        font-size:34px;
        line-height: 40px;
        padding: 38px 0 2px;
        font-weight: 600;
        padding-top: 0
    }

    .surface-laptop-family .surface-lf-userstory .c-feature>div .c-paragraph{
        padding-top: 12px
    }

    .surface-laptop-family .surface-lf-userstory .c-feature.f-align-right,
    .surface-laptop-family .surface-lf-userstory .c-feature.f-align-left {
        min-height: 279px
    }

    .surface-laptop-family .surface-lf-userstory .c-feature.f-align-right.f-image-priority picture,
    .surface-laptop-family .surface-lf-userstory .c-feature.f-align-left.f-image-priority picture{
        width: 65%
    }
    .surface-laptop-family .surface-lf-userstory .c-feature.f-align-right.f-image-priority>div,
    .surface-laptop-family .surface-lf-userstory .c-feature.f-align-left.f-image-priority>div {
        width: 35%
    }
    .surface-laptop-family .surface-lf-userstory .c-feature.f-align-right.f-image-priority>div{
        left: 65%
    }
}

@media only screen and (min-width: 1400px) {
    

    .surface-laptop-family .surface-lf-userstory .c-feature.f-align-right,
    .surface-laptop-family .surface-lf-userstory .c-feature.f-align-left{
        min-height: 315px
    }

    .surface-laptop-family .surface-lf-userstory .c-feature.f-align-right>div,
    .surface-laptop-family .surface-lf-userstory .c-feature.f-align-left>div {
        padding-left: 48px;
        padding-right: 48px
    }

   
}
@media only screen and (min-width: 1779px) {
    .surface-laptop-family .surface-lf-userstory .c-feature.f-align-left picture,
    .surface-laptop-family .surface-lf-userstory .c-feature.f-align-right picture{
        width:50%
    }

    .surface-laptop-family .surface-lf-userstory .c-feature.f-align-left picture img,
    .surface-laptop-family .surface-lf-userstory .c-feature.f-align-right picture img{
        right: 0
    }
    .surface-laptop-family .surface-lf-userstory .c-feature.f-align-left>div,
    .surface-laptop-family .surface-lf-userstory .c-feature.f-align-right>div {
        padding-left: 36px;
        padding-right: 36px;
        padding-bottom: 0;
        position: absolute;
        top: calc(50%);
        -ms-transform: translateY(-50%);
        transform: translateY(-50%);
        width: 50%;
        text-align: left
    }
    .surface-laptop-family .surface-lf-userstory .c-feature.f-align-left>div.m-ambient-video,
    .surface-laptop-family .surface-lf-userstory .c-feature.f-align-right>div.m-ambient-video{
        margin: 0
    }

    .surface-laptop-family .surface-lf-userstory .c-feature.f-align-left>div .c-heading,
    .surface-laptop-family .surface-lf-userstory .c-feature.f-align-right>div .c-heading{
        padding-top: 0
    }
    .surface-laptop-family .surface-lf-userstory .c-feature.f-align-left>div{
        left: 0
    }

    .surface-laptop-family .surface-lf-userstory .c-feature.f-align-left picture,
    .surface-laptop-family .surface-lf-userstory .c-feature.f-align-left .m-ambient-video {
        float: right
    }
    .surface-laptop-family .surface-lf-userstory .c-feature.f-align-right>div{
        left: 50%
    }

    .surface-laptop-family .surface-lf-userstory .c-feature.f-align-right picture,
    .surface-laptop-family .surface-lf-userstory .c-feature.f-align-right .m-ambient-video {
        float: left;
        left: 0
    }

    .surface-laptop-family .surface-lf-userstory .c-feature.f-align-right.f-image-priority>div{
        left: 65%
    }
    .surface-laptop-family .surface-lf-userstory .c-feature.f-align-right,
    .surface-laptop-family .surface-lf-userstory .c-feature.f-align-left {
        min-height: 400px
    }
}*/
/*FALL 22 updates End*/

/*Link nav START*/

/*.surface-laptop-family nav.c-link-navigation ul li a.c-hyperlink span {
   
    font-weight: 700;
    font-size: 13px;
    
    text-decoration: underline;
}
@media only screen and (max-width: 539px) {
.surface-laptop-family .laptop-family-drawer.c-glyph{
  font-size: 13px;
    line-height: 16px;
    display: block;
    border: 0;
    background: 0 0;
    color: #000;
    font-weight: 600;
    padding: 10px 12px 10px 0;
    left: 0;
    text-align: left;
    width: 50%;
    margin-bottom: 4px;
}
.surface-laptop-family button.laptop-family-drawer:focus {
    outline: #000 dashed 2px;
}
.surface-laptop-family button.laptop-family-drawer[aria-expanded="true"]::after {
    content: "";
}
.surface-laptop-family button.laptop-family-drawer:after {
    margin-top: 2px;
    position: absolute;
    padding-left: 6px;
    font-size: x-small;
}
.surface-laptop-family nav.c-link-navigation{
  margin: 0 auto 24px 0;
}
.surface-laptop-family nav.c-link-navigation ul li {
    text-align: left !important;
    width: 100%;
    clear: both;
    display: block;
    height: auto;
    padding-top: 10px;
}
.surface-laptop-family nav.c-link-navigation ul li a.c-hyperlink.f-image {
    display: inline !important;
}
.surface-laptop-family nav.c-link-navigation ul li a.c-hyperlink.f-image {
    padding-top: 4px;
}
.surface-laptop-family nav.c-link-navigation ul li a.c-hyperlink picture {
    text-align: left;
    max-width: none;
    display: inline-block;
}
.surface-laptop-family nav.c-link-navigation ul li a.c-hyperlink picture img {
    width: 20px;
    height: 100%;
}

.surface-laptop-family .laptop-family-prefooter{
    width: 90%;
    margin: 24px 18px 18px 18px;
    position: relative;
}
}

@media only screen and (min-width: 540px) {
  .surface-laptop-family .laptop-family-drawer.c-glyph{
    display: none;
  }
}*/
.surface-laptop-family .c-drawer {
    background: #ffffff;
}
.surface-laptop-family .wdg-m-prefooter nav.c-link-navigation ul li .c-hyperlink:focus:not(.x-hidden-focus):not(.wdg-f-blue-button) {
    outline: none !important;
}
@media only screen and (max-width: 539px) {
.surface-laptop-family .wdg-m-prefooter nav.c-link-navigation ul li a.c-hyperlink.f-image {
     display: inline-block !important;
}
.surface-laptop-family .wdg-m-prefooter button.drawer:focus {
    outline: #000000 dashed 2px;
}
}
@media only screen and (min-width: 1084px){
.wdg-m-prefooter nav.c-link-navigation.refineDrawer2list-7 ul li {
    width: 13%;
}
}
.surface-laptop-family nav#refineDrawer2 ul li a {
    border: none;
}
/*Link nav END*/
/*Animation off toggle css*/
    
@media screen and (max-width: 1600px) {
        .animation-off .surface-laptop-family .wdg-device-highlight-tile.business-style .wdg-device-highlight-tile-content {
            padding: 0 0 0 36px;
        }
        .animation-off .surface-laptop-family .wdg-device-highlight-tile.business-style .wdg-device-highlight-tile-content .wdg-device-content .c-heading-2 {
            font-size: 28px;
            line-height: 38px;
        }
        .animation-off .surface-laptop-family .wdg-device-highlight-tile.business-style .wdg-device-highlight-tile-content .wdg-device-specs-grid .wdg-device-specs-flex .wdg-device-category-content .wdg-device-spec-content {
            padding: 19px 36px 12px 36px;
        }
        .animation-off .surface-laptop-family .wdg-device-highlight-tile.business-style .wdg-device-highlight-tile-content .wdg-device-specs-grid .wdg-device-specs-flex .wdg-device-category-content .wdg-device-spec-content .c-heading-3 {
            font-size: 18px;
            line-height: 28px;
        }
        .animation-off .surface-laptop-family .wdg-device-highlight-tile.business-style .wdg-device-highlight-tile-content .wdg-device-specs-grid .wdg-device-specs-flex .wdg-device-category-content .wdg-device-spec-content .c-paragraph-3 {
            font-size: 16px;
            line-height: 20px;
        }
    }

@media screen and (max-width: 1400px) {
    .animation-off .surface-laptop-family .wdg-lifestyle-video .lifestyle-video-box-content {
        padding: 0 150px !important;
    }
    .animation-off .surface-laptop-family .wdg-lifestyle-video .lifestyle-video-box-content .lifestyle-video-main-content .c-heading-2 {
        font-size: 38px;
        line-height: 48px;
    }


    .animation-off .surface-laptop-family .wdg-lifestyle-video .lifestyle-video-box-content .lifestyle-video-main-content .c-paragraph {
        font-size: 16px;
    }


    .animation-off .surface-laptop-family .wdg-device-highlight-tile.business-style .wdg-device-highlight-tile-content {
        padding: 0 0 0 36px;
    }


    .animation-off .surface-laptop-family .wdg-device-highlight-tile .wdg-device-highlight-tile-content {
        padding: 0 0 0 36px;
    }
}

@media screen and (min-width: 1084px) and (max-width: 1400px) {
    .animation-off .surface-laptop-family .wdg-device-highlight-tile .wdg-device-highlight-tile-content .wdg-device-content .c-heading-2 {
        font-size: 34px;
        line-height: 44px;
    }
    .animation-off .surface-laptop-family .wdg-device-highlight-tile .wdg-device-highlight-tile-content .wdg-device-content .c-paragraph-2 {
        font-size: 16px;
        line-height: 20px;
    }
}

@media screen and (max-width: 1083px) {
    .animation-off .surface-laptop-family .wdg-lifestyle-video .lifestyle-video-box-content {
        padding: 0 100px;
    }
    .animation-off .surface-laptop-family .wdg-lifestyle-video .lifestyle-video-box-content .lifestyle-video-main-content .c-heading-2 {
        font-size: 27px;
        line-height: 37px;
    }
    .animation-off .surface-laptop-family .wdg-lifestyle-video .lifestyle-video-box-content .lifestyle-video-main-content .c-paragraph {
        padding: 15px 0 0 0;
    }
    .animation-off .surface-laptop-family .wdg-lifestyle-video .lifestyle-video-box-content .lifestyle-video-main-content .lifestyle-video-cta {
        padding: 16px 0 0 0;
    }
    .animation-off .surface-laptop-family .wdg-device-highlight-tile.business-style .wdg-device-highlight-tile-content {
        padding: 0 39px 0 39px;
    }
    .animation-off .surface-laptop-family .wdg-device-highlight-tile.business-style .wdg-device-highlight-tile-content .wdg-device-specs-grid .wdg-device-specs-flex .wdg-device-category-content .wdg-device-spec-content {
        padding: 19px 36px 12px 36px;
    }
    .animation-off .surface-laptop-family .wdg-device-highlight-tile.business-style .wdg-device-highlight-tile-content .wdg-device-specs-grid .wdg-device-specs-flex .wdg-device-category-content .wdg-device-spec-content .c-heading-3 {
        font-size: 28px;
        line-height: 38px;
    }
    .animation-off .surface-laptop-family .wdg-device-highlight-tile.business-style .wdg-device-highlight-tile-content .wdg-device-specs-grid .wdg-device-specs-flex .wdg-device-category-content .wdg-device-spec-content .c-paragraph-3 {
        font-size: 18px;
        line-height: 28px;
        padding: 17px 0 11px 0;
    }
    .animation-off .surface-laptop-family .wdg-device-highlight-tile .wdg-device-highlight-tile-content {
        padding: 0 95px 0 95px;
    }
    .animation-off .surface-laptop-family .main-image-stack .image-stack-item-2 {
        transition-property: none;
    }
}


@media screen and (max-width: 767px) {
    .animation-off .surface-laptop-family .wdg-lifestyle-video .lifestyle-video-box-content {
        padding: 0 72px;
    }
    .animation-off .surface-laptop-family .wdg-lifestyle-video .lifestyle-video-box-content .lifestyle-video-main-content .c-heading-2 {
        font-size: 27px;
        line-height: 37px;
    }
    .animation-off .surface-laptop-family .wdg-lifestyle-video .lifestyle-video-box-content .lifestyle-video-main-content .c-paragraph {
        font-size: 18px;
        padding: 38px 0 0 0;
    }
    .animation-off .surface-laptop-family .wdg-lifestyle-video .lifestyle-video-box-content .lifestyle-video-main-content .lifestyle-video-cta {
        padding: 28px 0 0 0;
    }
    /*Life style vide content is comming in single line in tablet and mobile vp */
    .animation-off .surface-laptop-family .wdg-lifestyle-video .lifestyle-video-box-content {
        padding: 0 72px;
    }
    /*interactive cards text cominng on video and on image*/
    .animation-off .surface-laptop-family .wdg-device-highlight-tile .wdg-device-m-image {
        position: initial;
    }

    .animation-off .surface-laptop-family .wdg-device-highlight-tile .wdg-device-highlight-tile-content {
        position: initial;
        -ms-transform: initial;
        -webkit-transform: initial;
        transform: initial;
        width: 100%;
        padding: 0 52px 146px 52px;
    }
}

@media screen and (max-width: 540px) {
    .animation-off .surface-laptop-family .wdg-lifestyle-video .lifestyle-video-box-content {
        padding: 50% 0 5% 8% !important;
    }
    .animation-off .surface-laptop-family .wdg-lifestyle-video .lifestyle-video-box-content .lifestyle-video-main-content .c-heading-2 {
        font-size: 25px;
        line-height: 35px;
    }
}

@media screen and (min-width: 768px) {
    .animation-off .surface-laptop-family .wdg-device-highlight-tile {
        min-height: 100vh;
    }
}

@media screen and (min-width: 768px) and (max-width: 1083px) {
    .animation-off .surface-laptop-family .wdg-device-highlight-tile.business-style .wdg-device-highlight-tile-content .wdg-device-content .c-paragraph-2 {
        font-size: 21px;
        line-height: 30px;
        padding: 16px 0 0 0;
    }
}
.animation-off .surface-laptop-family .feature_summary_360 .feature_summary_360_left .feature_summary_360_animation.is-scrollDown,
.animation-off .surface-laptop-family .feature_summary_360 .feature_summary_360_left .feature_summary_360_animation.is-scrollTop,
.animation-off .surface-laptop-family .m-multi-feature .feature-swatch .feature-swatch-content .swatch-content-animation.is-scrollDown,
.animation-off .surface-laptop-family .m-multi-feature .feature-swatch .feature-swatch-content .swatch-content-animation.is-scrollTop,
.animation-off .surface-laptop-family .family-color-picker .family-color-picker-container .family-color-picker-content.is-scrollTop,
.animation-off .surface-laptop-family .family-color-picker .family-color-picker-container .family-color-picker-content.is-scrollDown,
.animation-off .surface-laptop-family .family-color-picker .family-color-picker-container .family-color-picker-content.is-scrollTop,
.animation-off .surface-laptop-family .family-color-picker .family-color-picker-container .family-color-picker-content.is-scrollDown,
.animation-off .surface-laptop-family .animated-hero .animated-hero-main-content .hero-content.slide-in-m-banner,
.animation-off .surface-laptop-family .wdg-device-highlight-tile .wdg-device-highlight-tile-content .wdg-device-specs-grid .wdg-device-specs-flex .wdg-device-category-content.is-scrollDown,
.animation-off .surface-laptop-family .wdg-device-highlight-tile .wdg-device-highlight-tile-content .wdg-device-specs-grid .wdg-device-specs-flex .wdg-device-category-content.is-scrollTop,
.animation-off .surface-laptop-family .wdg-device-highlight-tile .wdg-device-highlight-tile-content .wdg-device-specs-grid .wdg-device-model.foldIn.foldout {
    -webkit-animation: none;
    animation: none;
}
.animation-off .surface-laptop-family .wdg-lifestyle-video .lifestyle-video.margin-top {
    top: 0;
}
.animation-off .surface-laptop-family .wdg-lifestyle-video .lifestyle-video {
        position: relative;
    }

.animation-off .surface-laptop-family .wdg-lifestyle-video .lifestyle-video .masker {
            background-color: rgba(0, 0, 0, 0.6);
            top: 0;
            height: 100%;
        }

.animation-off .surface-laptop-family .wdg-lifestyle-video .lifestyle-video-content {
        position: absolute;
        top: 50%;
        -webkit-transform: translateY(-50%);
        transform: translateY(-50%);
    }

.animation-off .surface-laptop-family .wdg-lifestyle-video .lifestyle-video-content .lifestyle-video-main-content {
            opacity: 1;
        }

.animation-off .surface-laptop-family .wdg-lifestyle-video .lifestyle-video-box-content {
        padding: 150px 176px 0px 176px;
    }

.animation-off .surface-laptop-family .wdg-lifestyle-video .lifestyle-video-box-content .lifestyle-video-main-content .c-heading-2 {
            font-size: 50px;
            line-height: 60px;
        }

.animation-off .surface-laptop-family .wdg-lifestyle-video .lifestyle-video-box-content .lifestyle-video-main-content .c-paragraph {
            font-size: 20px;
            padding: 30px 0 0 0;
        }

.animation-off .surface-laptop-family .wdg-lifestyle-video .lifestyle-video-box-content .lifestyle-video-main-content .lifestyle-video-cta {
            padding: 28px 0 0 0;
        }

.animation-off .surface-laptop-family .wdg-device-highlight-tile.business-style .wdg-device-highlight-tile-content {
        padding: 0 0 0 103px;
    }

.animation-off .surface-laptop-family .wdg-device-highlight-tile.business-style .wdg-device-highlight-tile-content .wdg-device-content .c-heading-2 {
            font-size: 34px;
            line-height: 44px;
        }

.animation-off .surface-laptop-family .wdg-device-highlight-tile.business-style .wdg-device-highlight-tile-content .wdg-device-content .c-paragraph-2 {
            font-size: 17px;
            line-height: 25px;
            padding: 25px 0 0 0;
        }

.animation-off .surface-laptop-family .wdg-device-highlight-tile.business-style .wdg-device-highlight-tile-content .wdg-device-specs-grid {
            padding: 46px 0 0 0;
        }

.animation-off .surface-laptop-family .wdg-device-highlight-tile.business-style .wdg-device-highlight-tile-content .wdg-device-specs-grid .wdg-device-specs-flex .wdg-device-category-content .wdg-device-spec-content {
                padding: 39px 33px 23px 33px;
            }

.animation-off .surface-laptop-family .wdg-device-highlight-tile.business-style .wdg-device-highlight-tile-content .wdg-device-specs-grid .wdg-device-specs-flex .wdg-device-category-content .wdg-device-spec-content .c-heading-3 {
                    font-size: 21px;
                    line-height: 30px;
                }

.animation-off .surface-laptop-family .wdg-device-highlight-tile.business-style .wdg-device-highlight-tile-content .wdg-device-specs-grid .wdg-device-specs-flex .wdg-device-category-content .wdg-device-spec-content .c-paragraph-3 {
                    padding: 22px 0 7px 0;
                }

.animation-off .surface-laptop-family .wdg-device-highlight-tile .wdg-device-m-image {
        position: relative;
        /*display: none;*/
    }

.animation-off .surface-laptop-family .wdg-device-highlight-tile .wdg-device-highlight-tile-content {
        position: absolute;
        top: 50%;
        -webkit-transform: translateY(-50%);
        transform: translateY(-50%);
        padding: 0 0 0 100px;
    }

.animation-off .surface-laptop-family .wdg-device-highlight-tile .wdg-device-highlight-tile-content.content-z-index {
            position: absolute;
        }

.animation-off .surface-laptop-family .wdg-device-highlight-tile .wdg-device-highlight-tile-content .wdg-device-content .c-heading-2 {
            font-size: 34px;
            line-height: 44px;
            padding: 0;
        }

.animation-off .surface-laptop-family .wdg-device-highlight-tile .wdg-device-highlight-tile-content .wdg-device-content .c-paragraph-2 {
            font-size: 18px;
            line-height: 28px;
            padding: 20px 0 0 0;
        }

.animation-off .surface-laptop-family .wdg-device-highlight-tile .wdg-device-highlight-tile-content .wdg-device-content .c-call-to-action {
            margin-top: 0;
        }

.animation-off .surface-laptop-family .wdg-device-highlight-tile .wdg-device-highlight-tile-content .wdg-device-specs-grid {
            padding: 30px 0 0 0;
        }

.animation-off .surface-laptop-family .wdg-device-highlight-tile .wdg-device-highlight-tile-content .wdg-device-specs-grid .wdg-device-specs-flex .wdg-device-category-content {
                opacity: 1;
                padding: 11px;
            }

.animation-off .surface-laptop-family .wdg-device-highlight-tile .wdg-device-highlight-tile-content .wdg-device-specs-grid .wdg-device-specs-flex .wdg-device-category-content .wdg-device-spec-content {
                    padding: 28px 28px 22px 28px;
                }

.animation-off .surface-laptop-family .wdg-device-highlight-tile .wdg-device-highlight-tile-content .wdg-device-specs-grid .wdg-device-specs-flex .wdg-device-category-content .wdg-device-spec-content .c-paragraph-2 {
                        font-size: 20px;
                        line-height: 30px;
                        padding: 20px 0 0 0;
                    }

.animation-off .surface-laptop-family .wdg-device-highlight-tile .wdg-device-highlight-tile-content .wdg-device-specs-grid .wdg-device-model {
                padding: 22px 0;
                top: 42px;
            }

.animation-off .surface-laptop-family .wdg-device-highlight-tile .wdg-device-highlight-tile-content .wdg-device-specs-grid .wdg-device-model.foldIn {
                    -webkit-animation: none;
                    animation: none;
                    width: 95%;
                }

.animation-off .surface-laptop-family .wdg-device-highlight-tile .wdg-device-highlight-tile-content .wdg-device-specs-grid .wdg-device-model .modal-content .c-paragraph-2 {
                    padding: 28px 5px 0 0;
                }

.animation-off .surface-laptop-family .wdg-lifestyle-video .lifestyle-video.margin-top {
        top: 0;
    }

/*animation off toggle end*/

/*Custom css for userstorys*/
@media only screen and (max-width:539px){
    .surface-laptop-family .surface-lf-userstory{
        padding-top: 55px;
    }
   .surface-laptop-family .lf-userstory-4{
       padding-bottom: 56px;
   }
    .surface-laptop-family .surface-lf-userstory .m-feature div > .c-paragraph-4{
        padding-bottom: 15px;
   }
   .surface-laptop-family .surface-lf-innovation .m-banner .c-heading-1{
    padding-top: 48px;
    padding-bottom: 16px;
     font-size: 34px;
    line-height: 40px;
}
 .surface-laptop-family .m-banner.surface-lf-banner{
       padding-left: 5%;
   }
   .surface-laptop-family .surface-lf-userstory .m-feature div > .c-heading-3{
  font-size: 20px;
  line-height: 24px;
}
}
   @media screen and (min-width: 540px) and (max-width: 767px){
       .surface-laptop-family .surface-lf-userstory{
        padding-top: 55px;
    }
   .surface-laptop-family .lf-userstory-4{
       padding-bottom: 56px;
   }
    .surface-laptop-family .surface-lf-userstory .m-feature div > .c-paragraph-4{
        padding-bottom: 15px;
   }
   .surface-laptop-family .surface-lf-innovation .m-banner .c-heading-1{
    padding-top: 48px;
    padding-bottom: 16px;
     font-size: 34px;
    line-height: 40px;
}
 .surface-laptop-family .m-banner.surface-lf-banner{
       padding-left: 5%;
   }
   .surface-laptop-family .surface-lf-userstory .m-feature div > .c-heading-3{
  font-size: 20px;
  line-height: 24px;
}
        }
    @media screen and (min-width: 768px) and (max-width: 1083px){
        .surface-laptop-family .surface-lf-userstory{
         padding-top: 48px;
      }
       .surface-laptop-family .lf-userstory-4{
       padding-bottom: 48px;
   }
   .surface-laptop-family .m-banner.surface-lf-banner{
       padding-left: 5%;
   }
   .surface-laptop-family .surface-lf-userstory .m-feature div > .c-paragraph-4{
        padding-top: 12px;
   }
   .surface-laptop-family .surface-lf-innovation .m-banner .c-heading-1{
    padding-top: 18px;
    font-size: 46px;
    line-height: 56px;
}
.surface-laptop-family .m-banner.surface-lf-banner p.c-paragraph-3{
    padding: 19px 0px 11px 0px;
}
.surface-laptop-family .surface-lf-userstory .m-feature div > .c-heading-3{
  font-size: 20px;
  line-height: 24px;
}
  }
   @media screen and (min-width: 1084px){
       .surface-laptop-family .lf-userstory-4{
       padding-bottom: 48px;
   }
   }
  
@media print {
 .print .recommended{width:1084px !important;}

 .Chrome .print .recommended .m-hero-item.f-y-center>div>div{display: block;top: 0; transform: none;} 
 .Chrome .print .recommended .m-hero-item.f-y-center {position: relative; top: -250px;}
 .Chrome .print .recommended .m-hero-item.f-y-center div{ top: -150px;}
 .Chrome .print .recommended .m-hero-item{overflow: visible;}
 .Chrome .print .recommended section {height:300px;}
 .Chrome .print .recommended .m-hero-item picture{top: 200px;}

 .print .recommended .m-hero-item.f-y-center{height:850px}
  .no-print#headerArea,.no-print#footerArea,.no-print.surface-social-share,.no-print.surface-hmc-business,.no-print.surface-hmc-business-logo,.print a.c-glyph,[data-vg='H18-surface-HMC-Not-sure-Banner_VG']{
    display:none !important;
  }
  .print .hmc-remodel-li ul{
    padding-top:18px !important;
  }
  /*.print.results{width:1366px !important;}*/
  .print .hmc-accessories picture img{width:100%!important;}
  .print+.surface-section-footnotes {
    -webkit-print-color-adjust: exact !important;
    background-color: #2F2F2F !important;
    color: white !important;
    padding-top: 20px !important;
    padding-bottom: 20px !important;
    
}
.print .recommended [class*='device-']{
  padding-top: 32px !important;
  padding-bottom: 32px !important;
}
.print .interested{
  page-break-inside: avoid !important;
  page-break-after: always !important;
}
.print .m-multi-feature>section>div,.print .m-feature>*{width:50% !important;}
.print .m-feature.f-align-left>div,.print .m-feature.f-align-right>div {
    padding-left: 36px !important;
    padding-right: 36px !important;
    padding-bottom: 0 !important;
    position: absolute !important;
    top: calc(50%) !important;   
    left:50% !important;
    -ms-transform: translateY(-50%) !important;
    transform: translateY(-50%) !important;
    width: 50% !important;
    text-align: left !important;
}
.print .m-multi-feature.f-align-left>section{
  display: flex !important;
  flex-direction: row !important;
}
.print .m-multi-feature.f-align-left>section>div{
  padding-left:36px !important;
  padding-right:36px !important;  
  text-align: left !important;
}
.print .c-heading-1{
  font-size: 41.33px !important;
}
.print .c-heading-2{
  font-size: 22.66px !important;  
}
.print .c-subheading-2{
  font-size: 13.33px !important;
  padding-top:26px !important;
}
.print .c-heading-3{
  font-size:22.66px !important;
}
.print .c-heading-4{
  font-size:16px !important;
}
.print .c-paragraph-3{
  font-size:10px !important;
}
.print .m-multi-feature.f-align-left>section>div:first{
  order:2 !important;
  -webkit-box-ordinal-group: 3 !important;
}
.print .m-multi-feature.f-align-left>section>div.c-carousel{
  order:1 !important;
  padding-left:0 !important;
  padding-right:0 !important;
}
}
@page{
  size:landscape;
  }
@media print and (orientation: landscape){  
  .print+.surface-section-footnotes,.print .hmc-shop-for-biz {
    page-break-before: always !important;
  }
}

@media print and (orientation: portrait) {
  .print .acc-item .surface-swatch-colors{
   width: 100% !important;
    display: inline-block !important;
  }
  .print .acc-item .surface-multiview-trigger{
    color:#fff !important;
    background-color: #fff !important;
    display: inline-block !important;
    width: 16% !important;
    
  }
  .print+.surface-section-footnotes {
   margin-top:30px !important;
   page-break-before: always !important;   
  }
  .print [data-vg='H18-Surface-HMC-Results-Accessories_VG'],.print .recommended{
     page-break-after: always !important;
  }
  .print .hmc-shop-for-biz{
    page-break-before: always !important;    
  }
  .print .acc-item .surface-swatch-colors .surface-multiview-trigger>span {
   visibility:hidden !important;
 }
 .print .acc-item .accessories-tout-images{
   border:none !important;
   padding:0 !important;
   width:80% !important;
   display:inline-block !important;
 }
    .print .interested .c-heading-3 {
        padding-bottom:15px !important;
        padding-top:24px !important;
    }
    .print .interested .hmc-remodel-li{
       padding-top:5px !important;
    }
    .print .m-hero-item>div>div{
      max-width:45% !important;
    }
    .print .m-hero-item.f-transparent-LV5-padtop66::before,.print .m-hero-item.f-transparent-V5-padtop45::before {
        padding-bottom: 66% !important;
     }
}
.zh-cn .surface-hmc-ans-block .c-radio label.c-label span,.zh-hk .surface-hmc-ans-block .c-radio label.c-label span,.zh-tw .surface-hmc-ans-block .c-radio label.c-label span,.ja-jp .surface-hmc-ans-block .c-radio label.c-label span{word-break: break-word;}
/*.surface-hmc-resultsPanel .c-badge+[class*='c-heading'],.surface-hmc-resultsPanel .c-badge+[class*='c-heading']+[class*='c-heading']{
    padding-top: 10px;
}*/

/*=====================================HMC REDESIGN CSS============================*/
/*
    *****

    ******

    *******

*/
/*.design-18{
  visibility:hidden;
}*/
.design-18 .questions-panel .surface-hmc-qa-block-item .option-block {
  width: 20%;
  display: inline-block;
  margin-right: 0;
  float: none;
  padding:0 12px;
  vertical-align: top; }

.design-18 .questions-panel .option-block img.f-round {
  max-width: 240px; 
  width:100%;
  height:auto;
  margin: 10px 0;
  border-radius: 70px;
  display: block;
  cursor: pointer !important; 
  }

.design-18 .questions-panel .answer-group {
  margin: 2.125vw auto 0;
  float: none;
  }

.design-18 .hmc-buttons {
  display: inline-block;
  position: relative;
  margin-bottom: 72px;  
  overflow: hidden; 
  margin-top: 66px;
  min-width:142px;
}

.design-18 .surface-hmc-qa-block-item {
  float: none;
  display: none;
  background: #fff;
  padding-top: 3.75vw;  
}

.design-18 .surface-hmc-qa-block-item.visited-item {
  display: none;
}

.design-18 .surface-hmc-qa-block-item.active-item {
  transition: all 1s ease-in;
  height: auto;
  display: block;
}


.design-18 section.questions-panel {
  position: relative;
  text-align: center;
}

.design-18 .questpan-visible-container {
  overflow-y: hidden;
}

.design-18 .hmc-progress-container {
  position: absolute;
  top: 50%;
  padding-left: 20px;
  transform: translateY(-50%);
  max-width: 200px;
  text-align: left;
  }

.design-18 .surface-hmc-qa-block-item .c-checkbox input[type=checkbox] + span:after, .design-18 .surface-hmc-qa-block-item .c-checkbox input[type=checkbox] + span:before,.design-18 .surface-hmc-qa-block-item .c-checkbox input[type=radio] + span:after, .design-18 .surface-hmc-qa-block-item .c-checkbox input[type=radio] + span:before {
  height: 36px;
  width: 36px;
}

.design-18 .surface-hmc-qa-block-item .c-checkbox input[type=checkbox]:checked + span:after {
  background-color: #0078d4;
  padding-top: 8px;
}

.design-18 .surface-hmc-qa-block-item .option-block .c-label input + span {
  display: inline;
  pointer-events: auto;
}

.design-18 .surface-hmc-qa-block-item .option-block .c-label input + span + span {
  margin-top: 13px;
  margin-bottom: 0px;
  display: block;
}

.design-18 .surface-hmc-qa-block-item .c-label input[type='radio'] + span:before {
  transform: translateX(-50%);  
  width: 36px;
  height: 36px;
  left: 50%; 
}

.design-18 .surface-hmc-qa-block-item [data-type='radio'] .c-label {
  margin-right: 0;
}

.design-18 .surface-hmc-qa-block-item label.c-label {
  pointer-events: none;  
}

.design-18 .surface-hmc-qa-block-item .c-label input[type='radio'] + span:after {
  transform: translateX(-50%);
  top: 5px;
  left: 50%;
  width: 26px;
  height: 26px;
}

.design-18 .hmc-progress-container .c-label span {
  padding-top: 0;
  color: #959595;
}

.design-18 .hmc-progress-container .c-label.active input[type=radio] + span {
  text-decoration: underline;
  color: #0078d4;
}

.design-18 .interested {
  overflow: hidden;
  padding-bottom: 80px;
  }

.design-18 .hmc-feature-text ul, .results .m-hero-item {
  padding-top: 25px;
}

.design-18 .hmc-progress-container .c-label input + span:before {
  border-color: #959595;
  top: 3px;
}

.design-18 .hmc-progress-container .c-label.visited span:before {
  background-color: #0078d4;
  border: none; }

.design-18 .hmc-progress-container .c-label.active input[type=radio] + span:before {
  border: 3px solid #0078d4; }

.design-18 .pre-result-screen fieldset {
  max-width: 50%;
  margin: 20px auto;
  text-align: center; }

.design-18 .pre-result-screen label.c-label {
  display: block; }

.design-18 .pre-result-screen fieldset > div {
  padding-left: 25%;
  text-align: left; }

.design-18 .pre-result-screen label.c-label span:before {
  top: 10px; }

.design-18 .pre-result-screen .c-label.visited span:before,.design-18 .pre-result-screen .c-label.active span:before {
  background-color: #005da6;
  border: none;   
  }

.design-18 .pre-result-screen .c-label.active span {
  font-weight: bold; }

.design-18 [class*='device-'] ul {
  list-style-type: disc;
  padding-left: 25px; }

.design-18 .start-questions {
  margin-left: auto;
  margin-right: auto; }

.design-18 .hmc-custom-hero {
  /*background: linear-gradient(#EEEEEE, #FFFFFF);*/
  background: #fff;
  text-align: center;
  padding-top: 2.9vw; }

.design-18 .hmc-custom-hero .c-group {
  display: inline-block;
  margin-top: 26px;
  margin-bottom: 62px;
  min-width:64px;
  
}
  
  .design-18 .hmc-custom-hero .c-heading-2{font-weight:600;}
  .design-18 .hmc-custom-hero .c-subheading-2{padding-bottom:0;}

.design-18 .start-questions.c-glyph.glyph-chevron-down:before, .design-18 .next.c-glyph.glyph-chevron-down:before
,.design-18 .back.c-glyph.glyph-chevron-up:before {
  display: none; }
.design-18 .start-questions.c-glyph.glyph-chevron-down, .design-18 .next.c-glyph.glyph-chevron-down,.design-18 .back.c-glyph.glyph-chevron-up{
  min-width:0;
  padding:0 !important;
  margin:22px 20px 11px 12px;  
}
.design-18 .start-questions.c-glyph.glyph-chevron-down,.design-18 .next.c-glyph.glyph-chevron-down,.design-18 .back.c-glyph.glyph-chevron-up{margin:12px;}
.design-18 .start-questions.c-glyph.glyph-chevron-down:focus, .design-18 .next.c-glyph.glyph-chevron-down:focus,
.design-18 .start-questions.c-glyph.glyph-chevron-down:focus:after, .design-18 .next.c-glyph.glyph-chevron-down:focus:after,
.design-18 .back.c-glyph.glyph-chevron-up:focus,.design-18 .back.c-glyph.glyph-chevron-up:focus:after
{
  outline: 2px dashed #000;
}

.design-18 .start-questions.c-glyph.glyph-chevron-down:after, .design-18 .next.c-glyph.glyph-chevron-down:after {
  font-family: "MWF-MDL2";
  content: "\E70D";
  padding: 22px;
  color: white;
  background-color: #0078d4;
  border-radius: 50%;
  top: 52px;
  font-size: 16px;
  left: 12px;
  position: absolute;
  transform: translateX(-17%);
  z-index: 2; 
  }
  .design-18 .start-questions.c-glyph.glyph-chevron-down:after{
    top: 42px;
  }
 .design-18 .next.c-glyph.glyph-chevron-down:after{
   top:42px;
   left: 50%;  
   transform: translateX(-50%);
 }
 .design-18 .back.c-glyph.glyph-chevron-up:after{
   font-family: "MWF-MDL2";
  content: "\E70E";
  padding: 22px;
  color: white;
  background-color: #0078d4;
  border-radius: 50%;
  top: 42px;
  font-size: 16px;
  left: 50%;
  position: absolute;
  transform: translateX(-50%);
  z-index: 2;
 } 
 .design-18 .c-glyph.glyph-download:hover{
    text-decoration: underline !important;
  }
.design-18 .c-glyph.glyph-download:before{
  /*font-family: "MWF-MDL2";*/
  content:"\E749";
}
.design-18 .next:disabled.c-glyph.glyph-chevron-down:after {
  color: #fff;
  background-color: #d2d2d2; }

.design-18 .hmc-progress-container label.c-label {
  margin-bottom: 20px; }

.design-18 .surface-hmc-ans-block legend[class*='c-heading'] + .surface-hmc-instr {
  margin-top: 0.125vw;
  }

.design-18 .surface-hmc-instr, .design-18 .start-questions, 
:not(.en-us) .design-18 .next,.design-18 .back,.design-18 .start-over,
:not(.en-gb) .design-18 .next,.design-18 .back,.design-18 .start-over,
:not(.en-au) .design-18 .next,.design-18 .back,.design-18 .start-over,
:not(.en-sg) .design-18 .next,.design-18 .back,.design-18 .start-over,
:not(.en-ca) .design-18 .next,.design-18 .back,.design-18 .start-over {
  text-transform: uppercase; }

.design-18 .hmc-accessories {
  padding-bottom: 60px;
  padding-top: 84px;
  overflow-x: hidden; }

.design-18 .hmc-remodel .m-hero-item .c-heading-2 {
  padding-top: 0px;
  padding-bottom: 10px;
  margin-top: 0px; }

.design-18 .m-hero-item .hmc-remodel-li {
  padding-top: 30px;
  padding-bottom: 0px; }

.design-18 .hmc-remodel .m-hero-item .c-price,  .design-18 .hmc-book .m-hero-item .c-price{
  margin-top: 0px !important; }

.design-18 .hmc-remodel .c-call-to-action.surface-secondary-cta.c-glyph {
  margin-top: 18px; }

.design-18 .hmc-remodel .hmc-glyph {
  margin-top: 15px;
  padding-left: 0px; }

.design-18 .hmc-remodel a.mscom-link:focus {
  outline: 1px solid #000 !important; }

.design-18 .surface-hmc-tip {
  float: none;
  margin-left: auto;
  margin-right: auto; 
  margin-top:1.6vw;
  }

.design-18 .surface-section-footnotes {
  margin-top: 0px; }

.design-18 .hmc-text-progress {
  display: none; }

.design-18 .results{
  transition: all 1s linear;
}
.design-18 .surface-hmc-ans-block > fieldset > legend {
  display: inline-block;
  width: 100%;
  text-align: center; }

/*.design-18 .recommended .c-price > span:first-child, .design-18 .interested .c-price > span:first-child {
  width: 100%; }*/
  
.design-18 .price.c-subheading-2.c-price .s2{
  padding-left: 10px;
} 

.design-18 [data-vg='H18-Surface-HMC-Accessories-Header_VG'] {
  margin-bottom: 84px; }

.design-18 [data-vg='H18-Surface-HMC-Accessories-Header_VG'] .m-banner, .design-18 [data-vg='H18-Surface-HMC-InterestedPanel-Header_VG'] .m-banner {
  margin-left: 0;
  text-align: left; }

.design-18 .hmc-custom-hero picture img {
  width: 100%; }

.design-18 .pre-result-screen label.c-label span {
  color: #2f2f2f !important;
  font-weight: 300; }

.design-18 .pre-result-screen label.c-label.active span {
  font-weight: 700; 
}

.design-18 section.questions-panel button.next,.design-18 section.questions-panel button.back {
  padding-bottom: 80px; 
  text-decoration: none !important;
  vertical-align: top;
  }
.design-18 .hmc-custom-hero .start-questions{
  text-decoration: none !important;
}
.design-18 .results a.c-call-to-action.c-glyph.surface-bg-cta-blue:after {
  margin-top: 5px; }


@media screen and (min-width: 1084px) {
  /*.design-18 .surface-multifeature-pivot .hmc-feature-text {
    width: 100% !important; }

   .design-18 .surface-multifeature-pivot .hmc-feature-pic {
    width: 50% !important; }*/
    
.design-18 .surface-hmc-ans-block > fieldset > legend {
    padding-top: 30px;
    }
    
    /*.design-18 .surface-hero-pivot-multi-img .c-pivot ul li{
      margin-right:8px;
      margin-left:8px;
    }*/
 /*.design-18 .recommended .device-1 .m-hero-item.f-transparent-LV5-padtop66:before {
        padding-bottom: 41.5%;
}*/

 }

@media screen and (max-width: 1083px) {
  .design-18 .questions-panel .surface-hmc-qa-block-item .option-block {
    width: 33.33%;
    max-width: 225px; 
    padding-bottom: 20px;
    }

  .design-18 .results .m-hero-item .hmc-remodel-li {    
    justify-content: center;
    display: flex;
    text-align: left;
}
.design-18 .results .surface-hero-pivot-multi-img .m-hero-item div>div>ul,.design-18 .m-multi-feature .hmc-feature-text ul,.m-feature div ul{
  display: inline-block;  
  text-align: left;
}
.design-18 .results .m-hero-item .c-price{width:auto;display:inline-block;}

 .design-18 .hmc-progress-container {
    display: none; }

    
.design-18 .hmc-text-progress {
    display: block;
    position: absolute;
    left: 50%;
    transform: translateX(-50%);
    top: 1.8vw;
    padding-top:3.1vw;
     }
  
   }
  
  

@media screen and (max-width: 539px) {
  .design-18 .questions-panel .surface-hmc-qa-block-item .option-block {
    width: 50%;
    padding-bottom: 20px;   
    }
  .design-18 .interested .m-feature .c-price{
    /*display: inline-block;*/
    display:block;
  }  
  .msw-page[class*='en-'] .design-18 .interested .m-feature .c-price span{
    width:100%;
    text-align: center;
  }
  .msw-page:not([class*='en-']):not([class*='zh-']) .design-18 .interested .m-feature .c-price {
   display: inline-block !important;
  }
  .zh-cn .design-18 .interested .m-feature .c-price{    
    width: 100%;
  }
  .zh-cn .design-18 .interested .m-feature .c-price span{
    width:100%;
    text-align: center;
    display: contents;
  }
}

/*Result Section*/
.design-18 .pre-result-screen .c-label .c-heading-4 {
  padding-top: 8px; }

.design-18 .pre-result-screen .c-radio input[type=radio] + span {
  margin-left: 46px; }

.design-18 .pre-result-screen .c-radio input[type=radio] + span:before {
  width: 27px;
  height: 27px; }

@media screen and (min-width: 1084px) {
  /*Result section*/
  .design-18 .pre-result-screen .c-heading-2 {
    padding-bottom: 40px; }

    .design-18 .pre-result-screen {
    margin-bottom: 80px; }

  /*Questions section*/ 
  .design-18 .hmc-custom-hero .c-heading-1 {
    padding-top: 18px; }
 }

@media screen and (max-width: 1083px) and (min-width: 540px) {
  /*Result section*/
  .design-18 .pre-result-screen fieldset {
    max-width: none; }

  .design-18 .pre-result-screen fieldset > div {
    margin-left: 8%;
    margin-right: 8%; }

  .design-18 .pre-result-screen .c-heading-2 {
    padding-bottom: 40px; }

  .design-18 .pre-result-screen {
    margin-bottom: 60px; }
  
  .design-18 .hmc-custom-hero .m-image{
    padding-top: 6.1vw; }

  .design-18 .hmc-custom-hero .c-group {
    margin-top: 13px;
    margin-bottom: 32px; }

 .design-18 .hmc-text-progress {
    top: -2%; }

  .design-18 .surface-hmc-ans-block > fieldset > legend {
    padding-top: 6vw; }

  .design-18 .surface-hmc-ans-block legend[class*='c-heading'] + .surface-hmc-instr {
    margin-top: 0;
    padding-top: 20px; }

  .design-18 .questions-panel .answer-group {
    margin-top: 18px; }

  .design-18 .hmc-buttons {
    margin-top: 47px;
    margin-bottom: 50px; }
    
    .design-18 .recommended .pricecurrnecy{clear:both;}
    .design-18 .surface-hmc-qa-block-item label.c-label{
      margin-top:13px;
      max-width:100%;
    }
    .design-18 .surface-hmc-qa-block-item .option-block .c-label input + span + span{margin-top:2px;}

 }

@media screen and (max-width: 539px) {
  /*Result section*/
  .design-18 .pre-result-screen fieldset {
    max-width: none;
    margin: 20px; }

  .design-18 .pre-result-screen .c-label .c-heading-4 {
    font-size: 18px;
    padding-top: 7px; }

  .design-18 .pre-result-screen {
    margin-bottom: 70px; }

  .design-18 .pre-result-screen .c-heading-2 {
    padding-bottom: 10px; }

  /*Questions section*/
  .design-18 .hmc-custom-hero {
    padding-top: 0; }

  .design-18 .hmc-custom-hero .c-group {
        margin-top: 0;
    margin-bottom: 57px;
}

  .design-18 .hmc-text-progress {
    top: 1%;
    padding-top:0px;
  }

  .design-18 .surface-hmc-ans-block legend[class*='c-heading'] + .surface-hmc-instr {
    margin-top: 2px; }

  .design-18 .questions-panel .answer-group {
    margin-top: 20px; }

  .design-18 .answer-group .option-block .c-label .c-heading-5 {
    padding-top: 20px; }

  .design-18 .answer-group .option-block .c-label {
    margin-top: 11px; }

  .design-18 .hmc-buttons {
    margin-top: 27px;
    margin-bottom: 100px; }
 }

@media screen and (max-width: 1083px) {
  .design-18 .surface-hmc-instr {
    font-size: 18px;
    line-height: 24px; }
 }

/*Question Section*/
.design-18 .hmc-progress-container .c-radio input[type=radio] + span:before {
  width: 27px;
  height: 27px; }

.design-18 .hmc-progress-container .c-radio input[type=radio] + span {
  margin-left: 40px;
  padding-top: 3px;
  padding-bottom: 2px; }
  
.design-18 .option-block a{pointer-events: auto;}
.design-18 .results .m-hero-item a.c-call-to-action.c-glyph.surface-bg-cta-blue:focus:not(.x-hidden-focus){
  background-color: #006cc2;
}
.design-18 .acc-item .surface-swatch-colors .surface-multiview-trigger>span{
	border-color:#fff !important;
}
.design-18 .results .surface-secondary-cta{
  background-color:transparent !important;
}
.design-18 .acc-item{
  padding:0 10px;
}
.design-18 .acc-item picture>img{
  width:100%;
  margin-bottom: -1px;
}
.design-18 a.c-hyperlink.supBLink{display:inline;}
@media screen and (min-width: 768px) and (max-width: 790px){
.design-18 .acc-item .surface-swatch-colors .surface-multiview-trigger>span{
	border:none !important;
}
.design-18 .hmc-accessories .surface-swatch-colors a.surface-multiview-trigger{
  margin: 0px 2px;
}
}
.design-18 .hmc-span .c-price.f-large span{
  float: none !important;
}

.design-18 .hmc-pro .c-group, .design-18 .hmc-P .c-group{
display:block;
}
.design-18 .hmc-book .m-hero-item{
padding-top:0px !important;
padding-left: 0px;
}
.design-18 .hmc-span .link-book{
  padding-bottom: 30px !important;
}
/*.design-18 .results .glyph-share,.results .glyph-download{display: none;}*/


.design-18 .recommended .hmc-results{
    padding-top:26px;
    
}

.design-18 .recommended .hmc-results .m-banner .c-subheading-2{
    padding-top: 38px; 
}

.design-18 .surface-laptop-pivots .swatch-color {
    margin-top: 38px !important;
}

.design-18 .recommended .m-hero-item .c-pivot ul {
    padding-left:0;
}

.design-18 .recommended .m-hero-item button.c-action-trigger.c-glyph:before, .design-18 .recommended .m-hero-item a.c-action-trigger.c-glyph:before {
    margin-left: 0;
}

.design-18 .results .interested .hmc-results .m-banner {
    padding-bottom: 0px;
    border-top: 1px solid rgba(0,0,0,.2);
    padding-top: 64px;
    max-width: 100%;
}

/*.design-18 .interested .hmc-span .link-book h2.c-heading-3 {
    padding-bottom: 50px;
}*/

/*.design-18 .interested .hmc-span .m-feature ul {
    padding-bottom: 30px;
}*/

.design-18 .interested .hmc-span .m-feature .c-price.f-large {
    padding-bottom: 14px;
}

.design-18 .interested .hmc-span .m-feature .link-book a.mscom-link.c-call-to-action.surface-secondary-cta.c-glyph {
    margin-top: 22px;
}

.design-18 .surface-banner-divider.bannerimage {
    padding-top: 56px;
}

.design-18 .surface-banner-divider.bannerimage .m-banner h2 {
    padding-top: 46px;
}

.design-18 .surface-banner-divider.bannerimage .m-banner {
    padding-bottom: 50px;
}

.design-18 .results .m-banner.wdg-mar-pad-x-reset.wdg-grey-banner {
    padding-top: 77px;
}
.design-18 .hmc-remodel-li li{line-height: 1.5;}
.Firefox .design-18 .hmc-buttons .next.c-glyph.glyph-chevron-down:after,.Firefox .design-18 .hmc-buttons .back.c-glyph.glyph-chevron-up:after{
  position: static;
  display: block;
  margin-top: 20px;
  transform: none;
}

.Firefox .design-18 .hmc-buttons .next.c-glyph.glyph-chevron-down,.Firefox .design-18 .hmc-buttons .back.c-glyph.glyph-chevron-up{
overflow: visible;
}
.design-18 .hmc-results em{
  font-style: inherit;
}

.design-18 .c-price .c-subheading-2{
  display: none!important;
}

.design-18 .m-multi-feature a.c-call-to-action.c-glyph.surface-bg-cta-blue, .design-18 .m-hero-item a.c-call-to-action.c-glyph.surface-bg-cta-blue{
  margin-right: 24px;
    margin-top: 0px;
}

.design-18 .m-hero-item a.c-call-to-action.c-glyph.surface-secondary-cta{
  margin-left: 0;
}

.design-18 .interested li em, .recommended li em{
  font-style: inherit;
}

.design-18 .hmc-results .c-subheading-2,.recommended .hmc-remodel-li,.design-18 .interested .hmc-remodel-li{font-size: 20px;}
.design-18 .results hr.c-divider{margin:1px 0;}

.design-18 .m-banner.border_top_live{
      border-top: 1px solid rgba(0,0,0,.2);
      max-width: 100%;
      padding-top: 36px!important;
}

.design-18 .recommended .c-price{
  padding-bottom: 5px;
}


.design-18 .interested .c-group a.c-call-to-action.c-glyph.surface-bg-cta-blue{
  margin-bottom: 0px;
}

/*.design-18 .interested .device-0 .c-group{
  display: block;
}*/

.design-18 .interested .m-feature .c-heading-3, .design-18 .interested .m-feature .c-subheading-2
{
  padding-left: 20px;
}

.design-18 .interested .m-feature .c-heading-3{
  padding-bottom: 40px;
}

@media screen and (min-width: 768px) {
  .design-18 .interested .m-multi-feature .c-price, .design-18 .interested .m-multi-feature .c-group,.interested .m-feature .c-price, .design-18 .interested .m-feature .c-group{
  padding-left: 20px;
}
}

@media screen and (min-width: 1084px) {
  
   /*.design-18 .recommended .c-price{
    padding-bottom: 30px;
  }*/
  
 /*.design-18 .interested h3.c-subheading-2{
   padding-left: 22px;
 }*/
 
 .design-18 .interested h2.c-subheading-3{
   padding-left: 22px;
 }
 
 /*.design-18 .recommended .m-hero-item.f-transparent-LV5-padtop66:before {
        padding-bottom: 52%;
}*/

/*.design-18 .recommended .surface-multifeature-pivot {
  padding-top: 90px;
  padding-bottom: 90px;
}*/
.design-18 .interested [class*='device-']{
  padding-top: 110px;
  padding-bottom: 90px;
}

/*.de-de .design-18 .interested [class*='device-7']{
  padding-bottom: 100px;
}*/

.design-18 .interested .surface-multifeature-pivot{
  padding-top: 30px;
}

.design-18 .interested .m-multi-feature .c-price, .design-18 .interested .m-multi-feature .c-group,.design-18 .interested .m-feature .c-price, .design-18 .interested .m-feature .c-group{
  padding-left: 20px;
}

.design-18 .interested [class*='device-']:not(.surface-multifeature-pivot) .link-book .c-heading-3,
.design-18 .interested [class*='device-']:not(.surface-multifeature-pivot) .link-book .c-subheading-2{
  padding-left: 20px;
}
}

.design-18 .hmc-buttons button.start-over.c-button{
	display:block;
  margin: 34px auto 0px;  
}

@media screen and (max-width:1083px){
  
  
  .design-18 .recommended{
    padding-bottom: 60px;
  }
  
  .design-18 .surface-hero-pivot-multi-img .c-pivot ul li{
    margin-right: 8px!important;
    margin-left: 8px!important;
  }
  
  .design-18 .hmc-buttons .start-over{
  margin-left: auto!important;
  margin-right: auto;
}

.design-18 .see-result+.start-over{
  margin-top: 18px;
} 
.design-18 .see-result.x-hidden+.start-over{
  margin-top: 25px;
}  
.design-18 .hmc-buttons .start-over {
    display: block;
    
    font-weight: 600;
    text-transform: uppercase;
}

.design-18 .see-results:visible+.start-over{
  margin-top:36px;
}
html:not(.Firefox) .design-18 .hmc-buttons .next.c-glyph.glyph-chevron-down.started:after,.design-18 .hmc-buttons .next.c-glyph.glyph-chevron-down:after{
	left:50%;
  transform:translateX(-50%);
}

} 
@media screen  and (min-width: 1084px)
{
.design-18 .hmc-custom-hero
{
color:#000000;
}
}

/*.design-18 .hmc-custom-hero .c-subheading-2{
  color: #2f2f2f;
}
*/
.design-18 .hmc-custom-hero .c-group .f-lightweight{
  color: #0078D4;
}

.design-18 .hmc-custom-hero .c-group .start-questions.c-glyph.glyph-chevron-down::after, .design-18 .next.c-glyph.glyph-chevron-down::after{
  background-color: #0078D4;
}

.design-18 .hmc-progress-container .c-radio input[type=radio]+span{
  color: #959595;
}

.design-18 legend + .surface-hmc-tip{
  padding-top: 18px;
}

.design-18 .hmc-buttons .see-result{
  /*margin-top: 50px;*/
  margin-bottom: 33px; 
}

.design-18 section[data-vg="H18-surface-HMC-Not-sure-Banner_VG"] .Compare_banner{
  margin-bottom: 85px;
  margin-top: 20px;
}

.design-18 .interested .swatch-color{
  padding-top: 20px;
}

.design-18 .interested .surface-acc-pdp-m-hero .c-price,
.design-18 .interested .surface-acc-pdp-m-hero .sur-devc-availbty,
.design-18 .interested .surface-acc-pdp-m-hero .sur-bundle-availbty{
  padding-bottom: 20px;
  padding-top: 16px;
}

.design-18 .hmc-accessories .surface-swatch-colors{
  justify-content: center;
}

.design-18 .recommended .c-price{
  padding-top: 10px;
}

.design-18 .firefox_hide{
  display: none;
}

.Firefox .design-18 .firefox_hide{
  /*display: block;*/
  height: 20px;
width: 100%;
background:transparent;
position: absolute;
top: 27px;
}
.Firefox .design-18 .see-result:not(.x-hidden)+.firefox_hide{
  top:112px;
}


/*.design-18 .recommended .surface-pivot-hero-mob-margin .c-price{
  padding-top: 0;
}*/

/*.design-18 .recommended .surface-hth-mob-margin .c-price{
  padding-bottom: 20px;
}*/

.design-18 .recommended .surface-hth-mob-margin .c-price{
  padding-top: 26px;
  padding-bottom: 16px;
}

.design-18 .interested [class*='device-']:not(.surface-multifeature-pivot) .c-price{
  padding-top: 30px;
  padding-bottom: 20px;
}

.design-18 [class*='device-']:not(.surface-multifeature-pivot) .sur-devc-availbty,
.design-18 [class*='device-']:not(.surface-multifeature-pivot) .sur-bundle-availbty{
  padding-top: 20px;
}

.design-18 .recommended .surface-laptop-pivots.padding_nonpivot .c-price{
  padding-top: 30px;  
}

.design-18 .pre-result-screen legend{
  width: 100%;
}

@media screen and (min-width: 540px) and (max-width: 767px){
   .design-18 .interested .c-price{
    display: flex;
    justify-content: center;
  }
}

@media screen and (min-width: 540px) and (max-width: 1083px){
  
 
  
  .design-18 .hmc-custom-hero{
    padding-top: 20px;
  }
  
  .design-18 .surface-section-footnotes{
    margin-top: 0px;
  }
  
  .design-18 .see-result.x-hidden+.start-over{
    margin-top: 25px;
  }
  
  .design-18 .hmc-buttons .see-result{
  margin-bottom:  22px; 
}
.design-18 legend+.surface-hmc-tip{
  padding-top: 0;
}

.design-18 legend+.surface-hmc-tip + .surface-hmc-instr{
  padding-top: 20px;
}

}

@media screen and (max-width:539px) {

    .design-18 .hmc-custom-hero .m-image {
        padding-top: 28px;
    }

    .design-18 .hmc-text-progress {
        padding-top: 30px;
    }

    .design-18 .questpan-visible-container .surface-hmc-qa-block-item {
        padding-top: 45px;
    }

    .design-18 .surface-hmc-qa-block-item .surface-hmc-ans-block .c-heading-4 {
        padding-top: 15px;
    }

    .design-18 .surface-hmc-qa-block-item .surface-hmc-ans-block .option-block .c-heading-4 {
        padding-top: 20px;
    }

    .design-18 .surface-section-footnotes {
        margin-top: 0px;
    }

    .design-18 .see-result.x-hidden + .start-over {
        margin-top: 25px;
    }
}
  
 
.design-18 .hmc-buttons .next.x-hidden~.f-lightweight.back{
  margin-top:0px;
}
.design-18 .back+.see-results{
  margin-top:36px;
}
@media screen and (min-width:1084px){
  .design-18 .recommended [class*='device-']{
    padding-top:48px;
    padding-bottom:48px;
  }
  .design-18 .results .m-hero-item.f-transparent-LV5-padtop66:before{
    padding-bottom: 52%;
  }
  .design-18 .results .m-hero-item.f-transparent-LV5-padtop66.pad-inc:before{
    padding-bottom: 70%;
  }
  .design-18 .results .m-hero-item.f-transparent-V5-padtop45.pad-inc:before{
    padding-bottom: 65%;
  }
}
.design-18 .c-radio .visited input[type=radio]:checked+span:after,.design-18 .c-radio .active input[type=radio]:checked+span:after{
  background-color: transparent;
  width:0;
  height:0;
}

.design-18 .c-radio .visited input[type=radio]:not(:disabled)+span{color:#595959;}


@media screen and (max-width:1083px) and (min-width:540px){
.design-18 .interested .m-feature .c-price{
  /*display: inline-block;*/
  display: block;
  }
  .msw-page[class*='en-'] .design-18 .interested .m-feature .c-price span{
    width:100%;
    text-align: center;
  }
  .msw-page:not([class*='en-']):not([class*='zh-']) .design-18 .interested .m-feature .c-price {
   display: inline-block !important;
  }
  .zh-cn .design-18 .interested .m-feature .c-price{    
    width: 100%;
  }
  .zh-cn .design-18 .interested .m-feature .c-price span{
    width:100%;
    text-align: center;
    display: contents;
  }
}

.design-18 .glyph-btn-wrap {
    display: inline-block;
    min-height: 103px;
    position: relative;
    min-width:64px;
}
.design-18 .btn-wrap-next {
    margin-left: 15px;
}
.design-18 .btn-wrap-back.x-hidden+.btn-wrap-next{
  margin-left: 0;
}
.design-18 .hmc-buttons .see-result{
  display: block;
}

@media screen and (max-width:1083px) and (min-width:540px){
.design-18 .hmc-buttons button.start-over.c-button{margin-top:22px;}
.design-18 .hmc-buttons .see-result{margin-top:17px;}
}


@page{
  size:landscape;
}
.design-18 .surface-laptop-pivots .c-pivot{
  max-height:72px;
}
.design-18 .surface-pivot-hero-mob-margin .c-call-to-action.surface-secondary-cta.c-glyph{
  margin-top:8px;
}
@media screen and (max-width:1083px){
  .design-18 .recommended .surface-pivot-hero-mob-margin .c-price {
    padding-top: 20px;
    padding-bottom: 20px;
}
.design-18 .interested [class*='device-']:not(.surface-multifeature-pivot) .c-price{padding-top:20px;}
.design-18 .interested [class*='device-']:not(.surface-multifeature-pivot) .c-group{margin-top:0;display: inline-block;}
}

@media screen and (max-width:767px){
  .design-18 .surface-multifeature-pivot .c-group{
    display:block;
  }
}
.design-18 .m-hero-item a.c-call-to-action.c-glyph.surface-bg-cta-blue{
  margin-bottom: 5px;
}

  .design-18 .interested [class*='device-']:not(.surface-multifeature-pivot) .link-book .c-subheading-2{
    padding-top:0;
  }
 /*.de-de .design-18 [data-vg='H18-Surface-HMC-Recommendation-Header_VG'] p,.ja-jp .design-18 [data-vg='H18-Surface-HMC-Recommendation-Header_VG'] p,.zh-cn .design-18 [data-vg='H18-Surface-HMC-Recommendation-Header_VG'] p{
   display:none !important;
 }*/


 .en-gb .design-18 .surface-section-footnotes .supLink,.en-au .design-18 .surface-section-footnotes .supLink,.de-de .design-18 .surface-section-footnotes .supLink,.ja-jp .design-18 .surface-section-footnotes .supLink,.zh-cn .design-18 .surface-section-footnotes .supLink{
   pointer-events: none !important;
   text-decoration: none !important;
 }
.acc-item:nth-child(3) [aria-controls='pivot-Surface_Go_Signature_Type_Cover-target-4'] {
    display: none;
}

/*.zh-cn [data-vg='H18-Surface-HMC-Results-Lg_VG'] .c-price .pricecurrnecy,.zh-cn [data-vg='H18-Surface-HMC-Results-Interested-Lg_VG'] .c-price .pricecurrnecy{visibility:hidden;}*/
.design-18 a.surface-secondary-cta.c-call-to-action:not(.glyph-play):after{
  top:0;
}
.design-18 .c-progress{
    position: fixed;
    left: 50%;
    top: 50%;    
    transform: translate(-50%);
    z-index:10;
}
@media screen and (min-width:1084px) and (max-width:1399px){
  :not(.zh-cn) .design-18 .questions-panel #divQuestion3 .answer-group,
  :not(.zh-cn) .design-18 .questions-panel #divQuestion7 .answer-group{
    margin-left:11vw;
  }
}

@media screen and (min-width:1084px) and (max-width:1150px){
  .de-de .design-18 .questions-panel #divQuestion7 .answer-group .option-block:nth-of-type(2) .c-label{
    margin-left:10px;
  }
}


.design-18 .hmc-glyph .c-action-trigger:focus{
  outline: #000 dashed 2px !important;
}

.design-18 a.glyph-download:focus.c-action-trigger.c-glyph:focus{
  outline: #000 dashed 2px !important;
  margin-bottom: 4px;
}

@media screen and (max-width:850px){
  .design-18 .hmc-text-progress{
    top:-1px !important;
  }
}

.domain_remove a,
.lte-domain_remove a{
  text-decoration: underline;
    color: #0078d4; 
}

.recommended [data-vg=H18-Surface-HMC-Results-Pro_VG] .c-pivot a img, .interested [role=tablist] .c-glyph a img,  .recommended [role=tablist] .c-glyph a img{
 width:40px;
 height:40px 
}

.prolive{
     background: 0 0!important;
    color: #0067B8!important;
    border-color: transparent!important;
}

.prolive:hover, .prolive:focus{
    text-decoration: underline!important;
}

.lte_displaynow{
  display: block!important;
}
.design-18 .hmc-buttons button.start-over.c-button
{
  margin-bottom: 10px !important;
}

.m-hero-item>div>div>div.hmc-remodel-li-mt {
  margin-top: 0px !important;
}

/*.design-18 .btn-wrap-next
{
display:inline-table;
}*/
.Firefox #divQuestion4  label.c-label
{
  pointer-events: auto!important;
}

/*color contrast issues*/

.wdg-f-highcontrast .design-18 .hmc-custom-hero .c-button.glyph-chevron-down,
.wdg-f-highcontrast .hmc-buttons .c-button.glyph-chevron-down,
.wdg-f-highcontrast .hmc-buttons .c-button.glyph-chevron-up,
.wdg-f-highcontrast .design-18 .hmc-buttons .see-result,
.wdg-f-highcontrast .design-18 .hmc-buttons button.start-over.c-button
{
outline:none;
}

.wdg-f-highcontrast .surface-hmc-qaBody .c-checkbox input[type="checkbox"] + span::before,
.wdg-f-highcontrast .design-18 .surface-hmc-qa-block-item .c-checkbox input[type="checkbox"]:checked + span::after,
.wdg-f-highcontrast .back.c-glyph.glyph-chevron-up::after,
.wdg-f-highcontrast .design-18 .surface-hmc-qa-block-item .c-checkbox input[type="checkbox"] + span::before,
.wdg-f-highcontrast .design-18 .hmc-buttons .next.c-glyph.glyph-chevron-down::after,
.wdg-f-highcontrast .hmc-custom-hero .c-group .start-questions.c-glyph.glyph-chevron-down::after,
.wdg-f-highcontrast .design-18 .hmc-progress-container .c-label.active input[type="radio"] + span::before,
.wdg-f-highcontrast .c-radio input[type="radio"] + span::before
{
border: 1px solid currentcolor !important;
}
.wdg-f-highcontrast .design-18 .surface-hmc-qa-block-item .c-label input[type="radio"] + span::after
{
  border: 13px solid currentcolor !important;
}

.surface-hero-pivot-multi-img .c-pivot>ul>li>a
{
  border:#fff 2px solid;
  
}
.design-18 .hmc-remodel a.mscom-link:focus, .surface-multifeature-pivot .m-multi-feature [role=tablist] li>a:focus
{
  outline:#000 1px dashed !important;
  
}


/*Surface for business link*/
.hmc-results .hmc-email-prnt.hmc-glyph{
  display: inline-block;
}

.design-18 .results .surface-hmc-business{
  display: none;
  color: #0067B8 !important;

}


.design-18 .results .surface-hmc-business a.mscom-link.c-call-to-action.surface-secondary-cta.c-glyph span:before{
  content: url("https://www.microsoft.com/en-us/CMSImages/Surface_HCM_Forbusiness_Logo.svg?version=a5576581-0604-a330-1e6b-ddb5ed072eb4");
  width:20px;
  height:20px;
  display: inline-block;
  margin-right:1%;
}

.design-18 .results .surface-hmc-business a.mscom-link.c-call-to-action.surface-secondary-cta.c-glyph{
text-align: left;
}

.design-18 .results .surface-hmc-business a.mscom-link.c-call-to-action.surface-secondary-cta.c-glyph:after{
 content:""; 
}
.design-18 .results .recommended .surface-hmc-business a.mscom-link.c-call-to-action.surface-secondary-cta.c-glyph,
.design-18 .results .recommended .surface-hmc-business{
  padding-top: 0;
  margin-top: 5PX;
}

.de-de .design-18 .results .recommended .surface-hmc-business a.mscom-link.c-call-to-action.surface-secondary-cta.c-glyph,
.de-de .design-18 .results .recommended .surface-hmc-business{
  margin-top: 0;
  padding-top: 0;
}

/*.design-18 .results .interested .device-1 .surface-hmc-business a.mscom-link.c-call-to-action.surface-secondary-cta.c-glyph{
          padding-left: 22px;
} */
.design-18 .interested .hmc-span .m-feature .link-book .surface-hmc-business a.mscom-link.c-call-to-action.surface-secondary-cta.c-glyph{
  margin-top: 0;
}
@media screen and (max-width:767px){
.design-18 .results .surface-hmc-business a.mscom-link.c-call-to-action.surface-secondary-cta.c-glyph{
    padding-right: 0;
    padding-left: 5px;
} 
}

@media screen and (min-width:1084px) and (max-width:1339px){
  .design-18 .results .interested, .design-18 .interested [class*='device-']{
    padding-top: 0;
    padding-bottom: 0;
    margin-top: 0;
    margin-bottom: 0;
  }
  /*.design-18 .interested .m-feature.f-align-right{
    padding-top: 0;
    padding-bottom: 0;
    margin-top: 0;
    margin-bottom: 0;
    float: none;
    display: table;
    width: 100%;
    height: auto;
  }*/
  .design-18 .interested .m-feature.f-align-right picture, .design-18 .interested .m-feature.f-align-right>div{
    display: table-cell;
    float: none;
    left: auto;
    width: auto;
    padding: 0;    
    margin: 0;
    position: relative;
  }
  .design-18 .interested .m-feature.f-align-right picture{
    vertical-align: middle;
  }
  .design-18 .interested .m-feature.f-align-right>div{
    transform: none;
  }
}

@media screen and (min-width:0px) and (max-width:1039px){
.design-18 .results .surface-hmc-business a.mscom-link.c-call-to-action.surface-secondary-cta.c-glyph{
text-align: center;
}
}

@media screen and (min-width:1340px){
/*.design-18 .interested .device-3{
padding-top: 130px;
}*/

.design-18 .interested .device-1,
.design-18 .interested .device-2,
.design-18 .interested .device-3,
.design-18 .interested .device-4,
.design-18 .interested .device-5{
padding-bottom: 0px;
}
}


/*@media screen and (min-width:1084px) and (max-width:1339px){
.design-18 .interested .device-1 .c-group{
padding-bottom: 50px;
}
}*/

.results .interested .m-multi-feature a.c-call-to-action.surface-bg-cta-blue:focus:not(.x-hidden-focus):not(.wdg-f-blue-button){
  background:#006cc2 !important;
  outline: #000 dashed 2px !important;
}

/*@media screen and (min-width:768px) and (max-width:1083px){
.results .interested .m-multi-feature.f-align-left>section{
flex-direction: column;
-ms-flex-direction: column;
}

.results .interested .m-multi-feature.f-align-left>section>.c-carousel,
.results .interested  .m-multi-feature.f-align-left>section>div{
  width:66.6666666667%
}

.results .interested .device-1.surface-multifeature-pivot .m-multi-feature.f-align-left>section>div,
.results .interested .device-2.surface-multifeature-pivot .m-multi-feature.f-align-left>section>div,
.results .interested .device-3.surface-multifeature-pivot .m-multi-feature.f-align-left>section>div,
.results .interested .device-4.surface-multifeature-pivot .m-multi-feature.f-align-left>section>div,
.results .interested .device-5.surface-multifeature-pivot .m-multi-feature.f-align-left>section>div,
.results .interested .device-1 .m-multi-feature.f-align-left>section [role=tabpanel],
.results .interested .device-2 .m-multi-feature.f-align-left>section [role=tabpanel],
.results .interested .device-3 .m-multi-feature.f-align-left>section [role=tabpanel],
.results .interested .device-4 .m-multi-feature.f-align-left>section [role=tabpanel],
.results .interested .device-5 .m-multi-feature.f-align-left>section [role=tabpanel]{
text-align: center;
}


.results .interested .device-1.surface-multifeature-pivot .m-multi-feature.f-align-left>section>div>ul[role=tablist],
.results .interested .device-2.surface-multifeature-pivot .m-multi-feature.f-align-left>section>div>ul[role=tablist],
.results .interested .device-3.surface-multifeature-pivot .m-multi-feature.f-align-left>section>div>ul[role=tablist],
.results .interested .device-4.surface-multifeature-pivot .m-multi-feature.f-align-left>section>div>ul[role=tablist],
.results .interested .device-5.surface-multifeature-pivot .m-multi-feature.f-align-left>section>div>ul[role=tablist],
.results .interested .device-1 .m-multi-feature.f-align-left>section>div .c-group,
.results .interested .device-2 .m-multi-feature.f-align-left>section>div .c-group,
.results .interested .device-3 .m-multi-feature.f-align-left>section>div .c-group,
.results .interested .device-4 .m-multi-feature.f-align-left>section>div .c-group,
.results .interested .device-5 .m-multi-feature.f-align-left>section>div .c-group{
justify-content: center;
}
}*/

.design-18 .start-questions.c-glyph.glyph-chevron-left::after,
 .design-18 .next.c-glyph.glyph-chevron-left::after
 {
    font-family: MWF-MDL2;
    content: "";
    color: rgb(255, 255, 255);
    background-color: rgb(0, 120, 212);
    top: 42px;
    font-size: 16px;
    left: 50%;
    position: absolute;
    transform: translateX(-50%);
    z-index: 2;
    padding: 22px;
    border-radius: 50%;
}
.design-18 .back.c-glyph.glyph-chevron-right::after
{
  font-family: MWF-MDL2;
    content: "";
    color: rgb(255, 255, 255);
    background-color: rgb(0, 120, 212);
    top: 42px;
    font-size: 16px;
    left: 50%;
    position: absolute;
    transform: translateX(-50%);
    z-index: 2;
    padding: 22px;
    border-radius: 50%;
}
.design-18 .next:disabled.c-glyph.glyph-chevron-left:after
{
    color: #fff;
    background-color: #d2d2d2;
}
.design-18 .start-questions.c-glyph.glyph-chevron-left, 
.design-18 .next.c-glyph.glyph-chevron-left, 
.design-18 .back.c-glyph.glyph-chevron-right,
.design-18 .start-questions.c-glyph.glyph-chevron-right
{
      margin: 12px;
}
.design-18 .start-questions.c-glyph.glyph-chevron-left,
 .design-18 .next.c-glyph.glyph-chevron-left, 
 .design-18 .back.c-glyph.glyph-chevron-right,
 .design-18 .start-questions.c-glyph.glyph-chevron-right
{
  min-width: 0;
    padding: 0 !important;
}
.design-18 section.questions-panel button.next,
 .design-18 section.questions-panel button.back
{
  text-decoration: none !important;
    vertical-align: top;
}
.design-18 .hmc-custom-hero .c-group .start-questions.c-glyph.glyph-chevron-left::after,
 .design-18 .next.c-glyph.glyph-chevron-left::after,
 .design-18 .hmc-custom-hero .c-group .start-questions.c-glyph.glyph-chevron-right::after,
 .design-18 .next.c-glyph.glyph-chevron-right::after
{
      background-color: #0078d4;
}
.design-18 .next.c-glyph.glyph-chevron-left:after,
.design-18 .next.c-glyph.glyph-chevron-right:after
{
    top: 42px;
    left: 50%;
    transform: translateX(-50%);
}
.design-18 .c-glyph.glyph-chevron-left:before,.design-18 .c-glyph.glyph-chevron-right:before
{
  content:"";
}

.design-18 .surface-hmc-ans-block legend[class*='c-heading']+.surface-hmc-instr
{
      padding-top: 30px;
}

  .hmc-custom-hero div:nth-child(1)
{
  text-align:left;
}
.design-18 .surface-hmc-ans-block>fieldset>legend
{
      padding-top: 25px;
}
.design-18 .hmc-buttons
{
  margin-top:69px;
}
.design-18 .btn-wrap-back.x-hidden+.btn-wrap-next
{
  margin-bottom:5px;
}
@media screen and (max-width:1083px){
.design-18 .questions-panel .option-block img.f-round,
.design-18 .surface-hmc-qa-block-item label.c-label
{
  margin-top:20px;
}
.design-18 .questions-panel .surface-hmc-qa-block-item .option-block
{
  padding-bottom:0px;
}
.design-18 .surface-hmc-qa-block-item .option-block .c-label input+span+span
{
  margin-top:8px;
}
.design-18 .btn-wrap-back.x-hidden+.btn-wrap-next
{
  margin-bottom:0px;
}
.design-18 .btn-wrap-back.x-hidden+.btn-wrap-next
{
  margin-bottom:29px;
}
}
@media screen and (max-width:539px){
  .design-18 .surface-hmc-qa-block-item .surface-hmc-ans-block .option-block .c-heading-4
{
  padding-top: 32px;
}
.design-18 .answer-group .option-block .c-label
{
  margin-top: 22px;
}
.design-18 .btn-wrap-back.x-hidden+.btn-wrap-next
{
  margin-bottom:0px;
}
}

/*Hero redlines*/

@media screen and (min-width:1084px) {
  .m-hero-item.hmc-custom-hero:before {
    padding-bottom: 27.8%;
  }
}
@media screen and (max-width:1083px) {
  .m-hero-item.hmc-custom-hero:before {
    padding-bottom: 28.25%;
  }
}

.hmc-custom-hero .c-heading-2 {
  padding: 0 0 12px;
}
.hmc-custom-hero .c-paragraph-2 {
  padding-top: 6px;
}

.design-18 .results button.surface-OOS-cta.disable-bluecta,
.design-18 .results button.surface-OOS-cta.disable-bluecta:hover,
.design-18 .results button.surface-OOS-cta.disable-bluecta:focus,
.design-18 .results button.surface-OOS-cta.disable-bluecta:active{
    color: rgba(0,0,0,.2) !important;
    background-color: rgba(0,103,184,.2) !important;
    border: 0px !important;
    padding: 14px 22px 14px 22px;
    cursor: not-allowed !important;
    outline:none !important;
    text-decoration: none !important;
    margin-right:24px;
    margin-left: 0px;
    vertical-align: 17px;
}

button.surface-OOS-cta{
 vertical-align: 17px !important; 
}
.c-button.f-primary.surface-OOS-cta.disable-bluecta{padding: 14px 22px 14px 22px;}

.design-18 .results a.mscom-link.c-call-to-action.surface-OOS-cta.disable-bluecta:hover span,
.design-18 .results a.mscom-link.c-call-to-action.surface-OOS-cta.disable-bluecta:focus span{
  text-decoration: none !important;
}

.en-sg .design-18 .c-price{
  display: inline-block;
  visibility: visible !important;
}
.interested .m-multi-feature [role=tablist] li{
  margin-left: 8px;
}

.design-18 .hmc-remodel.surface-hero-pivot-multi-img [role=tablist] li>a.mscom-link.f-active:focus{
  outline: #000 dashed 1px !important;
}

.design-18 .surface-hero-pivot-multi-img .c-pivot>ul>li>a{
  border: 0;
  display:block;
}

.design-18 .surface-hero-pivot-multi-img .c-pivot ul li[data-swatch-text="Black"] a.mscom-link:focus, 
.design-18 .surface-hero-pivot-multi-img .c-pivot ul li[data-swatch-text="Platinum"] a.mscom-link:focus
{border:0 !important}

.fr-ca .design-18 .recommended .hmc-results .hmc-email-prnt .glyph-share{
  padding-bottom: 0;
}
.fr-ca .design-18 .recommended .hmc-results{
  padding-bottom: 16px;
}

/*@media screen and (min-width: 1340px){
 .it-it .design-18 .interested, 
 .fr-ca .design-18 .interested {padding-bottom: 100px;}
 
 .design-18 .interested [class*='device-5']{padding-top: 140px;padding-bottom: 110px;} 
 
  .es-es .design-18 .interested .device-5,
 .de-de .design-18 .interested .device-5,
 .fr-ca .design-18 .interested .device-5, 
 .fr-fr .design-18 .interested .device-5, 
 .es-es .design-18 .interested .device-6,
 .es-es .design-18 .interested .device-7,
 .fr-ca .design-18 .interested .device-6,
 .fr-ca .design-18 .interested .device-7,
 .it-it .design-18 .interested .device-6,
 .it-it .design-18 .interested .device-7,
 .zh-cn .design-18 .interested .device-6,
 .zh-cn .design-18 .interested .device-7{padding-top: 160px;padding-bottom: 130px;}
 
 .de-de .design-18 .interested .device-6,
 .de-de .design-18 .interested .device-7,
 .fr-fr .design-18 .interested .device-6,
 .fr-fr .design-18 .interested .device-7,
 .ja-jp .design-18 .interested .device-6,
 .ja-jp .design-18 .interested .device-7{padding-top: 160px;padding-bottom: 140px;}
 
 .it-it .design-18 .interested .device-0{padding-bottom: 140px;}

  .fr-ca .design-18 .interested [class*='device-0'],
  .es-es .design-18 .interested [class*='device-6']  
  .nl-nl .design-18 .interested [class*='device-5']{
   padding-top: 140px;
  }
  .it-it .design-18 .interested [class*='device-5'],
  .it-it .design-18 .interested [class*='device-6']{
    padding-top: 185px;
  }
 
 .it-it .design-18 .interested [class*='device-0'],
 .it-it .design-18 .interested [class*='device-7'],
 .it-it .design-18 .interested [class*='device-8'],
 .de-de .design-18 .interested [class*='device-0'],
 .de-de .design-18 .interested [class*='device-8'],
 .nl-nl .design-18 .interested [class*='device-0'],
 .nl-nl .design-18 .interested [class*='device-8'],
 .nl-nl .design-18 .interested [class*='device-6'],
 .nl-nl .design-18 .interested [class*='device-7']{padding-top: 160px;}
 
 .nl-nl .design-18 .interested [class*='device-6'],
 .nl-nl .design-18 .interested [class*='device-7']{padding-bottom: 150px;}
 
 .de-de .design-18 .interested, .nl-nl .design-18 .interested{padding-bottom: 90px;}
 
}*/
.wdg-global .c-group a.surface-secondary-cta.c-call-to-action:nth-child(n+2) {
    padding-left: 25px;
}
.wdg-global .recommended .c-group a.surface-secondary-cta.c-call-to-action:nth-child(n+2) {
    vertical-align: super;
}
.recommended .c-pivot>section[aria-hidden=false] {
    display: none;
}
/*To fix all padding issue in interested section*/
.design-18 .interested .m-multi-feature .c-group, 
.design-18 .interested .m-feature .c-group{
    display: table-cell;
}
/*To fix Book padding issue in interested section*/
.design-18 .interested .device-6 .m-feature, 
.design-18 .interested .device-7 .m-feature{
  margin-top: 48px;
}

@media only screen and (max-width: 1083px) and (min-width: 540px){
.results .surface-multifeature-pivot .m-multi-feature>section>div {
 width: 66.6666666667%;
 margin: auto;
}
}

/*USB-C®*/
@media only screen and (min-width: 1250px){
.design-18 .surface-hmc-qa-block-item .option-block .c-label input[data-name="USB-C"]+span+span, 
.design-18 .surface-hmc-qa-block-item .option-block .c-label input[data-name="USB-A"]+span+span {
white-space: nowrap;
}
}

/*EN-US Redesign*/
/*HMC 360 slider*/
.design-18 .m-content-placement-item .thinSlider {
    cursor: default;
    pointer-events: auto;
}
.Surfaceimage360_ContentPlacement .image360 
{    
  touch-action: pan-y pinch-zoom;
}
.Surfaceimage360_ContentPlacement .image360__sprite
{
  /*background-size: 100% 3600%;    
  padding-bottom: 37.5%;    */
  background-size: 100% 410%;
  padding-bottom: 58.5%;
  background-position-y: 0%;    
  /*background-image: url(https://cmspreview2.corp.microsoft.com/en-us/CMSImages/Surface_Book_Sprite.jpg.png?version=124494a6-f4c3-8a73-b8ee-09cd7c256c9b&CollectionId=45e58e5b-0f8b-4f59-9c13-ec3d7dc2cd99);*/
  }
  .Surfaceimage360_ContentPlacement .image360__sprite 
  {    
    position: relative;    
    width: 100%;    
    height: 0;
  }
.Surfaceimage360_ContentPlacement .x-type-center {    
  text-align: center !important;
}
.Surfaceimage360_ContentPlacement .thinSlider 
{  
  /*-webkit-appearance: none;  
  width: 100%;  
  height: 12px;  
  background: #505050;  
  outline: none;  
  opacity: 1;  
  -webkit-transition: .2s;  
  transition: opacity .2s;*/
  -webkit-appearance: none; /* Hides the slider so that custom slider can be made */
  width: 100%; /* Specific width is required for Firefox. */
  background: transparent;
 }
/*.Surfaceimage360_ContentPlacement .thinSlider:hover 
{  
  opacity: 1;
}*/
.Surfaceimage360_ContentPlacement .thinSlider:focus {
    outline: none;
}
.Surfaceimage360_ContentPlacement .thinSlider::-webkit-slider-thumb 
{  
  -webkit-appearance: none;
  /*margin-top:-5px;*/  /*mandatory for chrome*/
  /*height: 12px;*/
  margin-top:-2.5px;  /*mandatory for chrome*/
  height: 6px;
  width: 130px;
  background: #505050;
  cursor: pointer;
}
.Surfaceimage360_ContentPlacement .thinSlider::-webkit-slider-runnable-track {
  width: 100%;
  height: 1px;
  cursor: pointer;
  background: #171717;
}
.Surfaceimage360_ContentPlacement .thinSlider::-moz-range-thumb
{  
  /*height: 12px;*/
  height: 6px;
  width: 130px;
  border-radius:0;
  background: #505050;
  cursor: pointer;
}
.Surfaceimage360_ContentPlacement .thinSlider::-moz-range-track {
  width: 100%;
  height: 1px;
  cursor: pointer;
  background: #171717;
}
.Surfaceimage360_ContentPlacement .thinSlider::-ms-thumb {
  /*padding-bottom:5px;*/ /*To fix height issue caused by chrome -webkit-thumb*/
  /*height: 12px;*/
  padding-bottom:2.5px; /*To fix height issue caused by chrome -webkit-thumb*/
  height: 6px;
  width: 130px;
  background: #505050;
  cursor: pointer;
}
.Surfaceimage360_ContentPlacement .thinSlider::-ms-tooltip {
  display: none;
}
.Surfaceimage360_ContentPlacement .thinSlider::-ms-track {
  width: 100%;
  height: 1px;
  cursor: pointer;
  background: transparent;
  border-color: transparent;
  border-width: 12px 0;
  color: transparent;
}
.Surfaceimage360_ContentPlacement .thinSlider::-ms-fill-lower, 
.Surfaceimage360_ContentPlacement .thinSlider::-ms-fill-upper {
   background: #171717;
}

.Surfaceimage360_ContentPlacement .thinSlider:focus::-ms-thumb{
  outline: 2px dashed #000;
  outline-offset: 2px;
}
 
.Surfaceimage360_ContentPlacement .thinSlider:focus::-moz-range-thumb{
  outline: 2px dashed #000;
  outline-offset: 2px;
}
.Surfaceimage360_ContentPlacement .thinSlider:focus::-webkit-slider-thumb{
  outline: 2px dashed #000;
  outline-offset: 2px;
}

.Surfaceimage360_ContentPlacement .image360__slider 
{
margin-top: 8px;    
/*width: 420px;    
max-width: 90%;*/
}
.Surfaceimage360_ContentPlacement .image360__instruction 
{    
  font-size: 15px;    
  line-height: 20px;    
  color: rgba(0,0,0,.6);    
  margin-top: 12px;
}
/*.results .surface-360slider .ui-state-default {
    height: 12px;
    width: 30px;
    border-radius: 0px;
}
.results .surface-360slider .ui-slider-horizontal .ui-slider-handle {
    top: -5px;
    margin-left: -1.0em;
}*/
.design-18 [class*='device-'].m-content-placement-item ul[role='tablist'] li a{
  display: inline-block;
}
.design-18 [class*='device-'].m-content-placement-item {
    padding-top: 0;
    margin-top: 10px !important;
}
.design-18 [class*='device-'].m-content-placement-item .c-carousel ul{
  padding-left: 0;
  width: 100%;
}
.design-18 [class*='device-'].m-content-placement-item ul{
    display: inline-block;
}
.design-18 [class*='device-'].m-content-placement-item .swatch-color~ul li{
    margin-right: 10px;
    float: left;   
}
.design-18 [class*='device-'].m-content-placement-item .swatch-color~ul {
    list-style-type: none;
}
/*.design-18 [class*='device-'] .swatch-color~ul li img {
    border-radius: 50%;
}
.design-18 [class*='device-'] .swatch-color~ul li img:focus:after {
    border-radius: 50%;
    outline: 1px dashed #000;
}*/
.design-18 .m-content-placement{
  padding-bottom: 40px;
}
.design-18 .m-content-placement .interested{
  padding-left: 36px;
}
.design-18 .m-content-placement .recommended{
  padding-right: 36px;
}
.design-18 [class*='device-'].m-content-placement-item {
    padding: 0;
}
.design-18 .interested [class*='device-'].m-content-placement-item .c-price {
    padding-top: 0;
    padding-bottom: 0;
}
.design-18 [class*='device-'].m-content-placement-item .MatchText{
      padding-bottom: 35px;
      padding-top: 24px;
}
.design-18 [class*='device-'].m-content-placement-item .NotMatchText{
      padding-bottom: 48px;      
}
.design-18 .results .Compare_banner .speclink[disabled='disabled']{
    pointer-events: none;    
    color: grey;
}
.design-18 .results .Compare_banner .speclink[disabled='disabled'] span{
    cursor: not-allowed;
}
.design-18 .results .m-content-placement .interested, .design-18 .results .m-content-placement .recommended {
  padding-bottom: 0;
}
/*.en-us .hmc-link-nav a.c-glyph.glyph-share:before {
    font-family: "MWF-MDL2";
    content: "\E72D";
    display: inline-block;
    padding-right: 5px;
}*/
#mainContent .hmc-link-nav a.c-hyperlink.c-glyph.glyph-startover{
    text-decoration: none !important;
}

#mainContent .hmc-link-nav a.c-hyperlink.c-glyph.glyph-startover:hover{
    text-decoration: underline !important;
}

@media screen and (max-width:767px){
#mainContent .hmc-link-nav nav.c-link-navigation li a.c-hyperlink{
    display:block;
  }
}

.hmc-link-nav a.c-glyph.glyph-startover:before{
    font-family: "MWF-MDL2";
    content: "\E72C";
    display: inline-block;
    padding-left: 4px;
    /*transform: rotateY(180deg);*/
    transform: rotate3d(9, 9, 1, 180deg);
    /*margin-right: 10px;*/
    margin-right: 5px;
    /*vertical-align: bottom;*/
}
.hmc-link-nav{
padding-bottom: 48px;
}

.design-18 .results .c-subheading-2.hmc-remodel-li.hmc-remodel-li-mt{
  padding-top: 40px;
}
/*.en-us .design-18 .results .hmc-shop-for-biz{
   padding-bottom: 56px;
 }*/
.design-18 .results .m-content-placement .interested [class*='device-'].m-content-placement-item .c-price, 
.design-18 .results .m-content-placement .recommended [class*='device-'].m-content-placement-item .c-price{
  padding-top: 10px;
  padding-bottom: 0px;
}
.design-18 .results .m-content-placement [class*='device-'].m-content-placement-item .swatch-color{
  padding-top: 10px;
  padding-bottom: 10px;
}
.design-18 [class*='device-'].m-content-placement-item .swatch-color~ul li a:focus{
  outline: 2px dashed #000;
}
.design-18 .results [class*='device-'].m-content-placement-item .MatchText li.deviceText span{
  /*padding-left: 10px;
  vertical-align: middle;*/
  margin-top: -17px;
  display: block;
  margin-left: 30px;
}
.design-18 .results [class*='device-'].m-content-placement-item .Specsdata li {
    line-height: 22px;
}
.design-18 .recommended .c-price {
    padding-bottom: 5px;
}
.design-18 .results [class*='device-'].m-content-placement-item .Specsdata h3.c-subheading-2, 
.design-18 .results [class*='device-'].m-content-placement-item .MatchText h3.c-subheading-2{
      padding-bottom: 12px;
}
.design-18 .results [class*='device-'].m-content-placement-item .Specsdata li, 
.design-18 .results [class*='device-'].m-content-placement-item .MatchText li{
      padding-bottom: 10px;
}
.design-18 .results [class*='device-'].m-content-placement-item .MatchText ul{
  list-style-type: none;
  padding-left: 0px;
}
.design-18 .results [class*='device-'].m-content-placement-item ul[role=tablist]{
    padding-left: 0px;
}
.design-18 .results [class*='device-'].m-content-placement-item ul[role=tablist] li .Selected{
  display: none;
}
.design-18 .results [class*='device-'].m-content-placement-item .Specsdata ul{
   padding-left: 20px;
}
.design-18 .results [class*='device-'].m-content-placement-item .MatchText li.deviceText .img-green-checkmark{
  width: 15px;
  height: 12px;
  display: inline-block;
  vertical-align: bottom;
}
.design-18 .results [class*='device-'].m-content-placement-item .MatchText .green_tick{
  display: none;
}
.design-18 .results [class*='device-'].m-content-placement-item .c-heading{
  padding-top: 0;
  padding-bottom: 10px;
}
.wdg-global .recommended [class*='device-'].m-content-placement-item .c-group a.surface-secondary-cta.c-call-to-action:nth-child(n+2) {
    vertical-align: baseline;
}
.design-18 .results .m-content-placement .interested .badge-wrapper .c-badge 
{
  font-weight: 400;
} 
/*.en-us .design-18 .results button.surface-OOS-cta{
  white-space: normal;
}   */
.hmc-results p.c-subheading-2{
  display: none;
}
.design-18 .results .m-banner.wdg-mar-pad-x-reset.wdg-grey-banner {
     padding-top: 60px; 
}
/*.en-us .design-18 .results .wdg-pad-60.Compare_banner{
  padding-bottom: 60px;
}*/
@media screen and (max-width: 1083px){
.design-18 .interested [class*='device-'].m-content-placement-item .c-group {
    margin-top: 12px;
}
}
@media screen and (max-width: 767px){
  .design-18 .results .m-content-placement .badge-wrapper, 
  .design-18 .results .m-content-placement h3.c-heading, 
  .design-18 .results .m-content-placement .c-paragraph{
    width: 90%;
    margin: 0px auto;
  }
  .design-18 .results .m-content-placement .interested{
    padding-top: 76px;
  }
  .design-18 .m-content-placement .interested{
    padding-left: 12px;
  }
  .design-18 .m-content-placement .recommended{
   padding-right: 12px;
  }
  .design-18 .m-content-placement{
    padding-bottom: 40px;
  }
  /*.design-18 .results [class*='device-'].m-content-placement-item .mobile_wrapper{
    justify-content: center;
    display: grid;
    text-align: left;
  }*/
  /*.design-18 .results [class*='device-'].m-content-placement-item .mobile_wrapper .Specsdata{
    width:50%
  }*/
  .design-18 .results [class*='device-'].m-content-placement-item .mobile_wrapper .Specsdata, 
  .design-18 .results [class*='device-'].m-content-placement-item .mobile_wrapper .MatchText{
    width:80%;
    margin: 0px auto;
    display: grid;
  }
  .design-18 .results [class*='device-'].m-content-placement-item .surface-hmc-business, 
  .design-18 .results [class*='device-'].m-content-placement-item .swatch-color, 
  .design-18 .results [class*='device-'].m-content-placement-item ul[role=tablist], 
  .design-18 .results [class*='device-'].m-content-placement-item .c-price{
    width:80%;
    margin: 0px auto;
    display: flex;
  }
  .design-18 .results [class*='device-'].m-content-placement-item .swatch-color{
    /*padding-bottom: 20px;*/
    align-items: baseline;
  }
  .design-18 .results [class*='device-'].m-content-placement-item .c-group{
    width:80%;
    margin: 0px auto;
    display: block;
    margin-top: 12px;
    align-items: baseline;
  }
  .design-18 .results [class*='device-'].m-content-placement-item .surface-hmc-business a{
    border-left-style: hidden;
    margin-bottom: 10px;
  }
  
  .design-18 .results [class*='device-'].m-content-placement-item .c-price {
    /*justify-content: center;*/
    padding-top: 20px;
    justify-content: left;
  }
  .design-18 .HMC_nav{
    padding-top: 40px;
  }
}

.design-18 .results .m-content-placement-item .surface-hmc-business a.mscom-link.c-call-to-action.surface-secondary-cta.c-glyph{
  text-align: left;
}


/*Coming Soon disabled CTA for new devices and Not available text CTA*/

.design-18 .recommended button.surface-OOS-cta.disable-bluecta {
    vertical-align: 24px !important;
}

/*Zh-cn Blue CTA CSS*/
.zh-cn .design-18 .m-hero-item a.c-call-to-action.c-glyph.surface-bg-cta-blue,
.zh-cn .design-18 .m-feature a.c-call-to-action.c-glyph.surface-bg-cta-blue,
.zh-cn .design-18 .m-multi-feature a.c-call-to-action.c-glyph.surface-bg-cta-blue,
.zh-cn .design-18 .m-content-placement-item a.c-call-to-action.c-glyph.surface-bg-cta-blue {
  padding-top:10px;
  padding-bottom:10px;
}

.zh-cn .design-18 .m-hero-item a.c-call-to-action.c-glyph.surface-bg-cta-blue:after,
.zh-cn .design-18 .m-feature a.c-call-to-action.c-glyph.surface-bg-cta-blue:after,
.zh-cn .design-18 .m-multi-feature a.c-call-to-action.c-glyph.surface-bg-cta-blue:after,
.zh-cn .design-18 .m-content-placement-item a.c-call-to-action.c-glyph.surface-bg-cta-blue:after{
  margin-top:4px;
}

/*ja-jp specific for price*/
@media screen and (max-width:1083px) and (min-width:540px){
  .msw-page.ja-jp #mainContent .design-18 .interested .m-feature .c-price,
  .msw-page.nl-nl #mainContent .design-18 .interested .m-feature .c-price{
    display:block !important;
    padding-left: 35%;
  }
}

/*For recommended heading and Links*/
@media screen and (min-width: 768px) {
  .msw-page:not([class='en-us']) .design-18 .recommended .m-hero-item div .c-heading-2,
  .msw-page:not([class='en-us']) .design-18 .recommended .m-hero-item .c-group{
    min-width: max-content;
    }
}
/*For IE*/
@media screen and (min-width: 1084px) {
 .IE11 .msw-page:not([class='en-us']) .design-18 .recommended .m-hero-item .c-group,
 .Edge .msw-page:not([class='en-us']) .design-18 .recommended .m-hero-item .c-group,
 .Edge .msw-page:not([class='en-us']) .design-18 .recommended .m-hero-item div .c-heading-2{
    width: 110%;
    }
}
/*End*/

.design-18 .recommended [class*='device-'].m-content-placement-item .swatch-color~ul li a.c-logo.f-active img.Selected:focus{
  outline: 2px dashed #000;
}

/*@media screen and (max-width: 539px) {
.design-18 .interested .surface-multifeature-pivot .m-multi-feature .c-group{
left: 25%;
}
}*/

/*Accessibility issues high contrast*/
@media screen and (-ms-high-contrast: active), (-ms-high-contrast: black-on-white) {
.design-18 .hmc-progress-container .c-label.visited input[type=radio]+span:before {
    border: 13px solid #fff;
}
}

.design-18 .recommended .sur-devc-availbty,
.design-18 .interested .sur-devc-availbty,
.design-18 .recommended .sur-bundle-availbty,
.design-18 .interested .sur-bundle-availbty{
font-size: 20px;
}

@media screen and (min-width: 1084px){
.design-18 .interested .m-multi-feature .sur-devc-availbty,
.design-18 .interested .m-multi-feature .sur-devc-availbty{
  padding-left: 20px;
}
}

.design-18 .results .wdg-pad-60.Compare_banner{
  margin-bottom: 85px; 
}

.design-18 .results .hmc-shop-for-biz{
  padding-bottom: 85px;
  padding-top: 59px;
}

/* carrot moves to the right on hovor */
.design-18 a.c-call-to-action:not(.glyph-play):hover:after,
.design-18 button.c-call-to-action:not(.glyph-play):hover:after{
right: -4px !important;
}
/* END */
.wdg-global .c-call-to-action:focus:not(.x-hidden-focus):not(.wdg-f-blue-button){
  outline: #000 dashed 2px !important;
}

@media screen and (max-width:767px){
.design-18 .m-content-placement-item .sur-devc-availbty,
.design-18 .m-content-placement-item .sur-bundle-availbty,
.fr-fr .design-18 .m-content-placement-item .reparability-score{
  padding-left: 10%;
}
}

.fr-fr .reparability-score{
  padding-top: 20px;
}

.fr-fr .reparability-score:empty{
  padding-top: 0px;
  padding-bottom: 0px;
}

/*.en-sg .design-18 .device-2 .c-group,
.en-sg .design-18 .device-3 .c-group{
  padding-top: 50px;
}*/

/*chevron issue in sentence case */

body[class*="en-"] .design-18 a.c-call-to-action:not(.glyph-play):after,
body[class*="en-"] .design-18 button.c-call-to-action:not(.glyph-play):after{
    margin-top: 4px
}

.sur-devc-availbty:not(.x-hidden){
visibility: hidden;
}

/*Result page start over live issue*/
.hmc-link-nav .m-link-navigation .c-link-navigation ul{ 
  display: block;
}
/*Result page start over live issue END*/

/* Bundle and save text */

.msw-page:not(.en-us):not(.en-ca):not(.fr-ca) .sur-bundle-availbty{
  visibility: hidden;
}
html[lang='fr-ca'] .surface-prefooter .c-call-to-action 
{
	font-size: 12px;
} 

/*accessories
html:not([lang='en-us']) .surface-accessories-categories .surface-new-devices{
	display: none;
}
*/
.zh-tw .c-price,.th-th .c-price,.en-th .c-price,.ko-kr .c-price,.en-my .c-price,.ms-my .c-price,.ar-ae .c-price,.en-ae .c-price,.ar-sa .c-price,.en-sa .c-price,ar-qa .c-price,.en-qa .c-price{visibility:hidden!important;}
@media only screen and (min-width: 1084px) and (max-width: 1265px) {
	html[lang='fr-ca'] .surface-margin-bottom-120px {
		margin-bottom: 200px;
	}
	html[lang='en-ca'] .surface-margin-bottom-120px {
		margin-bottom: 200px;
	}
} 

@media only screen and (min-width: 540px)
{
.rtl .surface-social-share .m-social.f-share
{
    float: left;
}
}
@media only screen and (min-width: 1084px) and (max-width: 1399px) {
.pl-pl .c-heading-1,.sv-se .c-heading-1, .nb-no .c-heading-1,.pt-pt .c-heading-1,
.fr-ch .c-heading-1,.ms-my .c-heading-1,.nl-be .c-heading-1,.fr-be .c-heading-1, 
.es-es .c-heading-1,.it-it .c-heading-1, .fr-lu .c-heading-1, .nl-nl .c-heading-1,
.rtl .c-heading-1, .de-lu .c-heading-1
{
	font-size: 48px;
}
}
/*** Hiding buy panel drop  for other locales ***/
.en-sa .surface-image-richblock .surface-contentrich-block .c-select-menu.f-border,
.ms-my .surface-image-richblock .surface-contentrich-block .c-select-menu.f-border,
.en-ae .surface-image-richblock .surface-contentrich-block .c-select-menu.f-border,
.rtl .surface-image-richblock .surface-contentrich-block .c-select-menu.f-border,
.en-my .surface-image-richblock .surface-contentrich-block .c-select-menu.f-border,
.ko-kr .surface-image-richblock .surface-contentrich-block .c-select-menu.f-border,
.en-in .surface-image-richblock .surface-contentrich-block .c-select-menu.f-border,
.en-th .surface-image-richblock .surface-contentrich-block .c-select-menu.f-border,
.th-th .surface-image-richblock .surface-contentrich-block .c-select-menu.f-border,
.zh-tw .surface-image-richblock .surface-contentrich-block .c-select-menu.f-border
{
    display:none;
}
.en-sg .surface-image-richblock .surface-contentrich-block .pricecurrnecy,
.en-hk .surface-image-richblock .surface-contentrich-block .pricecurrnecy,
.zh-hk .surface-image-richblock .surface-contentrich-block .pricecurrnecy
{
	display:none;
}
/*** Hiding buy panel drop  for other locales END***/

 .rtl .c-content-placement .c-group>.c-call-to-action+.c-call-to-action,
 .rtl .m-content-placement-item .c-group>.c-call-to-action+.c-call-to-action
 {
       margin-right:24px;
 }
 
 .rtl .c-content-placement>.c-group>.c-call-to-action+.c-call-to-action:focus, 
 .rtl .m-content-placement-item>.c-group>.c-call-to-action+.c-call-to-action:focus
 {
    padding-right:0px;
 }
 
.rtl .m-content-placement a.c-call-to-action.c-glyph.surface-bg-cta-blue, 
.rtl .c-content-placement a.c-call-to-action.c-glyph.surface-bg-cta-blue, 
.rtl .c-feature a.c-call-to-action.c-glyph.surface-bg-cta-blue,
.rtl .c-content-placement .c-call-to-action, 
.rtl .m-content-placement-item .c-call-to-action
{
	margin-right:0px;
}
  .rtl a.c-call-to-action.c-glyph.surface-bg-cta-blue
  {
     /*padding: 10px 24px 7px 40px;*/
     margin-left:20px;
  }
@media only screen and (max-width: 898px) {
    .rtl .surface-social-share, 
    .rtl .surface-section-footnotes>div, 
    .rtl .surface-prefooter
	{
        padding-right: 40px;
    }
}

@media only screen and (max-width: 539px) {
    .rtl .surface-social-share, 
    .rtl .surface-section-footnotes>div, 
    .rtl .surface-prefooter 
	 {
        padding-right: 12px;
    }
 .rtl .confgpanel-specs .confgpanel-specsandprice [data-grid~='col-6']{
     float: right;
 }
}
.rtl .shell-search button
{
    border-right:none;
    border-left : 1px solid #a9a9a9;
}

@media only screen and (max-width: 539px) {
html[lang^='de'] .c-heading-1 
{
	font-size: 30px;
    line-height: 42px;
} 
}
[class*='en-'] #surfaceAllAccessories_Browse .m-hero-item.surface-accessories-browse-hero .c-heading-1
{
    font-size: 58px;
    line-height: 68px;
}
#surfaceAllAccessories_Browse .m-hero-item.surface-accessories-browse-hero .c-heading-1
{
    font-size: 46px;
    line-height: 50px;
}
.de-de #surfaceAllAccessories_Browse .m-hero-item.surface-accessories-browse-hero .c-heading-1,
.de-at #surfaceAllAccessories_Browse .m-hero-item.surface-accessories-browse-hero .c-heading-1
{
    font-size: 62px;
    line-height: 72px;
}

.rtl .wdg-m-prefooter button.drawer {
   text-align:right;
}
.rtl .wdg-m-prefooter button.drawer:after{
padding-left:0px;
padding-right: 6px;
}

/*configurator panel*/
.en-au .confgpanel-specsandprice .c-price.c-heading-3, .es-es .confgpanel-specsandprice .c-price.c-heading-3,
.de-de .confgpanel-specsandprice .c-price.c-heading-3, .en-gb .confgpanel-specsandprice .c-price.c-heading-3,
.pt-pt .confgpanel-specsandprice .c-price.c-heading-3, .de-ch .confgpanel-specsandprice .c-price.c-heading-3,
.fr-ch .confgpanel-specsandprice .c-price.c-heading-3, .ja-jp .confgpanel-specsandprice .c-price.c-heading-3,
.nl-be .confgpanel-specsandprice .c-price.c-heading-3, .fr-be .confgpanel-specsandprice .c-price.c-heading-3,
.de-lu .confgpanel-specsandprice .c-price.c-heading-3, .nl-nl .confgpanel-specsandprice .c-price.c-heading-3,
.pl-pl .confgpanel-specsandprice .c-price.c-heading-3, .de-at .confgpanel-specsandprice .c-price.c-heading-3,
.en-ie .confgpanel-specsandprice .c-price.c-heading-3, .it-it .confgpanel-specsandprice .c-price.c-heading-3
{
    font-size:22px;
    line-height:30px;
}

@media only screen and (min-width: 1400px) {
.en-ca .confgpanel-specsandprice .c-price.c-heading-3, .sv-se .confgpanel-specsandprice .c-price.c-heading-3,
.fr-ca .confgpanel-specsandprice .c-price.c-heading-3, .fr-fr .confgpanel-specsandprice .c-price.c-heading-3,
.da-dk .confgpanel-specsandprice .c-price.c-heading-3, .en-nz .confgpanel-specsandprice .c-price.c-heading-3, 
.fr-lu .confgpanel-specsandprice .c-price.c-heading-3, .fi-fi .confgpanel-specsandprice .c-price.c-heading-3, 
.nb-no .confgpanel-specsandprice .c-price.c-heading-3,  
{
    font-size:22px;
    line-height:30px;
}
}

@media only screen and (max-width: 539px) {
    .en-au .confgpanel-specsandprice .c-price.c-heading-3, .fr-fr .confgpanel-specsandprice .c-price.c-heading-3,
    .en-nz .confgpanel-specsandprice .c-price.c-heading-3, .de-ch .confgpanel-specsandprice .c-price.c-heading-3,
    .fr-ch .confgpanel-specsandprice .c-price.c-heading-3, .da-dk .confgpanel-specsandprice .c-price.c-heading-3,
    .fr-lu .confgpanel-specsandprice .c-price.c-heading-3, .nb-no .confgpanel-specsandprice .c-price.c-heading-3,
    .pl-pl .confgpanel-specsandprice .c-price.c-heading-3, .sv-se .confgpanel-specsandprice .c-price.c-heading-3{
        font-size:20px;
        line-height:30px;
    }
    }
    
    
/*Accessories Browse Arabic*/
.rtl .surface-product-items{
    float:right;
}

.rtl #surfaceAllAccessories_Browse .surface-accessoriesgrid .surface-tags,
.rtl .surface-accessoriesgrid .surface-devicetype ,
.rtl .surface-accessoriesgrid .surface-collections{
    padding-right: 38px;
    padding-left: 0px;
}
@media only screen and (min-width: 1084px){
.rtl .surface-mosaic-with-features .c-mosaic [data-f-mosaic~=f-height-large] {
    border-left: 1px solid rgba(0,0,0,.2);
    border-right:0px;
}
}

@media only screen and (min-width: 1084px) and (max-width: 1399px)
{
.rtl .surface-mosaic-with-features .c-feature.f-align-right>div {
    right: 0;
}
}

@media only screen and (max-width: 768px)
{
.rtl #surfaceAllAccessories_Browse .surface-accessoriesgrid .surface-tags,
.rtl .surface-accessoriesgrid .surface-devicetype,
.rtl .surface-accessoriesgrid .surface-collections, {
    padding-right: 26px;
    padding-left: 0px;
}
}

@media only screen and (max-width: 1083px)
{
    .rtl .surface-mosaic-with-features .c-feature .c-call-to-action.c-glyph{
        float:right;
    }
    .rtl .surface-mosaic-with-features .c-feature[class*='f-align']>div{
        text-align: right;
    }
}
/* Arabic fix for business overview */
.rtl .m-product-placement.surface-business-touts ul li{
    float: right;
} 

html:not([lang|=en]) .surface-acc-pdp-m-hero.surface-top-84{
    margin-bottom: 100px;
}
/*.en-au .c-price meta+span, .en-au .c-price span
{
float: none;
}*/
.ar-ae a.c-call-to-action.c-glyph.surface-secondary-cta,
.ar-sa a.c-call-to-action.c-glyph.surface-secondary-cta{
    padding-left: 16px;
}
/*------------------------Mavis Hero------------------*/
@media only screen and (min-width: 768px){
body:not([class*='en-']) .c-feature.f-align-right.sur-custom-left picture ,body:not([class*='en-']) .m-feature.f-align-right.sur-custom-left picture  {
    float: right;
}
.fr-ca .c-feature.f-align-right.sur-custom-left picture ,.fr-ca .m-feature.f-align-right.sur-custom-left picture{
    float: left!important;
}
body:not([class*='en-']) .c-feature.f-align-right.sur-custom-left>div,body:not([class*='en-']) .m-feature.f-align-right.sur-custom-left>div {
    left: 0;
}
.fr-ca  .c-feature.f-align-right.sur-custom-left>div,.fr-ca  .m-feature.f-align-right.sur-custom-left>div{
    left:50%!important;
}
}

@media only screen and (max-width: 1083px){
body:not([class*='en-']) .c-feature.f-align-right.sur-custom-left picture,body:not([class*='en-']) .m-feature.f-align-right.sur-custom-left picture  {
    float: none;
} 

.fr-ca .c-feature.f-align-right.sur-custom-left picture ,.fr-ca .m-feature.f-align-right.sur-custom-left picture{
    float: none!important;
}
.fr-ca  .c-feature.f-align-right.sur-custom-left>div ,.fr-ca  .m-feature.f-align-right.sur-custom-left>div{
    left:0%!important;
}

}

@media only screen and (max-width: 1399px){		
 .fr-ca #surface-Studio-Overview .surface-studio-transparent-hero .m-hero-item>div>div{bottom:30px;} 		
}		
@media only screen and (max-width: 1200px) and (min-width:1084px){		
.fr-ca #surface-Studio-Overview .surface-studio-transparent-hero .m-hero-item>div>div{bottom:0;}		
}
.surface-pivot-hero-mob-margin .sur-color-undefined .c-pivot header[role='tablist']{margin:0;}

@media only screen and (min-width:1084px){
    .surface-pivot-hero-mob-margin .sur-color-undefined .c-pivot{padding-top:0;}    
    .surface-pivot-hero-mob-margin .sur-color-undefined .c-pivot .c-group{margin-top:0;}
    .de-de .m-lifestyle-feature>div>div, .pt-pt .m-lifestyle-feature>div>div,
    .de-ch .m-lifestyle-feature>div>div, .de-at .m-lifestyle-feature>div>div,
    .de-lu .m-lifestyle-feature>div>div, .nl-nl .m-lifestyle-feature>div>div, 
    .pl-pl .m-lifestyle-feature>div>div, /*.it-it .m-lifestyle-feature>div>div,*/
    .nl-be .m-lifestyle-feature>div>div{width:45%;} 
    /*.fr-ca .m-lifestyle-feature>div>div,.es-es .m-lifestyle-feature>div>div{width:47%;} */
    .fr-ca .m-lifestyle-feature.f-ratio-169.f-bottom-left>div>div{top:55%;} 
  
     .en-ca .offer-panel[data-vg='Surface_J_Offer_Hero_VG'] .c-heading-2,
    .en-ca .offer-panel[data-vg='Surface_Home_Offer_FeatureImagePriority_VG'] .c-heading-2,
    .es-es .offer-panel[data-vg='Surface_J_Offer_Hero_VG'] .c-heading-2,
    .es-es .offer-panel[data-vg='Surface_Home_Offer_FeatureImagePriority_VG'] .c-heading-2,
    .de-de .offer-panel[data-vg='Surface_J_Offer_Hero_VG'] .c-heading-2,
    .de-de .offer-panel[data-vg='Surface_Home_Offer_FeatureImagePriority_VG'] .c-heading-2,
    .fr-fr .offer-panel[data-vg='Surface_J_Offer_Hero_VG'] .c-heading-2,
    .fr-fr .offer-panel[data-vg='Surface_Home_Offer_FeatureImagePriority_VG'] .c-heading-2,
    .nl-nl .offer-panel[data-vg='Surface_J_Offer_Hero_VG'] .c-heading-2,
    .nl-nl .offer-panel[data-vg='Surface_Home_Offer_FeatureImagePriority_VG'] .c-heading-2,
    .nl-be .offer-panel[data-vg='Surface_J_Offer_Hero_VG'] .c-heading-2,
    .nl-be .offer-panel[data-vg='Surface_Home_Offer_FeatureImagePriority_VG'] .c-heading-2,
    .fr-be .offer-panel[data-vg='Surface_J_Offer_Hero_VG'] .c-heading-2,
    .fr-be .offer-panel[data-vg='Surface_Home_Offer_FeatureImagePriority_VG'] .c-heading-2,
    .it-it .offer-panel[data-vg='Surface_J_Offer_Hero_VG'] .c-heading-2,
    .it-it .offer-panel[data-vg='Surface_Home_Offer_FeatureImagePriority_VG'] .c-heading-2
    {
        font-size:30px;
        line-height:30px;
    }
    
    .fr-ca .offer-panel[data-vg='Surface_J_Offer_Hero_VG'] .c-heading-2,
    .fr-ca .offer-panel[data-vg='Surface_Home_Offer_FeatureImagePriority_VG'] .c-heading-2
    {
        font-size:26px;
        line-height:26px;
    }
    
    .ja-jp .offer-panel[data-vg='Surface_J_Offer_Hero_VG'] .c-heading-2,
    .ja-jp .offer-panel[data-vg='Surface_Home_Offer_FeatureImagePriority_VG'] .c-heading-2
    {
        font-size: 30px;
        line-height: 36px;
    }
}
@media only screen and (min-width: 1084px) and (max-width: 1399px) {
.ja-jp #surface-Studio-Overview .surface-studio-transparent-hero .m-hero-item>div>div{
bottom: 0px;
}
.rtl .c-pivot a{
padding-left:0px!important;
}
.fr-ca .surfacepro-techspecs-hero .m-hero-item .c-heading-1,
.zh-cn .surfacepro-techspecs-hero .m-hero-item .c-heading-1,
.sv-se .surfacepro-techspecs-hero .m-hero-item .c-heading-1, 
.nl-nl .surfacepro-techspecs-hero .m-hero-item .c-heading-1, 
.nb-no .surfacepro-techspecs-hero .m-hero-item .c-heading-1, 
.fr-fr .surfacepro-techspecs-hero .m-hero-item .c-heading-1, 
.fr-ch .surfacepro-techspecs-hero .m-hero-item .c-heading-1, 
.fi-fi .surfacepro-techspecs-hero .m-hero-item .c-heading-1, 
.de-de .surfacepro-techspecs-hero .m-hero-item .c-heading-1, 
.de-ch .surfacepro-techspecs-hero .m-hero-item .c-heading-1, 
.de-at .surfacepro-techspecs-hero .m-hero-item .c-heading-1, 
.da-dk .surfacepro-techspecs-hero .m-hero-item .c-heading-1, 
.fr-be .surfacepro-techspecs-hero .m-hero-item .c-heading-1, 
.nl-be .surfacepro-techspecs-hero .m-hero-item .c-heading-1, 
.fr-lu .surfacepro-techspecs-hero .m-hero-item .c-heading-1, 
.es-es .surfacepro-techspecs-hero .m-hero-item .c-heading-1, 
.pl-pl .surfacepro-techspecs-hero .m-hero-item .c-heading-1, 
.pt-pt .surfacepro-techspecs-hero .m-hero-item .c-heading-1, 
.th-th .surfacepro-techspecs-hero .m-hero-item .c-heading-1
{
    font-size: 46px;
    line-height: 56px;
    padding: 37px 0 3px;
}
}

.c-feature.f-align-center .surface-disabled-cta {
    margin-left: auto!important;
}
.rtl .confgpanel li:nth-child(2n+1){
padding-left:8px;
}

.rtl .m-panes-product-placement-item .c-group .c-call-to-action{
padding-right:20px;
}

@media only screen and (max-width: 1083px){
.rtl .m-multi-feature.f-align-left>section>div
{
  right:0%;
}
}

@media only screen and (min-width: 768px){
.en-us .c-feature.f-align-left.sur-custom-right picture,.en-au .c-feature.f-align-left.sur-custom-right picture,
.en-nz .c-feature.f-align-left.sur-custom-right picture,.fr-ca .c-feature.f-align-left.sur-custom-right picture,
.en-ca .c-feature.f-align-left.sur-custom-right picture,.zh-tw .c-feature.f-align-left.sur-custom-right picture,
.zh-hk .c-feature.f-align-left.sur-custom-right picture,.zh-cn .c-feature.f-align-left.sur-custom-right picture,
.ja-jp .c-feature.f-align-left.sur-custom-right picture,.en-hk .c-feature.f-align-left.sur-custom-right picture,
.en-us .m-feature.f-align-left.sur-custom-right picture,.en-au .m-feature.f-align-left.sur-custom-right picture,
.en-nz .m-feature.f-align-left.sur-custom-right picture,.fr-ca .m-feature.f-align-left.sur-custom-right picture,
.en-ca .m-feature.f-align-left.sur-custom-right picture,.zh-tw .m-feature.f-align-left.sur-custom-right picture,
.zh-hk .m-feature.f-align-left.sur-custom-right picture,.zh-cn .m-feature.f-align-left.sur-custom-right picture,
.ja-jp .m-feature.f-align-left.sur-custom-right picture,.en-hk .m-feature.f-align-left.sur-custom-right picture
 {
    float: left;
}
.en-us .c-feature.f-align-left.sur-custom-right>div,.en-au .c-feature.f-align-left.sur-custom-right>div,
.en-nz .c-feature.f-align-left.sur-custom-right>div,.fr-ca .c-feature.f-align-left.sur-custom-right>div,
.en-ca .c-feature.f-align-left.sur-custom-right>div,.zh-tw .c-feature.f-align-left.sur-custom-right>div,
.zh-hk .c-feature.f-align-left.sur-custom-right>div,.zh-cn .c-feature.f-align-left.sur-custom-right>div,
.ja-jp .c-feature.f-align-left.sur-custom-right>div,.en-hk .c-feature.f-align-left.sur-custom-right>div,
.en-us .m-feature.f-align-left.sur-custom-right>div,.en-au .m-feature.f-align-left.sur-custom-right>div,
.en-nz .m-feature.f-align-left.sur-custom-right>div,.fr-ca .m-feature.f-align-left.sur-custom-right>div,
.en-ca .m-feature.f-align-left.sur-custom-right>div,.zh-tw .m-feature.f-align-left.sur-custom-right>div,
.zh-hk .m-feature.f-align-left.sur-custom-right>div,.zh-cn .m-feature.f-align-left.sur-custom-right>div,
.ja-jp .m-feature.f-align-left.sur-custom-right>div,.en-hk .m-feature.f-align-left.sur-custom-right>div {
    right: 0;
    left: auto;
}
}

@media only screen and (max-width: 1083px){
.en-us .c-feature.f-align-left.sur-custom-right picture,.en-au .c-feature.f-align-left.sur-custom-right picture,
.en-nz .c-feature.f-align-left.sur-custom-right picture,.fr-ca .c-feature.f-align-left.sur-custom-right picture,
.en-ca .c-feature.f-align-left.sur-custom-right picture,.zh-tw .c-feature.f-align-left.sur-custom-right picture,
.zh-hk .c-feature.f-align-left.sur-custom-right picture,.zh-cn .c-feature.f-align-left.sur-custom-right picture,
.ja-jp .c-feature.f-align-left.sur-custom-right picture,.en-hk .c-feature.f-align-left.sur-custom-right picture,
.en-us .m-feature.f-align-left.sur-custom-right picture,.en-au .m-feature.f-align-left.sur-custom-right picture,
.en-nz .m-feature.f-align-left.sur-custom-right picture,.fr-ca .m-feature.f-align-left.sur-custom-right picture,
.en-ca .m-feature.f-align-left.sur-custom-right picture,.zh-tw .m-feature.f-align-left.sur-custom-right picture,
.zh-hk .m-feature.f-align-left.sur-custom-right picture,.zh-cn .m-feature.f-align-left.sur-custom-right picture,
.ja-jp .m-feature.f-align-left.sur-custom-right picture,.en-hk .m-feature.f-align-left.sur-custom-right picture {
    float: none;
}

}

.surface-high-contrast{
    background-color: #0078d7;
}
.high-contrast-mode .surface-typecover-pdp .swatch-color-list li, .high-contrast-mode .surface-multiview-feature .swatch-color-list li{
      border:#fff 1px solid !important;
  }
  .Edge.hcmode-black .surface-typecover-pdp .swatch-color-list li, .Edge.hcmode-black  .surface-multiview-feature .swatch-color-list li{
      border:#fff 1px solid !important;
  }
 .hcmode-black .surface-multifeature-pivot .m-multi-feature [role=tablist] li > a.c-logo.f-active{
     border:#2874f0 1px solid;
}

  
@media screen and (-ms-high-contrast: active) {
     surface-typecover-pdp .swatch-color-list li, .surface-multiview-feature .swatch-color-list li{
      border:#fff 1px solid !important;
  }
  a.c-hyperlink.surface-popup-video{text-decoration: none;}
  .surface-hero-pivot-multi-img .c-pivot .mscom-link img.mscom-image.icons:focus{z-index: 999;}
  
}

@media screen and (-ms-high-contrast: white-on-black) { 
      surface-typecover-pdp .swatch-color-list li, .surface-multiview-feature .swatch-color-list li{
      border:#fff 1px solid !important;
  }
/*bug 178214*/
.m-multi-feature [role=tablist] li>a.f-active.c-logo:focus{outline: #fff dashed 1px;}
.c-social>a:focus, .c-social>ul>li>a:focus, .m-social>a:focus, .m-social>ul>li>a:focus{
 padding:1px;   
 border:1px dashed #000;
}

.c-sequence-indicator a:before, .c-sequence-indicator button:before{
    border: 1px solid #FFF !important;
}

}
@media screen and (-ms-high-contrast: black-on-white) {
    surface-typecover-pdp .swatch-color-list li, .surface-multiview-feature .swatch-color-list li{
      border:#fff 1px solid !important;
  }

  .c-sequence-indicator button[aria-checked=true]:before, .c-sequence-indicator button[aria-selected=true]:before{background: #000;}
}

@media only screen and (min-width: 1400px) and (max-width: 1650px)
{
    .surface-studio-transparent-hero .m-hero-item .c-heading-2
    {
        font-size: 37px;
    }
}

.rtl .m-ambient-video div.c-toggle span
{
    float:right;
}
.surface-sp4-banner .wdg-theme-dark a.c-call-to-action.c-glyph:focus,.new-sp4-banner .newsp4bannercta a.c-call-to-action.c-glyph:focus {
    outline: #fff dashed 1px !important;
}
a.surface-bg-cta-blue span,a.c-call-to-action.surface-bg-cta-blue span {
    text-decoration: none !important;
}
.rtl .m-feature a.c-call-to-action.c-glyph.surface-bg-cta-blue 
{
    margin-right:0px;
}
.rtl .surface-dock-ports ol li
{
    float:right;
}
@media only screen and (max-width: 767px)
{
    .rtl .surface-dock-ports ol li
    {
         height: 76px;
    }
}

@media only screen and (min-width:1084px) and (max-width:1200px) {
   .fr-ca .m-feature .featurepanelwithimage_pad{
        padding-left: 0px !important;
        padding-right: 0px !important;
    }
}
@media only screen and (min-width:1084px) and (max-width:1120px){
    .fr-ca .dropdownNFL.dropdownNFL_pad{
        min-height: 400px !important;
    }
}
@media only screen and (min-width:1084px) and (max-width:1160px){
    .fr-ca .dropdownNFL.dropdownNFLcover_pad{
        min-height: 400px !important;
    }
}
.ar-ae section[data-vg='Surface_Home_OfferBanner_VG'],
.ar-sa section[data-vg='Surface_Home_OfferBanner_VG']{
    padding-top: 84px !important;
}

.fr-fr section[data-vg='Surface_Home_OfferBanner_VG']{
    padding-top: 40px;
}

/*.fr-be section[data-vg='Surface_Home_OfferBanner_VG'],
.fr-lu section[data-vg='Surface_Home_OfferBanner_VG'],
.nl-be section[data-vg='Surface_Home_OfferBanner_VG'],
.nl-nl section[data-vg='Surface_Home_OfferBanner_VG']
{
    padding-top: 84px;
}*/
.ar-ae .accolade-pad-bottom .c-paragraph-2,.ar-sa .accolade-pad-bottom .c-paragraph-2,.en-ae .accolade-pad-bottom .c-paragraph-2, 
.en-sa .accolade-pad-bottom .c-paragraph-2,.en-th .accolade-pad-bottom .c-paragraph-2,.en-in .accolade-pad-bottom .c-paragraph-2,.ko-kr .accolade-pad-bottom .c-paragraph-2,
.ar-qa .accolade-pad-bottom .c-paragraph-2,.th-th .accolade-pad-bottom .c-paragraph-2,.en-qa .accolade-pad-bottom .c-paragraph-2,.zh-tw .accolade-pad-bottom .c-paragraph-2{
    padding-bottom: 25px;
}

.ar-sa .surface-pivot-hero-mob-margin .c-pivot ul[role='tablist'] li{
    vertical-align: bottom;
    font-size: 0;
}

body:not([class*='en-']) .c-video.COS-video-hide{
    display: none;
}
body:not([class*='en-']) .Cos-image-hide{
    display: block !important;
}
.zh-cn .m-feature.f-align-center.ambient-padding>div{
    padding-left:0px;
    }

.rtl .surfacez-custom-pivot .c-image.active, .rtl .surfacez-custom-pivot .c-image.inactive{
    float: right;
    margin-left: 18px;
    margin-right:0px;
}
.rtl .surface-specsbanner .surface-indivspecs-container {
  border-left: 2px solid #f2f2f2;
  border-right:0;
}
.rtl .surface-specsbanner .surface-indivspecs-container:last-child {
    border-left:0;
}
@media only screen and (max-width: 1083px)
{
.rtl .surfacez-custom-pivot .c-logo .c-heading-3 {
    float: right;
}
.rtl .surfacez-custom-pivot .c-paragraph-2
{
    text-align: right;
}

.rtl .surfacez-custom-pivot .z-pivot 
{
    margin-right:0px;
}
}

.rtl .c-apps-panel .apps-wrapper .apps {
    float: right;
    padding-left: 20px;
}
@media only screen and (min-width: 768px)
{
.ja-jp #mwf-hero-carousel-with-video .c-heading-1
{
    font-size: 52px;
    line-height: 62px;
}
}
.rtl .surface-specsbanner .surface-indivspecs-container {
    border-left:0; 
}
@media only screen and (min-width:1150px) and (max-width:1400px){
.sv-se .m-hero.hero-heading-size .c-heading-1,.da-dk .m-hero.hero-heading-size .c-heading-1,.fi-fi .m-hero.hero-heading-size .c-heading-1,.nb-no .m-hero.hero-heading-size .c-heading-1{
    font-size:45px;
}
}
.ja-jp .book2-head .c-heading-1{
font-size:37px;
line-height:47px;
}
.wdg-m-prefooter nav.c-link-navigation.prefooternavlist-2 ul li {
    width: 32%;
}
@media only screen and (max-width: 767px){
.rtl .surface-filterbyhdng {
    float: right;
}
}
@media only screen and (max-width: 767px){
.rtl .dropdown-mobile:after {
    position: relative;
    float: left;
    right: 0px;
}
}
@media only screen and (max-width: 460px){
.ms-my .surface-accessories-categories .surface-filterby .surface-clearfilters .c-button{
    border-right-width: 0px;
    padding-right: 4px;
    padding-left: 4px;
}
}
.surface-laptop-fr-m3carsl{
  display: none;
}
.fr-fr .surface-laptop-fr-m3carsl{
  display: initial;
}

@media only screen and (min-width: 1084px)
{
.m-hero-item.f-transparent-47:before {
     padding-bottom: 47.5%; 
}
}.wdg-global  nav.c-link-nav li a.c-hyperlink p, .wdg-global  nav.c-link-nav5up li a.c-hyperlink p, .wdg-global  nav.c-link-nav4up li a.c-hyperlink p,
.wdg-global  nav.c-link-nav3up li a.c-hyperlink p,.wdg-global  nav.c-link-nav2up li a.c-hyperlink p, {
    font-size: 13px;
    font-weight: 700;

}

.pmp-devices .pad-top-0px{
    padding-top: 0px;
}

.pmp-devices .strongcontent{
    font-weight: 700;
}
.c-glyph.glyph-play:hover, .c-glyph.glyph-play:hover{
    text-decoration: underline !important;
}


a.c-action-trigger.c-glyph.glyph-play.dfc:before, button.c-action-trigger.c-glyph.glyph-play.dfc:before{
    margin-left: 0;
    margin-right: 4px;
    vertical-align: middle;
    
}


a.c-action-trigger.c-glyph.glyph-play:before, button.c-action-trigger.c-glyph.glyph-play:before{
    margin-right: 4px;
    
    position: relative;
    }
    
    #DFB section[data-vg='BusinessOverview_5_ImagePanel_VG'] a.c-action-trigger.glyph-play
{
    padding-top: 11px;
    display: inline-block;
    vertical-align: middle;
}

      #DFB .surface-dual-cta a.c-action-trigger.glyph-play
{
    padding-top: 11px;
    display: inline-block;
    vertical-align: middle;
}
/*Generic Panel product placement6UP*/

@media screen and (min-width:1400px){

nav.c-link-nav li a.c-hyperlink picture{
	max-height: 240px;
}
nav.c-link-nav li.list-items{
  display: block; 
  width: 16.6666%; 
  float: left;
  text-align: center;
  margin-right: 0px;
  
  padding-left:12px;
padding-right:12px;
}


nav.c-link-nav li.list-items picture img {
  max-width: 100%;
  max-height: 100%;
}

}

@media screen and (min-width:1084px) and (max-width: 1399px){


nav.c-link-nav li a.c-hyperlink picture{
	max-height: 240px;
}
nav.c-link-nav li.list-items{
  display: block; 
  width: 16.6666%; 
  float: left;
  text-align: center;
  margin-right: 0px;
  padding-left:12px;
  padding-right:12px;
}


nav.c-link-nav li.list-items picture img {
  max-width: 100%;
  max-height: 100%;
}
nav.c-link-nav .list-items a.c-hyperlink.f-image
{
	display: block;
    text-align: center;
}
}

@media screen and (min-width:540px) and (max-width: 1083px){


.pad-bottom-thin
    {
        margin-bottom:36px;
    }
.c-feature.f-align-left picture, .c-feature.f-align-right picture {
    width: 100%;
}

  nav.c-link-nav li.list-items {
    width: 48%;
        margin-left: 1%;
        margin-right: 1%;
    display: inline-block;
   
     text-align: center;
     float: left;

}
nav.c-link-nav li.list-items picture img {
  max-width: 100%;
  max-height: 100%;
}
nav.c-link-nav .list-items a.c-hyperlink.f-image
{
	display: block;
    text-align: center;
}

}


@media all and (max-width:539px){

    nav.c-link-nav li.list-items a.c-hyperlink picture {
        text-align: center;
        display: block;
    }
    nav.c-link-nav li.list-items {
    width: 48%;
        margin-left: 1%;
        margin-right: 1%;
     text-align: center;
     float: left;
    }
    nav.c-link-nav li.list-items a.c-hyperlink picture img {
    width: 120px;
    height: 120px;
    }
}


/*End of Generic Panel product placement 6UP*/

/*Generic Panel product placement5UP*/

@media screen and (min-width:1400px){

nav.c-link-nav5up li a.c-hyperlink picture{
	max-height: 240px;
}
nav.c-link-nav5up li.list-items{
  display: block; 
  width: 20%; 
  float: left;
  text-align: center;
  margin-right: 0px;
}


nav.c-link-nav5up li.list-items picture img {
  max-width: 100%;
  max-height: 100%;
}

}

@media screen and (min-width:1084px) and (max-width: 1399px){


nav.c-link-nav5up li a.c-hyperlink picture{
	max-height: 240px;
}
nav.c-link-nav5up li.list-items{
  display: block; 
  width: 18%; 
  float: left;
  text-align: center;
  margin-right: 2%;
}


nav.c-link-nav5up li.list-items picture img {
  max-width: 100%;
  max-height: 100%;
}

}

@media screen and (min-width:540px) and (max-width: 1083px){


.pad-bottom-thin
    {
        margin-bottom:36px;
    }
.c-feature.f-align-left picture, .c-feature.f-align-right picture {
    width: 100%;
}

  nav.c-link-nav5up li.list-items {
    width: 48%;
        margin-left: 1%;
        margin-right: 1%;
    display: inline-block;
    float: left;
  text-align: center;

}
nav.c-link-nav5up li.list-items picture img {
  max-width: 100%;
  max-height: 100%;
}

}


@media all and (max-width:539px){

    nav.c-link-nav5up li.list-items a.c-hyperlink picture {
        text-align: center;
        display: block;
    }
    nav.c-link-nav5up li.list-items {
    width: 48%;
        margin-left: 1%;
        margin-right: 1%;
    float: left;
    text-align: center;
    
    
    }
    nav.c-link-nav5up li.list-items a.c-hyperlink picture img {
    width: 120px;
    height: 120px;
    }
}


/*End of Generic Panel product placement 5UP*/

/*Generic Panel product placement4UP*/

@media screen and (min-width:1400px){

nav.c-link-nav4up li a.c-hyperlink picture{
	max-height: 240px;
}
nav.c-link-nav4up li.list-items{
  display: block; 
  width: 23%;
  margin-left: 1%;
  margin-right: 1%; 
  float: left;
  text-align: center;
  
}


nav.c-link-nav4up li.list-items picture img {
  max-width: 100%;
  max-height: 100%;
}

}
/*pmp pages banner component padding override*/
@media only screen and (max-width: 1083px)
{
.pmp-devices .m-banner .c-heading-2{
padding-top:38px;
}
}
/*pmp pages banner component padding override end*/

@media screen and (min-width:1084px) and (max-width: 1399px){


nav.c-link-nav4up li a.c-hyperlink picture{
	max-height: 240px;
}
nav.c-link-nav4up li.list-items{
  display: block; 
  width: 23%;
  margin-left: 1%;
  margin-right: 1%; 
  float: left;
  text-align: center;

}


nav.c-link-nav4up li.list-items picture img {
  max-width: 100%;
  max-height: 100%;
}

}

@media screen and (min-width:540px) and (max-width: 1083px){


.pad-bottom-thin
    {
        margin-bottom:36px;
    }
.c-feature.f-align-left picture, .c-feature.f-align-right picture {
    width: 100%;
}

  nav.c-link-nav4up li.list-items {
    width: 50;
    display: inline-block;
    float: left;
    text-align: center;

}
nav.c-link-nav4up li.list-items picture img {
  max-width: 100%;
  max-height: 100%;
}


}


@media all and (max-width:539px){

    nav.c-link-nav4up li.list-items a.c-hyperlink picture {
        text-align: center;
        display: block;
    }
    nav.c-link-nav4up li.list-items {
    width: 48%;
        margin-left: 1%;
        margin-right: 1%;
    float: left;
  text-align: center;
    
    }
    nav.c-link-nav4up li.list-items a.c-hyperlink picture img {
    width: 120px;
    height: 120px;
    }
}


/*End of Generic Panel product placement 4UP*/

/*Generic Panel product placement3UP*/

@media screen and (min-width:1400px){

nav.c-link-nav3up li a.c-hyperlink picture{
	max-height: 240px;
}
nav.c-link-nav3up li.list-items{
  display: block; 
  width: 33.32%; 
  float: left;
  text-align: center;
  margin-right: 0px;
}


nav.c-link-nav3up li.list-items picture img {
  max-width: 100%;
  max-height: 100%;
}

}

@media screen and (min-width:1084px) and (max-width: 1399px){


nav.c-link-nav3up li a.c-hyperlink picture{
	max-height: 240px;
}
nav.c-link-nav3up li.list-items{
  display: block; 
  width: 33.32%; 
  float: left;
  text-align: center;
  margin-right: 0px;
}


nav.c-link-nav3up li.list-items picture img {
  max-width: 100%;
  max-height: 100%;
}
}

@media screen and (min-width:540px) and (max-width: 1083px){


.c-feature.f-align-left picture, .c-feature.f-align-right picture {
    width: 100%;
}

  nav.c-link-nav3up li.list-items {
    width: 48%;
        margin-left: 1%;
        margin-right: 1%;
    display: inline-block;
    float: left;
  text-align: center;

}
nav.c-link-nav3up li.list-items picture img {
  max-width: 100%;
  max-height: 100%;
}


}


@media all and (max-width:539px){

    nav.c-link-nav3up li.list-items a.c-hyperlink picture {
        text-align: center;
        display: block;
    }
    nav.c-link-nav3up li.list-items {
    width: 48%;
        margin-left: 1%;
        margin-right: 1%;
    float: left;
     text-align: center;
    
    }
    nav.c-link-nav3up li.list-items a.c-hyperlink picture img {
    width: 120px;
    height: 120px;
    }
}


/*End of Generic Panel product placement 3UP*/

/*Generic Panel product placement2UP*/

@media screen and (min-width:1400px){

nav.c-link-nav2up li a.c-hyperlink picture{
	max-height: 240px;
}
nav.c-link-nav2up li.list-items{
  display: block; 
  width: 48%;
        margin-left: 1%;
        margin-right: 1%; 
  float: left;
  text-align: center;
}


nav.c-link-nav2up li.list-items picture img {
  max-width: 100%;
  max-height: 100%;
}

}

@media screen and (min-width:1084px) and (max-width: 1399px){


nav.c-link-nav2up li a.c-hyperlink picture{
	max-height: 240px;
}
nav.c-link-nav2up li.list-items{
  display: block; 
  width: 48%;
  margin-left: 1%;
  margin-right: 1%;
  float: left;
  text-align: center;

}


nav.c-link-nav2up li.list-items picture img {
  max-width: 100%;
  max-height: 100%;
}

}

@media screen and (min-width:540px) and (max-width: 1083px){


.c-feature.f-align-left picture, .c-feature.f-align-right picture {
    width: 100%;
}

  nav.c-link-nav2up li.list-items {
    width: 48%;
    margin-left: 1%;
    margin-right: 1%;
    display: inline-block;
    float: left;
    text-align: center;

}
nav.c-link-nav2up li.list-items picture img {
  max-width: 100%;
  max-height: 100%;
}


}


@media all and (max-width:539px){

    nav.c-link-nav2up li.list-items a.c-hyperlink picture {
        text-align: center;
        display: block;
    }
    nav.c-link-nav2up li.list-items {
    float: left;
  text-align: center;
    
    }
    nav.c-link-nav2up li.list-items a.c-hyperlink picture img {
    width: 120px;
    height: 120px;
    }
}


/*End of Generic Panel product placement 2UP*/

/*start  Panel bottom spacing for product palcement panel */

@media only screen and (max-width: 539px) {
    nav.c-link-nav li.list-items{
	min-height: 250px;
}
nav.c-link-nav5up li.list-items{
	min-height: 250px;
}
nav.c-link-nav4up li.list-items{
	min-height: 250px;
}
nav.c-link-nav3up li.list-items{
	min-height: 250px;
}
    nav.c-link-nav5up li.list-items{
    min-height: 250px;
    }
}

@media only screen and (min-width:540px) and (max-width: 1083px) {
 nav.c-link-nav li.list-items{
	min-height: 330px;
}
nav.c-link-nav5up li.list-items{
	min-height: 330px;
}
nav.c-link-nav4up li.list-items{
	min-height: 330px;
}
nav.c-link-nav3up li.list-items{
	min-height: 330px;
}
    nav.c-link-nav5up li.list-items{
    min-height: 330px;
    }
}
 /*end  Panel bottom spacing for product palcement panel */
 
 /* table heading font size update*/
 .devicesforbusiness  thead th, .devicesforbusiness .c-table thead th button{
   font-size: 15px;
 }
 
 /* End of table heading font size update*/
 
nav.c-link-nav li a.c-hyperlink.f-image:focus p, nav.c-link-nav li a.c-hyperlink.f-image:hover p,
nav.c-link-nav5up li a.c-hyperlink.f-image:focus p, nav.c-link-nav5up li a.c-hyperlink.f-image:hover p,
nav.c-link-nav4up li a.c-hyperlink.f-image:focus p, nav.c-link-nav4up li a.c-hyperlink.f-image:hover p,
nav.c-link-nav3up li a.c-hyperlink.f-image:focus p, nav.c-link-nav3up li a.c-hyperlink.f-image:hover p,
nav.c-link-nav2up li a.c-hyperlink.f-image:focus p, nav.c-link-nav2up li a.c-hyperlink.f-image:hover p
{
    text-decoration: underline !important;
}
nav .list-items a{display:inline-block;}
a.c-action-trigger.glyph-play{border-left-width: 0px;}
/*overide 7up in overview page*/
@media only screen and (max-width: 540px)
{
  #DFB .m-product-placement.surface-business-touts .m-product-placement-item.f-size-medium
  {
    margin:0 2%;
  }
  
}
@media only screen and (min-width: 1084px)
{  
#DFB .m-product-placement.surface-business-touts .m-product-placement-item.f-size-medium{
  margin:0px; padding:5%;
}
 #DFB .m-product-placement.surface-business-touts .surface-touts-list-seven-items ul li:last-child .m-product-placement-item{margin-right: 0px;}
}
@media only screen and (max-width: 1083px)
{
  #DFB .m-product-placement.surface-business-touts ul li
  {
       min-height:  250px !important;
  }
   
}
#DFB .m-feature>div .c-call-to-action{padding-right:10px;display:inline-block;vertical-align:middle;padding-bottom:7px;}
.pmp-devices .addSpace{padding-top:18px;}
#DFB nav.c-link-nav4up .list-items a p,
#DFB nav.c-link-nav3up .list-items a p,
#DFB nav.c-link-nav2up .list-items a p,
#DFB nav.c-link-nav5up .list-items a p,
#DFB nav.c-link-nav6up .list-items a p,
#DFB nav.c-link-nav7up .list-items a p{margin-top:18px;}
/*fixing padding issues for hr line*/
.pmp-devices hr.c-divider{border-bottom:1px solid rgba(0,0,0,.2); border-top:0px }
/*fixing padding issues for hr line end*/
.pmp-devices #shell-category-header-cta, .context-uhf .theme-light.js-cat-head .c-call-to-action.c-glyph{
  display: none;
}


/*Family of Devices product placement panel*/

/*** Devices Business Product Placement6UP Item ***/

.m-product-placement.devices-business-touts6up ul li {
    float:left;
    text-align: center;
}

.m-product-placement.devices-business-touts6up .m-product-placement-item.f-size-medium>a>div {
    padding-right:0px;
}

.m-product-placement.devices-business-touts6up .m-product-placement-item.f-size-medium {
    width: auto;
}

.m-product-placement.devices-business-touts6up .m-product-placement-item picture img{
    max-height: 100%;
    max-width: 100%;
}

.m-product-placement.devices-business-touts6up .m-product-placement-item picture img, 
.m-product-placement.devices-business-touts6up .m-product-placement-item picture {
    display: block;
    outline: transparent;
}

.m-product-placement.devices-business-touts6up picture.c-image img {
    margin:0 auto;
    
}

.m-product-placement.devices-business-touts6up {
    padding-top:0px;
}

.m-product-placement.devices-business-touts6up .m-product-placement-item {
    margin-top: 0px;
}

.m-product-placement.devices-business-touts6up .c-heading {
    padding-top:0px;
}

@media (min-width: 540px) and (max-width: 1083px) {

    .m-product-placement.devices-business-touts6up {
        
        float: none;
        margin: 0 auto;
    }
    .m-product-placement.devices-business-touts6up li {
        width: 48%;
        margin-left: 1%;
        margin-right: 1%;
        
    }
    

}

@media screen and (max-width: 539px) {
    
 
    .m-product-placement.devices-business-touts6up li{
        width: 48%;
        margin-left: 1%;
        margin-right: 1%;
       
    }
    .surface-compare-deviceimgblock .c-checkbox .c-label {
         margin-top: 0px;
    }
    .m-product-placement.devices-business-touts6up .m-product-placement-item.f-size-medium {
    width: 100%;
}
    
}

@media screen and (min-width: 1084px) {
    
    .m-product-placement.devices-business-touts6up .devices-touts-list6up {
        margin: 0 auto;
        float: none;
    }
    
    .m-product-placement.devices-business-touts6up ul li {
        width: 16.66%;
    }
    
  
    
}


/***Family of Devices  Product Placement6UP Item END ***/

/*** Devices Business Product Placement5UP Item ***/

.m-product-placement.devices-business-touts5up ul li {
    float:left;
    text-align: center;
}

.m-product-placement.devices-business-touts5up .m-product-placement-item.f-size-medium>a>div {
    padding-right:0px;
}

.m-product-placement.devices-business-touts5up .m-product-placement-item.f-size-medium {
    width: auto;
}

.m-product-placement.devices-business-touts5up .m-product-placement-item picture img{
    max-height: 100%;
    max-width: 100%;
}

.m-product-placement.devices-business-touts5up .m-product-placement-item picture img, 
.m-product-placement.devices-business-touts5up .m-product-placement-item picture {
    display: block;
    outline: transparent;
}

.m-product-placement.devices-business-touts5up picture.c-image img {
    margin:0 auto;
    
}

.m-product-placement.devices-business-touts5up {
    padding-top:0px;
}

.m-product-placement.devices-business-touts5up .m-product-placement-item {
    margin-top: 0px;
}

.m-product-placement.devices-business-touts5up .c-heading {
    padding-top:0px;
}

@media (min-width: 540px) and (max-width: 1083px) {

    .m-product-placement.devices-business-touts5up {
        
        float: none;
        margin: 0 auto;
    }
    .m-product-placement.devices-business-touts5up li {
        width: 48%;
        margin-left: 1%;
        margin-right: 1%;
    }
    
.m-product-placement.devices-business-touts5up ul li:last-child {
        margin-left: 33.3%;
    }
    
}

@media screen and (max-width: 539px) {
    
    .m-product-placement.devices-business-touts5up li {
        width: 48%;
        margin-left: 1%;
        margin-right: 1%;
    }
    
 
    .surface-compare-deviceimgblock .c-checkbox .c-label {
         margin-top: 0px;
    }
    .m-product-placement.devices-business-touts5up .m-product-placement-item.f-size-medium {
    width: 100%;
}

.m-product-placement.devices-business-touts5up ul li:last-child {
        margin-left: 33.3%;
    }
    
}

@media screen and (min-width: 1084px) {
    
    .m-product-placement.devices-business-touts5up .devices-touts-list5up {
        margin: 0 auto;
        float: none;
    }
    
    .m-product-placement.devices-business-touts5up ul li {
        width: 20%;
    }
    
 
    
}


/***Family of Devices  Product Placement5UP Item END ***/


/*** Devices Business Product Placement4UP Item ***/

.m-product-placement.devices-business-touts4up ul li {
    float:left;
        text-align: center;
}

.m-product-placement.devices-business-touts4up .m-product-placement-item.f-size-medium>a>div {
    padding-right:0px;
}

.m-product-placement.devices-business-touts4up .m-product-placement-item.f-size-medium {
    width: auto;
}

.m-product-placement.devices-business-touts4up .m-product-placement-item picture img{
    max-height: 100%;
    max-width: 100%;
}

.m-product-placement.devices-business-touts4up .m-product-placement-item picture img, 
.m-product-placement.devices-business-touts4up .m-product-placement-item picture {
    display: block;
    outline: transparent;
}

.m-product-placement.devices-business-touts4up picture.c-image img {
    margin:0 auto;
    
}

.m-product-placement.devices-business-touts4up {
    padding-top:0px;
}

.m-product-placement.devices-business-touts4up .m-product-placement-item {
    margin-top: 0px;
}

.m-product-placement.devices-business-touts4up .c-heading {
    padding-top:0px;
}

@media (min-width: 540px) and (max-width: 1083px) {

    .m-product-placement.devices-business-touts4up {
        
        float: none;
        margin: 0 auto;
    }
    .m-product-placement.devices-business-touts4up li {
        width: 48%;
        margin-left: 1%;
        margin-right: 1%;
    }
     
}

@media screen and (max-width: 539px) {
    
    .m-product-placement.devices-business-touts4up li {
        width: 48%;
        margin-left: 1%;
        margin-right: 1%;
    }
    
    .surface-compare-deviceimgblock .c-checkbox .c-label {
         margin-top: 0px;
    }
    .m-product-placement.devices-business-touts4up .m-product-placement-item.f-size-medium {
    width: 100%;
}
    
}

@media screen and (min-width: 1084px) {
    
    .m-product-placement.devices-business-touts4up .devices-touts-list4up {
        margin: 0 auto;
        float: none;
    }
    
    .m-product-placement.devices-business-touts4up ul li {
        width: 23%;
        margin-left: 1%;
        margin-right: 1%; 
    }
    
  
    
}


/***Family of Devices  Product Placement4UP Item END ***/


/*** Devices Business Product Placement3UP Item ***/

.m-product-placement.devices-business-touts3up ul li {
    float:left;
    text-align: center;
}

.m-product-placement.devices-business-touts3up .m-product-placement-item.f-size-medium>a>div {
    padding-right:0px;
}

.m-product-placement.devices-business-touts3up .m-product-placement-item.f-size-medium {
    width: auto;
}

.m-product-placement.devices-business-touts3up .m-product-placement-item picture img{
    max-height: 100%;
    max-width: 100%;
}

.m-product-placement.devices-business-touts3up .m-product-placement-item picture img, 
.m-product-placement.devices-business-touts3up .m-product-placement-item picture {
    display: block;
    outline: transparent;
}

.m-product-placement.devices-business-touts3up picture.c-image img {
    margin:0 auto;
    
}

.m-product-placement.devices-business-touts3up {
    padding-top:0px;
}

.m-product-placement.devices-business-touts3up .m-product-placement-item {
    margin-top: 0px;
}

.m-product-placement.devices-business-touts3up .c-heading {
    padding-top:0px;
}

@media (min-width: 540px) and (max-width: 1083px) {

    .m-product-placement.devices-business-touts3up {
        
        float: none;
        margin: 0 auto;
    }
    .m-product-placement.devices-business-touts3up li {
        width: 48%;
        margin-left: 1%;
        margin-right: 1%;
    }
    
.m-product-placement.devices-business-touts3up ul li:last-child {
        margin-left: 25%;
    }
    
}

@media screen and (max-width: 539px) {
    
    .m-product-placement.devices-business-touts3up li {
        width: 48%;
        margin-left: 1%;
        margin-right: 1%;
    }
    
 
    .surface-compare-deviceimgblock .c-checkbox .c-label {
         margin-top: 0px;
    }
    .m-product-placement.devices-business-touts3up .m-product-placement-item.f-size-medium {
    width: 100%;
}

.m-product-placement.devices-business-touts3up ul li:last-child {
        margin-left: 25%;
    }
    
}

@media screen and (min-width: 1084px) {
    
    .m-product-placement.devices-business-touts3up .devices-touts-list3up {
        margin: 0 auto;
        float: none;
    }
    
    .m-product-placement.devices-business-touts3up ul li {
        width: 33.33%;
    }
    
 
    
}


/***Family of Devices  Product Placement3UP Item END ***/

/*** Devices Business Product Placement2UP Item ***/

.m-product-placement.devices-business-touts2up ul li {
    float:left;
    text-align: center;
}

.m-product-placement.devices-business-touts2up .m-product-placement-item.f-size-medium>a>div {
    padding-right:0px;
}

.m-product-placement.devices-business-touts2up .m-product-placement-item.f-size-medium {
    width: auto;
}

.m-product-placement.devices-business-touts2up .m-product-placement-item picture img{
    max-height: 100%;
    max-width: 100%;
}

.m-product-placement.devices-business-touts2up .m-product-placement-item picture img, 
.m-product-placement.devices-business-touts2up .m-product-placement-item picture {
    display: block;
    outline: transparent;
}

.m-product-placement.devices-business-touts2up picture.c-image img {
    margin:0 auto;
    
}

.m-product-placement.devices-business-touts2up {
    padding-top:0px;
}

.m-product-placement.devices-business-touts2up .m-product-placement-item {
    margin-top: 0px;
}

.m-product-placement.devices-business-touts2up .c-heading {
    padding-top:0px;
}

@media (min-width: 540px) and (max-width: 1083px) {

    .m-product-placement.devices-business-touts2up {
        
        float: none;
        margin: 0 auto;
    }
    .m-product-placement.devices-business-touts2up li {
        width: 48%;
        margin-left: 1%;
        margin-right: 1%;
    }
    

    
}

@media screen and (max-width: 539px) {
    
   
    .m-product-placement.devices-business-touts2up li {
        width: 48%;
        margin-left: 1%;
        margin-right: 1%;
    }

    .surface-compare-deviceimgblock .c-checkbox .c-label {
         margin-top: 0px;
    }
    .m-product-placement.devices-business-touts2up .m-product-placement-item.f-size-medium {
    width: 100%;
}

    
}

@media screen and (min-width: 1084px) {
    
    .m-product-placement.devices-business-touts2up .devices-touts-list2up {
        margin: 0 auto;
        float: none;
    }
    
   
 .m-product-placement.devices-business-touts2up ul li
{
        width: 48%;
        margin-left: 1%;
        margin-right: 1%;
       
}

.m-product-placement.devices-business-touts2up ul li section
{
   margin-right: 0px;
}
}

    


/***Family of Devices  Product Placement2UP Item END ***/

/*start  Panel bottom spacing for product placement panel */

@media only screen and (max-width: 500px) {

.m-product-placement.devices-business-touts6up ul li,
.m-product-placement.devices-business-touts5up ul li,
.m-product-placement.devices-business-touts4up ul li,
.m-product-placement.devices-business-touts3up ul li,
.m-product-placement.devices-business-touts2up ul li
 {
	min-height: 250px;
}
.m-product-placement.devices-business-touts6up ul li:last-child, .m-product-placement.devices-business-touts6up ul li:nth-last-child(2),
.m-product-placement.devices-business-touts4up ul li:last-child, .m-product-placement.devices-business-touts4up ul li:nth-last-child(2),
.m-product-placement.devices-business-touts2up ul li:last-child, .m-product-placement.devices-business-touts2up ul li:nth-last-child(2),
.m-product-placement.devices-business-touts5up ul li:last-child, .m-product-placement.devices-business-touts3up ul li:last-child{
	min-height: 0px;
}
}

@media only screen and (min-width:501px) and (max-width: 767px) {

.m-product-placement.devices-business-touts6up ul li,
.m-product-placement.devices-business-touts5up ul li,
.m-product-placement.devices-business-touts4up ul li,
.m-product-placement.devices-business-touts3up ul li,
.m-product-placement.devices-business-touts2up ul li{
	min-height: 280px;
}
.m-product-placement.devices-business-touts6up ul li:last-child, .m-product-placement.devices-business-touts6up ul li:nth-last-child(2),
.m-product-placement.devices-business-touts4up ul li:last-child, .m-product-placement.devices-business-touts4up ul li:nth-last-child(2),
.m-product-placement.devices-business-touts2up ul li:last-child, .m-product-placement.devices-business-touts2up ul li:nth-last-child(2),
.m-product-placement.devices-business-touts5up ul li:last-child, .m-product-placement.devices-business-touts3up ul li:last-child{
	min-height: 0px;
}
}

@media only screen and (min-width:768px) and (max-width: 1083px) {

.m-product-placement.devices-business-touts6up ul li,
.m-product-placement.devices-business-touts5up ul li,
.m-product-placement.devices-business-touts4up ul li,
.m-product-placement.devices-business-touts3up ul li,
.m-product-placement.devices-business-touts2up ul li{
	min-height: 333px;
}
.m-product-placement.devices-business-touts6up ul li:last-child, .m-product-placement.devices-business-touts6up ul li:nth-last-child(2),
.m-product-placement.devices-business-touts4up ul li:last-child, .m-product-placement.devices-business-touts4up ul li:nth-last-child(2),
.m-product-placement.devices-business-touts2up ul li:last-child, .m-product-placement.devices-business-touts2up ul li:nth-last-child(2),
.m-product-placement.devices-business-touts5up ul li:last-child, .m-product-placement.devices-business-touts3up ul li:last-child{
	min-height: 0px;
}
}
 /*end  Panel bottom spacing for product placement panel */
/*Add click functionality on content-placement item hover*/ 

 .pmp-devices .m-content-placement-item[data-js-href]:hover .c-heading,.pmp-devices .m-content-placement-item[data-js-href]:hover a span {
     text-decoration: none;
 } 
  .pmp-devices .m-content-placement-item[data-js-href]:hover picture img{
      opacity: 1;
  }
 .pmp-devices .m-content-placement-item:not([data-js-href]):hover .c-heading,.pmp-devices .m-content-placement-item:not([data-js-href]):hover a span
 {
     text-decoration: none;
 }
 .pmp-devices .m-content-placement-item:not([data-js-href]):hover{
     cursor: default;
 }
 /* End of adding click functionality on content-placement item hover*/
 
  /*pmp page two cta issue in mobile viewport*/
 @media all and (max-width:539px){

.pmp-devices .m-banner a.c-call-to-action:nth-of-type(2), .pmp-devices .m-ratings-and-reviews a.c-call-to-action:nth-of-type(2)
{
    margin-top: 0px;
}
}
/*pmp page two cta issue in mobile viewport end*/

/*new sp banner*/

.pmp-devices .new-sp-banner .newspbannercta{
    padding-left: 1%;
}
.pmp-devices .newspbannertext .c-heading-4{
padding-top:42px;
}
.pmp-devices .newspbannertext .c-paragraph-2 {
padding-top:5px;
padding-bottom: 20px;
}
.pmp-devices .new-sp-banner .newspbannertext {
    padding-left: 20px;
}
@media only screen and (min-width:540px){
.pmp-devices .newspbannercta .c-glyph:after
{
position: absolute;
}
}

@media only screen and (max-width:767px){
.pmp-devices .new-sp-banner .pmp-devices .newspbannertext {
    padding-top: 10px;
}
}
@media only screen and (min-width: 768px){
.pmp-devices .new-sp-banner .newspbannercta .c-call-to-action{
    margin-top: 40px;
    padding-right: 40px;
}
}
@media only screen and (max-width: 539px){
   .pmp-devices .newspbannertext .c-heading-4, .pmp-devices .newspbannertext .c-paragraph-2{
padding-top:15px;
}
.pmp-devices .new-sp-banner{
    text-align: center;
    padding-top: 15px;
    }
.pmp-devices .newspbannercta .c-call-to-action{
    padding-right: 0px; 
}
.pmp-devices .newspbannertext{
    padding-left: 0px ;
} 
.pmp-devices .new-sp-banner .newspbannertext {
    padding-left: 0px !important;
}
} 
@media only screen and (max-width: 1083px) and (min-width: 540px){
.pmp-devices .new-sp-banner .newspbannertext[data-grid~=col-9] {
    width: 65% !important;
}
.pmp-devices .new-sp-banner .newspbannertext {
    padding-left: 0px !important;
}
}
@media only screen and (min-width:540px) and (max-width:767px){
.pmp-devices .new-sp-banner img
{
    width: 100%;
}
.pmp-devices .newspbannertext .c-heading-4{
padding-top:10px;
}
 .pmp-devices .newspbannertext .c-paragraph-2 {
padding-top:5px;
padding-bottom: 15px;
}  
.pmp-devices .newspbannertext .newspbannercta{
    padding-bottom: 0px;
    padding-top: 15px;
}
.vertical-center-vp2{
    display: -ms-flexbox;
    display: flex;
    -ms-flex-pack: justify;
    justify-content: space-between;
    -ms-flex-align: center;
    align-items: center 
}
}
/*RTL pro-4- banner live area fix*/
@media only screen and (max-width: 1083px)
{
.rtl .pmp-devices .new-sp4-banner .newsp4bannercta{
 padding-left: 24px;
}
.rtl .pmp-devices .new-sp4-banner .newsp4bannertext
{
    padding-right: 20px;
}
}
/*RTL pro-4- banner live area fix end*/


/*Zap page fixes*/
@media only screen and (min-width: 1084px)
{
    .pmp-devices .surface-performance-specsbanner .surface-indivspecs-container{
        padding-top: 24px;
    padding-bottom: 36px;
        
    }
    
}

/*.pmp-devices .surfacez-custom-pivot header section.f-active+a{margin-top:8px;}
.pmp-devices .surfacez-custom-pivot a.c-logo{margin-top: 10px;}
.pmp-devices .surfacez-custom-pivot .c-logo .c-heading-3{ margin-left: 60px; margin-top:8px;}*/
.pmp-devices .surfacez-custom-pivot a.c-logo{height:auto;/*margin-top: 20px;*/}
.pmp-devices .surfacez-custom-pivot .c-image.inactive{margin-right: 16px;}
.pmp-devices .surfacez-custom-pivot header .c-logo:not(.f-active):hover img{outline: 1px dashed #000;}
.pmp-devices .PMP-Custom .f-y-center.f-transparent>div>div{top: calc(50%)}
.pmp-devices .surface-performance-article.m-content-placement-item,.pmp-devices .surface-performance-specswrap.m-content-placement-item{cursor: default; pointer-events: none;}
.pmp-devices .surface-performance-specsbanner .m-content-placement-item .c-call-to-action:hover span{text-decoration:underline;}
.pmp-devices .surface-performance-specsbanner [data-grid~=pad-6x] ul>li[data-grid]{
    padding-left: 12px;
    padding-right: 12px;
}

.fr-fr .pmp-devices .surface-performance-specsbanner [data-grid~=pad-6x] ul>li[data-grid]
{
    padding-left: 10px;
    padding-right: 12px;
}
.ja-jp .pmp-devices .surface-performance-specsbanner [data-grid~=pad-6x] ul>li[data-grid] 
  {
    padding-left: 8px;
    padding-right: 0px;
}
@media only screen and (min-width: 1083px){
.ja-jp .pmp-devices .surface-performance-specswrap m-rich-content-block[data-grid~=pad-6x] {padding-left: 24px; padding-right: 12px;}
}

@media only screen and (max-width:1083px){
     .pmp-devices .surfacez-custom-pivot ul li{margin-top: 9px !important;}
.pmp-devices .surfacez-custom-pivot header section.f-active{margin-top: 10px; margin-bottom:10px;}
/*.pmp-devices .surfacez-custom-pivot a.c-logo:nth-child(1) {
    margin-top: 10px;
}*/
.pmp-devices .surfacez-custom-pivot .c-paragraph-2{padding-top:14px;padding-bottom:10px;}
.pmp-devices .surfacez-custom-pivot header section.f-active+a{margin-top:8px;}
/*.pmp-devices .surfacez-custom-pivot a.c-logo{margin-top: 16px;}*/
.pmp-devices .surfacez-custom-pivot .c-logo .c-heading-3{margin-left: 8px;}
.pmp-devices .surfacez-custom-pivot header section.f-active p{    margin-top: 0px; text-align: left; padding-top: 12px; }
.pmp-devices .PMP-Custom .c-pivot > header{margin-top:0px;}
.wdg-global .pmp-devices .PMP-Custom>div{margin-left:0px;}
.wdg-global .pmp-devices .PMP-Custom > div{margin-top: -6%;}
.pmp-devices .surfacez-custom-pivot .c-image.inactive{margin-right: 10px;}
.pmp-devices .surface-performance-specsbanner.image-banner{
    display: inline-block;
}
} 
@media only screen and (max-width:539px){
    
    .pmp-devices .PMP-Custom .c-pivot > header {
    margin-top: 0px;
}
.pmp-devices .surfacez-custom-pivot header section.f-active{margin-top: 12px;
    margin-bottom: 13px;}
    .pmp-devices .surface-performance-specsbanner.image-banner{
        padding-left: 5px !important;
    }
}
@media only screen and (max-width: 1083px) and (min-width:540px)
{
.wdg-global .pmp-devices .PMP-Custom > div{
padding-left: 24px;
}
}
/*Mwf live overrides*/
#mainContent .pmp-devices a.c-call-to-action span {text-transform: uppercase;}
.pmp-devices a.c-call-to-action:empty+a.c-call-to-action{margin-left:0px;}
.pmp-devices a.c-call-to-action:empty+a.c-call-to-action:hover span{text-decoration:underline;}
/*Mwf live overrides*/

/*Round-2 DFB overview page fix*/
#DFB .c-feature a.c-call-to-action+a.c-call-to-action{margin-left:0px;}
.pmp-devices .m-feature a.c-call-to-action+a.c-call-to-action{margin-left:0px;}

/*Round-2 DFB overview page fix end*/
/*4 tips panel fix*/
.pmp-devices .m-content-placement-item a.c-call-to-action.x-hidden+a.c-call-to-action{margin-left:0px;}
.pmp-devices .m-content-placement-item a.c-call-to-action.x-hidden+a.c-call-to-action:hover span{text-decoration:underline;}
/*4 tips panel fix*/

.pmp-devices .m-product-placement-item>a .c-heading, .m-product-placement-item>a .c-subheading{
    text-decoration: underline;
}

/* high contrast issue for surface-book 2*/		
@media screen and (-ms-high-contrast: white-on-black) {		
  .pmp-devices .PMP-Custom > div .c-pivot{background-color:#000;}		
}		
/* high contrast issue for surface-book 2*/
/* ja-jp Pro font fix*/
@media screen and (min-width:1084px) and (max-width:1400px){
.ja-jp .pmp-devices [data-vg='DevicesBusiness_SurfacePro_14_FeaturePanel_VG'] .m-feature  .c-heading{
    font-size: 34px;
    }
}
/* END of ja-jp*/

/*Surface laptop pivot overlap issue in tablet viewport*/
@media only screen and (max-width: 1399px) and (min-width: 1084px){	
 .rtl .pmp-devices .m-hero-item.surface-content-width-450>div>div, .rtl .pmp-devices .c-hero.surface-content-width-450>div>div.laptop-pivot-width{
      max-width: 333px !important;
  }
  
 .pmp-devices .m-hero-item.surface-content-width-450>div>div, .pmp-devices .c-hero.surface-content-width-450>div>div.laptop-pivot-width{
      max-width: 355px !important;
  }
  
}
@media only screen and (max-width: 1600px) and (min-width: 1400px){	
.rtl .pmp-devices .c-hero.f-x-left>div>div, .rtl .pmp-devices .m-hero-item.f-x-left>div>div{
left: -5%;
}

}
/* End of Surface laptop pivot overlap issue in tablet viewport*/

/* PMP-Laptop Custom panel spacing */
@media only screen and (min-width:1084px) and (max-width:1400px)
{
    .pmp-devices .m-feature p.PMP-Lap{
     padding-top: 32px;
     padding-bottom: 20px;
    }
    
}

@media only screen and (max-width: 1083px) and (min-width:540px)
{
    .pmp-devices .m-feature p.PMP-Lap
    {
     padding-top: 24px;
     padding-bottom: 20px;
    }
    
}

@media only screen and (max-width:539px){
 .pmp-devices .m-feature p.PMP-Lap
    {
     padding-top: 24px;
     padding-bottom: 20px;
    }
}

/*End of PMP-Laptop Custom panel spacing */


/*PMP-Laptop Custom panel cta LINK spacing in tablet viewport*/
@media only screen and (min-width:540px) and (max-width: 1083px)
{
     .pmp-devices .m-feature .laptop-cta-spacing{
         float: none;
         width: 100%;
          display: block;
               }
}
/*End of PMP-Laptop Custom panel cta LINK spacing in tablet viewport*/

@media only screen and (min-width: 1084px) {
.pmp-devices .sur-pivot-custom-color.surface-pivot-hero-mob-margin .c-pivot{
padding-top: 20px !important;
}
}
/*PMP-Laptop Platinum font black*/
.en-us .pmp-devices .sur-pivot-custom-color .sur-color-silver *,
.en-gb .pmp-devices .sur-pivot-custom-color .sur-color-silver *,
.zh-cn .pmp-devices .sur-pivot-custom-color .sur-color-silver *
{color:#000 !important;}
 /* End PMP-Laptop Platinum font black*/
 /*PMP-Book2 castamized panel fix*/
 .pmp-devices .surfacez-custom-pivot ul li{margin-top: 12px;}
 .pmp-devices .surfacez-custom-pivot .f-active>p{padding-bottom:10px;}
 
 .pmp-devices section.surfacez-custom-pivot {padding-bottom: 10px;padding-top: 10px;}
  /*End of PMP-Book2 castamized panel fix*/
  
  /*complete for business table allignment*/
  .cfb .c-table td.f-numerical, .c-table th.f-numerical { text-align: center;}
  .cfb .c-table thead th, .c-table thead th button {font-size: 15px;}     
  
   /*End of complete for business table allignment*/
   
   /* Adding font weight and font size to zh-cn preinstalled Software page table heading */
  
   .c-table .preinst thead tr th { font-weight: bold; font-size: 15px; }

/* End font weight and font size to zh-cn preinstalled Software page table heading */
   
   /*Accessbility fixes for laptop and extended for business pages*/
   .cfb .c-table thead tr th{
      font-weight: bold;
  }
  .pmp-devices .c-table tbody tr th{
     font-weight: bold;
 }
    /*End of Accessbility fixes for laptop and extended for business pages*/ 
    
   /*complete for business disclimers focus issue*/
   .cfb .surface-section-footnotes p a:focus, .cfb .surface-section-footnotes li a:focus{
       outline: 1px dotted #FFF !important;
   }
   /*End complete for business disclimers focus issue*/
 .pmp-devices .supBLink{
     padding-right: 2px;
 }
 
  .pmp-devices .wdg-f-cursor-default:hover>div .c-heading, .pmp-devices .wdg-f-cursor-default:hover .c-heading{
     text-decoration: none !important;
 }
 
 .pmp-devices sup a.c-hyperlink.supBLink:focus{
    outline: 1px dashed #000 !important;
    outline: none !important;
    background-color: transparent;
    
 }
 .pmp-devices .m-content-placement-item sup a.c-hyperlink.supBLink:focus{
      outline: 1px dashed #000 !important;
    outline: none !important;
    padding: 6px 3px 6px 2px !important;
    background-color: transparent;
 }
 /*Tick glyph update in CFB pages*/
.cfb .c-table.f-divided .sr-text{
     left:0;
     max-width: 320px;
     position: absolute;
     clip: rect(1px, 1px, 1px, 1px);
 }
 
/*.cfb .tick.c-glyph{
     content: "\E73E";
     font-size: 35px;
     
 }*/
 .cfb .tick.c-glyph{
 font-size: 35px;
    text-align: center;
    font-family: MWF-MDL2;
 }
.cfb .c-glyph:before, .c-glyph:after, .c-glyph:hover:before, .c-glyph:hover:after{
     text-decoration: none;
 }
.cfb .c-glyph:before, .c-glyph:after{
     font-family: "MWF-MDL2";
     display: "inline-block";
 }
 
 .cfb td.tick.c-glyph{
     text-align: center;
 }
 .cfb td{
     text-align: center;
 }
 /*End of Tick glyph update in CFB pages*/
 
 /* Remove underline issue on hover in Book 2 for-business page */ 
 .pmp-devices .surface-performance-article.m-content-placement-item>div>.c-call-to-action:hover span{
 text-decoration: underline !important;    
 }
 
.pmp-devices .surface-performance-article.m-content-placement-item:hover>div>.c-call-to-action span{
 text-decoration: none;    
 }
  /*End of css to Remove underline issue on hover in Book 2 page */
  
  /*Tooltip on Social Share links focus*/
#customTooltip {
  position: absolute;
  background: #f2f2f2;
  border: 1px solid rgba(0, 0, 0, 0.3);
  padding: 2px 5px;
  display: none;
  margin: 10px; }
  
  /*End of css for Tooltip on Social Share links focus*/
  
  @media only screen and (min-width: 1400px){
.pmp-devices .m-multi-feature.f-align-center>section>.c-pivot>section, .pmp-devices .m-multi-feature.f-align-center>section>ul{
width: 80%;
}
  }
/*add spacing btn 3 CTA links in Pro feature panel*/  
.pmp-devices .cta3up-spacing a.c-call-to-action{
      padding: 10px 16px 7px 0;
  }
/*End of code to add spacing btn 3 CTA links in Pro feature panel*/

/* Blockquote panel css fix start */
.pmp-devices blockquote p{
    font-style: normal;
}
/* Blockquote panel css fix start */

/* CSS to keep common border across panels*/
.pmp-devices .surface-section-footnotes p a.mscom-link:focus, .pmp-devices .surface-section-footnotes p a.c-hyperlink:focus, 
.cfb .surface-section-footnotes p a.mscom-link:focus, .cfb .surface-section-footnotes p a.c-hyperlink:focus,
.pmp-devices .surface-section-footnotes li a.mscom-link:focus, .pmp-devices .surface-section-footnotes li a.c-hyperlink:focus, 
.cfb .surface-section-footnotes li a.mscom-link:focus, .cfb .surface-section-footnotes li a.c-hyperlink:focus {
    outline: 1px dotted #FFFFFF !important;
    background: #FFFFFF !important;
    color: #0067b8 !important;
    border:0;
}


.pmp-devices .c-product-placement>a:focus, .pmp-devices .m-product-placement-item>a:focus,
.pmp-devices .m-content-placement>a:focus, .pmp-devices .m-content-placement-item>a:focus,
.cfb .c-product-placement>a:focus, .cfb .m-product-placement-item>a:focus, .pmp-devices .c-pivot a:focus,
.pmp-devices a.surface-popup-video:focus:not(.wdg-f-blue-button), .pmp-devices a.surface-popup-video.x-hidden-focus:focus:not(.wdg-f-blue-button),
.pmp-devices .c-social>a:focus, .c-social>ul>li>a:focus, .m-social>a:focus, .m-social>ul>li>a:focus,
{
outline: #000 dashed 1px !important;
border: 0 !important; 
}   

.pmp-devices thead th{
    font-weight: bold;
}
/*End of  CSS to keep common border across panels*/
/*High Contrast issue in CTA links*/

@media screen and (-ms-high-contrast: active) {
    
.pmp-devices a.c-action-trigger.glyph-play:focus, .pmp-devices  a.c-call-to-action:focus,
.pmp-devices .c-product-placement>a:focus,.pmp-devices .m-product-placement-item>a:focus,
.pmp-devices .m-content-placement>a:focus,.pmp-devices .m-content-placement-item>a:focus, 
.pmp-devices .cfb .c-product-placement>a:focus, .pmp-devices .cfb .m-product-placement-item>a:focus, .pmp-devices .c-pivot a:focus,
.pmp-devices a.surface-popup-video:focus:not(.wdg-f-blue-button), .pmp-devices  a.surface-popup-video.x-hidden-focus:focus:not(.wdg-f-blue-button),
.pmp-devices .c-social>a:focus, .pmp-devices .c-social>ul>li>a:focus, .pmp-devices .m-social>a:focus,
.pmp-devices .m-social>ul>li>a:focus, .pmp-devices nav.c-link-navigation li a.c-hyperlink.f-image:focus img,
.pmp-devices a.c-hyperlink:focus{outline:1px dotted #000;border:0;}

.pmp-devices a.c-action-trigger.glyph-play{
border: 2px solid rgb(255, 255, 0);
color: rgb(255, 255, 0);}
.pmp-devices .wdg-m-prefooter nav.c-link-navigation ul li a.c-hyperlink:focus span{
    border:none !important;
}

}

@media screen and (-ms-high-contrast: black-on-white) {
    
.pmp-devices a.c-action-trigger.glyph-play:focus, .pmp-devices  a.c-call-to-action:focus,
.pmp-devices .c-product-placement>a:focus,.pmp-devices .m-product-placement-item>a:focus,
.pmp-devices .m-content-placement>a:focus,.pmp-devices .m-content-placement-item>a:focus, 
.pmp-devices .cfb .c-product-placement>a:focus, .pmp-devices .cfb .m-product-placement-item>a:focus, .pmp-devices .c-pivot a:focus,
.pmp-devices a.surface-popup-video:focus:not(.wdg-f-blue-button), .pmp-devices  a.surface-popup-video.x-hidden-focus:focus:not(.wdg-f-blue-button),
.pmp-devices .c-social>a:focus, .pmp-devices .c-social>ul>li>a:focus, .pmp-devices .m-social>a:focus,
.pmp-devices .m-social>ul>li>a:focus, .pmp-devices nav.c-link-navigation li a.c-hyperlink.f-image:focus img,
.pmp-devices a.c-hyperlink:focus{outline:1px dotted #000 !important;border:0;}

.pmp-devices a.c-action-trigger.glyph-play{
border: 2px solid rgb(0, 0, 159) !important;
color:  rgb(0, 0, 159) !important;}

}

@media screen and (-ms-high-contrast: white-on-black) {
    
.pmp-devices a.c-action-trigger.glyph-play:focus, .pmp-devices  a.c-call-to-action:focus,
.pmp-devices .c-product-placement>a:focus,.pmp-devices .m-product-placement-item>a:focus,
.pmp-devices .m-content-placement>a:focus,.pmp-devices .m-content-placement-item>a:focus, 
.pmp-devices .cfb .c-product-placement>a:focus, .pmp-devices .cfb .m-product-placement-item>a:focus, .pmp-devices .c-pivot a:focus,
.pmp-devices a.surface-popup-video:focus:not(.wdg-f-blue-button), .pmp-devices  a.surface-popup-video.x-hidden-focus:focus:not(.wdg-f-blue-button),
.pmp-devices .c-social>a:focus, .pmp-devices .c-social>ul>li>a:focus, .pmp-devices .m-social>a:focus,
.pmp-devices .m-social>ul>li>a:focus, .pmp-devices nav.c-link-navigation li a.c-hyperlink.f-image:focus img,
.pmp-devices a.c-hyperlink:focus{outline:1px dotted #fff;border:0;}

.pmp-devices a.c-action-trigger.glyph-play{
border: 2px solid rgb(255, 255, 0);
color: rgb(255, 255, 0) !important;}

}

.pmp-devices .c-hyperlink.supLink{
color: #00bcf2 !important
}

.pmp-devices .surface-section-footnotes a.mscom-link, .pmp-devices .surface-section-footnotes a.c-hyperlink, 
.cfb .surface-section-footnotes a.mscom-link, .cfb .surface-section-footnotes a.c-hyperlink {
    
    color: #00bcf2 !important
}

/*End of code to resolve High Contrast issue in CTA links*/
/*Spot check Accessbility fixes*/
.pmp-devices .surface-performance-specsbanner .surface-indivspecs-container .specs-desc{
    display: block;
}

.cfb .c-table tbody tr th{
    font-weight:bold;
}
/*End of Spot check Accessbility fixes*/

.m-banner a.c-call-to-action, .m-ratings-and-reviews a.c-call-to-action, 
.m-feature.f-align-center>div .c-call-to-action {margin-right:4px;}
.pmp-devices .m-feature a.c-call-to-action {margin-right:4px !important;}
/*footnote css override*/

.pmp-devices .surface-section-footnotes li {
    font-size: 11px;
    margin-bottom: 10px;
}

.pmp-devices .surface-section-footnotes li:focus, .cfb .surface-section-footnotes li:focus, .DFB_Compare .surface-section-footnotes li:focus{
   outline: 2px dotted #FFFFFF !important;
   border:0;  
}

/*end of footnote css override*/
/* CSS to ovverride local-override.css file*/
@media only screen and (min-width: 1084px) and (max-width: 1399px) {
 .pl-pl .pmp-devices .c-heading-1, .sv-se .pmp-devices .c-heading-1, .nb-no .pmp-devices .c-heading-1, .pt-pt .pmp-devices .c-heading-1,
 .fr-ch .pmp-devices .c-heading-1, .ms-my .pmp-devices .c-heading-1, .nl-be .pmp-devices .c-heading-1, .fr-be .pmp-devices .c-heading-1, 
 .es-es .pmp-devices .c-heading-1, .it-it .pmp-devices .c-heading-1, .fr-lu .pmp-devices .c-heading-1, .nl-nl .pmp-devices .c-heading-1, 
 .rtl .pmp-devices .c-heading-1, .de-lu .pmp-devices .c-heading-1
{
	font-size: 62px !important;
}
}
/*End of CSS to ovverride local-override.css file*/

/*Spot check Accessbility CTA side by side issue fixes*/
.pmp-devices .wrap-ul, #DFB .wrap-ul{
    display: inline-block;
    padding-top: 6px;
}
.pmp-devices .wrap-li, #DFB .wrap-li{
    float:left;
}
.pmp-devices .wrap-li .mscom-link.c-call-to-action, #DFB .wrap-li .mscom-link.c-call-to-action{
    margin-top: 2px;
}
#DFB .wrap-li .dfc.surface-popup-video{
    padding-top:0px !important;
}
/*End of Spot check Accessbility CTA side by side issue fixes*/


@media screen and (max-width: 1399px) and (min-width: 768px){
.pmp-devices .surface-indivspecs-container .spec-val.c-heading-1{
font-size: 62px ;
}
.pmp-devices .surface-indivspecs-container .specs-unit.c-heading-2{
font-size: 46px ;
}
}
.pmp-devices .c-pivot .color_tip {
    display: none;
    position: absolute;
    border: 1px solid #000;
    background-color: #f2f2f2;
    color: #000 !important;
    padding: 6px;
}
/*Business overview cta allignment*/
@media only screen and (max-width: 365px){
#DFB .m-feature.f-align-center>div .c-call-to-action{
padding-left: 0px;
}
}
/*End of the Business overview cta allignment*/
.pmp-devices .surface-performance-specswrap.m-content-placement-item
{
    cursor:default !important;
    pointer-events: none !important;
 
 }
 .pmp-devices .c-feature > div .c-group .c-call-to-action, 
 .pmp-devices .m-feature > div .c-group .c-call-to-action
 {
     margin-right: 4px !important;
 }
 /*MDA Panel*/
.wdg-global .pmp-devices .new-sp4-banner.wdg-theme-dark a.c-call-to-action.c-glyph {
    color: #fff;
    background: #5e5e5e;
    padding-right: 20%;
}
#mainContent .pmp-devices a.c-call-to-action span:hover{text-decoration: underline;}
.pmp-devices .new-sp4-banner .newsp4bannertext{
    padding-left: 15px;
    height: 220px;
    padding-top: 75px !important;
}

.wdg-global .new-sp4-banner.wdg-theme-dark a.c-call-to-action.c-glyph:focus {
    outline: #fff dashed 1px;
}


@media only screen and (min-width:540px) and (max-width:1083px){
  .pmp-devices .new-sp4-banner div[data-grid~=col-4] {
    width:auto !important;
    }
  .pmp-devices .newsp4bannertext{
      padding-left: 0px !important;
  }
.pmp-devices .new-sp4-banner .wdg-pad-medium, .pmp-devices .new-sp4-banner .c-call-to-action{
      padding: 0px !important;
  }
 .pmp-devices .new-sp4-banner .newsp4bannertext{
     height: 220px;
    padding-top: 60px !important;
}
.pmp-devices .new-sp4-banner img
{
    width: 100%;
}
.pmp-devices .vertical-center-vp2{
    display: -ms-flexbox;
    display: flex;
    -ms-flex-pack: justify;
    justify-content: space-between;
    -ms-flex-align: center;
    align-items: center 
}
.pmp-devices .new-sp4-banner .newsp4bannertext .c-heading-4{
	    font-size: 24px;
	    line-height: 28px;
}
}
@media (max-width: 767px){
.pmp-devices .new-sp4-banner .newsp4bannertext .c-heading-4 {
 font-size: 20px;
  line-height: 24px;
}	
}
@media only screen and (max-width: 539px){
  .pmp-devices .new-sp4-banner .wdg-pad-medium{
    padding-top: 0px !important;
    padding-bottom: 26px;
}
.pmp-devices .new-sp4-banner .newsp4bannertext{
     height: auto;
    padding-top: 48px !important;
}
.pmp-devices .new-sp4-banner .c-call-to-action{
    padding: 0px !important; 
    float: none;
}
.pmp-devices .new-sp4-banner .newsp4bannertext .c-heading-4{
	    font-size: 20px;
    line-height: 24px;
}
.pmp-devices .newsp4bannertext .c-paragraph-2{
    padding-top: 5px !important;
}

}

/*End of MDA Panel*/

/*banner carousel tooltip*/ 
 .pmp-devices .carousel-tooltip{
    position: absolute;
    display: none;
    z-index: 100;
    bottom:0px;
    background-color: #f2f2f2;
    color: #000 !important;
    right:47%;
    outline: 1px dashed #000;
}
/*End of the banner carousel tooltip*/

/* zh-cn installed software page CSS override*/
.c-table.installed-software td, .c-table.installed-software th{

min-width: 100px;
max-width: 400px;    
}

/* Surface Prod plac override */

.surfaceplus-prodplac .m-content-placement-item .x-type-center a.mscom-link{
    padding-left: 6%;
}

@media only screen and (min-width:767px) and (max-width:1083px){
    .surfaceplus-prodplac .m-content-placement-item .x-type-center a.mscom-link{
    padding-left: 10%;
}

}
/* End of Surface Prod plac override */

.pmp-devices a.c-action-trigger, .pmp-devices button.c-action-trigger .COS-video{
    font-size: 15px;
}
/*Tulam panel updates*/
.pmp-devices .device-expand button.c-action-trigger.c-glyph[aria-label], .pmp-devices .device-expand a.c-action-trigger.c-glyph[aria-label] {
    min-width: 0;
    margin-right: 10px;
    margin-top: 55px;
    margin-bottom: 21px;
}

.pmp-devices .m-system-requirements #tulatable tr:last-child{
    border-bottom: 1px solid rgba(0,0,0,.2);
}
.pmp-devices .pad-buttom{margin-bottom: 60px;}
.pmp-devices .device-expand .c-action-trigger:focus{
    outline: 2px dotted #000;
    background: none !important;
}
.pmp-devices .m-banner.pad-bottom-thin-48px {
    padding-bottom: 48px;
}
/*End of Tulam panel updates*/
.pmp-devices a.c-call-to-action.c-glyph.surface-bg-cta-blue:after{
    margin-top: 5px;
}
/*Content placemnt pointer clickable issue*/
.pmp-devices .m-content-placement-item.wdg-f-cursor-default.f-size-medium{
cursor: pointer;
pointer-events: none;
}
/* End Content placemnt pointer clickable issue*/
/*accesibility spotcheck-2 fix*/
.pmp-devices .wdg-theme-dark-banner a.mscom-link.c-call-to-action:focus,
.pmp-devices .wdg-theme-dark a.mscom-link.c-call-to-action:focus{
    outline: #fff dashed 2px !important;
}
/*End of accesibility spotcheck-2 fix*/
/*One player video css*/
.pmp-devices .oneplayer-video .wdg-oneplayer-inline {
    padding-bottom:41.7% !important;
}
#surface-lightbox-preview div[role='document']{
    overflow-y: hidden;
} 

#surface-lightbox-preview div[role='dialog']{
    overflow-y: inherit !important;
    background-color: transparent;
}

.html5-video-player:not(.ytp-touch-mode) ::-webkit-scrollbar-thumb{
    background-color: transparent;
}

#surface-lightbox-preview div[role='dialog'] iframe{
    box-sizing: content-box;
    
}
@media only screen and (max-width: 767px){
    #surface-lightbox-preview div[role='dialog']{
    padding: 0px;
    
}

#surface-lightbox-preview div[role='document']>a, #surface-lightbox-preview div[role='document'] .c-video{
    min-width: auto;
}
}
#surface-lightbox-preview a.dummy-anchor{

    display:block;font-size:0px;
}

#surface-lightbox-preview div[role='document']{width:100%;height:100%;}
#surface-lightbox-preview div[role='document']>a,#surface-lightbox-preview div[role='document'] .c-video{height:inherit;}
@media only screen and (min-width:1084px){
  #surface-lightbox-preview div[role='dialog']{width:90%;height:90%!important;}
}
@media only screen and (min-width:768px) and (max-width:1083px) {
  #surface-lightbox-preview div[role='dialog']{width:80%;height:80%!important;}
}
@media only screen and (max-width:767px) {
  #surface-lightbox-preview div[role='dialog']{width:75%;height:75%!important;}
}
/*Update superscript font size in headings*/
.pmp-devices h2 sup,.pmp-devices h1 sup{
    font-size: 0.65em;
   
}
/*End of CSS to Update superscript font size in headings*/

.pmp-devices .ForresterPanel .centerimage picture>img{
    display: block;
    margin-left: auto;
    margin-right: auto;
    width:168px;
    height: 28px;  
}
.pmp-devices .centerimage{
    width: 500px;
    margin: 0 auto;
}
.pmp-devices .centerimage .forrester-image{
    padding: 41px 0px 41px 0px;
    background-color: #00562F;
}

@media screen and (max-width: 1083px){
   .pmp-devices .centerimage{
    width: auto;
    margin: 0 ;
} 
}
@media screen and (min-width:540px) and (max-width: 1083px){
  .pmp-devices .ForresterPanel .centerimage picture>img{
    display: block;
    margin-left: auto;
    margin-right: auto;
    width:215px;
    height: 34px;  
}
.pmp-devices .centerimage .forrester-image{
    padding: 58px 0px 58px 0px;
    background-color: #00562F;
}
}
@media screen and (max-width:540px){
   .pmp-devices .ForresterPanel .centerimage picture>img{
    display: block;
    margin-left: auto;
    margin-right: auto;
    width:109px;
    height: 20px;  
}
.pmp-devices .centerimage .forrester-image{
    padding: 27px 0px 27px 0px;
    background-color: #00562F;
}
.pmp-devices .ForresterPanel .wrap-li a.c-call-to-action {
    margin-right: 0px !important;
}
.pmp-devices .ForresterPanel .wrap-ul{
    display: inline-block;
    padding-left: 25px;
}
}
.pmp-devices .c-table tbody tr th {
    font-weight: bold;
}

.pmp-devices .m-content-placement.surfacedetails-3UP.no-CTA .m-content-placement-item > a .c-heading {
    text-decoration: underline;
}
.pmp-devices .new-sp-banner a.c-call-to-action.c-glyph{
    background: 0 0 !important;
    color: #0067B8 !important;
    border-color: transparent !important;
    padding-left: 0px !important;
    }
    
    #mainContent .pmp-devices .m-content-placement-item sup, #mainContent .pmp-devices .surface-section-footnotes a.supLink{
        pointer-events: auto !important;
    }
    
   .pmp-devices a.c-call-to-action:not(.glyph-play):after, .pmp-devices button.c-call-to-action:not(.glyph-play):after{
       margin-top: 3px;
   }
   
   .c-product-placement, .m-product-placement-item{
       margin-right: 0px;
   }
   /*Text transformation for new badge*/
   .pmp-devices .c-badge{
       text-transform: uppercase;
   }
    /*End of Text transformation for new badge*/

.pmp-devices .skanska a.c-action-trigger.c-glyph.glyph-play:before,.pmp-devices .skanska button.c-action-trigger.c-glyph.glyph-play:before{
    margin-left: 0px;
}

.pmp-devices .skanska button.c-action-trigger.c-glyph[aria-label], .pmp-devices .skanska a.c-action-trigger.c-glyph[aria-label]{
    padding-right: 16px;
}

.pmp-devices sup a.c-hyperlink:not(.f-image).x-hidden-focus{
    text-decoration: underline !important;
}
@media screen and (max-width:700px){
.pmp-devices .m-highlight-feature > div{
 margin-top: 20px !important;   
}
}

/*VFI changes for accessbility fixes*/
.pmp-devices .c-product-placement>a:focus, .m-product-placement-item>a:focus,
a.oneplayer-popup-video:focus:not(.wdg-f-blue-button),
a.oneplayer-popup-video.x-hidden-focus:focus:not(.wdg-f-blue-button){
   outline:2px dashed #000 !important;
}
a.oneplayer-popup-video.c-action-trigger:focus:not(.x-hidden-focus){
    background-color:transparent !important;
}
.pmp-devices .m-content-placement-item a:focus,
.pmp-devices .wdg-m-prefooter nav.c-link-navigation ul li a.c-hyperlink.f-image:focus span{
    outline:2px dashed #000 !important;
}
.pmp-devices .m-product-placement.devices-business-touts5up ul li,
.pmp-devices .m-product-placement.devices-business-touts2up ul li
{
    padding-right: 5px;
}
.pmp-devices .c-social>a:focus, .pmp-devices .c-social>ul>li>a:focus,
.pmp-devices .m-social>a:focus, .pmp-devices .m-social>ul>li>a:focus{
     outline: 2px dashed #000 !important;
 }
/*End of VFI changes for accessbility fixes*/
/*new badge p[adding issue*/
@media screen and (min-width:700px) and (max-width:770px){
.pmp-devices .DevicesHighlightfeature .c-badge.f-small.f-highlight{
    padding: 0 7px 1px;
    margin-top: 25px;
}
}
/*End of new badge p[adding issue*/

@media screen and (min-width:1400px){
html[lang^=ar-] .pmp-devices .m-hero-item > div > div,html[lang^=ar-] .pmp-devices .c-hero > div > div{
    padding-left: 28px !important;
    padding-right: 120px !important;
}
}

html:not([lang^=en-]):not([lang^=ar-]) .pmp-devices .m-feature.f-image-priority.f-align-left>div{
    padding-left: 0px;
}

html:not([lang^=en-]):not([lang^=ar-]) .pmp-devices .m-feature.f-image-priority.f-align-right>div{
    padding-right: 0px;
}
@media screen and (min-width:1084px) and (max-width:1399px){
.pmp-devices .hub2_accolade.m-feature>picture img{
    margin-top: 8%;
}
.pmp-devices .hub2_accolade.m-feature{
    min-height: 400px;
    }
    }

.pmp-devices a.supLink .supFn{
    text-decoration: underline;
}


/* Edge Prefooter focus issue Fix start*/

.pmp-devices .wdg-m-prefooter nav.c-link-navigation ul li a.c-hyperlink.f-image:focus span {
    display: inline-block !important;
}

/* Edge Prefooter focus issue Fix end*/

/*Compare page CSS code */

.DFB_Compare .m-content-placement-item .c-call-to-action.compare-padding{
    padding-left: 8%;
}

@media screen and (min-width: 768px) and (max-width: 943px){
    
.de-de .DFB_Compare input[type=checkbox]:checked + span
{
padding-bottom : 21px !important;
}
}

@media screen and (min-width: 768px) and (max-width: 914px){
    
.fr-fr .DFB_Compare input[type=checkbox]:checked + span,.fr-ca .DFB_Compare input[type=checkbox]:checked + span
{
padding-bottom : 21px !important;
}
}


@media screen and (min-width: 768px) and (max-width: 880px){
    
.ja-jp .DFB_Compare input[type=checkbox]:checked + span
{
padding-bottom : 21px !important;
}
}

@media screen and (min-width: 768px) and (max-width: 800px){
    
.ja-jp .DFB_Compare .compare_table_inner .m-content-placement-item h3.c-heading-4
{
    padding-right: 0px !important;
}
}
/*....Compare end
/*....Family of devices Custom Product Placement***/

.pmp-devices .custom_pp_panel .m-product-placement {
    float: none;    
}


  .pmp-devices .custom_pp_panel .m-product-placement-item.f-size-large, .c-product-placement.f-size-large{
      
    width: 280px !important;
  }
  .pmp-devices .custom_pp_panel .m-product-placement-item {
    position: relative;
    padding: 0;
    margin-right: 18px !important;
    margin-top: 12px;
}

.pmp-devices .custom_pp_panel .c-flipper{
    position: relative;
    border: 2px solid transparent;
    outline: 0;
    width: 44px;
    height: 44px;
    padding: 0;
    display: inline-block;
    border: 1px solid transparent;
    border-radius: 50%;
    background: #fafafa;
    color: #404040;
    opacity: .8;
    font-family: "MWF-MDL2";
}
 .pmp-devices .custom_pp_panel .c-flipper:focus, .c-flipper:hover, .c-flipper:active, .theme-light .c-flipper, .theme-dark .theme-light .c-flipper:focus, .theme-light .c-flipper, .theme-dark .theme-light .c-flipper:hover, .theme-light .c-flipper, .theme-dark .theme-light .c-flipper:active{
     background: #fff;
    color: #404040;
    opacity: 1;
 }
 .pmp-devices .custom_pp_panel .c-flipper:hover, .theme-light .c-flipper, .theme-dark .theme-light .c-flipper:focus, .theme-light .c-flipper, .theme-dark .theme-light .c-flipper:hover{
     box-shadow: 0 4px 8px rgba(0,0,0,.2);
 }
 
 
        
    .pmp-devices .custom_pp_panel .c-call-to-action {
            padding: 10px 0px 7px 0px;
        }
                

    .pmp-devices .custom_pp_panel .c-paragraph {
        padding-top: 4px !important;
    }



    .pmp-devices .custom_pp_panel span {
            overflow: visible;
        }

.pmp-devices .custom_pp_panel .c-carousel .c-flipper{
        position: absolute;
    top: 50%;
    -ms-transform: translateY(-50%);
    transform: translateY(-50%);
    z-index: 100;

}

@media only screen and (max-width: 539px) {
 .pmp-devices .custom_pp_panel .c-flipper {
 visibility:visible;
 }
 }
        
.pmp-devices #prod-plac-panel .c-carousel.f-scrollable-next .c-flipper.f-right, .pmp-devices #prod-plac-panel .c-carousel.f-scrollable-next .c-flipper.f-next{
    display: block;
}

.pmp-devices #prod-plac-panel .c-carousel.f-scrollable-previous .c-flipper.f-left, .pmp-devices #prod-plac-panel .c-carousel.f-scrollable-previous .c-flipper.f-previous{
    display: block;
}

.pmp-devices #prod-plac-panel .c-carousel .c-flipper{
    display: none;
}

.pmp-devices .surface-hero-pivot-multi-img .c-pivot>ul>li>a{
    border: none;
}
@media screen and (min-width: 1084px){
.pmp-devices .surface-hero-pivot-multi-img .c-pivot>ul>li>a:focus{
    outline: none;
}
}

@media screen and (max-width: 539px){
.pmp-devices .m-hero-item .c-pivot .icons {
    width: auto;
}
}