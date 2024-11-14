// Copilot, can you add a javascript function that makes the page background a
// gradient and rotates it around slowly?

function createGradientBackground() {
    let angle = 0;
    const body = document.body;

    function updateBackground() {
        angle = (angle + 1) % 360;
        body.style.background = `linear-gradient(${angle}deg, #ff7e5f, #feb47b)`;
        requestAnimationFrame(updateBackground);
    }

    updateBackground();
}

createGradientBackground();
