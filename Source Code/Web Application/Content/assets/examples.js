/* Examples */

/*
 * Example 1:
 *   - no animation
 *   - custom gradient
 *
 * By the way - you may specify more than 2 colors for the gradient
 */
$('.first.circle').circleProgress({
    value: 0.35,
    animation: false,
    fill: { gradient: ['#ff1e41', '#ff5f43'] }
});

/*
 * Example 2:
 *   - default gradient
 *   - listening to `circle-animation-progress` event and display the animation progress: from 0 to 100%
 */
$('.second.circle').circleProgress({
    value: 0.66,
    fill: {gradient: ['#3aeabb', '#fdd250']},       
}).on('circle-animation-progress', function(event, progress) {
    $(this).find('strong').html(parseInt(66 * progress) + '<i></i>');
});

$('.re.circle').circleProgress({
    value: 0.7,
    fill: {gradient: ['#f865bc', '#d4df1f']},       
}).on('circle-animation-progress', function(event, progress) {
    $(this).find('strong').html(parseInt(70 * progress) + '<i></i>');
});

$('.re2.circle').circleProgress({
    value: 0.6,
    fill: {gradient: ['#b8e810', '#e1940f']},       
}).on('circle-animation-progress', function(event, progress) {
    $(this).find('strong').html(parseInt(60 * progress) + '<i></i>');
});

$('.re3.circle').circleProgress({
    value: 0.83,
    fill: {gradient: ['#0cdaed', '#5656cc']},       
}).on('circle-animation-progress', function(event, progress) {
    $(this).find('strong').html(parseInt(83 * progress) + '<i></i>');
});


$('.re4.circle').circleProgress({
    value: 0.55,
    fill: {gradient: ['#ffdc50', '#61500d']},       
}).on('circle-animation-progress', function(event, progress) {
    $(this).find('strong').html(parseInt(55 * progress) + '<i></i>');
});

$('.re5.circle').circleProgress({
    value: 0.95,
    fill: {gradient: ['#ce99ff', '#0da5e5']},       
}).on('circle-animation-progress', function(event, progress) {
    $(this).find('strong').html(parseInt(95 * progress) + '<i></i>');
});

/*
 * Example 3:
 *   - very custom gradient
 *   - listening to `circle-animation-progress` event and display the dynamic change of the value: from 0 to 0.8
 */
$('.third.circle').circleProgress({
    value: 0.75,
    fill: { gradient: [['#0681c4', .5], ['#4ac5f8', .5]], gradientAngle: Math.PI / 4 }
}).on('circle-animation-progress', function(event, progress) {
    $(this).find('strong').html(parseInt(100 * progress) + '<i></i>');
});

$('.tfd.circle').circleProgress({
    value: 60,
    fill: { gradient: [['#0681c4', .5], ['#4ac5f8', .5]], gradientAngle: Math.PI / 4 }
}).on('circle-animation-progress', function(event, progress) {
    $(this).find('strong').html(parseInt(100 * progress) + '<i></i>');
});

/*
 * Example 4:
 *   - solid color fill
 *   - custom start angle
 *   - custom line cap
 *   - dynamic value set
 */
var c4 = $('.forth.circle');

c4.circleProgress({
    startAngle: -Math.PI / 4 * 3,
    value: 0.5,
    lineCap: 'round',
    fill: { color: '#ffa500' }
});

// let's emulate dynamic value update
setTimeout(function() { c4.circleProgress('value', 0.7); }, 1000);
setTimeout(function() { c4.circleProgress('value', 1.0); }, 1100);
setTimeout(function() { c4.circleProgress('value', 0.5); }, 2100);

/*
 * Example 5:
 *   - image fill; image should be squared; it will be stretched to SxS size, where S - size of the widget
 *   - fallback color fill (when image is not loaded)
 *   - custom widget size (default is 100px)
 *   - custom circle thickness (default is 1/14 of the size)
 *   - reverse drawing mode
 *   - custom animation start value
 *   - usage of "data-" attributes
 */
$('.fifth.circle').circleProgress({
    value: 0.7
    // all other config options were taken from "data-" attributes
    // options passed in config object have higher priority than "data-" attributes
    // "data-" attributes are taken into account only on init (not on update/redraw)
    // "data-fill" (and other object options) should be in valid JSON format
});
