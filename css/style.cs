@keyframes progress {
  0% {
    transform: scaleY(0);
  }
  100% {
    transform: scale(1);
    opacity: 1;
  }
}
@keyframes opacity-check {
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
li:nth-child(1) {
  animation-delay: 1s;
}

li:nth-child(2) {
  animation-delay: 2s;
}

li:nth-child(3) {
  animation-delay: 3s;
}

@font-face {
  font-family: Roboto;
  src: url(../roboto/Roboto-Regular.ttf);
}
@font-face {
  font-family: Roboto-bold;
  src: url(../roboto/Roboto-Bold.ttf);
}
@font-face {
  font-family: Roboto-thin;
  src: url(../roboto/Roboto-Thin.ttf);
}
@font-face {
  font-family: Shirkhand;
  src: url(../shirkhand/Shrikhand-Regular.ttf);
  font-size: 100 1000;
}
.header__logo--position {
  display: flex;
  flex-direction: row-reverse;
  justify-content: space-between;
  align-items: center;
}
.header__logo--position a {
  text-decoration: none;
  color: black;
  height: auto;
}
.header__logo--position a h1 {
  margin: 0;
}
.header__logo--position__button {
  padding: 0;
  margin: 0;
  background-color: white;
  font-family: "Shirkhand";
  height: fit-content;
  font-size: 20px;
  border: none;
  height: auto;
}

.mainpages2 {
  border-radius: 24px 24px 0 0;
  background-color: #f6f6f6;
  padding: 14px;
}

.menupart__ul {
  list-style-type: none;
  padding: 0;
  display: flex;
  gap: 14px;
  flex-direction: column;
  animation: progress 3s;
}
.menupart__ul__li {
  display: flex;
  background-color: white;
  border-radius: 16px;
  align-items: center;
  justify-content: space-between;
  animation: progress 0.5s ease-out;
  animation-fill-mode: both;
  transform-origin: bottom;
  position: relative;
}
.menupart__ul__li__icon {
  height: 74px;
  width: 74px;
  background-color: #99E2D0;
  border-radius: 0 16PX 16PX 0;
  display: flex;
  align-items: center;
  justify-content: center;
  transform-origin: 100% 0%;
  transform: scaleX(0);
  transition: transform 250ms linear;
}
.menupart__ul__li__icon i {
  color: white;
  font-size: 24px;
  transform: rotate(-390deg);
  transition: transform 1000ms;
}
.menupart__ul__li:hover > .menupart__ul__li__icon {
  display: flex;
  align-items: center;
  justify-content: center;
  transform: scaleX(1);
}
.menupart__ul__li:hover > .menupart__ul__li__icon > i {
  transform: rotate(0deg);
}
.menupart__ul__li__titre {
  padding-left: 10px;
}
.menupart__ul__li__titre h4 {
  margin: 16px 0 8px 0;
}
.menupart__ul__li__titre p {
  margin: 0 0 12px 0;
}
.menupart__ul__li__prix {
  padding: 42px 24px 0 0;
}

.commander {
  text-align: center;
}
.commander__lien:hover {
  transform: scale(1.05);
}
.commander__lien__button {
  border-radius: 100px;
  background: linear-gradient(#FF79DA, #9356DC);
  color: white;
  border: none;
  box-shadow: 4px 4px 4px #d4d4d4;
  padding: 18px 24px 18px 24px;
  font-weight: bold;
  font-size: 14PX;
  text-align: center;
}

.localisation {
  display: flex;
  flex-direction: row;
  justify-content: center;
  text-align: center;
  background-color: #eaeaea;
  padding: 16px;
}
.localisation span {
  padding-left: 16px;
}

.presentation {
  display: flex;
  flex-direction: column;
  align-items: center;
  text-align: center;
  background-color: #f6f6f6;
  padding: 40px 40px 50PX 40PX;
}
.presentation h2 {
  font-family: "Roboto-bold";
  margin: 0;
}
.presentation span {
  padding: 16px 0 30px 0;
  font-family: "Robot-thin";
  font-size: 18px;
  opacity: 0.6;
}
.presentation__lien {
  width: fit-content;
}
.presentation__lien:hover {
  transform: scale(1.05);
}
.presentation__lien:hover button {
  font-size: 15px;
  font-weight: bold;
}
.presentation__lien__button {
  border-radius: 100px;
  background: linear-gradient(#FF79DA, #9356DC);
  color: white;
  border: none;
  box-shadow: 4px 4px 4px #d4d4d4;
  padding: 18px 24px 18px 24px;
  font-weight: bold;
  font-size: 14PX;
}

.fonctionnement {
  padding: 0 20px 0 20px;
}
.fonctionnement ol {
  display: flex;
  flex-direction: row;
  gap: 24px;
  padding: 0;
  counter-reset: listCounter;
  list-style-type: none;
}
@media screen and (max-width: 872px) {
  .fonctionnement ol {
    flex-direction: column;
  }
}
.fonctionnement ol li {
  border-radius: 20px;
  padding: 24px 0;
  background-color: #f6f6f6;
  box-shadow: 4px 4px 4px #d4d4d4;
  flex: 1;
  display: flex;
  align-items: center;
}
.fonctionnement ol li::before {
  counter-increment: listCounter;
  content: counters(listCounter, ".") " ";
  color: white;
  background-color: #9356DC;
  border-radius: 50%;
  height: 22px;
  width: 22px;
  display: flex;
  justify-content: center;
  align-items: center;
  position: relative;
  left: -13px;
}
.fonctionnement ol li i {
  color: #7e7e7e;
  margin-right: 24px;
}
.fonctionnement ol li span {
  font-weight: bold;
}

.carte {
  display: flex;
  flex-direction: column;
  justify-content: space-between;
  padding: 60px 20px 60px 20px;
  background-color: #f6f6f6;
}
.carte h2 {
  margin: 0 0 24px 0;
}
.carte__resto {
  gap: 20px;
  display: grid;
  grid-template-columns: repeat(2, 1fr);
}
@media screen and (max-width: 872px) {
  .carte__resto {
    grid-template-columns: 1fr;
  }
}
.carte__resto__lien {
  text-decoration: none;
}
.carte__resto__lien__figure {
  height: 255px;
  width: 100%;
  border-radius: 20px;
  box-shadow: 4px 4px 4px 4px #e9e9e9;
  margin: 0;
  display: flex;
  flex-direction: column;
  justify-content: space-between;
  background-color: white;
}
.carte__resto__lien__figure__image {
  height: 175px;
  width: 100%;
  border-radius: 20px 20px 0 0;
}
.carte__resto__lien__figure__image__img {
  max-width: 100%;
  max-height: 100%;
  min-height: 100%;
  min-width: 100%;
  object-fit: cover;
  border-radius: 20px 20px 0 0;
}
.carte__resto__lien__figure__caption {
  height: 80px;
  display: flex;
  flex-direction: row;
  justify-content: space-between;
  align-items: center;
}
.carte__resto__lien__figure__caption__titre {
  color: black;
  padding-left: 10px;
}
.carte__resto__lien__figure__caption__titre h3 {
  margin: 0;
  padding-bottom: 5PX;
}
.carte__resto__lien__figure__caption__titre span {
  font-family: Roboto-thin;
}
.carte__resto__lien__figure__caption__icon:hover .fas {
  display: block;
  color: #FF79DA;
}
.carte__resto__lien__figure__caption__icon:hover .far {
  display: none;
}
.carte__resto__lien__figure__caption__icon i {
  height: 23px;
  width: 23px;
  font-size: 24px;
  text-align: center;
  display: flex;
  justify-content: space-around;
  margin-right: 24px;
  flex-direction: column;
  align-items: center;
  color: black;
}
.carte__resto__lien__figure__caption__icon .fas {
  display: none;
}

* {
  box-sizing: border-box;
}

body {
  margin: 0;
  display: flex;
  flex-direction: column;
  justify-content: space-between;
  font-family: "Roboto", sans-serif;
}

.header__logo {
  text-align: center;
  box-shadow: 0 0 8px #d4d4d4;
  padding: 10px;
  font-family: "Shirkhand", cursive;
  margin: 0;
}

main {
  display: flex;
  flex-direction: column;
}

footer {
  background-color: #353535;
  color: white;
  height: 198px;
}
footer .footer__logo {
  padding: 27px 0 0 20px;
}
footer ul {
  list-style-type: none;
  height: 95px;
  display: flex;
  flex-direction: column;
  justify-content: space-between;
}
footer ul .utensils::before {
  font-family: "FontAwesome";
  content: "\f2e7";
  margin-right: 15px;
}
footer ul .handshake::before {
  font-family: "FontAwesome";
  content: "\f4c4";
  margin-right: 15px;
}
footer ul .contact__a a {
  text-decoration: none;
  color: white;
}

/*# sourceMappingURL=style.cs.map */
