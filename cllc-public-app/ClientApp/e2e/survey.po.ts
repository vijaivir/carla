import { browser, by, element } from 'protractor';

export class AppSurveyPage {
    navigateTo() {
        return browser.get('/cannabislicensing/prv/');
    }

    getMainHeading() {
        return element(by.css('app-root h3')).getText();
    }

    surveyPageTitle() {
        browser.wait(function () {
            return element(by.className('sv_q_title')).isPresent();
        }, 10000);
        return element(by.className('sv_q_title')).getText();
    }

    getSurveyQuestion(surveyConfig, q) {
        var len = surveyConfig.pages.length;
        for (var i = 0; i < len; i++) {
            var p = surveyConfig.pages[i];
            if (p.name == q) {
                return [i, p];
            }
        }
        expect("Error no question found for ").toEqual(q);
    }

    async surveySetQValue(currentPage, i, toValue) {
        if (currentPage.elements[0].type == "radiogroup") {
            console.log(currentPage.elements[0].name + "_sq_" + (100+i));
            var fieldName = currentPage.elements[0].name + "_sq_" + (100+i);
            browser.wait(function () {
                return element(by.name(fieldName)).isPresent();
            }, 10000);
            var currentElement = element.all(by.name(fieldName));

            // click on the button that matches our "value"
            console.log('//input[@value="' + toValue + '"]');
            var selectedElement = currentElement.all(by.xpath('//input[@value="' + toValue + '"]'));
            expect(selectedElement.isPresent()).toBe(true);
            await selectedElement.click();
        } else if (currentPage.elements[0].type == "dropdown") {
            console.log("sq_" + (100+i) + "i");
            var fieldName = "sq_" + (100+i) + "i";
            browser.wait(function () {
                return element(by.id(fieldName)).isPresent();
            }, 10000);
            var currentElement = element.all(by.id(fieldName));

            // select the selected "value"
            console.log('option ' + toValue);
            var selectedElement = currentElement.all(by.cssContainingText('option', toValue));
            expect(selectedElement.isPresent()).toBe(true);
            await selectedElement.click();
        }
    }

    surveyPageButton(selectedButton) {
    var buttonName = "btn btn-primary sv_" + selectedButton + "_btn";
        browser.wait(function () {
            return element(by.className(buttonName)).isPresent();
        }, 10000);
        return element(by.className(buttonName));
    }

    async executeSurvey(navPath, surveyConfig) {
        console.log('>>> Enter executeSurvey()');

        // execute each step of the survey navigation
        var len = navPath.length;
        for (var i = 0; i < len; i++) {
            var myNav = navPath[i];
            var myQ = myNav['q'];
            var myR = myNav['r'];
            var myButton = myNav['button'];
            console.log('    ' + myQ + ',' + myR + ',' + myButton);

            var tempP = this.getSurveyQuestion(surveyConfig, myQ);
            var currentSurveyIdx = tempP[0];
            var currentSurveyP = tempP[1];

            // 1. confirm page title
            var currentPageTitle = this.surveyPageTitle();
            expect(currentPageTitle).toEqual("* " + currentSurveyP.elements[0].title);
            browser.waitForAngular();
            await browser.driver.sleep(400);

            // 2. set question response (value == myR)
            this.surveySetQValue(currentSurveyP, currentSurveyIdx, myR);
            browser.waitForAngular();
            await browser.driver.sleep(400);

            // 3. click on selected button (class "btn btn-primary sv_<<myButton>>_btn")
            var currentPageButton = this.surveyPageButton(myButton);
            expect(currentPageButton.isPresent()).toBe(true);
            await currentPageButton.click();
            browser.waitForAngular();
            await browser.driver.sleep(400);
        }

        // TODO return the final result page

        console.log('<<< Exit executeSurvey()');
    }
}
